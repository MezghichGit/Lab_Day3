Public Class Employer
    Public Sub New(nom As String, prenom As String, poste As String, salaire As String)
        Me.Nom = nom
        Me.Prenom = prenom
        Me.Poste = poste
        Me.Salaire = salaire
    End Sub

    Public Property Nom As String
    Public Property Prenom As String
    Public Property Poste As String
    Public Property Salaire As String

    Public Function Infos() As String
        Return "Nom : " & Nom & " Prenom : " & Prenom & " Poste : " & Poste & " Salaire : " & Salaire
    End Function

End Class
