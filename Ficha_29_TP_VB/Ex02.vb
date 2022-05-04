Imports System

Module Ex02
    Dim Num As Integer
    Sub Main()
        Dim vet() As String
        Dim vet_id() As Integer
        Dim vet_turma() As String
        Dim op, c As Integer
        c = 0
        Console.WriteLine("1–Entrada de Dados")
        Console.WriteLine("2–Listar Alunos dada uma idade")
        Console.WriteLine("3–Listar os Alunos que iniciam o Nome por uma dada Letra")
        Console.WriteLine("4-Listar os Alunos de uma determinada Turma")
        Console.WriteLine("5–Limpar Dados")
        Console.WriteLine("6–Sair")
        Do
            Console.WriteLine("Quantos alunos estão na lista?")
            Num = Console.ReadLine()
            If (Num <= 0 Or Num > 30) Then
                Console.WriteLine("Erro: número inválido." & vbCrLf & "Pressione uma tecla para introduzir um novo valor.")
                Console.ReadKey()
            End If
        Loop Until (Num > 0 And Num <= 30)
        ReDim vet(Num)
        ReDim vet_id(Num)
        ReDim vet_turma(Num)
        Do
            c += 1
            Do
                Console.WriteLine("Digite a opção que quer executar: ")
                op = Console.ReadLine()
                If (op < 1 Or op > 6) Then
                    Console.WriteLine("Erro: opção inválida." & vbCrLf & "Pressione uma tecla para escolher uma opção.")
                    Console.ReadKey()
                End If
            Loop Until (op >= 1 And op <= 6)
            If (op <> 1 And c = 1) Then
                op = 1
            End If
            Select Case op
                Case 1
                    Preencher_dad(vet, vet_id, vet_turma)
                Case 2
                    List_dada_id(vet, vet_id, vet_turma)
                Case 3
                    List_dada_let(vet, vet_id, vet_turma)
                Case 4
                    List_dada_turm(vet, vet_id, vet_turma)
                Case 5
                    Limpar(vet, vet_id, vet_turma)
                Case 6
                    Console.WriteLine("Saindo...")
                    System.Threading.Thread.Sleep(2000)
            End Select
        Loop Until (op = 6)
        Console.WriteLine("Fim")
    End Sub
    Sub Preencher_dad(ByRef vet() As String, ByRef vet_id() As Integer, ByRef vet_turma() As String)
        For i = 0 To Num - 1
            Console.WriteLine("Introduza o nome do {0}º aluno:", i + 1)
            vet(i) = Console.ReadLine()
            Do
                Console.WriteLine("Introduza a idade do {0}º aluno: ", i + 1)
                vet_id(i) = Console.ReadLine()
                If (vet_id(i) <= 0) Then
                    Console.WriteLine("Erro: idade inválida." & vbCrLf & "Pressione uma tecla para introduzir uma nova idade.")
                End If
            Loop Until (vet_id(i) > 0)
            Console.WriteLine("Digite a turma do {0}º aluno: ", i + 1)
            vet_turma(i) = Console.ReadLine()
        Next
    End Sub
    Sub List_dada_id(vet() As String, vet_id() As Integer, vet_turma() As String)
        Dim id As Integer
        Dim c As Integer = 0
        Do
            Console.WriteLine("Introduza a idade que quer procurar: ")
            id = Console.ReadLine()
            If (id <= 0) Then
                Console.WriteLine("Erro: idade inválida." & vbCrLf & "Pressione uma tecla para introduzir uma nova idade.")
            End If
        Loop Until (id > 0)
        For i = 0 To Num - 1
            If (vet_id(i) = id) Then
                c += 1
                Console.WriteLine(vet(i) & " " & id & " " & vet_turma(i))
            End If
        Next
        If (c = 0) Then
            Console.WriteLine("Não econtrada.")
        End If
    End Sub
    Sub List_dada_let(vet() As String, vet_id() As Integer, vet_turma() As String)
        Dim letra As Char
        Dim c As Integer = 0
        Console.WriteLine("Só podem ser digitadas letras minúsculas.")
        Do
            Console.WriteLine("Digite uma letra do alfabeto: ")
            letra = Console.ReadLine()
            If (Asc(letra) < 97 Or Asc(letra) > 122) Then
                Console.WriteLine("Erro: caracter inválido." & vbCrLf & "Pressione uma tecla para introduzir um novo caracter.")
                Console.ReadKey()
            End If
        Loop Until (Asc(letra) >= 97 And Asc(letra) <= 122)
        For i = 0 To Num - 1
            If (LCase(vet(i).First()) = letra) Then
                c += 1
                Console.WriteLine(vet(i) & " " & vet_id(i) & " " & vet_turma(i))
            End If
        Next
        If (c = 0) Then
            Console.WriteLine("Não encontrada.")
        End If
    End Sub
    Sub List_dada_turm(vet() As String, vet_id() As Integer, vet_turma() As String)
        Dim turm As String
        Dim c As Integer = 0
        Console.WriteLine("Digite uma turma: ")
        turm = Console.ReadLine()
        For i = 0 To Num - 1
            If (vet_turma(i) = turm) Then
                c += 1
                Console.WriteLine(vet(i) & " " & vet_id(i) & " " & vet_turma(i))
            End If
        Next
        If (c = 0) Then
            Console.WriteLine("Não encontrada.")
        End If
    End Sub
    Sub Limpar(ByRef vet() As String, ByRef vet_id() As Integer, ByRef vet_turma() As String)
        vet.Clear(vet)
        vet_id.Clear(vet_id)
        vet_turma.Clear(vet_turma)
        Do
            Console.WriteLine("Quantos alunos estão na lista?")
            Num = Console.ReadLine()
            If (Num <= 0 Or Num > 30) Then
                Console.WriteLine("Erro: número inválido." & vbCrLf & "Pressione uma tecla para introduzir um novo valor.")
                Console.ReadKey()
            End If
        Loop Until (Num > 0 And Num <= 30)
        ReDim vet(Num)
        ReDim vet_id(Num)
        ReDim vet_turma(Num)
    End Sub
End Module
