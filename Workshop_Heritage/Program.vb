Imports System

Module Program
    Sub Main(args As String())

        'Déclare un tableau de 3 employers
        Dim employers(2) As Employer

        'Initialisation du tableau par trois objets type employers
        employers(0) = New Employer("Mezghich", "Med Amine", "Chef projet", 4000)
        employers(1) = New Employer("Luc", "Jean", "Developpeur", 3000)
        employers(2) = New Employer("Dugley", "Julien", "Testeur", 2500)

        For i As Integer = 0 To employers.Length - 1
            Console.WriteLine(employers(i).Infos())
        Next


    End Sub
End Module
