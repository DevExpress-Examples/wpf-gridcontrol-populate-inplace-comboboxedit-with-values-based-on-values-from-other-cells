using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace FilterCombo {
    public enum FilterType {
        PrimaryColor, SecondaryColor
    }

    public class ComboBoxItem : BindableBase {
        public string Color {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public FilterType FilterType {
            get { return GetValue<FilterType>(); }
            set { SetValue(value); }
        }
    }

    public class Car : BindableBase {
        public string Color {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public FilterType FilterType {
            get { return GetValue<FilterType>(); }
            set { SetValue(value); }
        }
    }

    public class MainViewModel : ViewModelBase {
        public ObservableCollection<Car> Cars {
            get { return GetValue<ObservableCollection<Car>>(); }
            set { SetValue(value); }
        }
        public ObservableCollection<ComboBoxItem> ComboBoxItems {
            get { return GetValue<ObservableCollection<ComboBoxItem>>(); }
            set { SetValue(value); }
        }

        public MainViewModel() {
            Cars = GetCars();
            ComboBoxItems = GetComboBoxItems();
        }

        static ObservableCollection<Car> GetCars() {
            return new ObservableCollection<Car> {
                new Car() { Color = "Yellow", FilterType = FilterType.PrimaryColor },
                new Car() { Color = "Green", FilterType = FilterType.SecondaryColor },
            };
        }
        static ObservableCollection<ComboBoxItem> GetComboBoxItems() {
            return new ObservableCollection<ComboBoxItem> {
                new ComboBoxItem() { Color = "Red", FilterType = FilterType.PrimaryColor },
                new ComboBoxItem() { Color = "Yellow", FilterType = FilterType.PrimaryColor },
                new ComboBoxItem() { Color = "Blue", FilterType = FilterType.PrimaryColor },
                new ComboBoxItem() { Color = "Orange", FilterType = FilterType.SecondaryColor },
                new ComboBoxItem() { Color = "Green", FilterType = FilterType.SecondaryColor },
                new ComboBoxItem() { Color = "Violet", FilterType = FilterType.SecondaryColor },
            };
        }
    }
}
