using System;
using Prism.Navigation;
using Xamarin.Forms;

namespace EventApp.XamarinSummit.ViewModels
{
    public class SpeakerPageViewModel : BaseViewModel
    {
        public SpeakerPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Palestrante";
        }
    }
}

