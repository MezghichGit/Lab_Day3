Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer = 10
        Dim y As Integer = 0


        Try
            Dim res As Integer = x \ y
            Console.WriteLine("res = " & res)
        Catch ex As DivideByZeroException
            Console.WriteLine("Exception : " & ex.Message)
        End Try

        Console.WriteLine("Suite du programme")
        Dim voiture As Voiture = Nothing
        Try
            voiture.Avancer()
        Catch ex As Exception
            Console.WriteLine("Exception : Référence Null " & ex.Message)
            Exit Try

        Finally
            Console.WriteLine("Suite du programme 2")
        End Try


    End Sub
End Module
