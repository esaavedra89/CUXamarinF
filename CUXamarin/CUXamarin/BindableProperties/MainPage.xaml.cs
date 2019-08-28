
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.BindableProperties
{
    public class WebSite
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            BindingContext = new WebSite
            {
                Title = "Blog de Eleazar",
                SubTitle = "Ejemplo de Xamarin Bindable Porperties"
            };
		}
	}
}