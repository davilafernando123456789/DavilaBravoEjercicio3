using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio3
{
    public class ImageResourceExtension : IMarkupExtension

    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {

            if (Source == null)
                return null;
            //Do your translation lookup here, using whatever method you
            var imageSource = ImageSource.FromResource(Source,
                typeof(ImageResourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}