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
using M_Kiosk.Models;
using M_Kiosk.Views;


namespace M_Kiosk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 앱 전체에서 쓸 메뉴 저장소
        public MenuRepository MenuRepo { get; } = new MenuRepository();

        public MainWindow()
        {
            InitializeComponent();
            //start page 열기
            MainFrame.Navigate(new StartPage());
        }
    }
}