using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.AttachedProperty
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AttachedPropertyView : ContentPage
    {
        public AttachedPropertyView()
        {
            InitializeComponent();
            btnGetValue.Clicked += BtnGetValue_Clicked;
        }

        private void BtnGetValue_Clicked(object sender, EventArgs e)
        {
            //Se verifica si la etiqueta lblTest (Label)
            //tiene una propiedad adjuntada
            if (Attached.GetIsAttached(lblTest))
            {
                DisplayAlert("Attached", "Prpperty is atthached", "ok");
            }
            else
            {
                DisplayAlert("Not Attached", "Property is not atthached", "ok");
            }
        }
    }
}