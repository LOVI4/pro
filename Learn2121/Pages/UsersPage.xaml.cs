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

namespace Learn2121.Pages
{
    /// <summary>
    /// Логика взаимодействия для UsersPage.xaml
    /// </summary>
    public partial class UsersPage : Page
    {
        List<Model.User> list = new List<Model.User>();
        public UsersPage()
        {
            InitializeComponent();
            PeopleDataGrid.ItemsSource = App.db.Users.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
