Module Module1

    Sub Main()
        Dim a, b, c As Integer
        Console.WriteLine("enter three number")
        a = Console.ReadLine
        b = Console.ReadLine
        c = Console.ReadLine
        If a > b And a > c Then
            Console.WriteLine("the biggest number is " & a)
        ElseIf b > c And b > a Then
            Console.WriteLine("the biggest number is " & b)
        Else
            Console.WriteLine("the biggest number is " & c)
        End If
        If a < b And a < c Then
            Console.WriteLine("the smallest number is " & a)
        ElseIf b < c And b < a Then
            Console.WriteLine("the smallest number is " & b)
        Else
            Console.WriteLine("the smallest number is " & c)
        End If
        Console.ReadLine()
    End Sub

End Module
