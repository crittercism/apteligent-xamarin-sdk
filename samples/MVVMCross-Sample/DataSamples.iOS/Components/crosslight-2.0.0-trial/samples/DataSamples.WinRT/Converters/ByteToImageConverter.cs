using System;
using Windows.UI.Xaml.Data;

namespace DataSamples.WinRT
{
    public sealed class ByteToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            byte[] img = value as byte[];

            if (img == null)
                return null;

            return img.AsBitmapImageAsync().Result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
