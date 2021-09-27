Module Module1

    Sub Main()
        Dim n, a As Integer
        Console.WriteLine("enter a number")
        n = Console.ReadLine()
        If n = 5 Then
            For i = 1 To 5
                a = 1
                For j = 1 To i
                    Console.Write(a & " ")
                    a = a + 1
                Next j
                Console.WriteLine()
            Next i
        End If

        Console.ReadKey()
    End Sub

End Module
