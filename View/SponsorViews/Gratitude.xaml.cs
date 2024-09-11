using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Marathone.View.SponsorViews
{
    /// <summary>
    /// Логика взаимодействия для Gratitude.xaml
    /// </summary>
    public partial class Gratitude : UserControl
    {
        public Gratitude(NavigationVM context, Fondation fond, Sprinter spr, double money)
        {
            DataContext = context;

            InitializeComponent();

            fondation.Content = fond.Title;
            sprinter.Content = spr.SprintMember;

            amount.Content = money.ToString();
        }
    }
}
