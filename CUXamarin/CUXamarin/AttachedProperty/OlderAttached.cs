using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CUXamarin.AttachedProperty
{
    public class OlderAttached
    {
        public static readonly BindableProperty IsForOlderPeopleProperty =
            BindableProperty.CreateAttached(
                "IsForOlderPeople",
                typeof(bool),
                typeof(OlderAttached),
                false);


        public static bool GetIsForOlderPeople(BindableObject obj)
        {
            return (bool)obj.GetValue(IsForOlderPeopleProperty);
        }

        public static void SetIsForOlderPeople(BindableObject obj, bool value)
        {
            obj.SetValue(IsForOlderPeopleProperty, value);
        }

    }
}
