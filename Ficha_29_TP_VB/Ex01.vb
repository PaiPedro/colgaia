Imports System

Module Ex01
    Const N = 10
    Sub Main()
        Dim vet(N) As Decimal
        Dim op, c As Integer
        c = 0
        Do
            c += 1
            Do
                Console.WriteLine("Digite a opção que quer executar: ")
                op = Console.ReadLine()
                If (op < 1 Or op > 5) Then
                    Console.WriteLine("Erro: opção não encontrada." & vbCrLf & "Pressione uma tecla para introduzir uma nova opção.")
                End If
            Loop Until (op >= 1 And op <= 5)
            If (op <> 1 And c = 0) Then
                op = 1
            End If
            Select Case op
                Case 1
                    Leitura(vet)
                Case 2
                    Mostrar(vet)
                Case 3
                    Inverter(vet)
                Case 4
                    Media(vet)
                Case 5
                    Console.WriteLine("Saindo...")
                    System.Threading.Thread.Sleep(2000)
            End Select
        Loop Until (op = 5)
        Console.WriteLine("Fim")
    End Sub
    Sub Leitura(ByRef vet() As Decimal)
        For i = 0 To N - 1
            Console.WriteLine("Digite o {0} número: ", i + 1)
            vet(i) = Console.ReadLine()
        Next
    End Sub
    Sub Mostrar(vet() As Decimal)
        For i = 0 To N - 1
            Console.WriteLine(vet(i))
        Next
    End Sub
    Sub Inverter(ByRef vet() As Decimal)
        Dim aux As Decimal
        For i = 0 To (N - 1) \ 2
            aux = vet(i)
            vet(i) = vet(N - 1 - i)
            vet(N - 1 - i) = aux
        Next
    End Sub
    Sub Media(vet() As Decimal)
        Dim media As Decimal
        For i = 0 To N - 1
            media += vet(i)
        Next
        Console.WriteLine("A média dos dez números é de {0}.", media)
    End Sub

End Module
