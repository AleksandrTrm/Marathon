using System.Windows.Input;
using Marathone.Model;
using Marathone.Utilities;
using Marathone.View;
using Marathone.View.AuthorizationViews;
using Marathone.View.SponsorViews;

namespace Marathone.ViewModel
{
    public class NavigationVM : ViewModelBase
    {
        private object _menuNavigation;

        public object MenuNavigation
        {
            get { return _menuNavigation; }
            set { _menuNavigation = value; OnPropertyChanged(); }
        }

        private object _currentView;        

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand MainMenuCommand { get; set; }

        public ICommand CommonCommand { get; set; }

        public ICommand SponsorViewCommand { get; set; }

        public ICommand MoreInfoCommand { get; set; }

        public ICommand RegiserOrLoginCommand { get; set; }

        public ICommand GratitudeCommand { get; set; }

        public ICommand LoginCommand { get; set; }

        public ICommand RegistrationCommand { get; set; }

        private void MainMenu(object obj) => MenuNavigation = new MainMenu();

        private void Common(object obj) => MenuNavigation = new Common(this);    
        
        private void Registration(object obj)
        {
            MenuNavigation = new Common(this);
            CurrentView = new Registration(this);
        }

        private void Login(object obj)
        {
            MenuNavigation = new Common(this);
            CurrentView = new Authorization(this, new Common(this));
        }

        public void Gratitude(NavigationVM navigationVM, Fondation fond, Sprinter sprinter, double amount)
        {
            MenuNavigation = new Common(this);
            CurrentView = new Gratitude(navigationVM, fond, sprinter, amount);
        }

        private void SponsorView(object obj)
        {
            MenuNavigation = new Common(this);
            CurrentView = new SponsorView(this);
        }

        private void MoreInfo(object obj)
        {
            MenuNavigation = new Common(this);
            CurrentView = new View.MoreInfoViews.MoreInfo(this);
        }

        private void RegisterOrLoginAsRunner(object obj)
        {
            MenuNavigation = new Common(this);
            CurrentView = new RegisterOrLoginAsRunner(this);
        }

        public NavigationVM()
        {
            MainMenuCommand = new RelayCommand(MainMenu);
            CommonCommand = new RelayCommand(Common);

            SponsorViewCommand = new RelayCommand(SponsorView);
            RegiserOrLoginCommand = new RelayCommand(RegisterOrLoginAsRunner);            
            LoginCommand = new RelayCommand(Login);
            MoreInfoCommand = new RelayCommand(MoreInfo);
            RegistrationCommand = new RelayCommand(Registration);

            MenuNavigation = new MainMenu();
        }
    }
}
