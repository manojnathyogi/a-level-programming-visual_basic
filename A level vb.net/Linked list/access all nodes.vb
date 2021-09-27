Module Module1

    Sub Main()

    End Sub
    Sub outputallnode()
        Currentnodeptr = startpointer 'start at beginning of list
        While currentnodeptr = startpointer 'while not end of list
            Console.WriteLine(List(currentnodeptr).data)
            'follow the pointer to the next node
            currentnodeptr = List(currentnodeptr).pointer
        End While
        Console.ReadKey()

    End Sub
End Module
