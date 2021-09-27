Module Module1

    Sub Main()
        Dim number, n, a, b, num As Integer
        Console.WriteLine("enter the number")
        number = Console.ReadLine()
        num = number
        While number <> 0
            n = number Mod 10
            a = a * 10 + n
            number = number \ 10
        End While
        If a = num Then
            Console.WriteLine("the given number is palindrome")
        Else
            Console.WriteLine("the given number is not palindrome")
        End If
        Console.ReadLine()
    End Sub

End Module
