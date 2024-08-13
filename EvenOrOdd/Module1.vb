Module Module1

    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Number: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Number As Integer = Convert.ToInt32(Console.ReadLine())
        If Number Mod 2 = 1 Then
            System.Console.ForegroundColor = ConsoleColor.Blue
            Console.WriteLine("This Is Odd Number.")
        Else
            System.Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("This Number is Even.")
        End If
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")
        System.Console.ReadKey()
    End Sub

End Module
