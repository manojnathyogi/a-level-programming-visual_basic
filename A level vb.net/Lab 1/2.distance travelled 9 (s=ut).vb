Module Module1

    Sub Main()

        Dim u, t, s, a As Integer
        Console.WriteLine("enter the initial velocity of body in m/s")
        u = Console.ReadLine()
        Console.WriteLine("enter the time taken to travel the distance")
        t = Console.ReadLine()
        Console.WriteLine("enter the acceleration of the body in motion in m/s^2")
        a = Console.ReadLine()
        s = u * t + (1 / 2) * a * t ^ 2
        Console.WriteLine("distance travelled is" & s)
        Console.ReadLine()




    End Sub

End Module
