using System;
using System.Globalization;
using Xamarin.Forms;

namespace CUXamarin.Triggers.MultiTriggers
{
    /// <summary>
    /// Aplica una condición donde podemos indicar si un valor es mayor que algún valor dado, en este caso verificaremos
    /// si el texto dentro del control seleccionado es mayor a cero.
    /// </summary>
    public class RequiredConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Preguntamos si la conversion a un entero a value es > 0.
            if ((int)value > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
