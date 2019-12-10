using System.Windows.Input;
using Xamarin.Forms;

namespace CUXamarin.Behaviors.BehaviorCommand
{
    public class ListviewSelectedItemBehavior : Behavior<ListView>
    {
        public static readonly BindableProperty ItemTappedCommandProperty =
            BindableProperty.Create(
            "ItemTappedCommand",
            typeof(ICommand),
            typeof(ListviewSelectedItemBehavior),
            null);

        public ICommand ItemTappedCommand
        {
            get { return (ICommand)GetValue(ItemTappedCommandProperty); }
            set { SetValue(ItemTappedCommandProperty, value); }
        }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemSelected += Bindable_ItemSelected;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemSelected -= Bindable_ItemSelected;
        }

        private void Bindable_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (ItemTappedCommand == null)
            {
                return;
            }

            // Se pasa el item seleccionado para obtener el objeto en si.
            if (ItemTappedCommand.CanExecute(e.SelectedItem))
            {
                ItemTappedCommand.Execute(e.SelectedItem);
            }
        }
    }
}
