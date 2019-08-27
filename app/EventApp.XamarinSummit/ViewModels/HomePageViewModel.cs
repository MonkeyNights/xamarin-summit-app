using System;
using System.Threading.Tasks;
using System.Windows.Input;
using EventApp.XamarinSummit.Services;
using EventApp.XamarinSummit.Views;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace EventApp.XamarinSummit.ViewModels
{
    public sealed class HomePageViewModel : BaseViewModel
    {
        private readonly IEventService eventService;

        public HomePageViewModel(INavigationService navigationService
            , IEventService eventService)
            : base(navigationService)
        {
            this.eventService = eventService;

            SpeakerCommand = new DelegateCommand(async () => await ExecuteSpeakerCommand());
        }

        public ICommand SpeakerCommand { get; }

        private async Task ExecuteSpeakerCommand()
        {
            await navigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(SpeakerPage)}");
        }
    }
}
