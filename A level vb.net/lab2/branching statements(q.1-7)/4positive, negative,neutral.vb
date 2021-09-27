Module Module1

    Sub Main()
        Dim a As Integer
        Console.WriteLine("enter a number")
        a = Console.ReadLine()
        If a > 0 Then
            Console.WriteLine("the number is positive")
        ElseIf a < 0 Then
            Console.WriteLine("the number is negative")
        Else
            Console.WriteLine("the number is neutral")
        End If
        Console.ReadLine()

    End Sub

End Module
