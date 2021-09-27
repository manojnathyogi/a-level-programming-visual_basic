Module Module1

    Sub Main()
        Dim n As Integer
        Console.WriteLine("enter the number which factorila you want to calculate")
        n = Console.ReadLine
        For i = 1 To n
            If n Mod i = 0 Then
                Console.WriteLine("the factorial of " & n & "is " & i)
            End If
        Next
        Console.ReadLine()

    End Sub

End Module
