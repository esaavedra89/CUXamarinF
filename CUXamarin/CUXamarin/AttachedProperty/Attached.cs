
using Xamarin.Forms;

namespace CUXamarin.AttachedProperty
{
    //Se le va a asignar a una etiqueta una propiedad Attached
    //La misma funcionalidad que tienen las etiquetas dentro de un Grid
    //Que por defecto por ejm un Label no tiene la propiedad Grid.Row
    //Pero como se encuentra dentro de un Grid, esta propiedad se
    //Adjunta dentro de estas etiquetas

    public class Attached
    {
        public static readonly BindableProperty IsAttachedProperty =
            BindableProperty.CreateAttached(
                "IsAttached",
                typeof(bool),
                typeof(Attached),
                false);

        //Es importante poner delante del metodo el Get, para que que se asocie
        public static bool GetIsAttached(BindableObject view)
        {
            //Se pregunta si una etiqueta tiene adjunta una AttachedProperty
            //BindableObject view seria el control al cual le queremos aplicar la AttachedProperty

            return (bool)view.GetValue(IsAttachedProperty);
        }

        //Set es importante ponerlo adelante
        //bool value es el valor que le queremos asignar a la etiqueta o propiedad
        public static void SetIsAttached(BindableObject view, bool value)
        {
            view.SetValue(IsAttachedProperty, value);
        }
    }
}
