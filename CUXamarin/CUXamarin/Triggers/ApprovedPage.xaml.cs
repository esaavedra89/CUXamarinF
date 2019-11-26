
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.Triggers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApprovedPage : ContentPage
    {
        public ApprovedPage()
        {
            InitializeComponent();
            this.BindingContext = new ApprovedPageViewModel();
        }
    }
}