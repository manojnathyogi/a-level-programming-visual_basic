Module Module1

    Sub Main()
        Dim a(3, 3), b(3, 3), c(3, 3) As Integer
        Console.WriteLine(" enter numbers")

        For i = 1 To 3
            For j = 1 To 3
                a(i, j) = Console.ReadLine
                b(i, j) = Console.ReadLine
                c(i, j) = a(i, j) + b(i, j)
            Next
        Next
        Console.WriteLine(" the first matrix A =")
        For i = 1 To 3
            For j = 1 To 3
                Console.Write(" " & a(i, j))
            Next j
            Console.WriteLine()
        Next i

        Console.WriteLine("the second matrix B = ")
        For i = 1 To 3
            For j = 1 To 3
                Console.Write(" " & b(i, j))
            Next j
            Console.WriteLine()
        Next i

        Console.WriteLine("the sum of A and B is C= ")
        For i = 1 To 3
            For j = 1 To 3
                Console.Write(" " & c(i, j))
            Next j
            Console.WriteLine()
        Next i

        Console.ReadKey()
    End Sub

End Module
