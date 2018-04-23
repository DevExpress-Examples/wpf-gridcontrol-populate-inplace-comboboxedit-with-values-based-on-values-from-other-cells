using System;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Markup;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Mvvm;

namespace FilterCombo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 

    public partial class Window1 : Window
    {

        public ObservableCollection<Car> cars;
        public List<ComboItems> items { get; set; }

        public Window1()
        {
            InitializeComponent();
            this.Loaded += Window_Loaded;
        }

        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cars = new ObservableCollection<Car>();
            cars.Add(new Car() { AvailableColors = "Red", AvailableColors2 = "Red", Make = "Make1" });
            cars.Add(new Car() { AvailableColors = "Azure", AvailableColors2 = "Azure", Make = "Make2" });
            cars.Add(new Car() { AvailableColors = "Blue", AvailableColors2 = "Blue", Make = "Make1" });
            gridControl1.ItemsSource = cars;

            items = new List<ComboItems>();

            items.Add(new ComboItems() { ItemColors = "Red", TypeComboItems = "Make1" });
            items.Add(new ComboItems() { ItemColors = "Brown", TypeComboItems = "Make1" });
            items.Add(new ComboItems() { ItemColors = "Blue", TypeComboItems = "Make1" });
            items.Add(new ComboItems() { ItemColors = "Violet", TypeComboItems = "Make2" });
            items.Add(new ComboItems() { ItemColors = "Azure", TypeComboItems = "Make2" });

            this.DataContext = this;
        }
    }

    public class ComboItems : BindableBase
    {
        private string _TypeComboItems;
        private string _ItemColors;
        public string ItemColors
        {
            get
            {
                return _ItemColors;
            }
            set
            {
                SetProperty(ref _ItemColors, value, () => ItemColors);
            }
        }
        public string TypeComboItems
        {
            get
            {
                return _TypeComboItems;
            }
            set
            {
                SetProperty(ref _TypeComboItems, value, () => TypeComboItems);
            }
        }
    }

    public class Car : BindableBase
    {
        private string _Make;
        private string _AvailableColors2;
        private string _AvailableColors;
        public string AvailableColors
        {
            get
            {
                return _AvailableColors;
            }
            set
            {
                SetProperty(ref _AvailableColors, value, () => AvailableColors);
            }
        }
        public string AvailableColors2
        {
            get
            {
                return _AvailableColors2;
            }
            set
            {
                SetProperty(ref _AvailableColors2, value, () => AvailableColors2);
            }
        }
        public string Make
        {
            get
            {
                return _Make;
            }
            set
            {
                SetProperty(ref _Make, value, () => Make);
            }
        }
    }


    public class MakeFilterConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return CriteriaOperator.Parse("[TypeComboItems] == ?", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class FilterConverter : MarkupExtension, IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)values[2])
                return ((List<ComboItems>)values[0]).FindAll(f => f.TypeComboItems.Equals((string)values[1]));
            else return values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
