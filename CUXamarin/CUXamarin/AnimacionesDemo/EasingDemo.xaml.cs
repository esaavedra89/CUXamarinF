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
            await btnEasing.TranslateTo(500, 500, 2000, Easing.CubicInOut);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.BounceIn);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.SpringIn);
            //await btnEasing.TranslateTo(500, 500, 2000, Easing.SinInOut);
            await Task.Delay(1000);
            //Se desplaza de la posicion 500,500 a 0,0 en 2 seg, haciendo el efecto de SinOut
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SinOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.CubicOut);
            await btnEasing.TranslateTo(0, 0, 2000, Easing.CubicInOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.BounceOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SpringOut);
            //await btnEasing.TranslateTo(0, 0, 2000, Easing.SinInOut);
        }
    }
}