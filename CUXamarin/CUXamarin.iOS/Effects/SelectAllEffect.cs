using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CUXamarin.iOS.Effects;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(SelectAllEffect), "SelectAllEffect")]
namespace CUXamarin.iOS.Effects
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
            // Verificamos si ciertas propiedades cambiaron.
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == VisualElement.IsFocusedProperty.PropertyName)
            {
                // Obtenemos el control.
                var pEntry = Control as UITextField;
                if (pEntry == null)
                {
                    return;
                }

                pEntry.PerformSelector(
                    new ObjCRuntime.Selector("selectAll"), null, 0.0f);
            
        }
    }
}