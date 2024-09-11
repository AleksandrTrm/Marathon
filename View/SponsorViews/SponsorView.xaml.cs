using System.Windows;
using System.Collections.Generic;
using System.Windows.Controls;
using Marathone.Model;
using Marathone.View.SponsorViews;
using Marathone.ViewModel;

namespace Marathone.View
{
    /// <summary>
    /// Логика взаимодействия для SponsorView.xaml
    /// </summary>
    public partial class SponsorView : UserControl
    {
        private NavigationVM vm = null;

        public SponsorView(NavigationVM context)
        {           
            vm  = context;

            DataContext = context;

            InitializeComponent();

            sprinters.ItemsSource = Sprinters.SprintersList;
        }

        private void cardNumber_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            
        }

        private void sprinters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fondation.Content = Fondations.FondationsList[sprinters.SelectedIndex].Title;
        }

        private void getInfo_Click(object sender, RoutedEventArgs e)
        {
            GetInfo getInfo;

            if (sprinters.SelectedItem != null)
            {
                Fondation fond = Fondations.FondationsList[sprinters.SelectedIndex];

                getInfo = new GetInfo(fond);
                getInfo.ShowDialog();
            }

        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            vm.Gratitude(vm, Fondations.FondationsList[sprinters.SelectedIndex], (Sprinter)sprinters.SelectedItem, double.Parse(donationAmount.Text));
        }
    }
}
