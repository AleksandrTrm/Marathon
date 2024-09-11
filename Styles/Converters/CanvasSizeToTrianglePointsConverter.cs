using System;
using System.Windows;
using System.Globalization;
using System.Windows.Data;

namespace Marathone.Styles.Converters
{
    public class CanvasSizeToTrianglePointsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double size = (double)value;
            string position = parameter as string;

            if (position == "BottomPoint")
            {
                return new Point(size / 2, size);
            }
            else if (position == "LeftTopPoint")
            {
                return new Point(size / 4, size / 2);
            }
            else if (position == "RightTopPoint")
            {
                return new Point(3 * size / 4, size / 2);
            }

            throw new ArgumentException("Invalid position parameter");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
