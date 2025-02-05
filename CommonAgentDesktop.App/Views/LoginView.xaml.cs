using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views.Base;

namespace CommonAgentDesktop.App.Views;

public partial class LoginView : ContentPageBase
{
	public LoginView(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}