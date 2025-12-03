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
using M_Kiosk.Models;
using MenuModel = M_Kiosk.Models.MenuItem;



namespace M_Kiosk.Views
{
    public partial class MenuPage : Page
    {
        private readonly MenuRepository _repo;
        private List<MenuModel> _currentItems = new();

        public MenuPage(MenuRepository repo)
        {
            InitializeComponent();
            _repo = repo;

            // 기본: 전체 메뉴
            SetCategory(null);
        }

        private void SetCategory(string? category)
        {
            IEnumerable<MenuModel> query = _repo.AllMenus;

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(m => m.category == category);
            }

            _currentItems = query.ToList();
            MenuItemsControl.ItemsSource = _currentItems;
        }

        private void CategoryButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                string? cat = btn.Tag as string;

                if (string.IsNullOrEmpty(cat))
                    SetCategory(null);   // 전체
                else
                    SetCategory(cat);    // 해당 카테고리만
            }
        }
    }
}
