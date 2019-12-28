
using System.ComponentModel;
using Android.Widget;
using CUXamarin.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(SelectAllEffect), "SelectAllEffect")]
namespace CUXamarin.Droid.Effects
{
    public class SelectAllEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            
        }

        protected override void OnDetached()
        {
            
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "IsFocused")
            {
                // Obtenemos el contro.
                var pEntry = Control as EditText;
                if (pEntry == null)
                {
                    return;
                }

                // Seleccionamos todo el texto.
                pEntry.SetSelectAllOnFocus(true);
            }
        }
    }
}