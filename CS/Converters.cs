using DevExpress.Data.Filtering;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace FilterCombo {
    public class FilterConverter : MarkupExtension, IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            return CriteriaOperator.Parse("[FilterType] == ?", value);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }

    public class MultiBindingConverter : MarkupExtension, IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            if(values[0] == DependencyProperty.UnsetValue || values[1] == DependencyProperty.UnsetValue)
                return Binding.DoNothing;
            return (bool)values[2]
                ? ((ObservableCollection<ComboBoxItem>)values[0]).Where(item => item.FilterType.Equals((FilterType)values[1])).ToList()
                : values[0];
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
    }
}
