Module Module1

    Sub Main()
        Dim e(2, 2, 2) As Integer

        Console.WriteLine("enter your number")
        For l = 1 To 2
            For m = 1 To 2
                For n = 1 To 2
                    e(l, m, n) = Console.ReadLine
                Next
            Next
        Next

        Console.WriteLine("the numbers are")
        For l = 1 To 2
            For m = 1 To 2
                For n = 1 To 2
                    Console.WriteLine(e(l, m, n))
                Next
            Next
        Next
        Console.ReadKey()

    End Sub

End Module
