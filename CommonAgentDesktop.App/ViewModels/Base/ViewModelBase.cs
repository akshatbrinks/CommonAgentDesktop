using CommonAgentDesktop.App.Services.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommonAgentDesktop.App.ViewModels.Base
{
    public abstract partial class ViewModelBase : ObservableObject, IViewModelBase
    {
        public INavigationService NavigationService { get; }
        public IAsyncRelayCommand OnAppearingCommand { get; }
        public IAsyncRelayCommand OnDisappearingCommand { get; }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;

            OnAppearingCommand = new AsyncRelayCommand(OnAppearing);
            OnDisappearingCommand = new AsyncRelayCommand(OnDisappearing);
        }

        public virtual Task OnAppearing()
        {
            return Task.CompletedTask;
        }

        public virtual Task OnDisappearing()
        {
            return Task.CompletedTask;
        }

        public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
        {
        }
    }
}
