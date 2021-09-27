Module Module1

    Function join() As Integer
        Dim a, b, add As Integer
        Console.WriteLine("enter two numbers")
        a = Console.ReadLine
        b = Console.ReadLine
        add = a + b
        join = add
    End Function
    Sub sum()
        Dim a, b, add As Integer
        Console.WriteLine("enter two numbers")
        a = Console.ReadLine
        b = Console.ReadLine
        add = a + b
        Console.WriteLine(add)
    End Sub

    Sub product()
        Dim a, b, product As Single
        Console.WriteLine("enter two numbers")
        a = Console.ReadLine
        b = Console.ReadLine
        product = a * b
        Console.WriteLine(product)
        Console.ReadKey()
    End Sub

    Sub main()
        Dim total_sum As Integer
        Call product()
        Call sum()
        total_sum = join()
        Console.WriteLine("sum is" & total_sum)
        Console.ReadKey()
    End Sub

End Module
