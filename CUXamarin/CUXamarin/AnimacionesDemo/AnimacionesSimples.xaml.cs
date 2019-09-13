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
	public partial class AnimacionesSimples : ContentPage
	{
		public AnimacionesSimples ()
		{
			InitializeComponent ();
		}

        /// <summary>
        /// Para saber cuandp estan o no deshabilitados los botones
        /// </summary>
        void SetIsEnableButtonState(bool startButtonState, bool cancelButtonstate)
        {
            startButton.IsEnabled = startButtonState;
            cancelButton.IsEnabled = cancelButtonstate;
        }

        async void OnStartAnimationButtonClicked(object sender, EventArgs e)
        {
            SetIsEnableButtonState(false, true);

            //Translation
            //await image.TranslateTo(100, 100, 1000);
            //await image.TranslateTo(-100, -100, 50);
            //await image.TranslateTo(200, 0, 2000);
            //await image.TranslateTo(0, 0, 500);

            //Scaling
            //await image.ScaleTo(0,1000);
            //await image.ScaleTo(8,1000);
            //await image.ScaleTo(-2,1000);
            //await image.ScaleTo(1,1000);

            //Rotation
            //await image.RotateTo(100, 1000);
            //await image.RotateTo(-100, 1000);
            //await image.RotateTo(250, 1000);
            //await image.RotateTo(0, 1000);


            //await image.RotateXTo(35,1000);
            //await image.RotateYTo(35,1000);
            //await image.RotateXTo(0,1000);
            //await image.RotateYTo(0,1000);

            //Se probó la cancelacion de la animacion

            //Fade
            //var cancelado = await image.FadeTo(1, 4000);
            //if (!cancelado)//Si no fue cancelado continua
            //{
            //    await image.FadeTo(0, 4000);
            //    SetIsEnableButtonState(true, false);
            //}
            //else
            //{//Si fue cancelado, lo regresa a su estado original
            //    image.Opacity = 0;
            //    SetIsEnableButtonState(true, false);
            //}
            ////await image.FadeTo(0, 4000);




            //******************************************************************************///
            //Ejecutando multiples animaciones

            //Espera a que todos adentro terminen
            //await Task.WhenAll<bool>
            //    (
            //        image.RotateTo(360,2000),
            //        image.ScaleTo(5,1000)
            //    );
            //await image.ScaleTo(1, 1000);

            //Espera hasta que cualquiera termine
            await Task.WhenAny<bool>
                (
                    image.RotateTo(360, 2000),
                    image.ScaleTo(5, 1000)
                );
            await image.ScaleTo(1, 1000);
        }




        /// <summary>
        /// Creado para cancelar la animacion en progreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnCancelAnimationButtonClicked(object sender, EventArgs e)
        {
            //Detiene la animacion
            ViewExtensions.CancelAnimations(image);
            SetIsEnableButtonState(true, false);
        }
    }
}