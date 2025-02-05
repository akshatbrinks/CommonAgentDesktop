using CommonAgentDesktop.App.ViewModels;
using CommonAgentDesktop.App.Views.Base;

namespace CommonAgentDesktop.App.Views;

public partial class MovesView : ContentPageBase
{
    public MovesView(MovesViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}