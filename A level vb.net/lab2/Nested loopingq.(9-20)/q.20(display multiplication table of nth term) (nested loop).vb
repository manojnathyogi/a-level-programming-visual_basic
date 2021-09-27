Module Module1

    Sub Main()
        Dim n, b As Integer
        Console.WriteLine("enter the number up to which you want to know multiplication")
        n = Console.ReadLine()
        For i = 1 To n
            For j = 1 To n
                b = i * j
                Console.Write(b & " ")
            Next j
            Console.WriteLine()
        Next i
        Console.ReadKey()
    End Sub

End Module
