Module Module1

    Sub Main()
        Dim roll, name, phone As String
        Console.WriteLine("enter roll number of  a student")
        roll = Console.ReadLine()
        Console.WriteLine("enter name of  a student")
        name = Console.ReadLine()
        Console.WriteLine("enter phone number of  a student")
        phone = Console.ReadLine()
        Console.WriteLine("name of student is " & name & roll & phone)
        Console.WriteLine("roll number of student is " & roll)
        Console.WriteLine("name of student is " & phone)
        Console.ReadLine()
    End Sub

End Module
