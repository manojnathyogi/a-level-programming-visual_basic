Module Module1

    Sub Main()
        Dim n, a, b, palindrome As Integer
        Console.WriteLine("give a number")
        n = Console.ReadLine
        n = a
        While 
            While n <> 0
                b = n Mod 10
                palindrome = palindrome * 10 + b
                n = n \ 10
                If palindrome = a Then
                    Console.WriteLine("the given umber is palindrome")
                Else
                    Console.WriteLine("the given number is not palindrom")
                End If
            End While
        End While
        Console.ReadKey()
    End Sub

End Module
