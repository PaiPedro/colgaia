Imports System

Module Ex02
    'introduzir uma palavra com no mínimo 8 caracteres e mostrar os 4 primeiros e os 4 últimos.'
    Sub Main()
        Dim nom As String
        Dim quad_prim As String
        Dim quad_final As String
        Do
            Console.WriteLine("Introduza uma palavra com no mínimo 8 caracteres: ")
            nom = Console.ReadLine()
            If (Len(nom) < 8) Then
                Console.WriteLine("Erro: comprimento inválido" & vbCrLf & "Pressione uma tecla para introduzir uma nova palavra.")
                Console.ReadKey()
                Console.Clear()
            End If
        Loop Until (Len(nom) >= 8)

        quad_prim = nom.Substring(0, 4)
        quad_final = nom.Substring(Len(nom) - 4)
        Console.WriteLine("Quatro primeiros caracteres: {0}", quad_prim)
        Console.WriteLine("Quatro caracteres finais: {0}", quad_final)
    End Sub

End Module
