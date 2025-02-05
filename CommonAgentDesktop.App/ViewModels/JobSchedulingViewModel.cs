using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class JobSchedulingViewModel : ViewModelBase
    {
        public JobSchedulingViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [ObservableProperty]
        private string jobSchedulingWebUrl = "https://agentschedulingstg.pms.monitronics.pvt";
    }
}
