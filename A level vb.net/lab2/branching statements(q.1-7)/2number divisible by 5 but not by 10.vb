
Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("enter a number")
        a = Console.ReadLine
        b = a Mod 5
        c = a Mod 10
        If b = 0 And c <> 0 Then
            Console.WriteLine("the number is divisible by 5 and not divisible by 10")
        Else
            Console.WriteLine("the condition cnnot be satisfied to the given number")
        End If
        Console.ReadLine()
    End Sub

End Module
