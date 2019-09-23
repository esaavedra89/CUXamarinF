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
    public partial class AnimacionesPersonalizadas : ContentPage
    {
        public AnimacionesPersonalizadas()
        {
            InitializeComponent();
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

            // Se crea animacion de escalamiento
            //var animation = new Animation(
            //    v => image.Scale = v, //pasamos una valor actual a partir del v que va a regresar XF a partir de los parametros que definamos
            //    1,//valaor minimo
            //    2//valor maximo
            //    );

            //animation.Commit(this, "SimpleAnimation", 16, 2000, Easing.Linear, (v, c)=> image.Scale = 1, ()=> true);

            var parentAnimation = new Animation();
            var scaleUpAnimation = new Animation(v => image.Scale = v, 1, 2, Easing.SpringIn);
            var rotateAnimation = new Animation(v => image.Rotation = v, 0, 360);
            var scaleDownAnimation = new Animation(v => image.Scale = v, 2, 1, Easing.SpringOut);

            parentAnimation.Add(0, 0.5, scaleUpAnimation);
            parentAnimation.Add(0, 1, rotateAnimation);
            parentAnimation.Add(0.5, 1, scaleDownAnimation);

            parentAnimation.Commit(this, "ChindAnimation", 16, 4000, null, (v, c) => SetIsEnableButtonState(true, false));

            
        }




        /// <summary>
        /// Creado para cancelar la animacion en progreso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnCancelAnimationButtonClicked(object sender, EventArgs e)
        {
            //Detiene la animacion
            this.AbortAnimation("ChindAnimation"
                );
        }
    }
}