Module Module1

    Sub Main()
        Dim n(4), a As Integer
        Console.WriteLine("enter a number")
        For i = 1 To 4
            n(i) = Console.ReadLine()
        Next

        a = n(1)

        For j = 2 To 4

            If n(j) > a Then
                a = n(j)
            End If
        Next
        Console.WriteLine(a)
        Console.ReadKey()

    End Sub
    ]

End Module
