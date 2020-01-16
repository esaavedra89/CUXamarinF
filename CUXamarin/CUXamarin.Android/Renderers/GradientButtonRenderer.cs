
using Android.Content;
using Android.Graphics.Drawables;
using CUXamarin.CustomRenderers.Renderers;
using CUXamarin.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// Directiva.
[assembly: ExportRenderer(typeof(GradientButton), typeof(GradientButtonRenderer))]
namespace CUXamarin.Droid.Renderers
{
    public class GradientButtonRenderer : ButtonRenderer
    {
        public GradientButtonRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            // Es necesario para el renderizado del elemento.
            base.OnElementChanged(e);

            if (Control == null)
            {

            }

            // Representa el antiguo elemento al cual nuestro control XF estaba adjunto.
            if (e.OldElement != null)
            {

            }

            // Si estamos ligado a un elemtno XF.
            if (e.NewElement != null)
            {
                // Obtenemos el control XF.
                var button = Control;
                // Obtenemos el BackgroundColor del control en XF.
                // Este seria el color que se asigna por el control de XF.
                var colorTop = Element.BackgroundColor;
                // Asignamos un color a esta variable.
                // Este sería el color que le asignamos por aquí.
                var colorBottom = Color.Black;

                // Se le asigna un color al Background.
                Control.SetBackground(GetGradientDrawable(colorTop, colorBottom));
            }
        }

        private GradientDrawable GetGradientDrawable(Color colorTop, Color colorBottom)
        {
            return new GradientDrawable(
                                        GradientDrawable.Orientation.TopBottom,
                                        new int[] { colorTop.ToAndroid(),
                                                    colorBottom.ToAndroid()});
        }
    }
}