
Module Module1

    Sub Main()
        Dim n(10), a, b, c As Integer
        Console.WriteLine("enter 10 numbers")

        For i = 1 To 10
            n(i) = Console.ReadLine
        Next

        Console.WriteLine("the sets of numbers are:")
        For i = 1 To 10
            Console.Write(n(i))
        Next
        Console.WriteLine("enter the number to be searched")
        a = Console.ReadLine()

        For j = 1 To 10
            If n(j) = a Then
                Console.WriteLine("the number is in " & j & " position")
            End If
        Next


        For j = 1 To 10

            For i = 1 To 10
                If n(j) < n(i) Then
                    b = n(i)
                    n(i) = n(j)
                    n(j) = b
                End If
                For k = 1 To 10
                    Console.Write(n(k) & " ")
                Next
                Console.WriteLine()
            Next
        Next

        For j = 1 To 10
            Console.WriteLine(n(j))
        Next

        Console.ReadKey()
    End Sub

End Module
