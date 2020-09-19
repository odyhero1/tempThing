Public Class Form3
    Dim Above20 As Integer
    Dim Below20 As Integer
    Dim Counter As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Counter >= 10 Then
            MsgBox("You put already 10 values, what is this? Leave immidiately sir  ", 0, "RE what are you doing?")

        Else
            If IsNumeric(TextBox1.Text) Then
                If TextBox1.Text >= 20 Then
                    Above20 = Above20 + 1
                    Label2.Text = "Temperatures Above 20: " & Above20
                Else
                    Below20 = Below20 + 1
                    Label3.Text = "Temperatures Below 20: " & Below20
                End If
                Counter = Counter + 1
                Label4.Text = "Total Temperatures inputted: " & Counter
            Else
                MsgBox("You putting text instead of numbers?What is this behavior. STOP", 0, "SHAME")

            End If

        End If

    End Sub


End Class