Module Module1

    Sub Main()

    End Sub
    Function findnode(dataitem) As Integer 'return pointer to node
        currentnodeptr = startpointer ' start at beginning of list 
        While currentnodeptr <> nullpointer ' not end of list 
            And list(currentnodeptr).data <> dataitem 'item not found
            ' follow the pointer to the next node
            curretnnodeptr = List(currentnodeptr).pointer
        End While
        findnode = currentnodeptr ' returns nullpointer if item not found 
        Console.ReadKey()

    End Function
End Module
