using CommonAgentDesktop.App.ViewModels;

namespace CommonAgentDesktop.App
{
    public partial class App : Application
    {
        public App(AppShellViewModel vm)
        {
            InitializeComponent();

            MainPage = new AppShell(vm);
        }
    }
}
