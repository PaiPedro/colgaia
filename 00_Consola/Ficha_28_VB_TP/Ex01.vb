Imports System

Module Ex01
    Sub Main()
        Const N = 3
        Dim vet(N) As String
        Dim maior, frase As String
        Dim c_vog, m_vog, nvog, mcaract As Integer
        Dim caract As Char

        For i = 0 To N - 1
            Console.WriteLine("Digite a {0}ª frase: ", i + 1)
            vet(i) = Console.ReadLine()
        Next
        If (vet(0) = vet(1) And vet(0) = vet(2)) Then
            Console.WriteLine("Todas as frases são iguais.")
        ElseIf (vet(0) = vet(1)) Then
            Console.WriteLine("A 1ª frase é igual à 2ª frase.")
        ElseIf (vet(1) = vet(2)) Then
            Console.WriteLine("A 2ª frase é igual à 3ª frase.")
        ElseIf (vet(0) = vet(2)) Then
            Console.WriteLine("A 1ª frase é igual à 3ª frase.")
        End If
        maior = Len(vet(0))

        For i = 0 To N - 1
            If (Len(vet(i)) > maior) Then
                maior = Len(vet(i))
                mcaract = i
            ElseIf (Len(vet(i)) = maior) Then
                mcaract &= i
            End If
        Next
        For i = 0 To N - 1
            c_vog = 0
            frase = LCase(vet(i))
            For j = 0 To Len(frase) - 1
                caract = frase.Substring(j, 1)
                Select Case caract
                    Case "a"
                        c_vog += 1
                    Case "e"
                        c_vog += 1
                    Case "i"
                        c_vog += 1
                    Case "o"
                        c_vog += 1
                    Case "u"
                        c_vog += 1
                End Select
            Next
            If (c_vog > m_vog) Then
                m_vog = c_vog
                nvog = i

            ElseIf (c_vog = m_vog) Then
                nvog &= i
            End If

        Next
        Console.WriteLine("A {0}ª frase é a que tem maior número de caracteres.", mcaract + 1)
        Console.WriteLine("A {0}ª frase é a que tem maior número de vogais.", nvog + 1)
    End Sub
End Module
