Public Class Section_Three___Quotation
    Private Sub SectionThreeQuotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem.Click
        Section_One___Registration.Show()
        Close()
    End Sub

    Private Sub CommonIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommonIssuesToolStripMenuItem.Click
        Section_Two___Login.Show()
        Close()
    End Sub

    Private Sub SectionThreeQuotationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem1.Click
        Help_and_Support.Show()
        Close()
    End Sub

    Private Sub CommonIssuesToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles CommonIssuesToolStripMenuItem1.Click
        Common_issues.Show()
        Close()
    End Sub

    Private Sub LoginSectionTwoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginSectionTwoToolStripMenuItem.Click
        Login__Section_One_.Show()
        Close()
    End Sub

    Private Sub QuotationSectionThreeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuotationSectionThreeToolStripMenuItem.Click
        Quotation__Section_Two_.Show()
        Close()
    End Sub

    Private Sub QuotationToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QuotationToolStripMenuItem.Click
        Quotation.Show()
        Close()
    End Sub

    Private Sub HowToUseItToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseItToolStripMenuItem.Click
        Use_Quotation.Show()
        Close()
    End Sub
End Class