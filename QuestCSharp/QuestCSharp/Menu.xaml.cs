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
    public partial class Menu : Window
    {
        private Options optWin = new Options();
        private Store strWin = new Store();

        public Menu()
        {
            InitializeComponent();
        }
        
        private void BtnClick(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "optBtn":
                    optWin.Topmost = true;
                    optWin.Show();
                    break;
                case "strBtn":
                    strWin.Topmost = true;
                    strWin.Show();
                    break;
                case "exitBtn":
                    MessageBoxResult r = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButton.YesNo);
                    if (r == MessageBoxResult.Yes)
                        Application.Current.Shutdown();
                    break;
                case "backBtn":
                    this.Hide();
                    break;
            }
        }
    }
}
