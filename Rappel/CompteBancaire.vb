Public Class CompteBancaire

    Private proprietaire As String
    Private solde As Double

    Private _typeCompte As String
    'Public Property TypeCompte As String 'Une declaration réduite
    Public Property TypeCompte As String 'Une declaration verbose (étendue)
        Get
            Return _typeCompte
        End Get
        Set(value As String)
            If (value <> "Courant" And value <> "Epargne") Then
                Console.WriteLine("Type de compte invalide")
                Exit Property
            End If

            _typeCompte = value
        End Set
    End Property

    'Une methode Getter permet de récupérer la valeur de l'attribut
    Public Function GetSolde() As Double
        Return Me.solde
    End Function

    'Une méthode Setter permet de modifier la valeur de l'attribut
    Public Sub SetSolde(montant As Double)
        If montant < 0 Then
            Console.WriteLine("Montant négatif, Decouvert impossible")
            Exit Sub
        End If
        Me.solde = Me.solde + montant
    End Sub
    'Le constructeur par défaut
    Public Sub New()
        Console.WriteLine("Le constructeur par défaut")
    End Sub

    Public Sub New(prop As String, solde As Double)
        Me.proprietaire = prop
        Me.solde = solde
    End Sub

End Class
