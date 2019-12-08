
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CUXamarin.Behaviors
{
    public class BasicBehavior : Behavior<Entry>
    {
        public const string MatchEmailPattern =
            @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        /// <summary>
        /// Verifica si la data ingresada coincide con el patrón MatchEmailPattern.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsEmail(string email)
        {
            if (email != null)
            {
                return Regex.IsMatch(email, MatchEmailPattern);
            }
            else
            {
                return false;
            }
        }

        // Validamos corre electronico.
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            ((Entry)sender).TextColor =
                IsEmail(e.NewTextValue) ? Color.Default : Color.DarkRed;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged -= Bindable_TextChanged;// Nos desligamos del evento.
        }
    }
}
