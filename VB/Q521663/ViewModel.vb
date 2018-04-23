Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace Q521663
	Public Class ViewModel
		Public Sub New()
			Dim items As New ObservableCollection(Of ItemBase)()
			items.Add(New ItemBase() With {.Name = "Item1"})
			items.Add(New ItemBase() With {.Name = "Item2"})

			Dim groups As New ObservableCollection(Of Group)()
			groups.Add(New Group() With {.Name = "Group1", .Items = items})

			Dim pages As New ObservableCollection(Of Page)()
			pages.Add(New Page() With {.Name = "Page1", .Groups = groups})
			pages.Add(New Page() With {.Name = "Page2"})

			Categories = New ObservableCollection(Of Category)()
			Categories.Add(New Category() With {.Name = "Category1", .Pages = pages})

		End Sub
		Private privateCategories As ObservableCollection(Of Category)
		Public Property Categories() As ObservableCollection(Of Category)
			Get
				Return privateCategories
			End Get
			Set(ByVal value As ObservableCollection(Of Category))
				privateCategories = value
			End Set
		End Property
	End Class
	Public Class Category
		Inherits ItemBase
		Private privatePages As ObservableCollection(Of Page)
		Public Property Pages() As ObservableCollection(Of Page)
			Get
				Return privatePages
			End Get
			Set(ByVal value As ObservableCollection(Of Page))
				privatePages = value
			End Set
		End Property
	End Class
	Public Class Page
		Inherits ItemBase
		Private privateGroups As ObservableCollection(Of Group)
		Public Property Groups() As ObservableCollection(Of Group)
			Get
				Return privateGroups
			End Get
			Set(ByVal value As ObservableCollection(Of Group))
				privateGroups = value
			End Set
		End Property
	End Class
	Public Class Group
		Inherits ItemBase
		Private privateItems As ObservableCollection(Of ItemBase)
		Public Property Items() As ObservableCollection(Of ItemBase)
			Get
				Return privateItems
			End Get
			Set(ByVal value As ObservableCollection(Of ItemBase))
				privateItems = value
			End Set
		End Property
	End Class
	Public Class ItemBase
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class
End Namespace
