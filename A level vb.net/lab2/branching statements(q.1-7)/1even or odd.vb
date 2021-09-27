Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("enter the number")
        a = Console.ReadLine()

        b = a Mod 2
        If b = 0 Then
            Console.WriteLine("the number is even")
        Else
            Console.WriteLine("the number is odd")
        End If
        Console.ReadKey()
    End Sub

End Module
