using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views.Base;

namespace CommonAgentDesktop.App.Views;

public partial class VoziqView : ContentPageBase
{
	public VoziqView(VoziqViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}