
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.BindableProperties
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Header : ContentView
	{
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(
                "Title",
                typeof(string),
                typeof(Header),
                defaultValue: "Titulo",
                propertyChanged: TitleChanged);

        private static void TitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (Header)bindable;
            //Se accede a lblTitle.Text porque es la variable a modificar en este caso
            //lblTitle es un control, en este caso es un control tipo Label
            //.Text es una propiedad
            control.lblTitle.Text = newValue.ToString();
        }

        public string Title
        {
            get
            {
                return GetValue(TitleProperty).ToString();
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }


        public Header ()
		{
			InitializeComponent ();
		}
	}
}