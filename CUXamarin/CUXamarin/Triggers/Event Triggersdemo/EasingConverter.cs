using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace CUXamarin.Triggers.Event_Triggersdemo
{
    public class EasingConverter : TypeConverter
    {
        public override object ConvertFromInvariantString(string value)
        {
            if (value == null || !(value is string))
            {
                return null;
            }

            string name = value.Trim();
            if (name.StartsWith("Easing"))
            {
                name = name.Substring(7);
            }

            FieldInfo field = typeof(Easing).GetRuntimeField(name);
            if (field != null && field.IsStatic)
            {
                return (Easing)field.GetValue(null);
            }

            // Si no se puede convertir, se muestra la excepcion.
            throw new InvalidOperationException
                ($"No se puede convertir \"{value}\" en Xamarin.Forms.Easing");
        }
    }
}
