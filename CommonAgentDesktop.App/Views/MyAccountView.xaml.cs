using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views.Base;

namespace CommonAgentDesktop.App.Views;

public partial class MyAccountView : ContentPageBase
{
	public MyAccountView(MyAccountViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}