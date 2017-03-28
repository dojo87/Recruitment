Module Module1

    Sub Main()
        ' Write client to consume http://localhost:56011/Service1.svc (Recruitment.SoapUIWebService)
        ' Call the method GetDataUsingDataContract and assure the response string
        ' consists of "<Your Input String>Suffix" if BoolValue=True
		
		Dim input As String = "My Test String with ..."

        '''''''''''' Write Your code here, add any references you like, browse Google ''''''''''''

        Dim response = New With {.StringValue = ""}

        '''''''''''' END Your code here ''''''''''''

        If (response.StringValue = (input + "Suffix")) Then
            Console.WriteLine("Success!")
        Else
            Console.WriteLine("Failed!" + response.StringValue)
        End If

        Console.ReadLine()
    End Sub

End Module
