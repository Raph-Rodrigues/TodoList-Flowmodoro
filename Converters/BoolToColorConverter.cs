using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace TodoList_Flowmodoro.Converters;

public class BoolToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? Colors.Gray : Colors.Black; // Ou outra cor de sua preferência
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException(); // Converter de volta não é necessário neste caso
    }
}
