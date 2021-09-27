Module Module1

    Sub Main()
        Dim a, n, multiple As Integer
        Console.WriteLine("enter the number whose multiplication table you want to know")
        n = Console.ReadLine()
        a = 1
        While a <= 10
            multiple = n * 1
            Console.WriteLine(n & "*" & a & "=" & multiple)
            a = a + 1
        End While
        Console.ReadKey()
    End Sub

End Module
