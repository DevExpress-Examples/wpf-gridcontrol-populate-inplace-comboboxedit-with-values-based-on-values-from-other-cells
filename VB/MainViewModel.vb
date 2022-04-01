Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace FilterCombo

    Public Enum FilterType
        PrimaryColor
        SecondaryColor
    End Enum

    Public Class ComboBoxItem
        Inherits BindableBase

        Public Property Color As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property FilterType As FilterType
            Get
                Return GetValue(Of FilterType)()
            End Get

            Set(ByVal value As FilterType)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class Car
        Inherits BindableBase

        Public Property Color As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property FilterType As FilterType
            Get
                Return GetValue(Of FilterType)()
            End Get

            Set(ByVal value As FilterType)
                SetValue(value)
            End Set
        End Property
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Cars As ObservableCollection(Of Car)
            Get
                Return GetValue(Of ObservableCollection(Of Car))()
            End Get

            Set(ByVal value As ObservableCollection(Of Car))
                SetValue(value)
            End Set
        End Property

        Public Property ComboBoxItems As ObservableCollection(Of ComboBoxItem)
            Get
                Return GetValue(Of ObservableCollection(Of ComboBoxItem))()
            End Get

            Set(ByVal value As ObservableCollection(Of ComboBoxItem))
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Cars = GetCars()
            ComboBoxItems = GetComboBoxItems()
        End Sub

        Private Shared Function GetCars() As ObservableCollection(Of Car)
            Return New ObservableCollection(Of Car) From {New Car() With {.Color = "Yellow", .FilterType = FilterType.PrimaryColor}, New Car() With {.Color = "Green", .FilterType = FilterType.SecondaryColor}}
        End Function

        Private Shared Function GetComboBoxItems() As ObservableCollection(Of ComboBoxItem)
            Return New ObservableCollection(Of ComboBoxItem) From {New ComboBoxItem() With {.Color = "Red", .FilterType = FilterType.PrimaryColor}, New ComboBoxItem() With {.Color = "Yellow", .FilterType = FilterType.PrimaryColor}, New ComboBoxItem() With {.Color = "Blue", .FilterType = FilterType.PrimaryColor}, New ComboBoxItem() With {.Color = "Orange", .FilterType = FilterType.SecondaryColor}, New ComboBoxItem() With {.Color = "Green", .FilterType = FilterType.SecondaryColor}, New ComboBoxItem() With {.Color = "Violet", .FilterType = FilterType.SecondaryColor}}
        End Function
    End Class
End Namespace
