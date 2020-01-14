
using CUXamarin.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(Entry),typeof(MyEntryRenderer))]
namespace CUXamarin.iOS.Renderers
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor =
                    UIColor.FromRGB(204, 153, 255);

                Control.BorderStyle = 
                    UITextBorderStyle.Line;
            }
        }
    }
}