<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653421/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2163)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainViewModel.cs](./CS/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/MainViewModel.vb))
* [Converters.cs](./CS/Converters.cs) (VB: [Converters.vb](./VB/Converters.vb))
<!-- default file list end -->
# How to Populate ComboBoxEdit's ItemsSource Based on Values From Other Cells


GridControl can display lookup editors in column cells. Such editors can work with a shared data source or different sources for each data row. You can customize these sources depending on values in other cells of the same row. Use one of the following techniques:

* The [LookUpEditBase.FilterCriteria](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.FilterCriteria) property

DevExpress lookup editors have the data source filtering functionality. You can dynamically construct a filter depending on values from other cells. To do this, create a custom binding converter class that implements the [IValueConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.ivalueconverter?view=netcore-3.1) interface.

* A [MultiBinding](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.multibinding?view=netcore-3.1) object

An alternative technique is to use the multibinding approach. Specify multiple bindings in a MultiBinding object and create a converter (implementing the [IMultiValueConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.imultivalueconverter?view=netcore-3.1) interface) to produce a final value for the binding target property based on values of those bindings.

See also:
[How to build binding paths within WPF Grid control cells](https://github.com/DevExpress-Examples/how-to-build-binding-paths-in-gridcontrol-cells)
