Module module1
    Sub main()
        Dim a, b As Integer
        Console.WriteLine("enter numbers 2")
        a = Console.ReadLine
        b = Console.ReadLine
        Console.WriteLine("a=" & a & "b=" & b)
        Call pass(a, b)
        Console.WriteLine("a=" & a & "b=" & b)
        Console.ReadLine()
    End Sub

    Sub pass(ByRef a As Integer, ByVal b As Integer)
        a = a + 1
        b = b + 1
        Console.WriteLine("a=" & a & "b=" & b)

    End Sub


End Module