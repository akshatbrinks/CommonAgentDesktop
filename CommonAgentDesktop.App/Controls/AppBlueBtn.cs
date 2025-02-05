namespace CommonAgentDesktop.App.Controls
{
    public class AppBlueBtn : Button
    {
        public bool Disabled
        {
            get => (bool)GetValue(DisabledProperty);
            set => SetValue(DisabledProperty, value);
        }

        public static BindableProperty DisabledProperty = BindableProperty.Create(
                                                            propertyName: nameof(Disabled),
                                                            returnType: typeof(bool),
                                                            declaringType: typeof(AppBlueBtn),
                                                            defaultValue: false,
                                                            defaultBindingMode: BindingMode.TwoWay,
                                                            propertyChanged: DisabledPropertyChanged);

        private PointerGestureRecognizer _pgr = null;
        private static Color _enabledColor = null;
        private static Color _disabledColor = null;
        private Color _hoverColor = null;

        public AppBlueBtn()
        {
            _enabledColor = Application.Current.Resources["AppBlueColor"] as Color;
            _disabledColor = Colors.LightGrey;
            _hoverColor = Colors.Black;

            BackgroundColor = _enabledColor;
            TextColor = Colors.White;
            CornerRadius = 5;

            _pgr = new PointerGestureRecognizer();
            _pgr.PointerEntered += Pgr_PointerEntered;
            _pgr.PointerExited += Pgr_PointerExited;
            GestureRecognizers.Add(_pgr);

            IsEnabled = !Disabled;
        }

        private void Pgr_PointerEntered(object sender, PointerEventArgs e)
        {
            if (Disabled == true)
                return;

            this.BackgroundColor = _hoverColor;
        }

        private void Pgr_PointerExited(object sender, PointerEventArgs e)
        {
            if (Disabled == true)
                return;

            this.BackgroundColor = _enabledColor;
        }

        private static void DisabledPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            bool.TryParse(newValue.ToString(), out bool disabled);
            var control = (AppBlueBtn)bindable;

            if (disabled == true)
            {
                control.BackgroundColor = _disabledColor;
                control.IsEnabled = false;
            }
            else
            {
                control.BackgroundColor = _enabledColor;
                control.IsEnabled = true;
            }
        }

        ~AppBlueBtn()
        {
            _pgr.PointerEntered -= Pgr_PointerEntered;
            _pgr.PointerExited -= Pgr_PointerExited;
        }
    }
}
