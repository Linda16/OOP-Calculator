Public Class MyFirstClass
    Public Function Labour(ByVal P As Double)
        Labour = Format((P), "0.00")
    End Function

    Public Function Hour(ByVal H As Double)
        Hour = Format((H), "0.00")
    End Function

    Public Function TotalWorked(ByVal P As Double, ByVal H As Double, ByVal PHP As Double)
        TotalWorked = Format((P) * (H) * (PHP), "£" + "0.00")
    End Function

    Public Function Travel(ByVal M As Double, ByVal MP As Double)
        Travel = Format((M) * (MP), "£" + "0.00")
    End Function

    Public Function PlasticPipe(ByVal PPM As Double, ByVal PMP As Double)
        PlasticPipe = Format((PPM) * (PMP), "£" + "0.00")
    End Function

    Public Function CopperPipe(ByVal CPM As Double, ByVal CPP As Double)
        CopperPipe = Format((CPM) * (CPP), "£" + "0.00")
    End Function

    Public Function ChromePipe(ByVal CHPM As Double, ByVal CHPP As Double)
        ChromePipe = Format((CHPM) * (CHPP), "£" + "0.00")
    End Function

    Public Function Total(ByVal TotalWorked As Double, ByVal Travel As Double, ByVal PlasticPipe As Double, ByVal CopperPipe As Double, ByVal ChromePipe As Double)
        Total = Format((TotalWorked) + (Travel) + (PlasticPipe) + (CopperPipe) + (ChromePipe), "£" + "0.00")
    End Function

    Public Function TotalcostafterVAT(ByVal Total As Double, ByVal VAT As Double)
        TotalcostafterVAT = Format((Total) + (Total * VAT), "£" + "0.00")
    End Function

    Public Function TotalcostafterDiscount(ByVal TotalcostafterVAT As Double)
        If TotalcostafterVAT >= 500 Then
            TotalcostafterDiscount = Format((TotalcostafterVAT) - (TotalcostafterVAT * 0.5), "£" + "0.00")
        Else
            TotalcostafterDiscount = Format("£" + "0.00")
        End If
    End Function
End Class
