using Xamarin.Forms;

namespace CUXamarin.Triggers.Event_Triggersdemo
{
    public class ScaleAction : TriggerAction<VisualElement>
    {
        public Point Anchor { get; set; }
        public double Scale { get; set; }
        public int Length { get; set; }
        [TypeConverter(typeof(EasingConverter))]
        public Easing EasingType { get; set; }

        public ScaleAction()
        {
            Anchor = new Point(0.5, 0.5);
            Scale = 1;
            Length = 250;
            EasingType = Easing.Linear;
        }

        protected override void Invoke(VisualElement sender)
        {
            sender.AnchorX = Anchor.X;
            sender.AnchorY = Anchor.Y;
            EasingType.ToString();
            sender.ScaleTo(Scale, (uint)Length, EasingType);
            //sender.ScaleTo(3.5);
        }
    }
    //public class DeScaleAction : TriggerAction<VisualElement>
    //{
    //    protected override void Invoke(VisualElement sender)
    //    {
    //        sender.ScaleTo(1);
    //    }
    //}
}
