﻿using System;
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

namespace chcool12.Components
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Service service)
        {
            InitializeComponent();
            if (!App.isAdmin)
            {
                DeleteBtn.Visibility = Visibility.Hidden;
                CreateBtn.Visibility = Visibility.Hidden;
            }
            TitleTb.Text = service.Title;
            CostTimeTb.Text = service.costTimeStr;
            DiscountTb.Text = service.DiscountStr;
            CostTb.Text = service.Cost.ToString("N0");
            CostTb.Visibility = service.CostVisibility;
            MainBorder.Background = service.ColorDiscount;

        }
    }
}
