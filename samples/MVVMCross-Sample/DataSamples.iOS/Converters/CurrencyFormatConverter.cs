using System;
using System.Globalization;
using Intersoft.Crosslight;

namespace DataSamples.Converters
{
    public class CurrencyFormatConverter : IValueConverter
    {
        #region IValueConverter implementation

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.Format(culture, parameter.ToString(), value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }

        #endregion

    }
}

