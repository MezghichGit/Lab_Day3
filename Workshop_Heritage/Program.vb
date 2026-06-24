Imports System

Module Program
    Sub Main(args As String())

        'Déclare un tableau de 3 employers
        'Dim employers(2) As Employer

        'Initialisation du tableau par trois objets type employers
        'employers(0) = New Employer("Mezghich", "Med Amine", "Chef projet", 4000)
        'employers(1) = New Employer("Luc", "Jean", "Developpeur", 3000)
        'employers(2) = New Employer("Dugley", "Julien", "Testeur", 2500)

        'For i As Integer = 0 To employers.Length - 1
        'Console.WriteLine(employers(i).Infos())
        'Next

        ' Exemple sur le UpCasting et le DownCasting

        'Dim personne As Personne = New Personne()
        'Dim etudiant As Etudiant = New Etudiant()
        'Try
        'etudiant = personne 'DownCasting KO
        'Personne = etudiant  'UpCasting OK
        'Catch ex As InvalidCastException
        'Console.WriteLine("Problème de conversion : " & ex.Message)
        'End Try
        Try

            Dim p As New Personne(-5)

        Catch ex As AgeInvalideException

            Console.WriteLine("Erreur : " & ex.Message)

        End Try
    End Sub
End Module
