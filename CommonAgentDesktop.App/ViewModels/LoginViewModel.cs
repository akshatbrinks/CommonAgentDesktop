using CommonAgentDesktop.App.Models;
using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [RelayCommand]
        public async Task SignInAsync()
        {
            await NavigationService.NavigateToAsync($"//{ViewsRouting.HomeView}");
            Shell.Current.FlyoutBehavior = FlyoutBehavior.Locked;
        }
    }
}
