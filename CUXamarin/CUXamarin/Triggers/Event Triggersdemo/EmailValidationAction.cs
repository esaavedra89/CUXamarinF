

using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace CUXamarin.Triggers.Event_Triggersdemo
{
    public class EmailValidationAction : TriggerAction<Entry>
    {
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

        protected override void Invoke(Entry sender)
        {
            bool isValid = IsEmail(sender.Text);
            sender.TextColor = isValid ? Color.Default : Color.DarkRed;
        }
    }
}
