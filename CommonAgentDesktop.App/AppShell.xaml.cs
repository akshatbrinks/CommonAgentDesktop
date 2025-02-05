using CommonAgentDesktop.App.ViewModels;

namespace CommonAgentDesktop.App
{
    public partial class AppShell : Shell
    {
        public AppShell(AppShellViewModel vm)
        {
            InitializeComponent();

            BindingContext = vm;
        }
    }
}
