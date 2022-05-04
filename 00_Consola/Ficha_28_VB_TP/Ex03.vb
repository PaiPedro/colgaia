Imports System

Module Ex03
    Sub Main()
        Dim texto As String = " "
        Dim vet() As Char
        Dim vet2() As Boolean
        Dim i As Integer = 1
        Ler_texto(texto)
        vet = texto.ToCharArray()
        ReDim vet2(texto.Length)
        For i = 1 To vet.Length - 1
            If (vet(i - 1) = vet(i)) Then
                vet2(i) = True
            Else
                vet2(i) = False
            End If
        Next
        For i = 1 To vet.Length - 1
            If (vet2(i)) Then
                vet(i) = ""
            End If
        Next
        For i = 0 To vet.Length - 1
            Console.Write(vet(i))
        Next
    End Sub
    Sub Ler_texto(ByRef texto As String)
        Console.WriteLine("Introduza uma frase: ")
        texto = Console.ReadLine()

    End Sub
End Module
