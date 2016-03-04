using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Input.Touch;

namespace Star_Battle
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;
        GamePadState currentGamePadState;
        GamePadState previousGamePadState;

        Player player;
        float playerMoveSpeed;
        SpriteFont font;
        int score;

        Texture2D titleScreen;
        Texture2D ruleScreen;
        Texture2D controlScreen;
        Texture2D mainBackground;
        ParallaxingBackground parallaxLayer1;
        ParallaxingBackground parallaxLayer2;
        Texture2D gameoverScreen;
        Texture2D thankyouScreen;
        int screen = 0;

        List<Enemy> enemies;
        Texture2D enemyTexture;
        TimeSpan enemySpawnTime;
        TimeSpan previousSpawnTime;
        Random random;

        List<Projectile> projectiles;
        Texture2D projectileTexture;
        TimeSpan fireTime;
        TimeSpan previousFireTime;
        SoundEffect laserSound;

        List<Animation> explosions;
        Texture2D explosionTexture;
        SoundEffect explosionSound;

        Song gameplayMusic;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            player = new Player();
            playerMoveSpeed = 8.0f;

            parallaxLayer1 = new ParallaxingBackground();
            parallaxLayer2 = new ParallaxingBackground();

            enemies = new List<Enemy>();
            previousSpawnTime = TimeSpan.Zero;
            enemySpawnTime = TimeSpan.FromSeconds(1.0f);
            random = new Random();

            projectiles = new List<Projectile>();
            fireTime = TimeSpan.FromSeconds(.15f);

            explosions = new List<Animation>();

            score = 0;
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Animation playerAnimation = new Animation();
            Texture2D playerTexture = Content.Load<Texture2D>("playerShipAnimation");
            playerAnimation.Initialize(playerTexture, Vector2.Zero, 115, 69, 7, 30, Color.White, 1f, true);

            Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y
            + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
            player.Initialize(playerAnimation, playerPosition);

            titleScreen = Content.Load<Texture2D>("titleMenu");
            ruleScreen = Content.Load<Texture2D>("ruleMenu");
            controlScreen = Content.Load<Texture2D>("controlMenu");
            mainBackground = Content.Load<Texture2D>("mainbackground");
            parallaxLayer1.Initialize(Content, "parallaxLayer1", GraphicsDevice.Viewport.Width, -1);
            parallaxLayer2.Initialize(Content, "parallaxLayer2", GraphicsDevice.Viewport.Width, -2);
            gameoverScreen = Content.Load<Texture2D>("gameoverMenu");
            thankyouScreen = Content.Load<Texture2D>("thankyouMenu");

            enemyTexture = Content.Load<Texture2D>("enemyShipAnimation");
            projectileTexture = Content.Load<Texture2D>("laser");
            laserSound = Content.Load<SoundEffect>("sound/laserFire");
            explosionTexture = Content.Load<Texture2D>("explosion");
            explosionSound = Content.Load<SoundEffect>("sound/explosion");

            gameplayMusic = Content.Load<Song>("sound/gameMusic");

            font = Content.Load<SpriteFont>("gameFont");

            PlayMusic(gameplayMusic);
        }

        private void PlayMusic(Song song)
        {
            try
            {
                MediaPlayer.Play(song);
                MediaPlayer.IsRepeating = true;
            }
            catch { }
        }

        private void AddEnemy()
        {
            Animation enemyAnimation = new Animation();
            enemyAnimation.Initialize(enemyTexture, Vector2.Zero, 47, 80, 8, 30, Color.White, 1f, true);
            Vector2 position = new Vector2(GraphicsDevice.Viewport.Width + enemyTexture.Width / 2, random.Next(100, GraphicsDevice.Viewport.Height - 100));
            Enemy enemy = new Enemy();
            enemy.Initialize(enemyAnimation, position);
            enemies.Add(enemy);
        }

        private void UpdateEnemies(GameTime gameTime)
        {
            if (gameTime.TotalGameTime - previousSpawnTime > enemySpawnTime)
            {
                previousSpawnTime = gameTime.TotalGameTime;

                AddEnemy();
            }

            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i].Update(gameTime);

                if (enemies[i].Active == false)
                {
                    if (enemies[i].Health <= 0)
                    {
                        AddExplosion(enemies[i].Position);
                        explosionSound.Play();

                        score += enemies[i].Value;
                    }
                    enemies.RemoveAt(i);
                }
            }
        }

        private void AddProjectile(Vector2 position)
        {
            Projectile projectile = new Projectile();
            projectile.Initialize(GraphicsDevice.Viewport, projectileTexture, position);
            projectiles.Add(projectile);
        }

        private void UpdateProjectiles()
        {
            for (int i = projectiles.Count - 1; i >= 0; i--)
            {
                projectiles[i].Update();

                if (projectiles[i].Active == false)
                {
                    projectiles.RemoveAt(i);
                }
            }
        }

        private void AddExplosion(Vector2 position)
        {
            Animation explosion = new Animation();
            explosion.Initialize(explosionTexture, position, 134, 134, 12, 45, Color.White, 1f, false);
            explosions.Add(explosion);
        }

        private void UpdateExplosions(GameTime gameTime)
        {
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                explosions[i].Update(gameTime);
                if (explosions[i].Active == false)
                {
                    explosions.RemoveAt(i);
                }
            }
        }

        protected override void UnloadContent()
        {
          
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            previousGamePadState = currentGamePadState;
            previousKeyboardState = currentKeyboardState;

            currentKeyboardState = Keyboard.GetState();
            currentGamePadState = GamePad.GetState(PlayerIndex.One);

            switch (screen)
            {
                case 0:
                    if (currentKeyboardState.IsKeyDown(Keys.Enter))
                    {
                        screen = 1;
                    }
                    break;
                case 1:
                    if (currentKeyboardState.IsKeyDown(Keys.Space))
                    {
                        screen = 2;
                    }
                    break;
                case 2:
                    if (currentKeyboardState.IsKeyDown(Keys.Enter))
                    {
                        screen = 3;
                    }
                    break;
                case 3:
                    UpdatePlayer(gameTime);
                    parallaxLayer1.Update();
                    parallaxLayer2.Update();
                    UpdateEnemies(gameTime);
                    UpdateCollision();
                    UpdateProjectiles();
                    UpdateExplosions(gameTime);

                    if (player.Health == 0)
                    {
                        screen = 4;
                    }
                    break;
                case 4:
                    if (currentKeyboardState.IsKeyDown(Keys.Escape))
                    {
                        screen = 5;
                    }
                    if (currentKeyboardState.IsKeyDown(Keys.Enter))
                    {
                        screen = 3;
                        Reload();
                    }
                    break;
                case 5:
                    if (currentKeyboardState.IsKeyDown(Keys.Enter))
                    {
                        this.Exit();
                    }
                    if (currentKeyboardState.IsKeyDown(Keys.Space))
                    {
                        screen = 3;
                        Reload();
                    }
                    break;

            }
            base.Update(gameTime);
        }

        private void UpdatePlayer(GameTime gameTime)
        {
            player.Update(gameTime);

            player.Position.X += currentGamePadState.ThumbSticks.Left.X * playerMoveSpeed;
            player.Position.Y -= currentGamePadState.ThumbSticks.Left.Y * playerMoveSpeed;

            if (currentKeyboardState.IsKeyDown(Keys.Left) ||
            currentGamePadState.DPad.Left == ButtonState.Pressed)
            {
                player.Position.X -= playerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.Right) ||
            currentGamePadState.DPad.Right == ButtonState.Pressed)
            {
                player.Position.X += playerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.Up) ||
            currentGamePadState.DPad.Up == ButtonState.Pressed)
            {
                player.Position.Y -= playerMoveSpeed;
            }
            if (currentKeyboardState.IsKeyDown(Keys.Down) ||
            currentGamePadState.DPad.Down == ButtonState.Pressed)
            {
                player.Position.Y += playerMoveSpeed;
            }

            player.Position.X = MathHelper.Clamp(player.Position.X, 0, GraphicsDevice.Viewport.Width - player.Width);
            player.Position.Y = MathHelper.Clamp(player.Position.Y, 0, GraphicsDevice.Viewport.Height - player.Height);

            if (currentKeyboardState.IsKeyDown(Keys.Space))
            {
                if (gameTime.TotalGameTime - previousFireTime > fireTime)
                {
                    previousFireTime = gameTime.TotalGameTime;

                    AddProjectile(player.Position + new Vector2(player.Width / 4, 14));
                    laserSound.Play();
                }
            }

            if (player.Health <= 0)
            {
                player.Health = 100;
            }

        }

        private void UpdateCollision()
        {
            Rectangle rectangle1;
            Rectangle rectangle2;

            rectangle1 = new Rectangle((int)player.Position.X,
            (int)player.Position.Y,
            player.Width,
            player.Height);

            for (int i = 0; i < enemies.Count; i++)
            {
                rectangle2 = new Rectangle((int)enemies[i].Position.X,
                (int)enemies[i].Position.Y,
                enemies[i].Width,
                enemies[i].Height);

                if (rectangle1.Intersects(rectangle2))
                {
                    player.Health -= enemies[i].Damage;

                    enemies[i].Health = 0;

                    if (player.Health <= 0)
                        player.Active = false;
                }

            }

            for (int i = 0; i < projectiles.Count; i++)
            {
                for (int j = 0; j < enemies.Count; j++)
                {
                    rectangle1 = new Rectangle((int)projectiles[i].Position.X -
                    projectiles[i].Width / 2, (int)projectiles[i].Position.Y -
                    projectiles[i].Height / 2, projectiles[i].Width, projectiles[i].Height);

                    rectangle2 = new Rectangle((int)enemies[j].Position.X - enemies[j].Width / 2,
                    (int)enemies[j].Position.Y - enemies[j].Height / 2,
                    enemies[j].Width, enemies[j].Height);

                    if (rectangle1.Intersects(rectangle2))
                    {
                        enemies[j].Health -= projectiles[i].Damage;
                        projectiles[i].Active = false;
                    }
                }
            }
        }

        private void Reload()
        {
            enemies = new List<Enemy>();
            LoadContent();
            score = 0;
        }
   
        protected override void Draw(GameTime gameTime)
        {
            switch (screen)
            {
                case 0:
                    spriteBatch.Begin();
                    spriteBatch.Draw(titleScreen, Vector2.Zero, Color.White);
                    spriteBatch.End();
                    break;
                case 1:
                    spriteBatch.Begin();
                    spriteBatch.Draw(ruleScreen, Vector2.Zero, Color.White);
                    spriteBatch.End();
                    break;
                case 2:
                    spriteBatch.Begin();
                    spriteBatch.Draw(controlScreen, Vector2.Zero, Color.White);
                    spriteBatch.End();
                    break;
                case 3:
                    spriteBatch.Begin();

                    spriteBatch.Draw(mainBackground, Vector2.Zero, Color.White);

                    parallaxLayer1.Draw(spriteBatch);
                    parallaxLayer2.Draw(spriteBatch);

                    player.Draw(spriteBatch);

                    for (int i = 0; i < enemies.Count; i++)
                    {
                        enemies[i].Draw(spriteBatch);
                    }

                    for (int i = 0; i < projectiles.Count; i++)
                    {
                        projectiles[i].Draw(spriteBatch);
                    }

                    for (int i = 0; i < explosions.Count; i++)
                    {
                        explosions[i].Draw(spriteBatch);

                    }
                    spriteBatch.DrawString(font, "Score: " + score, new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + 640, GraphicsDevice.Viewport.TitleSafeArea.Y), Color.White);
                    spriteBatch.DrawString(font, "Health: " + player.Health, new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X + 640, GraphicsDevice.Viewport.TitleSafeArea.Y + 30), Color.White);

                    spriteBatch.End();

                    break;
                case 4:
                    spriteBatch.Begin();
                    spriteBatch.Draw(gameoverScreen, Vector2.Zero, Color.White);
                    spriteBatch.End();
                    break;
                case 5:
                    spriteBatch.Begin();
                    spriteBatch.Draw(thankyouScreen, Vector2.Zero, Color.White);
                    spriteBatch.End();
                    break;
            }
            base.Draw(gameTime);
        }
    }
}
