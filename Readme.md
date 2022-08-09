<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653421/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2163)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Populate ComboBoxEdit's ItemsSource Based on Values from Other Cells

This example demonstrates how to populate a GridControl's in-place ComboBoxEdit with values based on the type of its neighbouring cells.

![image](https://user-images.githubusercontent.com/12169834/183652084-c06f59be-8c23-4a15-be68-a2938158fa28.png)

GridControl can display lookup editors in column cells. You can bind these editors to shared data sources or use a different data source for each data row. Use one of the following approaches to customize these sources:

* The [LookUpEditBase.FilterCriteria](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.FilterCriteria) property

  Our lookup editors allow you to filter their data source. The main idea of this approach is to dynamically construct a filter depending on values from other cells. If you use this approach, you should implement a conversion logic in the scope of a custom binding converter class that implements the [IValueConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.ivalueconverter?view=netcore-3.1) interface.

* A [MultiBinding](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.multibinding?view=netcore-3.1) object

  In this approach, you should specify multiple bindings in a MultiBinding object and create a converter (implementing the [IMultiValueConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.imultivalueconverter?view=netcore-3.1) interface) to produce a final value for the binding target property based on values of those bindings.

<!-- default file list -->
## Files to Look At

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/MainViewModel.vb))
* [Converters.cs](./CS/Converters.cs) (VB: [Converters.vb](./VB/Converters.vb))
<!-- default file list end -->

## More Examples

* [Build Binding Paths Within WPF Grid Control Cells](https://github.com/DevExpress-Examples/how-to-build-binding-paths-in-gridcontrol-cells)
