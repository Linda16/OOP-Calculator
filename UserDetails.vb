Public Class UserDetails
    Private Details As String
    Private Sub LLQ_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles O_H.LinkClicked
        Quotation.Show()
    End Sub

    Private Sub Label24_TextChanged(sender As Object, e As EventArgs) Handles Welcome.TextChanged
        Welcome.Text = My.Settings.Username
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Logout.LinkClicked
        Hide()
        Login.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Q_F.Click
        Quotation.Show()
        Close()
    End Sub

    Public Property UserDetails As String

        Get
            Return Details
        End Get
        Set(ByVal value As String)
            Details = value
        End Set
    End Property

End Class