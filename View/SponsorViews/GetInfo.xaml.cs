using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Marathone.Model;

namespace Marathone.View.SponsorViews
{
    /// <summary>
    /// Логика взаимодействия для GetInfo.xaml
    /// </summary>
    public partial class GetInfo : Window
    {
        public GetInfo(Fondation fond)
        {           
            InitializeComponent();

            title.Content = fond.Title;
            discription.Text = fond.Info;

            BitmapImage image = new BitmapImage(new Uri(fond.Source, UriKind.Relative));

            picture.Source = image;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
