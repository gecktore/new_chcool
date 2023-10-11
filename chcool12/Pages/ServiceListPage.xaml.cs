using chcool12.Components;
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
    /// Логика взаимодействия для ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {

        public ServiceListPage()
        {
            InitializeComponent();
            var servicesList = App.Entities.Service.ToList();
            if (App.isAdmin == false)
            {
                AddBut.Visibility = Visibility.Collapsed;
            }
            foreach (var service in servicesList)
            {
                ServicesWp.Children.Add(new UserControl1(service));

            }

        }
        private void Refresh()
        {
            IEnumerable<Service> servicesListSort = App.Entities.Service;
            if (SortCb.SelectedIndex != 0)
            {
                if (SortCb.SelectedIndex == 1)
                {
                    servicesListSort = servicesListSort.OrderBy(x => x.CostDiscount);
                }
                else if (SortCb.SelectedIndex == 2)
                {
                    servicesListSort = servicesListSort.OrderByDescending(x => x.CostDiscount);
                }
            }
            ServicesWp.Children.Clear();
            foreach (var service in servicesListSort)
            {
                ServicesWp.Children.Add(new UserControl1(service));
            }
        }
        private void SortCb_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }
    }
}
