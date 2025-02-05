using System.Windows.Input;

namespace CommonAgentDesktop.App.Controls;

public partial class MenuItem : Frame
{
    public string MenuImage
    {
        get => GetValue(MenuImageProperty).ToString();
        set => SetValue(MenuImageProperty, value);
    }

    public static BindableProperty MenuImageProperty = BindableProperty.Create(
                                                        propertyName: nameof(MenuImage),
                                                        returnType: typeof(string),
                                                        declaringType: typeof(MenuItem),
                                                        defaultValue: string.Empty,
                                                        defaultBindingMode: BindingMode.TwoWay,
                                                        propertyChanged: MenuImagePropertyChanged);

    public string MenuText
    {
        get => GetValue(MenuTextProperty).ToString();
        set => SetValue(MenuTextProperty, value);
    }

    public static BindableProperty MenuTextProperty = BindableProperty.Create(
                                                        propertyName: nameof(MenuText),
                                                        returnType: typeof(string),
                                                        declaringType: typeof(MenuItem),
                                                        defaultValue: string.Empty,
                                                        defaultBindingMode: BindingMode.TwoWay,
                                                        propertyChanged: MenuTextChanged);
    public Color MenuTextColor
    {
        get => (Color)GetValue(MenuTextColorProperty);
        set => SetValue(MenuTextColorProperty, value);
    }

    public static BindableProperty MenuTextColorProperty = BindableProperty.Create(
                                                        propertyName: nameof(MenuTextColor),
                                                        returnType: typeof(Color),
                                                        declaringType: typeof(MenuItem),
                                                        defaultValue: Colors.Grey,
                                                        defaultBindingMode: BindingMode.TwoWay,
                                                        propertyChanged: MenuTextColorChanged);

    public ICommand TapCommand
    {
        get => (ICommand)GetValue(TapCommandProperty);
        set => SetValue(TapCommandProperty, value);
    }

    public static BindableProperty TapCommandProperty = BindableProperty.Create(
                                                        propertyName: nameof(TapCommand),
                                                        returnType: typeof(ICommand),
                                                        declaringType: typeof(MenuItem));

    public string TapCommandParameter
    {
        get => GetValue(TapCommandParameterProperty).ToString();
        set => SetValue(TapCommandParameterProperty, value);
    }

    public static BindableProperty TapCommandParameterProperty = BindableProperty.Create(
                                                        propertyName: nameof(TapCommandParameter),
                                                        returnType: typeof(string),
                                                        declaringType: typeof(MenuItem),
                                                        defaultValue: string.Empty,
                                                        defaultBindingMode: BindingMode.TwoWay);

    public bool IsSelected
    {
        get => (bool)GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
    }
    public static BindableProperty IsSelectedProperty = BindableProperty.Create(
                                                        propertyName: nameof(IsSelected),
                                                        returnType: typeof(bool),
                                                        declaringType: typeof(MenuItem),
                                                        defaultValue: false,
                                                        defaultBindingMode: BindingMode.TwoWay,
                                                        propertyChanged: OnIsSelectedChanged);



    private PointerGestureRecognizer _pgr = null;
    private TapGestureRecognizer _tgr = null;

    public MenuItem()
    {
        InitializeComponent();

        _pgr = new PointerGestureRecognizer();
        _pgr.PointerEntered += PointerGestureRecognizer_PointerEntered;
        _pgr.PointerExited += PointerGestureRecognizer_PointerExited;

        _tgr = new TapGestureRecognizer();
        _tgr.Tapped += TapGestureRecognizer_Tapped;

        GestureRecognizers.Add(_pgr);
        GestureRecognizers.Add(_tgr);
    }

    private void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
        //Scale = 1.1;
        this.BackgroundColor = Color.FromRgba(241, 242, 244, 0.1);

    }

    private void PointerGestureRecognizer_PointerExited(object sender, PointerEventArgs e)
    {
        //Scale = 1;

        if (IsSelected == true)
        {
            return;
        }
        else
        {

            this.BackgroundColor = Colors.Transparent;
        }
    }

    private static void MenuImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue == null)
            return;

        var control = (MenuItem)bindable;
        control.MenuImg.Source = ImageSource.FromFile(newValue.ToString());
    }

    private static void MenuTextChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue == null)
            return;

        var control = (MenuItem)bindable;
        control.MenuLabel.Text = newValue.ToString();
    }
    private static void MenuTextColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (newValue == null)
            return;

        var control = (MenuItem)bindable;
        control.MenuLabel.TextColor = (Color)newValue;
    }

    private static void OnIsSelectedChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var menuItem = (MenuItem)bindable;

        menuItem.UpdateAppearance((bool)newValue);
    }

    private void UpdateAppearance(bool isSelected)
    {
        if (isSelected)
        {
            this.BackgroundColor = Color.FromRgba(241, 242, 244, 0.1);
        }
        else
        {
            this.BackgroundColor = Colors.Transparent;
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (TapCommand != null && TapCommand.CanExecute(TapCommandParameter))
            TapCommand.Execute(TapCommandParameter);
    }

    ~MenuItem()
    {
        _pgr.PointerEntered -= PointerGestureRecognizer_PointerEntered;
        _pgr.PointerExited -= PointerGestureRecognizer_PointerExited;
        _tgr.Tapped -= TapGestureRecognizer_Tapped;
    }

    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
        MenuLabel.AutomationId = this.AutomationId;
    }
}