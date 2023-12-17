Imports System.Text

Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Get the text entered into the TextBox
        Dim userInput As String = txtInput.Text

        ' Process the input and generate ASCII values
        Dim asciiResult As String = ConvertToASCII(userInput)

        ' Display the ASCII values in the Label
        lblASCII.Text = "ASCII Values: " & vbCrLf & asciiResult
    End Sub


    ' Function to convert input to ASCII values
    Private Function ConvertToASCII(inputText As String) As String
        Dim asciiResult As New StringBuilder()

        For Each character As Char In inputText
            Dim asciiValue As Integer = AscW(character)
            asciiResult.AppendLine($"Character: {character}, ASCII Value: {asciiValue}")
        Next

        Return asciiResult.ToString()
    End Function
End Class
