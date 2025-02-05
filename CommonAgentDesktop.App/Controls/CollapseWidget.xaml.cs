using CommonAgentDesktop.App.ViewModels.Base;
using System.Windows.Input;

namespace CommonAgentDesktop.App.Controls;

public partial class CollapseWidget : HorizontalStackLayout
{

    public ICommand TapCommand
    {
        get => (ICommand)GetValue(TapCommandProperty);
        set => SetValue(TapCommandProperty, value);
    }

    public static BindableProperty TapCommandProperty = BindableProperty.Create(
                                                        propertyName: nameof(TapCommand),
                                                        returnType: typeof(ICommand),
                                                        declaringType: typeof(CollapseWidget));

    public bool IsCollapsed
    {
        get => (bool)GetValue(IsCollapsedProperty);
        set => SetValue(IsCollapsedProperty, value);
    }
    public static BindableProperty IsCollapsedProperty = BindableProperty.Create(
                                                        propertyName: nameof(IsCollapsed),
                                                        returnType: typeof(bool),
                                                        declaringType: typeof(CollapseWidget),
                                                        defaultValue: false,
                                                        defaultBindingMode: BindingMode.TwoWay,
                                                        propertyChanged: OnIsCollapsedChanged);

    private static void OnIsCollapsedChanged(BindableObject bindable, object oldValue, object newValue)
    {
        bool.TryParse(newValue.ToString(), out bool isCollapsed);
        var control = (CollapseWidget)bindable;

        if (isCollapsed == true)
        {
            control.CollapseWidgetImg.Source = "expand_icon.png";
            control.CollapseWidgetLbl.IsVisible = false;
        }
        else
        {
            control.CollapseWidgetImg.Source = "collapse_icon.png";
            control.CollapseWidgetLbl.IsVisible = true;
        }
    }

    private PointerGestureRecognizer _pgr = null;
    private TapGestureRecognizer _tgr = null;

    public CollapseWidget()
    {
        InitializeComponent();

        _pgr = new PointerGestureRecognizer();
        _pgr.PointerEntered += PointerGestureRecognizer_PointerEntered;
        _pgr.PointerExited += PointerGestureRecognizer_PointerExited;

        _tgr = new TapGestureRecognizer();
        _tgr.Tapped += TapGestureRecognizer_Tapped;

        GestureRecognizers.Add(_pgr);
        GestureRecognizers.Add(_tgr);

        CollapseWidgetImg.Source = ImageSource.FromFile("collapse_icon.png");
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (TapCommand != null && TapCommand.CanExecute(null))
            TapCommand.Execute(null);
    }

    private void PointerGestureRecognizer_PointerExited(object sender, PointerEventArgs e)
    {
        this.BackgroundColor = Application.Current.Resources["AppBlueColor"] as Color;
    }

    private void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        this.BackgroundColor = Color.FromRgba(241, 242, 244, 0.1);
    }

    ~CollapseWidget()
    {
        _pgr.PointerEntered -= PointerGestureRecognizer_PointerEntered;
        _pgr.PointerExited -= PointerGestureRecognizer_PointerExited;
        _tgr.Tapped -= TapGestureRecognizer_Tapped;
    }
}