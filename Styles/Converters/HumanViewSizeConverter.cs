using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows;

namespace Marathone.Styles.Converters
{
    public class HumanViewSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double totalSize && double.TryParse(parameter as string, out double percentage))
            {
                return new GridLength(totalSize * percentage / 100, GridUnitType.Pixel);
            }
            return new GridLength(0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }   
}