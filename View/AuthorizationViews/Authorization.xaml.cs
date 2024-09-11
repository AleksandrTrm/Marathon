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
using Marathone.ViewModel;

namespace Marathone.View.AuthorizationViews
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : UserControl
    {
        private AuthorizationVM _context;

        public Authorization(NavigationVM navigationVM, Common common)
        {
            _context = new AuthorizationVM(navigationVM, common);

            DataContext = _context;

            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (_context.DataIsValid() == false)
            {
                email.BorderBrush = Brushes.Red;
                password.BorderBrush = Brushes.Red;
            }
            else
            {
                email.BorderBrush = Brushes.Gray;
                password.BorderBrush = Brushes.Gray;
            }
        }
    }
}
