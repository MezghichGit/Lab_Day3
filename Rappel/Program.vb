Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        Dim cb1 As CompteBancaire = New CompteBancaire("Amine", 100)
        Dim cb2 As CompteBancaire = New CompteBancaire("Mael", 100)

        'cb1.solde = -10000
        cb1.SetSolde(1000)

        Console.WriteLine("Solde de cb1 : " & cb1.GetSolde())
        cb1.TypeCompte = "Nimportre" 'Set
        Console.WriteLine(cb1.TypeCompte) 'Get
    End Sub
End Module
