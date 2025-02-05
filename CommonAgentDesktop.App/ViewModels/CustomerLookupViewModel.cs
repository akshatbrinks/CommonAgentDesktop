using CommonAgentDesktop.App.Models;
using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class CustomerLookupViewModel : ViewModelBase
    {
        public CustomerLookupViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [RelayCommand]
        public async Task VerifyCustomerAsync()
        {
            await NavigationService.NavigateToAsync($"//{ViewsRouting.CustomerLookupTabs}");
        }
    }
}
