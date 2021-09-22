using System;
using System.Diagnostics;
using System.Globalization;
using Xamarin.Forms;

namespace SimpleApp.Core.Converter
{
    public class IntToBoolConverter : IValueConverter
    {
        public IntToBoolConverter()
        {
        }

        // ソースからターゲットに値が渡されるたびに、`Convert `メソッドが呼ばれる
        // - value: 変換対象となるdataBindingのソースの値
        // - targetType: dataBindingのターゲットプロパティの型
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("Convert value: " + value + " targetType: " + targetType + " parameter: " + parameter + " culture: " + culture);
            return (int)value != 0;
        }

        // ConvertBackメソッドは`TwoWay`または、`OneWayToSource` Bindingのみ呼び出される。
        // - value: dataBindingのターゲットの値
        // - targetType: dataBindingのソースプロパティの型
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Debug.WriteLine("ConvertBack value: " + value + " targetType: " + targetType + " parameter: " + parameter + " culture: " + culture);
            return (bool)value ? 1 : 0;
        }
    }
}
