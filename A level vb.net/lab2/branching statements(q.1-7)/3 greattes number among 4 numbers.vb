Module Module1

    Sub Main()
        Dim a, b, c, d, e, f As Integer

        Console.WriteLine("enter four numbers")
        a = Console.ReadLine()
        b = Console.ReadLine()
        c = Console.ReadLine()
        d = Console.ReadLine()
        e = a
        If b > e Then
            e = b
        End If
        If c > e Then
            e = c
        End If
        If d > e Then
            e = d
        End If

        f = a
        If b < f Then
            f = b
        End If
        If c < f Then
            f = c
        End If
        If d < f Then
            f = d
        End If

        Console.WriteLine("the greatest nummber= " & e & " And the smallest number = " & f)
        Console.ReadKey()

    End Sub

End Module
