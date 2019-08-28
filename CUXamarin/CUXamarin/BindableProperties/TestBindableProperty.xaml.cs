using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.BindableProperties
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestBindableProperty : ContentPage
	{
		public TestBindableProperty ()
		{
			InitializeComponent ();
            this.BindingContext = new Carro
            {
                Nombre = "Malibu",
                Puntaje = 3.0
            };
		}
	}

    public class Carro
    {
        public string Nombre { get; set; }

        public double Puntaje { get; set; }
    }
}
