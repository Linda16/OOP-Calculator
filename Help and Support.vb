Public Class Help_and_Support

    Private Sub QuotationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Quotation.Show()
        Close()
    End Sub

    Private Sub SectionThreeQuotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem.Click
        Section_One___Registration.Show()
        Close()
    End Sub

    Private Sub CommonIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommonIssuesToolStripMenuItem.Click
        Section_Two___Login.Show()
        Close()
    End Sub

    Private Sub SectionThreeQuotationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem1.Click
        Section_Three___Quotation.Show()
        Close()
    End Sub

    Private Sub CommonIssuesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CommonIssuesToolStripMenuItem2.Click
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

    Private Sub QuotationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuotationToolStripMenuItem1.Click
        Quotation.Show()
        Close()
    End Sub

    Private Sub HowToUseItToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseItToolStripMenuItem.Click
        Use_Quotation.Show()
        Close()
    End Sub
End Class