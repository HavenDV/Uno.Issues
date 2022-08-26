#nullable enable

using System.Globalization;
using System;
using System.Windows.Data;
using System.Windows.Media;

namespace UpworkPdfGenerator.Apps.Wpf;

[ValueConversion(typeof(System.Drawing.Color), typeof(Color))]
public class SystemDrawingColorToColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not System.Drawing.Color expected)
        {
            throw new InvalidOperationException();
        }

        return Color.FromArgb(expected.A, expected.R, expected.G, expected.B);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not Color expected)
        {
            throw new InvalidOperationException();
        }

        return System.Drawing.Color.FromArgb(expected.A, expected.R, expected.G, expected.B);
    }
}