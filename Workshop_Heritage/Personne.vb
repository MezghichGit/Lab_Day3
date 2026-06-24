Public Class Personne

    Public Age As Integer

    Public Sub New(age As Integer)

        If age < 0 Then
            Throw New AgeInvalideException()
        End If

        Me.Age = age

    End Sub

End Class