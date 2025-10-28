Public Class Form1

    ' زر عرض الوقت
    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        TextBox1.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    ' زر عرض التاريخ
    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        TextBox1.Text = Date.Today.ToString("dd/MM/yyyy")
    End Sub

    ' زر أو ليبل الخروج
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

End Class