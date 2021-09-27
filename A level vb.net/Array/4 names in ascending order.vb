Module Module1console.read


    Sub Main()
        Dim name(4), sorry, a As String
        Console.WriteLine("input the names")
        For i = 1 To 4
            name(i) = Console.ReadLine
        Next

        sorry = name(1)

        For i = 1 To 4 Step 1
            a = Left(name(i), 1)
            If length(name(i)) < length(sorry) Then
                sorry = name(i)
            End If
        Next
        console.writeline("the longest name is " & sorry)
        console.readkey()
    End Sub

End Module
