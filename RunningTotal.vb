Option Explicit On
Option Strict On
Option Compare Text

Module RunningTotal

    Sub Main()
        Dim userInput As String
        Dim runningTotal As Double
        Const TAXRATE As Double = 0.06
        Dim badData As Boolean
        Dim taxAmount As Double

        While userInput <> "Q"
            Console.WriteLine("Please select an option.")
            Console.WriteLine("1. Add Item.")
            Console.WriteLine("2. Calculate Tax.")
            userInput = Console.ReadLine()


            If userInput = "1" Then

                Do
                    Try
                        Console.WriteLine("Enter cost of item.")
                        userInput = Console.ReadLine()
                        runningTotal += CDec(userInput)
                        badData = False

                    Catch ex As Exception
                        'prompt user to give good data.
                        Console.WriteLine("Data must be a number.")
                        badData = True
                    End Try
                Loop While badData
                Console.WriteLine("Total: $" & runningTotal)



            ElseIf userInput = "2" Then
                taxAmount = runningTotal * TAXRATE

                Console.WriteLine("Tax:  $" & taxAmount)

            Else



            End If






        End While
    End Sub

End Module
