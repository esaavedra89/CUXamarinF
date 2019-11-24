using System;
using Xamarin.Forms;

namespace CUXamarin.Triggers.Event_Triggersdemo
{
    public class ScaleAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.ScaleTo(3.5);
        }
    }
    public class DeScaleAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            sender.ScaleTo(1);
        }
    }
}
