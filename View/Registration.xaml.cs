using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Marathone.View
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : UserControl
    {
        private Users _users = new Users();
        private NavigationVM navigation;

        public Registration(NavigationVM context)
        {
            DataContext = context;
            navigation = context;

            InitializeComponent();

            var gender = new List<string> { "Male", "Female" };
            var country = new List<string>
            {
                "Andora", "Argentina", "Australia","Austria","Belgium","Botswana","Brazil","Bulgaria","Cameroon","Canada","Central Africa","Chile","China","Chinese Taipei","Colombia","Croatia","Czech Republic","Denmark","Dominican Republic","Ecuador","Egypt","El Salvador","Equatorial Guinea","Esonia","Finland","France","Germany","Greece","Guatemala","Guinea","Guinea-Bissau","Honduras","Hong Kong","Hungary","India","Indonesia","Ireland","Israel","Italy","Ivory Coast","Jamaica","Japan","Jordan","Kenya","Latvia", "Liechtenstein","Lithuania","Luxemburg", "Macau", "Macedonia", "Madagascar", "Malaysia", "Mali", "Malta", "Mauritius", "Mexico", "Moldova", "Monaco", "Montenegro", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Norway", "Panama", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Romania", "Russia", "Saudi Arabia", "Senegal", "Singapore","Slovakia", "South Africa", "South Korea", "Spain", "Sweden", "Switzerland", "Thailand", "Turkey", "Unitied Arab Emirates", "Inited Kingdom", "Uruguay", "USA", "Vatican", "Venezuela", "Vietnam"
            };
            cmb_gender.ItemsSource = gender;
            cmbCountry.ItemsSource = country;
        }

        private void txb_email_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_email.Text = "";     
        }

        private void txb_pass_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_pass.Text = "";
        }

        private void txb_repeatpass_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_repeatpass.Text = "";
        }

        private void txb_name_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_name.Text = "";
        }

        private void txb_surname_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_surname.Text = "";
        }

        private void txb_pathphoto_GotFocus(object sender, RoutedEventArgs e)
        {
            txb_pathphoto.Text = "";
        }

        private void btn_source_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FilterIndex = 2;
            open.Filter = "jpg|*.jpg| png|*.png";

            if (open.ShowDialog() == true)
            {
                BitmapImage source = new BitmapImage();
                source.BeginInit(); // начало считывания фото
                source.UriSource = new Uri(@"" + open.FileName, UriKind.Relative);
                source.CacheOption = BitmapCacheOption.OnLoad;
                source.EndInit();

                imgAvatar.Source = source;
                imgAvatar.Stretch = Stretch.Uniform;
            }
        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (string.IsNullOrEmpty(txb_email.Text) == false || string.IsNullOrEmpty(txb_pass.Text) == false || string.IsNullOrEmpty(txb_repeatpass.Text) == false ||
                string.IsNullOrEmpty(txb_name.Text) == false || string.IsNullOrEmpty(txb_surname.Text) == false || cmb_gender.SelectedItem != null || cmbCountry != null)
            {
                if (regex.IsMatch(txb_email.Text))
                {
                    if (txb_pass.Text == txb_repeatpass.Text)
                    {
                        UserDataHelper userDataHelper = new UserDataHelper();
                        _users = userDataHelper.GetUsers();

                        User user = new User();

                        user.Email = txb_email.Text;
                        user.Password = txb_pass.Text;
                        user.Role = "sprinter";

                        //txb_email.Text = "";
                        //txb_pass.Text = "";
                        //txb_repeatpass.Text = "";
                        //txb_name.Text = "";
                        //txb_surname.Text = "";
                        //cmbCountry.SelectedItem = null;
                        //cmb_gender.SelectedItem = null;

                        navigation.CurrentView = new MarathoneRegistration(user, navigation);
                    }
                    else MessageBox.Show("Введеные пароли не совпадают");
                }
                else MessageBox.Show("Email введен неправильно");
            }
            else MessageBox.Show("Заполните все поля");
            
        }
    }
}
