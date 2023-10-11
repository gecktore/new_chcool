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

namespace chcool12.Pages
{
    /// <summary>
    /// Логика взаимодействия для autorizatePage.xaml
    /// </summary>
    public partial class autorizatePage : Page
    {
        public autorizatePage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "0000")
                App.isAdmin = true;
            NavigationService.Navigate(new ServiceListPage());
        }
    }
}
