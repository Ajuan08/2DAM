using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepasoMAUI2.Converters
{
    public class intConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var answer = (int)value;
            if (answer > 0)
            {
                return (double)answer / 100;
            }
            else
            {
                return value;
            }
            
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            var answer = value;
            return (int)answer * 100;
        }
    }
}
