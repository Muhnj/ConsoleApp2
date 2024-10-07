Imports System

Module Program
    Sub Main(args As String())
        'Dvision Handling
        Try
            Console.Write("Enter Fisrt Name: ")
            Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())

            Console.Write("Enter Second Name: ")
            Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

            Dim result As Integer = num1 / num2
            Console.WriteLine("Results: " & result)


        Catch ex As Exception
            Console.WriteLine("Error: Division by Zero is Not Allowed")

        Finally
            Console.WriteLine("Program Complete")
        End Try
    End Sub
End Module
