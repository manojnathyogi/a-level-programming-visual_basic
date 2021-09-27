Module Module1

    Sub Main()
        Dim n, product As Integer
        Console.WriteLine("enter th number which multiplication table you want to print")
        n = Console.ReadLine()
        For i = 1 To 10
            product = n * i
            Console.WriteLine(n & "*" & i & "=" & product)

        Next
        Console.ReadKey()
    End Sub

End Module
