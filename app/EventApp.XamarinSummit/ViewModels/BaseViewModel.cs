using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace EventApp.XamarinSummit.ViewModels
{
    public abstract class BaseViewModel : BindableBase, IInitializeAsync
    {
        protected readonly INavigationService navigationService;

        private bool isBusy;
        private string title;

        protected BaseViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            BackCommand = new DelegateCommand(async () => await navigationService.GoBackAsync())
                .ObservesCanExecute(() => IsNotBusy);
        }

        public ICommand BackCommand { get; }

        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        public bool IsNotBusy => !IsBusy;

        public virtual Task InitializeAsync(INavigationParameters parameters)
            => Task.CompletedTask;

        protected async Task ExecuteBusyAction(Func<Task> theBusyAction)
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                await theBusyAction();
            }
            catch (Exception ex)
            {
#if DEBUG
                System.Diagnostics.Debug.Write(ex);
#endif
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

