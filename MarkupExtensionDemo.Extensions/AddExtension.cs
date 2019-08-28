using System;
using Xamarin.Forms.Xaml;

namespace MarkupExtensionDemo.Extensions
{
    public class AddExtension : IMarkupExtension<string>
    {
        public int NumeroUno { get; set; }

        public int NumeroDos { get; set; }

        public string ProvideValue(IServiceProvider serviceProvider)
        {
            return (NumeroUno + NumeroDos).ToString();
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return (this as IMarkupExtension<string>).ProvideValue(serviceProvider);
        }
    }
}
