Module Module1

    Sub Main()
        Dim a(10), sum, o, e As Integer
        Dim n(10) As String
        n(1) = "st"
        n(2) = "nd"
        n(3) = "rd"
        For i = 4 To 10
            n(i) = "th"
        Next
        sum = 0
        Console.WriteLine("enter 10 numbers")
        For i = 1 To 10
            Console.WriteLine("enter " & i & n(i) & " numbers")
            a(i) = Console.ReadLine
            sum = sum + a(i)
        Next
        For i = 1 To 10
            If a(i) Mod 2 = 0 Then
                e = e + 1
            Else
                o = o + 1
            End If
        Next
        Console.WriteLine("even no.: " & e)
        Console.WriteLine("odd no.: " & o)
        Console.WriteLine("the sum is " & sum)
        Console.ReadKey()
    End Sub

End Module
