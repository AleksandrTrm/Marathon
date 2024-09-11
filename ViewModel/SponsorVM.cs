using Marathone.Model;
using Marathone.Utilities;

namespace Marathone.ViewModel
{
    public class SponsorVM : ViewModelBase
    {
        private NavigationVM _navigation;
        private double _amount;
        private Fondation _fondation;
        private Sprinter _sprinter;

        public NavigationVM Navigation
        {
            get { return _navigation; }
        }

        public double Amount
        {
            get { return _amount; }
        }

        public string Fondation
        {
            get { return _fondation.Title; }
        }

        public string Sprinter
        {
            get { return _sprinter.SprintMember; }
        }

        public SponsorVM(NavigationVM navigation, Fondation fond, Sprinter sprinter, double amount)
        {
            _navigation = navigation;
            _fondation = fond;
            _sprinter = sprinter;
            _amount = amount;
        }
    }
}
