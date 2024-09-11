using System.Linq;
using Marathone.Model;
using Marathone.View.SponsorViews;

namespace Marathone.ViewModel
{
    public class FondationsListVM
    {            
        public object CatFondation
        {
            get { return new GetInfoView(Fondations.FondationsList.ElementAt(0)); }
        }

        public object DogFondation
        {
            get { return new GetInfoView(Fondations.FondationsList.ElementAt(1)); }
        }        

        public object UnicornFondation
        {
            get { return new GetInfoView(Fondations.FondationsList.ElementAt(2)); }
        }

        public object StingrayFondation
        {
            get { return new GetInfoView(Fondations.FondationsList.ElementAt(3)); }
        }

        public object WizardFondation
        {
            get { return new GetInfoView(Fondations.FondationsList.ElementAt(4)); }
        }
    }
}
