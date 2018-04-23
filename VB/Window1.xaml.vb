Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Data
Imports System.Globalization
Imports System.Windows.Markup
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Mvvm

Namespace FilterCombo
    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    ''' 

    Partial Public Class Window1
        Inherits Window

        Public cars As ObservableCollection(Of Car)
        Public Property items() As List(Of ComboItems)

        Public Sub New()
            InitializeComponent()
            AddHandler Me.Loaded, AddressOf Window_Loaded
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            cars = New ObservableCollection(Of Car)()
            cars.Add(New Car() With {.AvailableColors = "Red", .AvailableColors2 = "Red", .Make = "Make1"})
            cars.Add(New Car() With {.AvailableColors = "Azure", .AvailableColors2 = "Azure", .Make = "Make2"})
            cars.Add(New Car() With {.AvailableColors = "Blue", .AvailableColors2 = "Blue", .Make = "Make1"})
            gridControl1.ItemsSource = cars

            items = New List(Of ComboItems)()

            items.Add(New ComboItems() With {.ItemColors = "Red", .TypeComboItems = "Make1"})
            items.Add(New ComboItems() With {.ItemColors = "Brown", .TypeComboItems = "Make1"})
            items.Add(New ComboItems() With {.ItemColors = "Blue", .TypeComboItems = "Make1"})
            items.Add(New ComboItems() With {.ItemColors = "Violet", .TypeComboItems = "Make2"})
            items.Add(New ComboItems() With {.ItemColors = "Azure", .TypeComboItems = "Make2"})

            Me.DataContext = Me
        End Sub
    End Class

    Public Class ComboItems
        Inherits BindableBase

        Private _TypeComboItems As String
        Private _ItemColors As String
        Public Property ItemColors() As String
            Get
                Return _ItemColors
            End Get
            Set(ByVal value As String)
                SetProperty(_ItemColors, value, Function() ItemColors)
            End Set
        End Property
        Public Property TypeComboItems() As String
            Get
                Return _TypeComboItems
            End Get
            Set(ByVal value As String)
                SetProperty(_TypeComboItems, value, Function() TypeComboItems)
            End Set
        End Property
    End Class

    Public Class Car
        Inherits BindableBase

        Private _Make As String
        Private _AvailableColors2 As String
        Private _AvailableColors As String
        Public Property AvailableColors() As String
            Get
                Return _AvailableColors
            End Get
            Set(ByVal value As String)
                SetProperty(_AvailableColors, value, Function() AvailableColors)
            End Set
        End Property
        Public Property AvailableColors2() As String
            Get
                Return _AvailableColors2
            End Get
            Set(ByVal value As String)
                SetProperty(_AvailableColors2, value, Function() AvailableColors2)
            End Set
        End Property
        Public Property Make() As String
            Get
                Return _Make
            End Get
            Set(ByVal value As String)
                SetProperty(_Make, value, Function() Make)
            End Set
        End Property
    End Class


    Public Class MakeFilterConverter
        Inherits MarkupExtension
        Implements IValueConverter

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Return CriteriaOperator.Parse("[TypeComboItems] == ?", value)
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class FilterConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            If DirectCast(values(2), Boolean) Then
                Return DirectCast(values(0), List(Of ComboItems)).FindAll(Function(f) f.TypeComboItems.Equals(DirectCast(values(1), String)))
            Else
                Return values(0)
            End If
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
