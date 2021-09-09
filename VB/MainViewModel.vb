Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq

Namespace FilterCombo
	Friend Class MainViewModel
		Inherits ViewModelBase

		Private _cars As ObservableCollection(Of Car)
		Private _comboItems As ObservableCollection(Of ComboItem)

		Public Sub New()
			Cars = New ObservableCollection(Of Car)()

			Cars.Add(New Car() With {
				.Color = "Red",
				.FilterType = RowFilterType.Type1
			})
			Cars.Add(New Car() With {
				.Color = "Azure",
				.FilterType = RowFilterType.Type2
			})
			Cars.Add(New Car() With {
				.Color = "Blue",
				.FilterType = RowFilterType.Type1
			})

			ComboItems = New ObservableCollection(Of ComboItem)()

			ComboItems.Add(New ComboItem() With {
				.Color = "Red",
				.FilterType = RowFilterType.Type1
			})
			ComboItems.Add(New ComboItem() With {
				.Color = "Brown",
				.FilterType = RowFilterType.Type1
			})
			ComboItems.Add(New ComboItem() With {
				.Color = "Blue",
				.FilterType = RowFilterType.Type1
			})
			ComboItems.Add(New ComboItem() With {
				.Color = "Violet",
				.FilterType = RowFilterType.Type2
			})
			ComboItems.Add(New ComboItem() With {
				.Color = "Azure",
				.FilterType = RowFilterType.Type2
			})
		End Sub

		Public Property Cars() As ObservableCollection(Of Car)
			Get
				Return _cars
			End Get
			Set(ByVal value As ObservableCollection(Of Car))
				SetProperty(_cars, value, Function() Cars)
			End Set
		End Property
		Public Property ComboItems() As ObservableCollection(Of ComboItem)
			Get
				Return _comboItems
			End Get
			Set(ByVal value As ObservableCollection(Of ComboItem))
				SetProperty(_comboItems, value, Function() ComboItems)
			End Set
		End Property
	End Class

	Public Enum RowFilterType
		Type1
		Type2
	End Enum

	Public Class ComboItem
		Inherits BindableBase

		Private _color As String
		Private _filterType As RowFilterType

		Public Property Color() As String
			Get
				Return _color
			End Get
			Set(ByVal value As String)
				SetProperty(_color, value, Function() Color)
			End Set
		End Property
		Public Property FilterType() As RowFilterType
			Get
				Return _filterType
			End Get
			Set(ByVal value As RowFilterType)
				SetProperty(_filterType, value, Function() _filterType)
			End Set
		End Property
	End Class

	Public Class Car
		Inherits BindableBase

		Private _color As String
		Private _filterType As RowFilterType

		Public Property Color() As String
			Get
				Return _color
			End Get
			Set(ByVal value As String)
				SetProperty(_color, value, Function() Color)
			End Set
		End Property
		<RefreshProperties(RefreshProperties.All)>
		Public Property FilterType() As RowFilterType
			Get
				Return _filterType
			End Get
			Set(ByVal value As RowFilterType)
				SetProperty(_filterType, value, Function() FilterType)
			End Set
		End Property
	End Class
End Namespace
