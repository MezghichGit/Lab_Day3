Public Class AgeInvalideException
    Inherits Exception

    Public Sub New()
        MyBase.New("L'âge doit être supérieur ou égal à 0.")
    End Sub

    Public Sub New(message As String)
        MyBase.New(message)
    End Sub

End Class
