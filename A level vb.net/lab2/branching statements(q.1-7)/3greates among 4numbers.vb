Module Module1

    Sub Main()
        Dim a(4) As Array
        Dim b As Integer

        Console.WriteLine("input 4 numbers")
        For i = 1 To 4
            Console.WriteLine("input 4 numbers")
            a(i) = Console.ReadLine()
        Next

        b = a(1)

        For j = 2 To 4
            If a(j) > b Then b = a(j)
        Next
        Console.WriteLine("the biggest number is " & b)
    End Sub

End Module
