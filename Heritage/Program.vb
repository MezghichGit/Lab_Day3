Imports System

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")
        'Dim animal As Animal = New Animal()
        'Animal.espece = "a"
        'Dim poisson As Poisson = New Poisson()
        'P'oisson.espece = "Dorade
        '
        Dim noms(2) As String
        noms(0) = "Amine"
        noms(1) = "Mael"
        noms(2) = "Pascal"

        For i As Integer = 0 To noms.Length - 1
            Console.WriteLine("Element n°" & i)
            Console.WriteLine(noms(i))
        Next

        Dim oiseaux(2) As Oiseau
        oiseaux(0) = New Oiseau()
        oiseaux(1) = New Oiseau()
        oiseaux(2) = New Oiseau()

        For i As Integer = 0 To oiseaux.Length - 1
            Console.WriteLine("Element n°" & i)
            oiseaux(i).SeDeplacer()
        Next
    End Sub
End Module
