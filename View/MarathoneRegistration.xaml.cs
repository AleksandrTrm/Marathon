using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Marathone.Model;
using Marathone.ViewModel;

namespace Marathone.View
{
    /// <summary>
    /// Логика взаимодействия для MarathoneRegistration.xaml
    /// </summary>
    public partial class MarathoneRegistration : UserControl
    {
        private User _user;
        private NavigationVM _navigation;
        private int price = 0;

        public MarathoneRegistration(User user, NavigationVM navigation)
        {
            _navigation = navigation;
            _user = user;

            InitializeComponent();

            cmb_fund.ItemsSource = Fondations.FondationsList;
        }

        private void check_full_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 145;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_half_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 75;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_min_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_a_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 0;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_b_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_c_Unchecked(object sender, RoutedEventArgs e)
        {
            price -= 45;
            txt_price.Text = Convert.ToString(price);
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {
            if (cmb_fund.SelectedItem != null)
            {
                _user.MarathonInfo = price.ToString();

                _navigation.CurrentView = new Confirm(_navigation);
            }
            else MessageBox.Show("Фонд не выбран");
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            _navigation.MenuNavigation = new MainMenu();
        }

        private void check_full_Checked(object sender, RoutedEventArgs e)
        {
            price += 145;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_half_Checked(object sender, RoutedEventArgs e)
        {
            price += 75;
            txt_price.Text = Convert.ToString(price);
        }

        private void check_min_Checked(object sender, RoutedEventArgs e)
        {
            price += 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_a_Checked(object sender, RoutedEventArgs e)
        {
            price += 0;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_b_Checked(object sender, RoutedEventArgs e)
        {
            price += 20;
            txt_price.Text = Convert.ToString(price);
        }

        private void radio_c_Checked(object sender, RoutedEventArgs e)
        {
            price += 45;
            txt_price.Text = Convert.ToString(price);
        }
    }
}
