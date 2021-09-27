Module Module1

    Sub Main()
        Dim a, b, sum, product, difference As Integer
        Dim choice As String
        Console.WriteLine("input twonumbers")
        a = Console.ReadLine()
        b = Console.ReadLine()
        Console.WriteLine("enter s for calculating sum")
        Console.WriteLine("enter d for calculating sdifference")
        Console.WriteLine("enter p for calculating product")
        choice = Console.ReadLine
        Select Case choice
            Case "s"
                sum = a + b
                Console.WriteLine("sum of two numbers is" & sum)
            Case "p"
                product = a * b
                Console.WriteLine("product of two numbers is" & product)
            Case "d"
                difference = a - b
                Console.WriteLine("the fiffernce is " & difference)
            Case Else
                Console.WriteLine("wrong choice")
        End Select
        Console.ReadLine()

    End Sub

End Module
