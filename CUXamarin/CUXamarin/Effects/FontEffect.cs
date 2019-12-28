using Xamarin.Forms;

namespace CUXamarin.Effects
{
    public class FontEffect : RoutingEffect
    {
        public static readonly BindableProperty FontNameProperty =
            BindableProperty.CreateAttached(
                "FontName",
                typeof(string),
                typeof(FontEffect),
                null);

        public static void SetFontName(VisualElement view, string fontName) 
        {
            view.SetValue(FontNameProperty, fontName);
        }

        public static string GetFontName(VisualElement view) 
        {
            return (string)view.GetValue(FontNameProperty);
        }

        public FontEffect() : base("ES.FontEffect")
        {

        }
    }
}
