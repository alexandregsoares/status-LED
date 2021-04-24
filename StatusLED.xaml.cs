using System.Windows;
using System.Windows.Media;


namespace status_LED
{
    public partial class StatusLed
    {
        public StatusLed()
        {
            InitializeComponent();
        }

        public enum eLedStatus { On, Off }

        public string LedColorOn
        {
            get { return (string)GetValue(LedColorOnProperty); }
            set { SetValue(LedColorOnProperty, value); }
        }
        public static readonly DependencyProperty LedColorOnProperty = DependencyProperty.Register("LedColorOn", typeof(string), typeof(StatusLed), new PropertyMetadata("Green"));
        public string LedColorOff
        {
            get { return (string)GetValue(LedColorOffProperty); }
            set { SetValue(LedColorOffProperty, value); }
        }
        public static readonly DependencyProperty LedColorOffProperty = DependencyProperty.Register("LedColorOff", typeof(string), typeof(StatusLed), new PropertyMetadata("#FF282424"));

        public int LedSize
        {
            get { return (int)GetValue(LedSizeOnProperty); }
            set { SetValue(LedSizeOnProperty, value); }
        }
        public static readonly DependencyProperty LedSizeOnProperty = DependencyProperty.Register("LedSize", typeof(int), typeof(StatusLed), new PropertyMetadata(30));

        public string LedShadowBlurRadius
        {
            get { return (string)GetValue(LedShadowBlurRadiusOnProperty); }
            set { SetValue(LedShadowBlurRadiusOnProperty, value); }
        }
        public static readonly DependencyProperty LedShadowBlurRadiusOnProperty = DependencyProperty.Register("LedShadowBlurRadius", typeof(string), typeof(StatusLed), new PropertyMetadata("3"));

        public string LedShadowDepth
        {
            get { return (string)GetValue(LedShadowDepthOnProperty); }
            set { SetValue(LedShadowDepthOnProperty, value); }
        }
        public static readonly DependencyProperty LedShadowDepthOnProperty = DependencyProperty.Register("LedShadowDepth", typeof(string), typeof(StatusLed), new PropertyMetadata("0.5"));

        public string LedBorderSize
        {
            get { return (string)GetValue(LedBorderSizeOnProperty); }
            set { SetValue(LedBorderSizeOnProperty, value); }
        }
        public static readonly DependencyProperty LedBorderSizeOnProperty = DependencyProperty.Register("LedBorderSize", typeof(string), typeof(StatusLed), new PropertyMetadata("3"));

        public string LabelFontSize
        {
            get { return (string)GetValue(LabelFontSizeOnProperty); }
            set { SetValue(LabelFontSizeOnProperty, value); }
        }
        public static readonly DependencyProperty LabelFontSizeOnProperty = DependencyProperty.Register("LabelFontSize", typeof(string), typeof(StatusLed), new PropertyMetadata("12"));
        public string LabelFont
        {
            get { return (string)GetValue(LabelFontOnProperty); }
            set { SetValue(LabelFontOnProperty, value); }
        }
        public static readonly DependencyProperty LabelFontOnProperty = DependencyProperty.Register("LabelFont", typeof(string), typeof(StatusLed), new PropertyMetadata("Segoe UI"));

        public string LabelRowHeight
        {
            get { return (string)GetValue(LabelRowHeightOnProperty); }
            set { SetValue(LabelRowHeightOnProperty, value); }
        }
        public static readonly DependencyProperty LabelRowHeightOnProperty = DependencyProperty.Register("LabelRowHeight", typeof(string), typeof(StatusLed), new PropertyMetadata("0"));
        public string Label
        {
            get { return (string)GetValue(LabelOnProperty); }
            set { SetValue(LabelOnProperty, value); }
        }
        public static readonly DependencyProperty LabelOnProperty = DependencyProperty.Register("Label", typeof(string), typeof(StatusLed), new UIPropertyMetadata("", OnLabelPropertyChange));
        public static void OnLabelPropertyChange(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var element = obj as StatusLed;

            if (element.Label == "")
            {
                element.LabelRowHeight = "0";
            }
            else
            {
                element.LabelRowHeight = "auto";
            }
        }

        public bool LedStatus
        {
            get { return (bool)GetValue(LedStatusProperty); }
            set { SetValue(LedStatusProperty, value); }
        }
        public static readonly DependencyProperty LedStatusProperty = DependencyProperty.Register("LedStatus", typeof(bool), typeof(StatusLed), new UIPropertyMetadata(false, OnLedStatusPropertyChange));
        public static void OnLedStatusPropertyChange(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var element = obj as StatusLed;
            if (element.LedStatus == true)
            {
                var color = (SolidColorBrush)new BrushConverter().ConvertFromString(element.LedColorOn);
                element.LedCircle.Background = color;
            }
            else
            {
                var color = (SolidColorBrush)new BrushConverter().ConvertFromString(element.LedColorOff);
                element.LedCircle.Background = color;
            }
        }
    }
}
