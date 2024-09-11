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
using System.Windows.Shapes;
using Marathone.ViewModel;

namespace Marathone.View
{
    /// <summary>
    /// Логика взаимодействия для RegisterOrLoginAsRunner.xaml
    /// </summary>
    public partial class RegisterOrLoginAsRunner : UserControl
    {
        public RegisterOrLoginAsRunner(NavigationVM context)
        {
            DataContext = context;

            InitializeComponent();
        }
    }
}
