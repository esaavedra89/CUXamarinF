using Xamarin.Forms;

namespace CUXamarin
{
    public class DarkTheme
    {
        public static Color BackgroundColor = Color.Black;

        public static Color FontColor = Color.White;

        public static double ParagraphSize = 15;

        public static double TitleSize = ParagraphSize + 5;

        public const FontAttributes QuoteStyle = FontAttributes.Italic;

        public const FontAttributes TitleStyle = FontAttributes.Bold;
    }

    public class WhiteTheme
    {
        public static Color BackgroundColor = Color.White;

        public static Color FontColor = Color.Black;

        public static double ParagraphSize = 13;

        public static double TitleSize = ParagraphSize + 5;

        public const FontAttributes QuoteStyle = FontAttributes.Bold;

        public const FontAttributes TitleStyle = FontAttributes.Italic;
    }
}

