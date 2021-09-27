Module Module1

    Sub Main()
        Dim a, b, n As Integer
        Console.WriteLine("enter the number(n) of terms you want to print")
        n = Console.ReadLine()
        a = 1
        For i = 1 To n
            Console.Write(a & " ")
            a = a + 2
            b = b + 1

            If b = n Then
                Continue For
            End If

        Next i
        Console.ReadLine()
    End Sub

End Module
