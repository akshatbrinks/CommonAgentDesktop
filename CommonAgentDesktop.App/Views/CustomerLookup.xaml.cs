using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views.Base;

namespace CommonAgentDesktop.App.Views;

public partial class CustomerLookup : ContentPageBase
{
	public CustomerLookup(CustomerLookupViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}