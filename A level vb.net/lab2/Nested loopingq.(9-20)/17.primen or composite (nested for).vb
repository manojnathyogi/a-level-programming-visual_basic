Module Module1

    Sub Main()
        Dim a, b As Integer
        Console.WriteLine("Enter a number")
        a = Console.ReadLine
        For i = 1 To a
            If a Mod i = 0 Then
                b = b + 1
            End If
        Next i
        For j = 1 To 1
                If b = 2 Then
                    Console.WriteLine("the given number is prime")
                Else
                    Console.WriteLine("the given number is composite")
                End If
            Next j

            Console.ReadKey()
    End Sub

End Module
