Imports System

Module Ex03
    'ler uma sequência de caracteres alfanuméricos e censurar os numéricos por um asterisco.'
    Sub Main()
        Dim texto As String
        Dim vet() As Char
        Leitura(texto)
        vet = texto.ToCharArray()
        For i = 0 To Len(vet) - 1
            Select Case vet(i)
                Case "0"
                    vet(i) = "*"
                Case "1"
                    vet(i) = "*"
                Case "2"
                    vet(i) = "*"
                Case "3"
                    vet(i) = "*"
                Case "4"
                    vet(i) = "*"
                Case "5"
                    vet(i) = "*"
                Case "6"
                    vet(i) = "*"
                Case "7"
                    vet(i) = "*"
                Case "8"
                    vet(i) = "*"
                Case "9"
                    vet(i) = "*"
            End Select
        Next
        For j = 0 To Len(vet) - 1
            Console.Write(vet(j))
        Next
    End Sub
    Sub Leitura(ByRef texto As String)
        Console.WriteLine("Introduza um texto qualquer: ")
        texto = Console.ReadLine()
    End Sub
End Module
