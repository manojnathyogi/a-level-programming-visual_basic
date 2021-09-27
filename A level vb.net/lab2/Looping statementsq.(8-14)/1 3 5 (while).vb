Module Module1

    Sub Main()
        Dim a, n As Integer
        a = 2
        Console.WriteLine(" enter the number of digits you want to print")
        n = Console.ReadLine()
        Do
            Console.Write(a & ",")
            a = a + 2
            n = n - 1
        Loop Until n <> 0


        Console.ReadKey()
    End Sub

End Module
