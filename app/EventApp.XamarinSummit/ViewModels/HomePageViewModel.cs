using System;
using System.Threading.Tasks;
using System.Windows.Input;
using EventApp.XamarinSummit.Models;
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
        private Speaker speaker;

        public HomePageViewModel(INavigationService navigationService
            , IEventService eventService)
            : base(navigationService)
        {
            this.eventService = eventService;

            SpeakerCommand = new DelegateCommand(async () => await ExecuteSpeakerCommand())
                .ObservesCanExecute(() => IsNotBusy);

            Title = "Xamarin Summit 2019";
        }

        public ICommand SpeakerCommand { get; }

        public Speaker SelectedSpeaker
        {
            get => speaker;
            set
            {
                SetProperty(ref speaker, value);
            }
        }

        private async Task ExecuteSpeakerCommand()
        {
            await ExecuteBusyAction(async () =>
            {
                await navigationService.NavigateAsync($"{nameof(SpeakerPage)}");

                SelectedSpeaker = null;
            });
        }
    }
}
