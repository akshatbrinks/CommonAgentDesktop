namespace CommonAgentDesktop.App.Services.Navigation
{
    public class MauiNavigationService : INavigationService
    {
        public MauiNavigationService()
        {

        }

        public async Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            if (routeParameters != null)
            {
                await Shell.Current.GoToAsync(shellNavigation, false, routeParameters);
            }
            else
            {
                await Shell.Current.GoToAsync(shellNavigation, false);
            }
        }

        public async Task PopAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
