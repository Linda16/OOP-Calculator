Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'given order of username and password to met data registered at Registration Form.
        If TextBox1.Text = My.Settings.Username And TextBox2.Text = My.Settings.Password Then
            Quotation.Show()
            Me.Hide()

            'Given order of what will happen when inforamtion incorrect. 
        Else
            MsgBox("Incorrect Username or Password!")
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object,
                                       e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Given order allow users go back to registration form. 
        Registration.Show()
        Me.Close()
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class