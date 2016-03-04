using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace CSHARP_Chapter_8_Exercise_8._28
{
    class Program
    {
        static int start = 1;
        static int HPos = 1;
        static int TPos = 1;
        static int startcount = 1;
        static int racestart = 0;
        static int Trand = 1;
        static int Hrand = 1;
        static Random rand = new Random();

        private static void WriteHare()
        {
            for (int counter = 1; counter <= 70; counter++)
            {
                if (counter == HPos)
                    Console.Write("H");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void WriteTortoise()
        {
            for (int fin = 1; fin <= 70; fin++)
            {
                if (fin == 70)
                    Console.WriteLine("|FINISH");
                else
                    Console.Write(" ");
            }
            for (int counter = 1; counter <= 70; counter++)
            {
                if (counter == TPos)
                    Console.Write("T");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Timer clock = new Timer();
            clock.Elapsed += new ElapsedEventHandler(clock_tick);
            clock.Interval = 3000;
            clock.AutoReset = true;
            clock.Enabled = true;
            Console.Read();
        }
        private static void clock_tick(object sender, ElapsedEventArgs e)
            {
                while(startcount != 0)
                {   
                    switch (startcount)
                    {   
                     case 1:
                        Console.WriteLine("ON YOUR MARK");
                        startcount += 1;
                        break;
                    case 2:
                        Console.WriteLine("GET SET");
                        startcount += 1;
                        break;
                    case 3:
                        Console.WriteLine("BANG !!!!!");
                        startcount += 1;
                        break;
                    case 4:
                        Console.WriteLine("AND THEY'RE OFF !!!!!");
                        startcount += 1;
                        break;
                    case 5:
                        Console.Clear();
                        startcount = 0;
                        racestart = 1;
                        break;
                    }
                }
                while (racestart == 1)
                {
                    Program.Hrand = rand.Next(1, 11);
                    Program.Trand = rand.Next(1, 11);

                    if ((Trand >= 1) || (Trand <= 2))
                    {
                        if (Program.TPos <= 6)
                            Program.TPos = 1;
                        else
                            Program.TPos -= 6;
                    }
                    if ((Trand >= 3) || (Trand <= 5))
                    {
                        Program.TPos += 1;
                    }
                    if ((Trand >= 6) || (Trand <= 10))
                    {
                        Program.TPos += 3;
                    }
                    if (Hrand == 1)
                    {
                        if (Program.HPos <= 12)
                            Program.HPos = 1;
                        else
                            Program.HPos -= 12;
                    }
                    if ((Hrand >= 2) || (Hrand <= 3))
                    {
                        Program.HPos += 9;
                    }
                    if ((Hrand >= 4) || (Hrand <= 5))
                    {
                        Program.HPos += 0;
                    }
                    if ((Hrand >= 6) || (Hrand <= 7))
                    {
                        if (Program.HPos <= 2)
                            Program.HPos = 1;
                        else
                            Program.HPos -= 2;
                    }
                    if ((Hrand >= 8) || (Hrand <= 10))
                    {
                        Program.HPos += 1;
                    }
                    Console.Clear();
                    WriteTortoise();
                    WriteHare();
                    if (Program.TPos >= 70)
                    {
                        Console.WriteLine("TORTOISE WINS!!! YAY!!!");
                        racestart = 0;
                    }
                    if (Program.HPos >= 70)
                    {
                        Console.WriteLine("Hare Wins. Yuch.");
                        racestart = 0;
                    }
                    if ((Program.HPos >= 70) && (Program.TPos >= 70))
                    {
                        Console.WriteLine("It's a Tie.");
                        racestart = 0;
                    }
                    if (Program.TPos == Program.HPos)
                        Console.WriteLine();
                        for (int count = 1; count <= 70; count++)
                        {
                            if (count == HPos)
                                Console.WriteLine("Ouch!!!");
                            else
                                Console.Write(" ");
                        }
                }
            }
        }
    }


   
