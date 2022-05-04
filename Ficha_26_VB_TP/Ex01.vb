Imports System

Module Ex01
    'Criar uma matriz 5x5 e mostrar determinadas tarefas.'
    Const N = 5
    Sub Main()
        Dim mat(N, N) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim media_5_l As Decimal

        'introdu��o dos valores na matriz.'
        For i = 0 To N - 1
            For j = 0 To N - 1
                Console.WriteLine("Introduza o elemento da {0}� coluna da {1}� linha.", j + 1, i + 1)
                mat(i, j) = Console.ReadLine()
            Next
        Next

        'mostrar os elementos da primeira coluna'
        For i = 0 To N - 1
            Console.WriteLine("{0}� elemeto da 1�coluna = {1}", i + 1, mat(i, 0))
        Next

        'mostrar os elementos da segunda linha.'
        For i = 0 To N - 1
            Console.WriteLine("{0}� elemeto da 2�linha = {1}", i + 1, mat(1, i))
        Next

        'mostrar a soma dos elementos da terceira coluna.'
        Console.WriteLine("Soma dos elementos da 3� coluna = {0}", Soma3colun(mat))

        'Soma da quarta linha menos a soma da segunda coluna.'
        Console.WriteLine("Diferen�a entre os elementos da quarta linha e os elementos da terceira coluna = {0}", Dif4lin_3col(mat))

        'maior e menor n�meros e as suas coordenadas.'
        Dim maior, maior_c, maior_l, menor, menor_c, menor_l As Integer
        maior = mat(0, 0)
        menor = mat(0, 0)
        For i = 0 To N - 1
            For j = 0 To N - 1
                If (mat(i, j) > maior) Then
                    maior = mat(i, j)
                    maior_l = i
                    maior_c = j
                ElseIf (mat(i, j) < menor) Then
                    menor = mat(i, j)
                    menor_l = i
                    menor_c = j
                End If
            Next
        Next
        Console.WriteLine("O maior n�mero da matriz � {0} e encontra-se na posi��o [{1}, {2}].", maior, maior_l, maior_c)
        Console.WriteLine("O menor n�mero da matriz � {0} e encontra-se na posi��o [{1}, {2}].", menor, menor_l, menor_c)

        'm�dia da quinta linha.'
        For i = 0 To N - 1
            media_5_l += mat(4, i)
        Next
        Console.WriteLine("m�dia da quinta linha = {0}.", media_5_l / N)

        'subtra��o entre o maior e o menor.'
        Console.WriteLine("Diferen�a entre o maior e o menor n�mero = {0}", maior - menor)

        'mostrar todos os n�meros da diagonal principal.'
        Console.WriteLine("Elementos da diagonal principal: ")
        For i = 0 To N - 1
            Console.WriteLine(mat(i, i) & " ")
        Next

        'mostrar todos os elementos da diagonal secund�ria.'
        Console.WriteLine(vbCrLf & "Elementos da diagonal secund�ria: ")
        For i = 0 To N - 1
            Console.Write(mat(i, N - 1 - i) & " ")
        Next

        'mostrar os elementos abaixo da diagonal principal.'
        Console.WriteLine(vbCrLf & "Elementos abaixo da diagonal principal: ")
        For i = 1 To N - 1
            For j = 0 To i - 1
                Console.Write(mat(i, j) & " ")
            Next
        Next

        'mostrar os elementos acima da diagonal principal.'
        Console.WriteLine(vbCrLf & "Elementos acima da diagonal principal: ")
        For i = 0 To N - 2
            For j = i + 1 To N - 1
                Console.Write(mat(i, j) & " ")
            Next
        Next

        'mostrar os elementos abaixo da diagonal secund�ria.'
        Console.WriteLine(vbCrLf & "Elementos abaixo da diagonal secund�ria: ")
        For i = 1 To N - 1
            For j = N - 1 To N - i Step -1
                Console.Write(mat(i, j) & " ")
            Next
        Next
        'mostrar os elementos acima da diagonal secund�ria.'
        Console.WriteLine(vbCrLf & "Elementos acima da diagonal secund�ria: ")
        For i = 0 To N - 2
            For j = 0 To N - 1 - i
                Console.Write(mat(i, j) & " ")
            Next
        Next

        'm�dia de todos os n�meros exceto o maior e o menor.'
        Dim media_total As Decimal
        Dim cont As Integer

        For i = 0 To N - 1
            For j = 0 To N - 1
                If (mat(i, j) <> maior And mat(i, j) <> menor) Then
                    media_total += mat(i, j)
                    Cont += 1
                End If
            Next
        Next

        Console.WriteLine(vbCrLf & "m�dia total exceto o maior e o menor = {0}", media_total / cont)


        ' soma, o maior e a m�dia de uma linha escolhida pelo utilizador.'
        Dim lin As Integer
        Do
            Console.WriteLine("Introduza uma linha da matriz (1 a 5): ")
            lin = Console.ReadLine()
            If (lin < 1 Or lin > 5) Then
                Console.WriteLine("Erro: n�mero inv�lido" & vbCrLf & "Pressione uma tecla para introduzir um novo valor")
                Console.ReadKey()
                Console.Clear()
            End If
        Loop Until (lin >= 1 And lin <= 5)
        lin -= 1
        Dad_lin_ut(mat, lin)
    End Sub
    Function Soma3colun(ByVal mat2(,) As Integer)
        Dim i As Integer
        Dim soma As Integer
        For i = 0 To N - 1
            soma += mat2(i, 2)
        Next
        Return soma
    End Function
    Function Dif4lin_3col(ByVal mat2(,) As Integer)
        Dim i As Integer
        Dim soma, soma2 As Decimal
        For i = 0 To N - 1
            soma += mat2(3, i)
            soma2 += mat2(i, 2)
        Next
        Return soma - soma2
    End Function
    Sub Dad_lin_ut(ByVal mat2(,) As Integer, Lin_prod As Integer)
        Dim i As Integer
        Dim mai_n As Integer
        Dim som, media As Decimal

        mai_n = mat2(Lin_prod, 0)
        For i = 0 To N - 1
            If (mat2(Lin_prod, i) > mai_n) Then
                mai_n = mat2(Lin_prod, i)
            End If
            som += mat2(Lin_prod, i)
        Next
        media = som / i
        Console.WriteLine("maior n�mero da {0} linha = {1}", Lin_prod, mai_n)
        Console.WriteLine("soma dos n�meros da {0} linha = {1}", Lin_prod, som)
        Console.WriteLine("m�dia dos n�meros da {0} linha = {1}", Lin_prod, media)
    End Sub
End Module
