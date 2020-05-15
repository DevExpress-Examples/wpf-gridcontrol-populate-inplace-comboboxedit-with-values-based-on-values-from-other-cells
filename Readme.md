<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to populate ComboBoxEdit's ItemsSource based on values from other cells


<p>GridControl can display lookup editors in column cells. Such editors can work with a shared data source or different sources for each data row. It is possible to customize these sources further, depending on values in other cells of the same column. Use one of the following approaches to accomplish this task:</p>
<br/>
<p>* The [LookUpEditBase.FilterCriteria](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.FilterCriteria) property</p>
<p>Our lookup editors provide the capability to filter their data source. The main idea of this approach is to dynamically construct a filter depending on values from other cells. It is necessary to implement a conversion logic in the scope of a custom binding converter class that implements the [IValueConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.ivalueconverter?view=netcore-3.1) interface.</p>
<br/>
<p>* A [MultiBinding](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.multibinding?view=netcore-3.1) object</p>
<p>An alternative way to achieve the required result is to use the multibinding approach. Specify multiple bindings in a MultiBinding object and create a converter (implementing the [IMultiValueConverter](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.imultivalueconverter?view=netcore-3.1) interface) to produce a final value for the binding target property based on values of those bindings.</p>
