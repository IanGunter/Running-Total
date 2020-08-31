Option Explicit On
Option Strict On

Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Integer
        Const TAXRATE As Double = 0.06

        While userInput <> "Q"
            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item.")
            Console.WriteLine("2. Calculate Tax.")
            userInput = Console.ReadLine()


            If userInput = "1" Then
                Console.WriteLine("Enter cost of item.")
                userInput = Console.ReadLine()

                Try
                    runningTotal += CInt(userInput)

                Catch ex As Exception
                    'prompt user to give good data.
                End Try
                Console.WriteLine("Total: $" & runningTotal)



            ElseIf userInput = "2" Then

                Console.WriteLine("Tax:  $" & runningTotal * TAXRATE)

            End If






        End While
    End Sub

End Module
