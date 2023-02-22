Imports DevExpress.Xpf.Core
Imports System.Collections.ObjectModel

Namespace DXGridSample

    Public Partial Class MainWindow
        Inherits ThemedWindow

        Public Sub New()
            Me.InitializeComponent()
            Dim items = New ObservableCollection(Of Item)()
            For i As Integer = 0 To 100 - 1
                items.Add(New Item(i))
            Next

            Me.grid.ItemsSource = items
        End Sub
    End Class

    Public Class Item

        Public Sub New(ByVal i As Integer)
            Value1 = i
            Value2 = i
        End Sub

        Public Property Value1 As Decimal

        Public Property Value2 As Decimal
    End Class
End Namespace
