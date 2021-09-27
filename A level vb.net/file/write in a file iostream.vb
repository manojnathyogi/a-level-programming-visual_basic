Module Module1

    Sub Main()
        Dim lineoftext As String
        Dim filehandle As System.IO.StreamReader
        filehandle = New System.IO.StreamReader("d:\samplefile.txt")
        lineoftext = filehandle.ReadLine()
        Console.WriteLine(lineoftext)
        filehandle.Close()
        Console.ReadKey()
    End Sub

End Module
