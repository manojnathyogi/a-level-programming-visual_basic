Module Module1

    Sub Main()

    End Sub

    Sub insertnode(newitem)
        If freelistptr <> nullpointer Then ' there is space in the array

            ' take node from free list and store data item 
            List(newnodeptr).data = newitem
            freelistptr = List(freelistptr).pointer
            ' find insertion point
            thisnodeptr = startpointer 'start at begining of list 

            While thisnodeptr <> nullpointer ' whilenot end of list
                And List(thisndeptr).pointer 
                Previousnodepointer = thisnodeptr ' remember this node 
                ' follow the pointer to the next node
                thisnodeptr = List(thisnodeptr).pointer


            End While
            If previousnodeptr = startpointer Then 'insert new node at start of ist
                List(newnodeptr).pointer = startpointer
                startpointer = newnodeptr
            Else ' insertnew node between previous and this node

                List(newnodeptr).pointer = List(preciousnodeptr).pointer
                List(previousnodeptr).pointer = newnodeptr



            End If

        End If
        Console.ReadKey()

    End Sub
End Module
