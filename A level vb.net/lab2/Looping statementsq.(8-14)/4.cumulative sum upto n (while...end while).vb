Module Module1

    Sub Main()
        Dim n, sum As Integer
        Console.WriteLine("enter a number")
        n = Console.ReadLine
        While n <> 0
            sum = sum + n
            n = n - 1
        End While
        Console.WriteLine("The cumulative sum upto given number = " & sum)
        Console.ReadKey()
    End Sub

End Module
