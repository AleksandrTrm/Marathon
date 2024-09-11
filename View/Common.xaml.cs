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
using System.Windows.Threading;
using Marathone.ViewModel;

namespace Marathone.View
{
    /// <summary>
    /// Логика взаимодействия для Common.xaml
    /// </summary>
    public partial class Common : UserControl
    {
        DateTime marathonDate = new DateTime(2024, 06, 21, 8, 30, 0);
        DispatcherTimer timer = new DispatcherTimer() { Interval = new TimeSpan(0, 1, 0) };

        public Common(NavigationVM context)
        {
            DataContext = context;

            timer.Tick += Timer_tick;
            timer.Start();

            InitializeComponent();

            daysLeft.Content = $"{Math.Abs(marathonDate.Day - DateTime.Now.Day)} дней {Math.Abs(marathonDate.Hour - DateTime.Now.Hour)} часов " +
                $"{Math.Abs(marathonDate.Minute - DateTime.Now.Minute)} минут осталось до конца практики";
        }

        private void Timer_tick(Object sender, object e)
        {
            if (DateTime.Now == marathonDate)
            {
                MessageBox.Show("Марафон начался!");
                timer.Stop();
            }

            daysLeft.Content = $"{Math.Abs(marathonDate.Day - DateTime.Now.Day)} дней {Math.Abs(marathonDate.Hour - DateTime.Now.Hour)} часов " +
                $"{Math.Abs(marathonDate.Minute - DateTime.Now.Minute)} минут осталось до конца практики";
        }
    }
}
