Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace Q521663

    Public Class ViewModel

        Public Sub New()
            Categories = New ObservableCollection(Of Category) From {New Category("Category1", New Page("Page1", New Group("Group1", New Item("Item1"), New Item("Item2"))), New Page("Page2"))}
        End Sub

        Public ReadOnly Property Categories As ObservableCollection(Of Category)
    End Class

    Public Class Category
        Inherits ItemBase

        Public ReadOnly Property Pages As ObservableCollection(Of Page)

        Public Sub New(ByVal Optional name As String = Nothing, ParamArray pages As Page())
            MyBase.New(name)
            Me.Pages = New ObservableCollection(Of Page)(pages)
        End Sub
    End Class

    Public Class Page
        Inherits ItemBase

        Public ReadOnly Property Groups As ObservableCollection(Of Group)

        Public Sub New(ByVal Optional name As String = Nothing, ParamArray groups As Group())
            MyBase.New(name)
            Me.Groups = New ObservableCollection(Of Group)(groups)
        End Sub
    End Class

    Public Class Group
        Inherits ItemBase

        Public ReadOnly Property Items As ObservableCollection(Of Item)

        Public Sub New(ByVal Optional name As String = Nothing, ParamArray items As Item())
            MyBase.New(name)
            Me.Items = New ObservableCollection(Of Item)(items)
        End Sub
    End Class

    Public Class Item
        Inherits ItemBase

        Public Sub New(ByVal Optional name As String = Nothing)
            MyBase.New(name)
        End Sub
    End Class

    Public MustInherit Class ItemBase
        Inherits ViewModelBase

        Public Property Name As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Sub New(ByVal name As String)
            Me.Name = name
        End Sub
    End Class
End Namespace
