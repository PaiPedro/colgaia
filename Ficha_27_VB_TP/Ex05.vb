Imports System

Module Ex05
    Sub Main()
        Dim nom As String
        Leitura(nom)
        Inserir(nom)
        nom = UCase(nom)
        nom = Trocar(nom)
        Console.WriteLine(nom)
    End Sub
    Sub Leitura(ByRef nom As String)
        Console.WriteLine("Introduza um nome: ")
        nom = Console.ReadLine()
    End Sub
    Sub Inserir(ByRef nom As String)
        Dim sobre As String
        Console.WriteLine("Introduza um sobrenome: ")
        sobre = Console.ReadLine()
        sobre = sobre.Insert(0, " ")
        nom = nom.Insert(Len(nom), sobre)
        Console.WriteLine(nom)
    End Sub
    Function Trocar(nom As String) As String
        Dim aux As String
        Dim vet() As String
        vet = nom.Split(" ")
        For i = 0 To (vet.Length - 1) \ 2
            aux = vet(i)
            vet(i) = vet(vet.Length - 1 - i)
            vet(vet.Length - 1 - i) = aux
        Next

        nom = nom.Join(" ", vet)
        Return nom
    End Function
End Module
