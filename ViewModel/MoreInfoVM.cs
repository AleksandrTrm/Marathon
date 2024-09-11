using System.Windows.Input;
using Marathone.Utilities;
using Marathone.View.MoreInfoViews;

namespace Marathone.ViewModel
{
    public class MoreInfoVM
    {
        private NavigationVM _navigationVM;

        public MoreInfoVM(NavigationVM navigationVM) 
        {
            _navigationVM = navigationVM;

            FonadtionsCommand = new RelayCommand(Fondations);
            BMICalculatorCommand = new RelayCommand(BMICalclulator);
            BMRCalculatorCommand = new RelayCommand(BMRCalclulator);
        }

        public ICommand FonadtionsCommand { get; set; }
        
        public ICommand BMICalculatorCommand { get; set; }
        
        public ICommand BMRCalculatorCommand { get; set; }

        public void Fondations(object obj)
        {
            _navigationVM.CurrentView = new FondationsList();
        }

        public void BMICalclulator(object obj)
        {
            _navigationVM.CurrentView = new BMICalculatorView(_navigationVM);
        }
        
        public void BMRCalclulator(object obj)
        {
            _navigationVM.CurrentView = new BMRCalculator(_navigationVM);
        }
    }
}
