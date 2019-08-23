using System.Threading.Tasks;
using EventApp.XamarinSummit.Services;
using Prism.Navigation;

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
        }

        public override async Task InitializeAsync(INavigationParameters parameters)
        {
            var details = await eventService.Details();
        }
    }
}
