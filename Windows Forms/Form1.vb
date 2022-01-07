Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        txtName.Text = "Hello " & txtName.Text

    End Sub

    Private Sub txtMessage_Click(sender As Object, e As EventArgs) Handles txtMessage.Click

        MessageBox.Show("Hello " & txtName.Text,
                        "Hello " & txtName.Text)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click

        Try

            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please only enter numbers.", "Invalid Cast Exception")

        Catch ex As Exception

            MessageBox.Show("An unknown error occurred.",
                             "Error")

        End Try

    End Sub

    Private Sub btnDivideVals_Click(sender As Object, e As EventArgs) Handles btnDivideVals.Click

        Dim firstNum As Decimal = CDec(txtDivideVal1.Text)
        Dim secondNum As Decimal = CDec(txtDivideVal2.Text)
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivisionAnswer.Text = CStr(intSolution)

    End Sub
End Class
