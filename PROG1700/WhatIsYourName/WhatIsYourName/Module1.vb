Module Module1

    Sub Main()
        ' Ask for your name
        Console.Write("Please enter your name: ")

        ' Store Date to console
        Dim name = Console.ReadLine
        Dim currentDate = DateTime.Now

        ' Ootput Date to console
        Console.WriteLine($"Hello, {name}, on [{currentDate:d} at {currentDate:t}")

        ' Terminate Program
        Console.WriteLine("Press any Key to Terminate Program...")
        Console.ReadKey(True)

    End Sub

End Module
