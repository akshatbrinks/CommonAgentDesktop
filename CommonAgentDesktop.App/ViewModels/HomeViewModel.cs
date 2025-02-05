using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
