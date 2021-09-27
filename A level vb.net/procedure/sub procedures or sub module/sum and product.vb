Module Module1

    Sub main()
        Dim addition As Integer
        addition = join()
        console.writeline("from function procedure)the sum is " & addition)
        Call sum()
        Call product()

    End Sub

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
        Console.WriteLine("(from sub procedure)the sum is " & add)
    End Sub

    Sub product()
        Dim a, b, product As Single
        Console.WriteLine("enter two numbers")
        a = Console.ReadLine
        b = Console.ReadLine
        product = a * b
        Console.WriteLine("(from sub procedure)the product is " & product)
        Console.ReadKey()
    End Sub


End Module
