Public Class Registration
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare type of variables.  
        My.Settings.Username = TextBox1.Text
        My.Settings.Password = TextBox2.Text
        My.Settings.Confirm = TextBox3.Text
        My.Settings.Save()

        'When textboxes empty or smaller than 0, the message-box approach. 
        If TextBox1.Text = vbNullString And TextBox2.Text = vbNullString Or
            TextBox3.Text = vbNullString Or TextBox2.Text <> TextBox3.Text Then
            MsgBox("Could not create an acconut, try again!")
        Else
            'Information all correct, the message-box approach. 
            MsgBox("User create successful")
            Me.Hide()
            Login.Show()
        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'When information not march, the message display.
        If Not TextBox3.Text = TextBox2.Text Then
            Label4.Text = "Password not match!"
        Else
            Label4.Text = ""
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Give order allow users go to Login form. 
        Login.Show()
        Me.Hide()
    End Sub
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class