Module Module1


    Structure Student 'record declaration
        Dim id As Integer 'field
        Dim name As String 'field
        Dim DoB As Date 'field
    End Structure
    Sub Main()
        Dim newStudent(3) As Student
        FileOpen(1, "d:\filestructure.txt", OpenMode.Output)
        PrintLine(1, "S.N.", "Student Name  ", "Date Of Birth")
        For i = 1 To 3
            Console.WriteLine("insert the id")
            newStudent(i).id = Console.ReadLine()
            Console.WriteLine("insert the name")
            newStudent(i).name = Console.ReadLine()
            Console.WriteLine("insert the Date of Birth")
            newStudent(i).DoB = Console.ReadLine()
            PrintLine(1, newStudent(i).id, newStudent(i).name, newStudent(i).DoB)
        Next i
        Console.WriteLine("S.N." & "  " & "Student Name  " & "    " & "Date Of Birth")
        For j = 1 To 3
            Console.WriteLine(newStudent(j).id & "     " & newStudent(j).name & "         " & newStudent(j).DoB)
        Next j
        FileClose(1)
        Console.ReadKey()

    End Sub


End Module
