using System;
using CUXamarin.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("ES")]
[assembly: ExportEffect(typeof(SimpleSliderEffect), "SimpleSliderEffect")]
namespace CUXamarin.iOS.Effects
{
    public class SimpleSliderEffect : PlatformEffect
    {
        UIColor minColor;
        UIColor maxColor;

        protected override void OnAttached()
        {
            var pSlider = Control as UISlider;

            if (pSlider == null)
            {
                return;
            }

            // Asignamos el color de background del Slider.
            pSlider.MinimumTrackTintColor = UIColor.Green;
            pSlider.MaximumTrackTintColor = UIColor.Green;

        }

        protected override void OnDetached()
        {
            var pSlider = Control as UISlider;

            if (pSlider == null)
            {
                return;
            }

            // Asignamos colores por defecto.
            pSlider.MinimumTrackTintColor = minColor;
            pSlider.MaximumTrackTintColor = maxColor;
        }
    }
}