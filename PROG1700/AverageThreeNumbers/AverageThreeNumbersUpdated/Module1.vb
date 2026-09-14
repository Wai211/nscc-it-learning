Module Module1

    Sub Main()
        Dim number1, number2, number3 As Double
        Dim answer As Double

        Console.Write("Type your 1st number and press enter: ")
        number1 = Console.ReadLine

        Console.Write("Type your 2nd number and press enter: ")
        number2 = Console.ReadLine

        Console.Write("Type your 3rd number and press enter: ")
        number3 = Console.ReadLine

        answer = (number1 + number2 + number3) / 3
        Console.WriteLine($"The Average of {number1} and {number2} and {number3} is {answer}")

        Console.ReadKey(True)


    End Sub

End Module
