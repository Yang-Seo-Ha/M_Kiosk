using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M_Kiosk.Views
{
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void EatInButton_Click(object sender, RoutedEventArgs e)
        {
            GoToMenuPage();
        }

        private void TakeOutButton_Click(object sender, RoutedEventArgs e)
        {
            GoToMenuPage();
        }

        private void GoToMenuPage()
        {
            // MainWindow 찾아서, 거기에 있는 MenuRepo를 MenuPage에 넘겨줌
            var main = (MainWindow)Application.Current.MainWindow;
            var repo = main.MenuRepo;

            main.MainFrame.Navigate(new MenuPage(repo));
        }
    }
}
