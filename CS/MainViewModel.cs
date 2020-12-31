using DevExpress.Xpf.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace FilterCombo {
    class MainViewModel : ViewModelBase {

        ObservableCollection<Car> _cars;
        ObservableCollection<ComboItem> _comboItems;

        public MainViewModel() {
            Cars = new ObservableCollection<Car>();

            Cars.Add(new Car() { Color = "Red", FilterType = RowFilterType.Type1 });
            Cars.Add(new Car() { Color = "Azure", FilterType = RowFilterType.Type2 });
            Cars.Add(new Car() { Color = "Blue", FilterType = RowFilterType.Type1 });

            ComboItems = new ObservableCollection<ComboItem>();

            ComboItems.Add(new ComboItem() { Color = "Red", FilterType = RowFilterType.Type1 });
            ComboItems.Add(new ComboItem() { Color = "Brown", FilterType = RowFilterType.Type1 });
            ComboItems.Add(new ComboItem() { Color = "Blue", FilterType = RowFilterType.Type1 });
            ComboItems.Add(new ComboItem() { Color = "Violet", FilterType = RowFilterType.Type2 });
            ComboItems.Add(new ComboItem() { Color = "Azure", FilterType = RowFilterType.Type2 });
        }

        public ObservableCollection<Car> Cars { get => _cars; set => SetProperty(ref _cars, value, () => Cars); }
        public ObservableCollection<ComboItem> ComboItems { get => _comboItems; set => SetProperty(ref _comboItems, value, () => ComboItems); }
    }

    public enum RowFilterType {
        Type1, Type2
    }

    public class ComboItem : BindableBase {
        private string _color;
        private RowFilterType _filterType;

        public string Color {
            get => _color; set => SetProperty(ref _color, value, () => Color);
        }
        public RowFilterType FilterType {
            get => _filterType; set => SetProperty(ref _filterType, value, () => _filterType);
        }
    }

    public class Car : BindableBase {
        private string _color;
        private RowFilterType _filterType;

        public string Color {
            get => _color; set => SetProperty(ref _color, value, () => Color);
        }
        [RefreshProperties(RefreshProperties.All)]
        public RowFilterType FilterType {
            get => _filterType; set => SetProperty(ref _filterType, value, () => FilterType);
        }
    }
}
