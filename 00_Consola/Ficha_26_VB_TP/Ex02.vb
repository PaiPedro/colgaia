Imports System

Module Ex02
    'mostrar vários dados de uma turma de 10 alunos.'
    Const N_l = 10
    Const N_c = 7
    Sub Main()
        Dim mat(N_l, N_c) As Decimal
        Dim vet_nom(N_l), vet_dis(N_c) As String
        Dim i, j As Integer

        For i = 0 To N_l - 1
            Console.WriteLine("Introduza o nome do {0}º aluno: ", i + 1)
            vet_nom(i) = Console.ReadLine()
        Next

        vet_dis(0) = "Português"
        vet_dis(1) = "Matemática"
        vet_dis(2) = "Ed. Física"
        vet_dis(3) = "Física e Química"
        vet_dis(4) = "Tec. De Programação"
        vet_dis(5) = "Fun. E Arq. De Computadores"
        vet_dis(6) = "Aplicações Informáticas"
        For k = 0 To N_c - 1
            Console.WriteLine("A {0}ª disciplina é {1}.", k + 1, vet_dis(k))
            For i = 0 To N_l - 1
                For j = 0 To N_c - 1
                    Do
                        Console.WriteLine("Introduza a {0}ª nota do {1}º aluno (valor 1 a 20): ", j + 1, i + 1)
                        mat(i, j) = Console.ReadLine()
                        If (mat(i, j) < 0 Or mat(i, j) > 20) Then
                            Console.WriteLine("Erro: nota inválida" & vbCrLf & "Pressione uma tecla para introduzir uma nova nota.")
                            Console.ReadKey()
                            Console.Clear()
                        End If
                    Loop Until (mat(i, j) >= 0 And mat(i, j) <= 20)
                Next
            Next
        Next

        'mostrar o nome do terceiro aluno.'
        Console.WriteLine("O nome do terceiro aluno é {0}.", vet_nom(2))

        'mostrar as notas de português'
        Console.WriteLine("Notas de português: ")
        For i = 0 To N_c - 1
            Console.Write(mat(0, i) & " ")
        Next

        'mostrar a nota do aluno nº8 a tec. programação.'
        Console.WriteLine(vbCrLf & "A nota do 8º aluno de tec. programação é {0}", mat(7, 4))

        'mostrar a média da turma.'
        Console.WriteLine("A média de curso da turma é {0}", Media_turm(mat))

        'mostrar a média de cada disciplina.'
        Dim med_disc As Decimal
        For i = 0 To N_c - 1
            med_disc = 0
            For j = 0 To N_l - 1
                med_disc += mat(j, i)
            Next
            Console.WriteLine("A disciplina de {0} teve a média {1}.", vet_dis(i), med_disc)
        Next

        'mostrar a média de cada aluno'
        Dim med_alu As Decimal
        Dim m_med As Decimal
        For i = 0 To N_l - 1
            med_alu = 0
            For j = 0 To N_c - 1
                med_alu += mat(i, j)
            Next
            If (med_alu > m_med) Then
                m_med = med_alu
            End If
            Console.WriteLine("A média do aluno {0} teve a média {1}.", vet_nom(i), med_alu)
        Next
        Console.WriteLine("A melhor média é de {0}.", m_med)

        'número de negativas na turma.'
        Dim c_n As Integer
        c_n = 0
        For i = 0 To N_l - 1
            For j = 0 To N_c - 1
                If (mat(i, j) <= 9.4) Then
                    c_n += 1
                End If
            Next
        Next
        Console.WriteLine("Houve {0} negativas na turma.", c_n)

        'disciplina com menos negativas.'
        Dim c_n_d As Integer
        Dim d_m_n As Integer
        For i = 0 To N_l - 1
            For j = 0 To N_c - 1
                If (mat(i, j) <= 9.4) Then
                    c_n_d += 1
                End If
            Next
            If (c_n_d > d_m_n) Then
                d_m_n = c_n_d
                Console.Write(vet_dis(j))
            ElseIf (c_n_d = d_m_n) Then
                Console.Write(" " & vet_dis(j))
            End If
        Next

        'aluno com a melhor nota a português.'
        Dim m_i As Integer
        Dim m_port As Decimal
        Console.WriteLine("Alunos que tiveram a melhor nota a portguês.")
        For i = 0 To N_l - 1
            If (mat(i, 0) > m_port) Then
                m_port = mat(i, 0)
                m_i = i
            End If
            Console.WriteLine(vet_nom(m_i))
        Next


        'os alunos que passariam de ano.'
        Dim c_n_2 As Integer
        For i = 0 To N_l - 1
            c_n_2 = 0
            For j = 0 To N_c - 1
                c_n_2 += 1
            Next
            If (c_n_2 <= 2) Then
                Console.WriteLine("O aluno {0} transitou.", vet_nom(i))
            End If
        Next

        'três melhores alunos da turma.'
        Dim media, m_alu, seg_m_alu, terc_m_alu As Decimal
        Dim m_alu_noms, seg_m_alu_noms, terc_m_alu_noms As String

        For i = 0 To N_l - 1
            For j = 0 To N_c - 1
                media += mat(i, j)
            Next
            ' Calcular a média e guardar num vetor

            ' ordenar o vetor das médias decrescente

            'Percorrer as 3 primeiras do vetor ordenado e ir encontrar o valor da média no vetor das médias
            'e com base na posição encontrada a média ir buscar o nome do aluno e mostrar. Obs: Colocar o valor da
            ' média em zero.





        Next
        Console.WriteLine("alunos da turma com a melhor média - {0}:", m_alu)
        Console.WriteLine(m_alu_noms)
        Console.WriteLine("alunos da turma com a segunda melhor média - {0}:", seg_m_alu)
        Console.WriteLine(seg_m_alu_noms)
        Console.WriteLine("alunos da turma com a terceira melhor média - {0}", terc_m_alu)
        Console.WriteLine(terc_m_alu_noms)

        'Quantos 20s existiram na turma, de quem foram e a que disciplina.'
        Dim c As Integer

        For i = 0 To N_l - 1
            c = 0
            Console.WriteLine("O aluno {0}: ", vet_nom(i))
            For j = 0 To N_c - 1
                If (mat(i, j) = 20) Then
                    c += 1
                    Console.WriteLine("20 a {0}", vet_dis(j))
                End If
            Next
            If (c = 0) Then
                Console.WriteLine("nenhum 20.")
            End If
        Next
    End Sub
    Function Media_turm(ByRef mat2(,) As Decimal)
        Dim i, j As Integer
        Dim media As Decimal

        For i = 0 To N_l - 1
            For j = 0 To N_c - 1
                media += mat2(i, j)
            Next
        Next
        media /= (N_c * N_l)
        Return media
    End Function
End Module
