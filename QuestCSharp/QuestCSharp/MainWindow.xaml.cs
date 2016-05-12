using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuestCSharp
{
    public partial class MainWindow : Window
    {
        private Character chrWin = new Character();
        private Inventory invWin = new Inventory();
        private Skills sklWin = new Skills();
        private Menu menuWin = new Menu();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "chrBtn":
                    chatInfoTB.Text = chatInfoTB.Text + "dfwwwwwwwwwwjhsdfgajkghflasdfhdgjfhsjkfhskdjgh;xzhxjhjsjsjsjsjjkdkjksjdkjsdkjskjdksjdkjskjdksdsdsdsd";
                    chrWin.Topmost = true;
                    chrWin.Show();
                    break;
                case "invBtn":
                    invWin.Topmost = true;
                    invWin.Show();
                    break;
                case "sklBtn":
                    sklWin.Topmost = true;
                    sklWin.Show();
                    break;
                case "menuBtn":
                    menuWin.Topmost = true;
                    menuWin.Show();
                    break;
            }
        }

        private void TBTextChanged(object sender, TextChangedEventArgs e)
        {
            switch ((sender as TextBox).Name)
            {
                case "chatInfoTB":
                if (chatScrollViewer.VerticalOffset == chatScrollViewer.ScrollableHeight)
                    chatScrollViewer.ScrollToEnd();
                    break;
                case "gameInfoTB":
                if (gameScrollViewer.VerticalOffset == gameScrollViewer.ScrollableHeight)
                    gameScrollViewer.ScrollToEnd();
                    break;
            }
        }
    }
}
