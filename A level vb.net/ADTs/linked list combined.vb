Module Module1
    'null ponter should be set to -1 if using arrat element with index 0 
    Const nullpointer As Integer = 0
    ' Declare record type to store data and pointer
    Dim startpointer As Integer
    Dim freelistptr As Integer
    Dim list(7) As listnode
    Dim newitem, dataitem As String

    Structure listnode
        Dim data As String
        Dim pointer As Integer
    End Structure

    Sub main()
        Call initialiselist()

        For i = 1 To 6
            Console.WriteLine("enter a new item")
            newitem = Console.ReadLine
            Call insertnode(newitem)
        Next
        Call outputallnode()

        For i = 1 To 2
            Console.WriteLine("enter a data item to be deleted")
            dataitem = Console.ReadLine
            Call deletenode(dataitem)
        Next
        Call outputallnode()

        Console.WriteLine("thank you")
        Console.ReadKey()


    End Sub

    Sub initialiselist()
        startpointer = nullpointer ' set start pointer
        freelistptr = 1 'set starting position of free list
        For index = 1 To 6
            list(index).pointer = index + 1
        Next
        list(7).pointer = nullpointer 'last node of free list 

    End Sub


    Sub insertnode(newitem)
        Dim newnodeptr, thisnodeptr, previousnodeptr As Integer
        If freelistptr <> nullpointer Then ' there is space in the array
            ' take node from free list and store data item 
            newnodeptr = freelistptr
            list(newnodeptr).data = newitem
            freelistptr = list(freelistptr).pointer
            ' find insertion point
            thisnodeptr = startpointer 'start at begining of list 

            While thisnodeptr <> nullpointer And list(thisnodeptr).data < newitem ' while not end of list
                previousnodeptr = thisnodeptr ' remember this node 
                ' follow the pointer to the next node
                thisnodeptr = list(thisnodeptr).pointer
            End While
            If previousnodeptr = startpointer Then 'insert new node at start of ist
                list(newnodeptr).pointer = startpointer
                startpointer = newnodeptr
            Else ' insertnew node between previous and this node
                list(newnodeptr).pointer = list(previousnodeptr).pointer
                list(previousnodeptr).pointer = newnodeptr
            End If

        End If

    End Sub
    Sub deletenode(dataitem)
        Dim thisnodeptr, previousnodeptr As Integer
        thisnodeptr = startpointer
        While thisnodeptr <> nullpointer And list(thisnodeptr).data <> dataitem 'while not end of list and data item not found          
            previousnodeptr = thisnodeptr 'remember this node
            'follow the pointer tto the next node
            thisnodeptr = list(thisnodeptr).pointer
        End While
        If thisnodeptr <> nullpointer Then ' node exists in list

            If thisnodeptr = startpointer Then ' firstnode to be deleted
                startpointer = list(startpointer).pointer
            Else
                list(previousnodeptr).pointer = list(thisnodeptr).pointer
            End If
            list(thisnodeptr).pointer = freelistptr
            freelistptr = thisnodeptr
        End If
    End Sub

    Sub outputallnode()
        Dim currentnodeptr As Integer
        currentnodeptr = startpointer 'start at beginning of list
        Console.WriteLine(" data        " & "pointer     ")
        While currentnodeptr <> nullpointer 'while not end of list
            Console.WriteLine(list(currentnodeptr).data & "         " & list(currentnodeptr).pointer)
            'follow the pointer to the next node
            currentnodeptr = list(currentnodeptr).pointer
        End While
    End Sub

    Sub extra()
        Dim choice As String
        Dim validity As Boolean
        Dim newitem As String
        Dim dataitem As String
        choice = "c"
        While choice <> "e"
            Console.WriteLine("press c to initialise linked list")
            Console.WriteLine("press p to put data linked list")
            Console.WriteLine("press i to insert node in linked list")
            Console.WriteLine("press d to delete item from linked list")
            Console.WriteLine("press o to output linked list")
            Console.WriteLine("press e only If you have completed initialise, insert, delete , output and If your result is obtained")
            Do
                choice = Console.ReadLine
                If LCase(choice) = "c" Or LCase(choice) = "d" Or LCase(choice) = "i" Or LCase(choice) = "o" Then
                    validity = True
                End If
            Loop Until validity = False
            Select Case choice
                Case LCase(choice) = "c"
                    Call initialiselist()

                Case LCase(choice) = "i"
                    Console.WriteLine("enter new item to be iserted")
                    newitem = Console.ReadLine
                    Call insertnode(newitem)
                Case LCase(choice) = "d"
                    Console.WriteLine("enter new item to be deleted")
                    dataitem = Console.ReadLine
                    Call insertnode(dataitem)
                Case LCase(choice) = "o"
                    Call outputallnode()
            End Select
        End While
        Console.ReadKey()
    End Sub

End Module