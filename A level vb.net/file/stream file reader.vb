Option Explicit On
Imports System.IO
Imports System.Environment

Module Module1


    'create variable to write a stream of characters to a text file
    Dim currentfilewriter As StreamWriter
    Sub main()
        Dim filename, textstring As String
        Dim count As Integer

        filename = getfolderpath(specialfolder.mydocuments) & "MYFILE.txt"
        currentfilewriter = New StreamWriter(filename)
        Console.WriteLine("file being created")
        currentfilewriter.WriteLine("file created on" & Now())
        For count = 1 To 5
            textstring = Rnd() * 100
            Console.WriteLine("random number" & count & "is " & textstring)
            currentfilewriter.WriteLine("random number" & count & "is " & textstring)
        Next

        currentfilewriter.Close() 'close file
        Console.WriteLine("flie saved")
        Console.ReadLine()


        Next
    End Sub

End Module
