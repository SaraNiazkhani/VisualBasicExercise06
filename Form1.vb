Imports System.IO

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles OutPutLabel.Click

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click


        Dim stepValue As Integer = CInt(StepTextBox.Text)
        Dim Output As String
        Dim fileName As String = "multiples_of_5.txt"
        Dim i As Integer
        For i = i To 10 Step stepValue
            Output = Output + Str(i * 5) + ","
        Next i
        OutPutLabel.Text = Output
        My.Computer.FileSystem.WriteAllText(fileName, Output, True)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        End

    End Sub
End Class
