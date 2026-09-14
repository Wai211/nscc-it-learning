Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim answer As Integer

        Console.Write("Type a number and press enter.")
        num1 = Console.ReadLine

        Console.Write("Type another number to add to it and press Enter.")
        num2 = Console.ReadLine

        answer = num1 + num2

        Console.WriteLine("The answer is " & answer)
        Console.Write("Press any Key to Continue")

        Console.ReadKey(True)

    End Sub

End Module
