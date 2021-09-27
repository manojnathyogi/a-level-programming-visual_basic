Module Module1

    Sub Main()
        Dim n As Integer
        For i = 1 To 10
            For j = 1 To i
                If i Mod j = 0 Then
                    n = n + 1
                End If
            Next j
            If n = 2 Then
                Console.Write(i & " ")
            End If
        Next i
        Console.ReadKey()
    End Sub

End Module
