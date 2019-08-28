//Se crea una propiedad tipo Box para hacer uso de ella y crearle una funcionalidad en base al valor que le pasemos
//muestra un color en base al numero que se le pase como parametro


using System;
using Xamarin.Forms;

namespace CUXamarin.BindableProperties
{
    public class HealthBox : BoxView
    {
        //Definimos la BindablePropertie
        //Nombre de la propiedad seguido de la palabra Property 
        // Se inicializa esta variable
        /* 
         "HealthStatus" = nombre de la propiedad
         typeof(double), = tipo de dato de retorno
         typeof(HealthBox) = tipo de dato que se esta declarando
         10.0 = valor por defecto ***(es importante pasar el mismo tipo de dato para evitar errores)****
         propertyChanged: ValueChanged = callback que nos permite saber cuando cambia el dato de la propiedad HealthStatusProperty,
            cuando exista el cambio, se va a ejecutar el codigo que esté dentro del metodo ValueChanged()
             */
        public static readonly BindableProperty HealthStatusProperty =
            BindableProperty.Create(
                "HealthStatus",
                typeof(double),
                typeof(HealthBox),
                10.0,
                propertyChanged: ValueChanged);

        //Con varios parametros de entrada, se pueden tener varias instancias sin tener problemas
        private static void ValueChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var instance = bindable as HealthBox;
            if (instance != null)
            {
                //Ejecutamos el metodo SetHealth haciendo un casteo del tipo de dato que viene dentro de newValue
                //y pasandolo como parametro
                instance.SetHealth((double)newValue);
            }
        }

        public HealthBox()
        {
            //inicializamos el valor por defecto
            //Ejecutamos el metodo pasandole la propiedad con el valor por defecto
            //se pasa el valor por defecto, haciendo uso del DefaultValue declarado en la HealthStatusProperty
            SetHealth((double)HealthStatusProperty.DefaultValue);
        }

        //Se declara la propiedad CLR para el guardado de la informacion
        public double HealthStatus
        {
            get
            {
                //Casteo para obtener el tipo de dato que espera la propiedad
                //GetValue regresa una BindableProperty
                return (double)GetValue(HealthStatusProperty);
            }

            set
            {
                //Se invoica el SetValue
                SetValue(HealthStatusProperty, value);

            }
        }

        //Creamos un metodo que se encargue de la operacion a realizar, que es
        //la eleccion de un color

        /// <summary>
        /// Elige un color en base al número que se pasa como parametro
        /// </summary>
        /// <param name="health"></param>
        void SetHealth(double health)
        {
            if (health <4)
            {
                Color = Color.DarkRed;
            }
            else if (health >= 4 && health < 8)
            {
                Color = Color.LightGoldenrodYellow;
            }
            else
            {
                Color = Color.DarkGreen;
            }
        }
    }
}
