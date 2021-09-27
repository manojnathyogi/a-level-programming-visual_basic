Module Module1

    Sub Main()
        Dim name As String
        Dim a As Integer

        a = 10
        Console.WriteLine("enter your name")
        name = Console.ReadLine()

        While a <> 0
            Console.WriteLine(name)
            a = a - 1
        End While
        Console.ReadLine()
    End Sub

End Module
