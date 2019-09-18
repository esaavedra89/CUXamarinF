using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.AnimacionesDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EasingDemo : ContentPage
    {
        public EasingDemo()
        {
            InitializeComponent();
            btnEasing.Clicked += BtnEasing_Clicked;
        }

        private async void BtnEasing_Clicked(object sender, EventArgs e)
        {
            /*************SinIn y SinOut***************/
            //Se desplaza de la posicion 0,0 a 500,500 en 2 seg, haciendo el efecto de SinIn
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.SinIn);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.CubicIn);
            ////await btnEasing.TranslateTo(500, 500, 2000, Easing.CubicInOut);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.BounceIn);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.SpringIn);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.SinInOut);
            //await Task.Delay(1000);
            //Se desplaza de la posicion 500,500 a 0,0 en 2 seg, haciendo el efecto de SinOut
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SinOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.CubicOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.CubicInOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.BounceOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SpringOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SinInOut);

            //Func<double, double> linear = t => t;
            //Easing easing = new Easing(t => t);
            //Func<double, double> linear2 = t => linear(t);
            //Func<double, double> myOwnEasing = t => linear(t);

            var translationX = btnEasing.TranslationX;
            Func<double, double> noEasing = t => NoEasing(t, translationX, 500, 1);

            await btnEasing.TranslateTo(500, 0, 5000, noEasing);         
        }

        double linear(double t)
        {
            Console.WriteLine(t);
            return t;
        }

        double MyOwnEasing(double t)
        {
            var result = (int)(5 * t) / 5.0;
            Console.WriteLine(result);
            return result;
        }

        double NoEasing(double tiempo, double valorInicial, double cambio, double duracion)
        {
            tiempo /= duracion;
            var result = valorInicial + cambio * (tiempo);
            Console.WriteLine(result);
            return result;
        }
    }
}