using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CUXamarin.Behaviors
{
    public class EmailBehavior : Behavior<Entry>
    {
        bool colorSet = false;

        Color color;

        #region Email
        public const string MatchEmailPattern =
            @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

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
        #endregion

        // Creando Bindable properties.

        public static readonly BindableProperty ErrorTextColorProperty =
            BindableProperty.Create("ErrorTextColor",
                typeof(Color),// Valor de retorno.
                typeof(EmailBehavior),//quien declara.
                default(Color));// Valor por defecto.

        public Color ErrorTextColor
        {
            get { return (Color)GetValue(ErrorTextColorProperty); }
            set { SetValue(ErrorTextColorProperty, value); }
        }

        static readonly BindablePropertyKey IsValidPropertyKey =
            BindableProperty.CreateReadOnly("IsValid",
                typeof(bool),
                typeof(EmailBehavior),
                false);

        // propiedad de solo lectura.
        public static readonly BindableProperty IsValidProperty =
            IsValidPropertyKey.BindableProperty;

        public bool IsValid
        {
            get { return (bool)GetValue(IsValidProperty); }
            private set { SetValue(IsValidPropertyKey, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += Bindable_TextChanged;
        }

        private void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
            IsValid = IsEmail(e.NewTextValue);

            // Para el caso donde por el Xaml cambiaron el color del texto.
            if (!colorSet)
            {
                colorSet = true;
                color = ((Entry)sender).TextColor;
            }

            ((Entry)sender).TextColor = IsValid ? Color.Default : ErrorTextColor;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= Bindable_TextChanged;
        }
    }
}
