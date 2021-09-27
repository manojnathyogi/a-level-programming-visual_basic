Module Module1

    Sub Main()
        Dim a(3, 3), b(3, 3), c(3, 3) As Integer
        For i = 1 To 3
            For j = 1 To 3
                a(i, j) = Console.ReadLine()
                b(i, j) = Console.ReadLine()
                c(i, j) = a(i, j) + b(i, j)
            Next j
        Next i
        Console.WriteLine("The Matrix A =")
        For i = 1 To 3
            For j = 1 To 3
                Console.Write(" " & a(i, j))

            Next
            Console.WriteLine()

        Next
        Console.WriteLine("The Matrix B =")

        For i = 1 To 3
            For j = 1 To 3
                Console.Write(" " & b(i, j))

            Next
            Console.WriteLine()
        Next


        Console.WriteLine("The Matrix C i.e the sum of A and B =")

        For i = 1 To 3
            For j = 1 To 3
                c(i, j) = a(i, j) + b(i, j)
                Console.Write(" " & c(i, j))


            Next
            Console.WriteLine()

        Next
        Console.ReadKey()

    End Sub

End Module
