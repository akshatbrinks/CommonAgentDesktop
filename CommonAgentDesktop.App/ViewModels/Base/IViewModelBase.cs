using CommonAgentDesktop.App.Services.Navigation;
using CommunityToolkit.Mvvm.Input;

namespace CommonAgentDesktop.App.ViewModels.Base
{
    public interface IViewModelBase : IQueryAttributable
    {
        public INavigationService NavigationService { get; }
        public IAsyncRelayCommand OnAppearingCommand { get; }
        public IAsyncRelayCommand OnDisappearingCommand { get; }
    }
}
