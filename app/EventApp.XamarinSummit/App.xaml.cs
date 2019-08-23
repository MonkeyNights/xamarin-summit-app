using Xamarin.Forms;
using EventApp.XamarinSummit.Views;
using Prism.DryIoc;
using Prism;
using Prism.Ioc;
using EventApp.XamarinSummit.ViewModels;
using EventApp.XamarinSummit.Factories;
using EventApp.XamarinSummit.Services;
using EventApp.XamarinSummit.Repositories;

namespace EventApp.XamarinSummit
{
    public partial class App : PrismApplication
    {
        public App()
            : this(null) { }

        public App(IPlatformInitializer platformInitializer)
            : base(platformInitializer) { }

        public App(IPlatformInitializer platformInitializer, bool setFormsDependencyResolver)
            : base(platformInitializer, setFormsDependencyResolver) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService
                .NavigateAsync($"{nameof(NavigationPage)}/{nameof(HomePage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterPages(containerRegistry);
            RegisterServices(containerRegistry);
        }

        private void RegisterPages(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
        }

        private void RegisterServices(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(HttpClientFactory.CreateClient());
            containerRegistry.RegisterInstance(RepositoryFactory.For<IEventRepository>(Container));

            containerRegistry.Register<IEventService, EventService>();
        }
    }
}
