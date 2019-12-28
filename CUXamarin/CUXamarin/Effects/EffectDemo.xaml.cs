
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.Effects
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EffectDemo : ContentPage
    {
        //Effect sliderEffect;
        RoutingEffect sliderEffect;

        public EffectDemo()
        {
            InitializeComponent();

            // Aquí buscamos el efecto que esté bajo este nombre.
            //sliderEffect = Effect.Resolve("ES.SimpleSliderEffect");

            sliderEffect = new SliderEffect(); // Este acepta.
            //sliderEffect = new SliderEffect();
            mySlider.Effects.Add(sliderEffect);// Lo agregamos a la lista de efectos.
            // Si no encuentra un efecto con este nombre, no habrá ningun error
            // Ya que este efecto se puede aplicar a cualquier plataforma o a una plataforma en especifico y en otras no.
        }

        private void switchEffects_Toggled(object sender, ToggledEventArgs e)
        {
            mySlider.Effects.Remove(sliderEffect);

            if (switchEffects.IsToggled)
            {
                mySlider.Effects.Add(sliderEffect);
            }
        }
    }
}