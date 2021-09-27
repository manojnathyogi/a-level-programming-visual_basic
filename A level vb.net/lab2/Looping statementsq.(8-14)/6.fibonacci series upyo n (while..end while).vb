Module Module1

    Sub Main()
        Dim a, b, c, n As Integer
        Console.WriteLine("enter the number")
        n = Console.ReadLine
        a = 1
        b = 1
        Console.Write(a & " " & b & " ")
        While n <> 0
            c = a + b
            Console.Write(c & " ")
            a = b
            b = c
            n = n - 1
        End While
        Console.ReadKey()
    End Sub

End Module
