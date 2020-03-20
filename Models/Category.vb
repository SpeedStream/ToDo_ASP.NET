Imports System.ComponentModel.DataAnnotations
Public Class Category
    Private Sub Category()
    End Sub

    Public Property Id As Integer

    <Required(ErrorMessage:="Category is required")>
    Public Property Name As String

    Public Sub Category(name As String)
        SetName(name)
    End Sub

    Public Sub SetName(NameVal As String)
        Name = Name
    End Sub

End Class
