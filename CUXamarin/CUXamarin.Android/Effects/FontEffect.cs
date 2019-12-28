using System;
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

            var font =
                Typeface.CreateFromAsset(Android.App.Application.Context.Assets,
                "Sweety.ttf");

            pLabel.Typeface = font;
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}