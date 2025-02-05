using CommonAgentDesktop.App.ViewModels.Base;

namespace CommonAgentDesktop.App.Views.Base
{
    public class FlyoutPageBase : FlyoutPage
    {
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is not IViewModelBase vm)
            {
                return;
            }

            await vm.OnAppearingCommand.ExecuteAsync(null);
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();

            if (BindingContext is not IViewModelBase vm)
            {
                return;
            }

            await vm.OnDisappearingCommand.ExecuteAsync(null);
        }
    }
}
