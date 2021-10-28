' Developer Express Code Central Example:
' How to use a combo box whose choices are different for each cell in the grid
' 
' There are two ways to accomplish this task: via filter criteria and by using a
' multibinding approach. Let me explain theses approaches in detail.
' 
' 1) Filter
' criteria
' The main idea is to dynamically construct a filter by using the
' selected value of the first column in the grid. So, items in the ComboBox editor
' will be filtered automatically according to the filter's value. In this case, it
' is necessary to create a converter (which implements the IValueConverter
' interface) in the code-behind file. 2) Multibinding approach.
' You can also
' resolve this problem by using the multibinding approach. Specify multiple
' bindings in a MultiBinding object and create a converter (which implements the
' IMultiValueConverter interface) to produce a final value for the binding target
' property based on values of those bindings.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2163
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly:AssemblyTitle("FilterCombo")>
<Assembly:AssemblyDescription("")>
<Assembly:AssemblyConfiguration("")>
<Assembly:AssemblyCompany("")>
<Assembly:AssemblyProduct("FilterCombo")>
<Assembly:AssemblyCopyright("Copyright ©  2010")>
<Assembly:AssemblyTrademark("")>
<Assembly:AssemblyCulture("")>
' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly:ComVisible(False)>
'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.
'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]
'(used if a resource is not found in the page, 
' or application resource dictionaries)
'(used if a resource is not found in the page, 
' app, or any theme specific resource dictionaries)
<Assembly:ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)> 'where theme specific resource dictionaries are located
'where the generic resource dictionary is located
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly:AssemblyVersion("1.0.0.0")>
<Assembly:AssemblyFileVersion("1.0.0.0")>
