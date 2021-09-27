Module Module1

    Sub Main()
        Dim a, b, c, n As Integer
        a = 1
        b = 1
        Console.WriteLine("enter the number of digits you want to print in fibonacci series")
        n = Console.ReadLine()
        n = n - 2
        Console.Write(a & "," & b & ", ")
        While n <> 0
            c = a + b
            Console.Write(c & ",")
            a = b
            b = c
            n = n - 1
        End While
        Console.ReadLine()

    End Sub

End Module
