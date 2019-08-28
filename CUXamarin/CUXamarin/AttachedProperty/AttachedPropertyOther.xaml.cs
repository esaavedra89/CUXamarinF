using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.AttachedProperty
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AttachedPropertyOther : ContentPage
	{
		public AttachedPropertyOther ()
		{
			InitializeComponent ();
            btnIsAttached.Clicked += BtnIsAttached_Clicked;
		}

        private void BtnIsAttached_Clicked(object sender, EventArgs e)
        {
            //Se valida si la etiqueta lblMainText contiene un AttachedProperty asignada
            if (OlderAttached.GetIsForOlderPeople(lblMainText))
            {
                lblMainText.FontSize *= 2;
            }
            //Se valida si la etiqueta entrySecondText contiene un AttachedProperty asignada
            if (OlderAttached.GetIsForOlderPeople(entrySecondText))
            {
                entrySecondText.FontSize *= 2;
            }
        }
    }
}