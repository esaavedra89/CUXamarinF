using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CUXamarin.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(UnderLineEffect), "UnderLineEffect")]
namespace CUXamarin.iOS.Effects
{
    public class UnderLineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var pLabel = Control as UILabel;
            if (pLabel == null)
            {
                return;
            }

            // Agregamos atributos de texto por c#, por ejm el subrayado.
            var attrString = new NSMutableAttributedString(pLabel.Text);

            attrString.AddAttribute(UIStringAttributeKey.UnderlineStyle, 
                NSNumber.FromInt32((int)NSUnderlineStyle.Single),
                new NSRange(0, attrString.Length));

            // Asignamos los atributos a la variable.
            pLabel.AttributedText = attrString;
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}