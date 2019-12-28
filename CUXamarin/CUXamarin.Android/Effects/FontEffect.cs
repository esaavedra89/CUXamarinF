using System;
using System.Diagnostics;
using Android.Graphics;
using Android.Widget;
using CUXamarin.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(FontEffect), "FontEffect")]
namespace CUXamarin.Droid.Effects
{
    public class FontEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var xLabel = Element as Label;
            if (xLabel == null)
            {
                return;
            }

            var pLabel = Control as TextView;
            // De prueba para ver si esta viniendo el texto que le pasamos por el Xaml.
            var fontFamily = CUXamarin.Effects.FontEffect.GetFontName(xLabel);
            Debug.WriteLine(fontFamily);

            var font =
                Typeface.CreateFromAsset(Android.App.Application.Context.Assets,
                $"{fontFamily}.ttf");

            pLabel.Typeface = font;
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}