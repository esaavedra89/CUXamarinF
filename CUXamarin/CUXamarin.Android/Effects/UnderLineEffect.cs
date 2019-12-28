using System;
using Android.Widget;
using CUXamarin.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportEffect(typeof(UnderLineEffect), "UnderLineEffect")]
namespace CUXamarin.Droid.Effects
{
    // No se delara ResolutionGroupName porque ya esta declarado desde otro lado.
    public class UnderLineEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var pLabel = Control as TextView;// Obtenemos el control.
            if (pLabel == null)
            {
                return;
            }
            // Agregamos una nueva bandera que nos permira agregar texto.
            pLabel.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}