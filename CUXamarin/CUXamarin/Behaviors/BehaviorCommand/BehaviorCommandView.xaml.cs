using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CUXamarin.Behaviors.BehaviorCommand
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BehaviorCommandView : ContentPage
    {
        public BehaviorCommandView()
        {
            InitializeComponent();
            this.BindingContext = new BehaviorCommandViewModel();
        }
    }

    public class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class BehaviorCommandViewModel
    {
        public Command SelecteditemCommand { get; set; }
        public Command AcceptCommand { get; set; }
        public Command CancelCommand { get; set; }

        public List<Person> People { get; set; }

        public BehaviorCommandViewModel()
        {
            People = new List<Person>
            {
                new Person
                {
                    Name = "Jose"
                },
                new Person
                {
                    Name = "Juan"
                },
                new Person
                {
                    Name = "Manuel"
                },
                new Person
                {
                    Name = "Rafael"
                },
            };

            SelecteditemCommand = new Command(async (item) => await ShowData((Person)item));

            AcceptCommand = new Command(() => Debug.WriteLine("HECHO"));

            CancelCommand = new Command(() => Debug.WriteLine(" No HECHO"));
        }

        async Task ShowData(Person item)
        {
            await App.Current.MainPage.DisplayAlert("OK",item.ToString(),"Ok");
        }
    }
}