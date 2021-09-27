Module Module1
    Class Member
        Private FirstName As String
        Private LastName As String
        Private DateOfBirth As Date
        Private Gender As String

        Public Sub New(ByVal Fname As String, ByVal lname As String, ByVal DOB As Date, ByVal Genderval As String)
            FirstName = Fname
            LastName = lname
            DateOfBirth = DOB
            Gender = Genderval

        End Sub
        Public Function DisplayFullNameAndDateOfBirth() As String
            DisplayFullNameAndDateOfBirth = FirstName + "" + LastName + "" + "and " + "" + DateOfBirth

        End Function
    End Class
    Class Competitor
        Inherits Member
        Private Sport As String
        Public Sub New(ByVal Fname As String, ByVal lNAME As String, ByVal DOB As Date, ByVal genderval As String, ByVal sportval As String)
            MyBase.New(Fname, lNAME, DOB, genderval)
            Sport = sportval


        End Sub

        Public Overloads Function Introduction() As String
            Dim Message As String
            Message = "Hellow I'm " + FirstName + " " + LastName + "and my sport is  " + Sport
            Return Message
        End Function
    End Class
    Sub Main()
        Dim BMXJudge As Competitor = New Competitor("Omar", "Ellen", "1/1/1234", "male", "basketball")







    End Sub

End Module
