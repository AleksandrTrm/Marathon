using System.Windows.Input;
using System.Windows.Media;
using System.Text.RegularExpressions;
using Marathone.Model;
using Marathone.View.AuthorizationViews.SprinterViews;
using System.Windows;
using Marathone.Utilities;
using Marathone.View;
using Marathone.View.AuthorizationViews.AdminViews;
using Marathone.View.AuthorizationViews.CoordinatorViews;

namespace Marathone.ViewModel
{
    public class AuthorizationVM
    {
        private NavigationVM _navigationVM;
        private Common _common;
        private string _email;
        private string _password;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public AuthorizationVM(NavigationVM navigationVM, Common common)
        {
            _navigationVM = navigationVM;
            _common = common;
        }

        private RelayCommand _cancel;

        public RelayCommand Cancel
        {
            get
            {
                return _cancel ?? (_cancel = new RelayCommand(obj =>
                {
                    _navigationVM.MenuNavigation = new MainMenu();
                    _navigationVM.CurrentView = null;
                }));
            }
        }

        private RelayCommand _login;

        public RelayCommand Login
        {
            get
            {
                return _login ?? (_login = new RelayCommand(obj =>
                {
                    if (DataIsValid())
                    {
                        User user = new User();

                        UserDataHelper users = new UserDataHelper();

                        Users allUsers = users.GetUsers();

                        foreach (var usr in allUsers.User)
                        {
                            if (Email == usr.Email)
                            {
                                user = usr;
                                break;
                            }
                        }

                        if (string.IsNullOrEmpty(user.Email) == false)
                        {
                            if (user.Password == Password)
                            {

                                switch (user.Role)
                                {
                                    case "admin":
                                        _navigationVM.MenuNavigation = new Common(_navigationVM);
                                        _navigationVM.CurrentView = new Admin();
                                        break;
                                    case "sprinter":
                                        _navigationVM.CurrentView = new View.AuthorizationViews.SprinterViews.Sprinter();
                                        break;
                                    case "coordinator":
                                        _navigationVM.CurrentView = new Coordinator();
                                        break;
                                }

                                _common.Logout.Visibility = Visibility.Visible;
                            }
                            else MessageBox.Show("Неверный пароль");
                        }
                        else MessageBox.Show("Такого пользователя нет");

                    }
                    else MessageBox.Show("Поля не заполнены");
                }));
            }
        }

        ICommand ValidationCommand;

        public bool DataIsValid()
        {
            Regex regex = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (string.IsNullOrEmpty(Email) == false && string.IsNullOrEmpty(Password) == false)
                if (regex.IsMatch(Email))
                    return true;
            
            return false;
        }
    }

}
