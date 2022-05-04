Imports System

Module Ex02
    Sub Main()
        Dim texto As String = " "
        Dim caract As Char
        Dim pos As Integer
        Ler_texto(texto)
        Console.WriteLine("Digite o caracter a procurar: ")
        caract = Console.ReadLine()
        pos = InStrRev(texto, caract)
        If (pos >= 0) Then
            Console.WriteLine("Última ocorrência encontra-se na posição {0}.", pos)
        End If
    End Sub
    Sub Ler_texto(ByRef texto As String)
        Console.WriteLine("Introduza uma frase: ")
        texto = Console.ReadLine()

    End Sub
End Module
