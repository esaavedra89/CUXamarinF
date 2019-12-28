using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CUXamarin.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(FontEffect), "FontEffect")]
namespace CUXamarin.iOS.Effects
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

            var pLabel = Control as UILabel;

            pLabel.Font = UIFont.FromName("Sweety.ttf", pLabel.Font.PointSize);
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}