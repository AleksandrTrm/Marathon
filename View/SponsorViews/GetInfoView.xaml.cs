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
using Marathone.Model;

namespace Marathone.View.SponsorViews
{
    /// <summary>
    /// Логика взаимодействия для GetInfoView.xaml
    /// </summary>
    public partial class GetInfoView : UserControl
    {
        public GetInfoView(Fondation fond)
        {
            InitializeComponent();

            title.Content = fond.Title;
            discription.Text = fond.Info;

            BitmapImage image = new BitmapImage(new Uri(fond.Source, UriKind.Relative));

            picture.Source = image;
        }
    }
}
