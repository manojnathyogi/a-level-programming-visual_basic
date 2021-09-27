Module Module1

    Sub Main()
        Dim lineoftext As String
        Dim filehandle As System.IO.StreamReader
        filehandle = New System.IO.StreamReader("d:\samplefile.txt")
        Dim a As Integer = 1
        Do
            lineoftext = filehandle.ReadLine()
            Console.WriteLine(lineoftext)
        Loop Until a = 1
        filehandle.Close()
        Console.ReadKey()
    End Sub

End Module
