Module Module1

    Sub Main()
        Dim a, b, c, d, e As Integer
        Console.WriteLine("input 4 numbers")
        a = Console.ReadLine
        b = Console.ReadLine
        c = Console.ReadLine
        d = Console.ReadLine
        e = a
        If b > e Then
            e = b
        ElseIf c > e Then
            e = c
        ElseIf d > e Then
            e = d
        Else
            e = a
        End If
        Console.WriteLine("the greates number is" & e)
        Console.ReadLine()
    End Sub

End Module
