Module Module1
    Private Const V As Integer = 5

    Sub Main()
        Dim a, c As Integer, d(1 To 10) As Integer
        Dim e() As Integer = {1, 2, 3, 4, 5}
        Dim longArray() As Long = {0, 1, 2, 3}
        a = 1
        c = 3
        For k = 1 To 5
            Console.WriteLine(e(k))
        Next
        For i = 1 To a
            a = a - 1
            c = c + 1
            Console.WriteLine(a & i & c)
        Next
        For j = 1 To 10
            Console.WriteLine("enter a number")
            d(j) = Console.ReadLine
        Next
        Console.WriteLine(" numbers are ")
        For k = 1 To 12
            Console.WriteLine(d(k))
        Next
        Console.ReadKey()
    End Sub

End Module
