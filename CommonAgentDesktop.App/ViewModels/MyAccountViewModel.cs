using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class MyAccountViewModel : ViewModelBase
    {
        public MyAccountViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [ObservableProperty]
        private string myAccountWebViewURL = "https://pip-01-cp-stg.brinkshome.com/customeragents";
    }
}
