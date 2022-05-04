Imports System

Module Ex04
    Sub Main()
        Dim nom, palavra, prim_caract As String
        Dim c, c_mai_15, c_A As Integer
        Do
            Console.WriteLine("Digite o {0}º nome: ", c + 1)
            nom = Console.ReadLine()
            If (Len(nom) > 15) Then
                c_mai_15 += 1
            End If
            prim_caract = nom.First()
            If (prim_caract = "A" Or prim_caract = "a") Then
                c_A += 1
            End If
            Console.WriteLine("Para terminar digite a palavra SAIR: ")
            palavra = Console.ReadLine()
            palavra = UCase(palavra)
        Loop Until (c = 20 Or palavra = "SAIR")
        Console.WriteLine("Existem {0} nomes com mais de 15 letras.", c_mai_15)
        Console.WriteLine("Existem {0} nomes que começam com a letra A.", c_A)
    End Sub
End Module
