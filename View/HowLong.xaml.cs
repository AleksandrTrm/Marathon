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
using Marathone.Data;

namespace Marathone.View
{
    /// <summary>
    /// Логика взаимодействия для HowLong.xaml
    /// </summary>
    public partial class HowLong : UserControl
    {
        public HowLong()
        {
            InitializeComponent();
            gridSpeed.ItemsSource = Items.SpeedItems;
            gridDistance.ItemsSource = Items.DistantionItems;
        }

        private void gridSpeed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item item = gridSpeed.SelectedItem as Item;

            txtName.Text = item.Name;
            txtInfo.Text = item.Discription;
        }

        private void gridDistance_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Item item = gridDistance.SelectedItem as Item;

            txtName.Text = item.Name;
            txtInfo.Text = item.Discription;
        }
    }
}
