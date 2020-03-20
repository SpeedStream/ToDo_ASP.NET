Imports System.ComponentModel.DataAnnotations
Public Class Task
    Private _description As String
    Private _isComplete As String = False
    Private Sub Task()
    End Sub

    Public Sub Task(description As String, category As Category)
        setDetails(description, category)
    End Sub

    Public Property Id As Integer

    <Required(ErrorMessage:="Description is required")>
    Public Property Description As String
        Get
            Return _description
        End Get
        Private Set(value As String)
            _description = value
        End Set
    End Property

    Public Property IsComplete As Boolean
        Get
            Return _isComplete
        End Get
        Private Set(value As Boolean)
            _isComplete = value
        End Set
    End Property

    <Required(ErrorMessage:="Category is required")>
    Public Property Category As Category

    Public Sub setDetails(description As String, category As Category)
        Me.Description = description
        Me.Category = category
    End Sub

    Public Sub MarkComplete()
        IsComplete = True
    End Sub

    Public Sub MarkIncomplete()
        IsComplete = False
    End Sub

End Class
