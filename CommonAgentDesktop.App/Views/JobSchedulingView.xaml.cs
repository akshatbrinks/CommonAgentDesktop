using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views.Base;

namespace CommonAgentDesktop.App.Views;

public partial class JobSchedulingView : ContentPageBase
{
	public JobSchedulingView(JobSchedulingViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}