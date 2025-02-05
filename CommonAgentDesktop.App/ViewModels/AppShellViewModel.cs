using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class AppShellViewModel : ViewModelBase
    {
        public AppShellViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
