Imports System

Module Ex04
    Sub Main()
        Dim texto As String = " "
        Dim i As Integer = 0
        Ler_texto(texto)
        While (i < texto.Length - 1)
            If (texto.Substring(i, 1) <> " " And texto.Substring(i + 1, 1) <> " ") Then
                texto = texto.Insert(i + 1, " ")
            End If
            i += 1
        End While
        Console.WriteLine(texto)
    End Sub
    Sub Ler_texto(ByRef texto As String)
        Console.WriteLine("Introduza uma frase: ")
        texto = Console.ReadLine()

    End Sub
End Module
