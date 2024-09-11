using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Wpf_Markups
{
    internal class TimeExtension : MarkupExtension
    {
        public string Format { get; set; }

        public TimeExtension()
        {
            
        }

        public TimeExtension(string format)
        {
            Format = format;
        }
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return DateTime.Now.ToString(Format);
        }
    }
}
