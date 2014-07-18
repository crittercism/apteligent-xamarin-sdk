using System;
using System.Globalization;
using System.IO;
using System.Windows.Media.Imaging;

namespace DataSamples.WinPhone.Converters
{
    public sealed class ByteToImageConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo language)
        {
            byte[] img = value as byte[];

            if (img == null)
                return null;

            using (MemoryStream stream = new MemoryStream(img))
            {
                BitmapSource source = new BitmapImage();
                source.SetSource(stream);

                return source;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo language)
        {
            throw new NotImplementedException();
        }
    }
}
