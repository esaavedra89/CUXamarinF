
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.AnimacionesDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpAnimado : ContentPage
    {
        public PopUpAnimado()
        {
            InitializeComponent();
            btnPagar.Clicked += BtnPagar_Clicked;
            btnAprobar.Clicked += BtnAprobar_Clicked;
        }

        private async void BtnPagar_Clicked(object sender, System.EventArgs e)
        {
            //Desactivamos boton
            mainContainer.Opacity = .2;
            mainContainer.IsEnabled = false;

            //Ejecutamos PopUp
            await Task.WhenAll
                (
                    frame.ScaleTo(2.5, 500, Easing.Linear),//Escalamos 2.5 con duracion de 500ml 
                    frame.FadeTo(1, 250, Easing.CubicIn)//250 ml
                );
            //Se agrega este para que no se vea tan grande
            await frame.ScaleTo(1, 500, Easing.SpringIn);
        }

        private async void BtnAprobar_Clicked(object sender, System.EventArgs e)
        {
            //Desaparecemos PopUp
            //
            await Task.WhenAll
                (
                    frame.ScaleTo(2.5, 500, Easing.SpringOut),//Escalamos a 2.5 para que se vea que se agranda
                    frame.FadeTo(0, 1000, Easing.CubicInOut)
                );

            await frame.ScaleTo(0, 500, Easing.Linear);//Aqui hacemos que vuelva a 0, se aleja

            //Activamos boton
            mainContainer.Opacity = 1;
            mainContainer.IsEnabled = true;
        }
    }
}