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

Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows

Namespace FilterCombo
    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Partial Public Class App
        Inherits Application

    End Class
End Namespace
