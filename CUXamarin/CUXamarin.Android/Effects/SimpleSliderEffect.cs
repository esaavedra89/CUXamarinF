using Android.Graphics;
using Android.Widget;
using CUXamarin.Droid.Effects;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ResolutionGroupName("ES")]// Este debe ser igual en todos lados.
[assembly:ExportEffect(typeof(SimpleSliderEffect), "SimpleSliderEffect")] // Requerido para el uso de los efectos en diferentes plataformas.
namespace CUXamarin.Droid.Effects
{
    public class SimpleSliderEffect : PlatformEffect
    {
        ColorFilter color;

        protected override void OnAttached()
        {
            // Obtenemos el control.
            var pslider = Control as SeekBar; // SeekBar es el nombre del control en la plataforma Android Slider == SeekBar.

            // Asignamos el color por defecto.
            color = pslider.ProgressDrawable.ColorFilter;

            if (pslider == null)// Si es nulo lo retornamos.
            {
                return;
            }

            // Definimos un unico color.
            pslider.
                ProgressDrawable. // Representa el fondo del slider.
                SetColorFilter( // Se le asigna un color a elemento ProgressDrawable que realmente va a iluminar nuestro elemento background del slider.
                new PorterDuffColorFilter(Xamarin.Forms.Color.DarkGreen.ToAndroid(), // Le pasamos el color que queremos y le pasamos ToAndroid() para convertir de XF a Android.
                                          PorterDuff.Mode.SrcIn)); // 
        }



        protected override void OnDetached()
        {
            var pSlider = Control as SeekBar;

            if (pSlider == null)
            {
                return;
            }

            // Le asingnamos el color por defecto.
            pSlider.ProgressDrawable.SetColorFilter(color);

        }
    }
}