using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepasoMAUI.Converter
{
    class Converter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var valor = value.ToString();
            if(valor == "yes")
            {
                return true;
            }
            return false;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var boolean = (bool)value;
            if(boolean)
            {
                return "yes";
            }
            return "no";
        }
    }
}
