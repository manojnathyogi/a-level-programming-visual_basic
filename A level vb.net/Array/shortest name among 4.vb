Module Module1

    Sub Main()
        Dim name(4), sorry, a As String
        Console.WriteLine("input the names")
        For i = 1 To 4
            name(i) = Console.ReadLine
        Next

        sorry = name(1)

        For i = 2 To 4 Step 1
            If Len(name(i)) < Len(sorry) Then
                sorry = name(i)
            End If
        Next
        Console.WriteLine("the longest name is " & sorry)
        Console.ReadKey()
    End Sub

End Module
