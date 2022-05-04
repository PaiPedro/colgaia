Imports System

Module Ex01
    'programa que permita que quando o utilizador digitar a palavra-passe seja igual à sua correspondente.'
    Sub Main()
        Dim password As String
        Console.WriteLine("Defina uma password")
        Verif(password)
    End Sub
    Sub Verif(pass As String)
        Dim palavra_passe As String
        Console.WriteLine("Digite a sua palavra passe.")
        palavra_passe = Console.ReadLine()
        If (palavra_passe = pass) Then
            Console.WriteLine("Utilizador autorizado")
        Else
            Console.WriteLine("Utilizador não autorizado")
        End If
    End Sub
End Module
