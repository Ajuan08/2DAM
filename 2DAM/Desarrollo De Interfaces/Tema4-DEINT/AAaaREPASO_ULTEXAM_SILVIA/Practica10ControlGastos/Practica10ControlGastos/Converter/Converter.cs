using Humanizer;
using Humanizer.DateTimeHumanizeStrategy;
using Practica10ControlGastos.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica10ControlGastos.Converter
{
    public class Converter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {


            if (value is DateTime date)
            {
                return $"hace {TimeSpan.FromMinutes((DateTime.Now - date).TotalMinutes).Humanize()}";
            }
            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
           throw new NotImplementedException();
        }
    }
}
