
using Android.Content;
using CUXamarin.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

// El primero valor de typeof representa al elemento al cual se le van a realizar los cambios. En este caso es un Entry.
// En el segundo, es la clase que llevará a cabo los cambios. En este caso es MyEntryRenderer.
[assembly:ExportRenderer(typeof(Entry), typeof(MyEntryRenderer))]
namespace CUXamarin.Droid.Renderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {

        }

        /// <summary>
        /// Lleva a cabo la renderización para el control nativo y escribe la lógica 
        /// para personalizar el control.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            // Lo primero que debe ir es el base.OnElementChanged(e);.
            base.OnElementChanged(e);
            // e.OldElement; representa el elemento este renderer al cual fue abjuntado.
            // e.NewElement; representa el elemento tipo XF al cual este renderer fue abjuntado.
            // Control: que es el control nativo al cual le hacemos el cambio.
            // Element: representa el control en XF.
            if (Control != null)
            {
                // En este caso configuramos el control Entry en general pero solo para el proyecto Android
                // Es decir, que se modifica el control Entry y todos los Entries tendran este cambio aplicado.
                Control.SetBackgroundColor(Color.DarkRed.ToAndroid());
            }

            // Este metodo es llamado cuando el control XF es llamado
            
        }
    }
}