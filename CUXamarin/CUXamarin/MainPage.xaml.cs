using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CUXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //btnTask.Clicked += BtnTask_Clicked;
        }

        private async void BtnTask_Clicked(object sender, EventArgs e)
        {
            //await WaitTime(3000).ContinueWith((args) =>
            //{
            //    //Se usa BeginInvokeOnMainThread porque las tareas en segundo plano
            //    //No pueden actualizar el hilo principal
            //    Device.BeginInvokeOnMainThread(() =>
            //    {
            //        StatusLabel.Text = "Operación terminada";
            //    });
            //});

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    if (Device.Idiom == TargetIdiom.Phone)
                    {
                        await DisplayAlert("Android", "Hola, estoy en una telefono Android", "Ok");
                    }
                    else if (Device.Idiom == TargetIdiom.Tablet)
                    {
                        await DisplayAlert("Android", "Hola, estoy en una tablet Android", "Ok");
                    }
                    
                    break;
                case Device.iOS:
                    if (Device.Idiom == TargetIdiom.Phone)
                    {
                        await DisplayAlert("iOS", "Hola, estoy en una telefono iOS", "Ok");
                    }
                    else if (Device.Idiom == TargetIdiom.Tablet)
                    {
                        await DisplayAlert("iOS", "Hola, estoy en una tablet iOS", "Ok");
                    }
                    break;
                default:
                    await DisplayAlert("UnKown", "No se en que dispositivo estoy", "Ok");
                    break;
            }
        }
    }
}
