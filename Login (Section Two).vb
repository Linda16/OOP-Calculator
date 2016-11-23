Public Class Login__Section_One_

    Private Sub SectionThreeQuotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem.Click
        Common_issues.Show()
        Close()
    End Sub

    Private Sub CommonIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommonIssuesToolStripMenuItem.Click
        Quotation__Section_Two_.Show()
        Close()
    End Sub

    Private Sub SectionOneRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionOneRegistrationToolStripMenuItem.Click
        Section_One___Registration.Show()
        Close()
    End Sub

    Private Sub SectionTwoLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionTwoLoginToolStripMenuItem.Click
        Section_Two___Login.Show()
        Close()
    End Sub

    Private Sub SectionThreeQuotationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem2.Click
        Section_Three___Quotation.Show()
        Close()
    End Sub

    Private Sub QuotationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuotationToolStripMenuItem1.Click
        Quotation.Show()
        Close()
    End Sub

    Private Sub HowToUseItToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseItToolStripMenuItem.Click
        Use_Quotation.Show()
        Close()
    End Sub

    Private Sub Login__Section_One__Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class