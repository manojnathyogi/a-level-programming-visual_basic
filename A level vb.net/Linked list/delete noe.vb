Module Module1

    Sub Main()

    End Sub

    Sub 'deletenode(dataitem)
        thisnodeptr = startpointer
        While thisnodeptr <> nullpointer 'while not end of list
            And ist(thisnodeptr).data 'and data item not found

            previousnodeptr -thisnodeptr 'remember this node
            'follow the pointer tto the next node
            thisnodeptr = List(thisnodeptr).pointer
        End While

        If thisnodeptr <> Nullablepointer Then ' node exists in list

                If thisnodeptr = startpointer = startpointer Then ' firstnode to be deleted
                    startpointer = List(startpointer).pointer
                Else
                    List(previousnodeptr).pointer List(thisnodeptr).pointer
                End If
            End If
        List(thisnodeptr).pointer = freelistptr
        freelistptr = thisnodeptr
        Console.ReadKey()

    End Sub
End Module
