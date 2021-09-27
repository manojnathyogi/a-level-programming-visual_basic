Module Module1

    Sub Main()
        Dim lineoftext As String
        Dim filehandle As System.IO.StreamWriter
        filehandle = New IO.StreamWriter("d:\samplefile.txt", True)
        lineoftext = Console.ReadLine
        filehandle.WriteLine(lineoftext)

        filehandle.Close()
        Console.ReadKey()
    End Sub

End Module
