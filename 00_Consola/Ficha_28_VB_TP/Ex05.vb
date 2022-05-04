Imports System

Module Ex05
    Sub Main()
        Dim texto As String
        Dim vet() As Char
        Ler_texto(texto)
        vet = texto.ToCharArray()
        For i = 0 To Len(vet) - 1 Step 2
            vet(i) = UCase(vet(i))
            vet(i + 1) = LCase(vet(i + 1))

        Next
        For i = 0 To Len(vet) - 1
            Console.Write(vet(i))
        Next
    End Sub
    Sub Ler_texto(ByRef texto As String)
        Console.WriteLine("Introduza uma frase: ")
        texto = Console.ReadLine()

    End Sub
End Module
