Public Class Quotation
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Declare all the variables that requests. 
        Dim MyObjects As Object
        Dim Total, Labour, Hour, TotalWorked, Travel, PlasticPipe, CopperPipe, ChromePipe, TotalcostafterVAT, TotalcostafterDisount As Double
        Dim P, H, M, PPM, PHP, PMP, CPM, CPP, CHPM, CHPP, MP, VAT As Double

        'Set MyObjects to MyFirstClass.
        MyObjects = New MyFirstClass()

        'Inform user to enter request data into system. 
        P = InputBox("How many people worked?")
        MessageBox.Show("Total Labours:", MyObjects.Labour(P))
        TotalLabour.Text = MyObjects.Labour(P)

        'Inform user to enter request data into system. 
        H = InputBox("How many hours worked?")
        MessageBox.Show("Total hours worked:", MyObjects.Hour(H))
        TotalHour.Text = MyObjects.Hour(H)

        'Inform user to enter request data into system. 
        PHP = InputBox("What is the price per hour?")
        MessageBox.Show("Total price of all hours (Labour(s) x hour(s) x price(s) of hour(s)):", MyObjects.TotalWorked(P, H, PHP))
        TW.Text = MyObjects.TotalWorked(P, H, PHP)

        'Inform user to enter request data into system. 
        M = InputBox("How many mile traved?")
        MP = InputBox("What is the price per mile?")
        MessageBox.Show("Total costs of Labour(s) travelled (Mile travelled x Price per mile):", MyObjects.Travel(M, MP))
        TotalTravel.Text = MyObjects.Travel(M, MP)

        'Inform user to enter request data into system. 
        PPM = InputBox("How much meter plastic pipe used?")
        PMP = InputBox("What is the price per mile?")
        MessageBox.Show("Total costs of used plastic pipe (Meters plastic pipe used x price per meter):", MyObjects.PlasticPipe(PPM, PMP))
        PPU.Text = MyObjects.PlasticPipe(PPM, PMP)

        'Inform user to enter request data into system. 
        CPM = InputBox("How much meter copper pipe used?")
        CPP = InputBox("What is the price per mile?")
        MessageBox.Show("Total costs of used copper pipe (Meters copper pipe used x price per meter):", MyObjects.CopperPipe(CPM, CPP))
        CPU.Text = MyObjects.CopperPipe(CPM, CPP)

        'Inform user to enter request data into system. 
        CHPM = InputBox("How much meter chrome pipe used?")
        CHPP = InputBox("What is the price per mile?")
        MessageBox.Show("Total costs of used chrome pipe (Meters chrome pipe used x price per meter):", MyObjects.ChromePipe(CHPM, CHPP))
        CHPU.Text = MyObjects.ChromePipe(CHPM, CHPP)

        'Set correct value to each other. 
        Labour = TotalLabour.Text
        Hour = TotalHour.Text
        TotalWorked = TW.Text
        Travel = TotalTravel.Text
        PlasticPipe = PPU.Text
        CopperPipe = CPU.Text
        ChromePipe = CHPU.Text

        'Give out the data of total costs.
        MessageBox.Show("Total costs for all (Total worked + total travelled + total costs of used plastic pipe + total costs of used copper pipe + total costs of used chrome pipe):", MyObjects.Total(TotalWorked, Travel, PlasticPipe, CopperPipe, ChromePipe))
        TC.Text = MyObjects.Total(TotalWorked, Travel, PlasticPipe, CopperPipe, ChromePipe)

        'Set correct value to each other. 
        Total = TC.Text

        'Inform user to enter request data into system. 
        VAT = InputBox("What is the VAT of decimals?")
        MessageBox.Show("Total costs after VAT (Total + VAT):", MyObjects.TotalcostafterVAT(Total, VAT))
        TACV.Text = MyObjects.TotalcostafterVAT(Total, VAT)

        'Set correct value to each other. 
        TotalcostafterVAT = TACV.Text

        'Give out the data of total cost after Discount. 
        MessageBox.Show("5% off when the total cost after VAT OVER £500!", MyObjects.TotalcostafterDiscount(TotalcostafterVAT))
        TACD.Text = MyObjects.TotalcostafterDiscount(TotalcostafterVAT)

        'Set correct value to each other.
        TotalcostafterDisount = TACD.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Set the button to clear all the texts. 
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Set all the values in the text-boxes to 0.00 .
        TotalLabour.Text = "0.00"
        TotalHour.Text = "0.00"
        TW.Text = "0.00"
        TotalTravel.Text = "0.00"
        PPU.Text = "0.00"
        CPU.Text = "0.00"
        CHPU.Text = "0.00"
        TC.Text = "0.00"
        TACV.Text = "0.00"
        TACD.Text = "0.00"
    End Sub

    Private Sub Label24_TextChanged(sender As Object, e As EventArgs) Handles WelcomeSign.TextChanged
        'Set the welconesign to username.
        WelcomeSign.Text = My.Settings.Username
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Set link (Logout) to close the Quotation form, then link to Login form. 
        Hide()
        Login.Show()
        Close()
    End Sub

    Private Sub WelcomeSign_Click(ByVal sender As Object, ByVal e As EventArgs) Handles WelcomeSign.Click
        Dim UserDetails As New UserDetails
        UserDetails.Show()
        Close()
    End Sub

#Region "Data Menu-bar"
    'Set forms to pop up with different request. 
    Private Sub SectionThreeQuotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem.Click
        Help_and_Support.Show()
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

    Private Sub SectionThreeQuotationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SectionThreeQuotationToolStripMenuItem1.Click
        Section_Three___Quotation.Show()
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

    Private Sub CommonIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommonIssuesToolStripMenuItem.Click
        Common_issues.Show()
        Close()
    End Sub

    Private Sub HowToUseItToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseItToolStripMenuItem.Click
        Use_Quotation.Show()
        Close()
    End Sub
#End Region


    Private Sub Quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
