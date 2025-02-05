using CommonAgentDesktop.App.Services.Navigation;
using CommonAgentDesktop.App.ViewModels.Base;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CommonAgentDesktop.App.ViewModels
{
    public partial class VoziqViewModel : ViewModelBase
    {
        public VoziqViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        [ObservableProperty]
        private string voziqWebViewURL = "https://brinks-qa.voziq.com";
    }
}
