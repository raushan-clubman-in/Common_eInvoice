Imports System.Data.SqlClient
Imports System.IO
Public Class contract_details1
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim dblBasic, dblTax, dblNet, dblPaid As Double
    Dim dblNBasic, dblNTax, dblNNet, dblNPaid As Double
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal columnheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal OUTLET As String, ByVal TDSPERC As Double)
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim BILLAMT_GNT, TAXAMT_GND, ROUDOFF_GND, TOTALAMOUNT_GND, OUTLET_USAGE, SVS_CHG, TDS_CHG, mnt_chg As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I, SNO As Integer
        Dim STRSTRING As String
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 770000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Call PrintHeader(columnheading, mskfromdate, msktodate, OUTLET)
            gconnection.getDataSet(SQLSTRING, "CREDITSALEREGISTER")
            BILLAMT_GNT = 0 : TAXAMT_GND = 0 : ROUDOFF_GND = 0 : TOTALAMOUNT_GND = 0
            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                pagesize = pagesize + 1
                I = 0
                dblNet = 0
                SNO = 1
                For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(77, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(columnheading, mskfromdate, msktodate, OUTLET)
                        pagesize = pagesize + 1
                    End If
                    Filewrite.Write("|" & Mid(Str(SNO) & ".", 1, 5) & Space(5 - Len(Mid(Str(SNO) & ".", 1, 5))))
                    Filewrite.Write("|" & Mid(Trim(Format(dr("BILLDATE"), "dd/MM/yyyy")), 1, 10), Space(10 - Len(Mid(Trim(Format(dr("BILLDATE"), "dd/MM/yyyy")), 1, 10))))
                    Filewrite.Write("|" & Space(12 - Len(Mid(Format(dr("billamount"), "0.00"), 1, 12))) & Mid(Format(dr("billamount"), "0.00"), 1, 12))
                    Filewrite.Write("|" & Space(12 - Len(Mid(Format(dr("taxamount"), "0.00"), 1, 12))) & Mid(Format(dr("taxamount"), "0.00"), 1, 12))
                    Filewrite.Write("|" & Space(12 - Len(Mid(Format(dr("roundoff"), "0.00"), 1, 12))) & Mid(Format(dr("roundoff"), "0.00"), 1, 12))
                    Filewrite.Write("|" & Space(12 - Len(Mid(Format(dr("totalamount"), "0.00"), 1, 12))) & Mid(Format(dr("totalamount"), "0.00"), 1, 12))
                    Filewrite.WriteLine("|")
                    BILLAMT_GNT = BILLAMT_GNT + dr("Billamount")
                    TAXAMT_GND = TAXAMT_GND + dr("Taxamount")
                    ROUDOFF_GND = ROUDOFF_GND + dr("ROUNDOFF")
                    TOTALAMOUNT_GND = TOTALAMOUNT_GND + dr("Totalamount")

                    pagesize = pagesize + 1
                    SNO = SNO + 1
                Next dr
                Filewrite.WriteLine(StrDup(77, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("|Total =====>" & Space(4) & "|" & Space(12 - Len(Mid(Format(Val(BILLAMT_GNT), "0.00"), 1, 12))) & Mid(Format(Val(BILLAMT_GNT), "0.00"), 1, 12))
                Filewrite.Write("|" & Space(12 - Len(Mid(Format(Val(TAXAMT_GND), "0.00"), 1, 12))) & Mid(Format(Val(TAXAMT_GND), "0.00"), 1, 12))
                Filewrite.Write("|" & Space(12 - Len(Mid(Format(Val(ROUDOFF_GND), "0.00"), 1, 12))) & Mid(Format(Val(ROUDOFF_GND), "0.00"), 1, 12))
                Filewrite.WriteLine("|" & Space(12 - Len(Mid(Format(Val(TOTALAMOUNT_GND), "0.00"), 1, 12))) & Mid(Format(Val(TOTALAMOUNT_GND), "0.00"), 1, 12))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(77, "-"))
                pagesize = pagesize + 1
                gconnection.getDataSet(SQLSTRING2, "CREDITSALEREGISTER")
                If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                    Filewrite.WriteLine("")
                    OUTLET_USAGE = 0
                    Dim dd As Boolean
                    mnt_chg = 0
                    TDS_CHG = 0
                    dd = True
                    For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                        If Val(dr("PERCENTAGE")) > 0 Then
                            Filewrite.Write(Space(16) & Mid(dr("DETAILS") & " @" & Trim(dr("PERCENTAGE")) & "%", 1, 40) & Space(40 - Len(Mid(dr("DETAILS") & " @" & Trim(dr("PERCENTAGE")) & "%", 1, 40))))
                            Filewrite.WriteLine("|" & Space(12 - Len(Mid(Format((BILLAMT_GNT * dr("PERCENTAGE")) / 100, "0.00"), 1, 12))) & Mid(Format((BILLAMT_GNT * dr("PERCENTAGE")) / 100, "0.00"), 1, 12))
                            SVS_CHG = SVS_CHG + (BILLAMT_GNT * dr("PERCENTAGE")) / 100
                        Else
                            If dd = True Then
                                dd = False
                                Filewrite.WriteLine("")
                                Filewrite.WriteLine(StrDup(77, "-"))
                                Filewrite.WriteLine(Space(16) & "TOTAL PAYABLE  " & Space(25) & "|" & Space(12 - Len(Mid(Format(Val(BILLAMT_GNT) - Val(SVS_CHG), "0.00"), 1, 12))) & Mid(Format(Val(BILLAMT_GNT) - Val(SVS_CHG), "0.00"), 1, 12))
                                If Val(TDSPERC) > 0 Then
                                    Filewrite.WriteLine("")
                                    Filewrite.Write(Space(16) & "TDS CHARGES @" & Val(TDSPERC) & "%")
                                    TDS_CHG = ((BILLAMT_GNT - SVS_CHG) * Val(TDSPERC)) / 100
                                    Filewrite.WriteLine(Space(25) & "|" & Space(12 - Len(Mid(Format(Val(TDS_CHG), "0.00"), 1, 12))) & Mid(Format(Val(TDS_CHG), "0.00"), 1, 12))
                                    Filewrite.WriteLine("")
                                End If
                            End If
                            Filewrite.Write(Space(16) & Mid(dr("DETAILS"), 1, 40) & Space(40 - Len(Mid(dr("DETAILS"), 1, 40))))
                            Filewrite.WriteLine("|" & Space(12 - Len(Mid(Format(dr("AMOUNT"), "0.00"), 1, 12))) & Mid(Format(dr("AMOUNT"), "0.00"), 1, 12))
                            OUTLET_USAGE = OUTLET_USAGE + Val(dr("AMOUNT"))
                        End If
                        Filewrite.WriteLine("")
                    Next
                    Filewrite.WriteLine(StrDup(77, "-"))
                    Filewrite.Write(Space(16) & "DEDUCTION")
                    Filewrite.WriteLine(Space(31) & "|" & Space(12 - Len(Mid(Format(Val(OUTLET_USAGE), "0.00"), 1, 12))) & Mid(Format(Val(OUTLET_USAGE), "0.00"), 1, 12))
                    Filewrite.WriteLine("")
                    Filewrite.Write(Space(16) & "NET PAYABLE")
                    Filewrite.WriteLine(Space(29) & "|" & Space(12 - Len(Mid(Format(Val(BILLAMT_GNT) - (Val(OUTLET_USAGE) + Val(TDS_CHG) + Val(SVS_CHG)), "0.00"), 1, 12))) & Mid(Format(Val(BILLAMT_GNT) - (Val(OUTLET_USAGE) + Val(TDS_CHG) + Val(SVS_CHG)), "0.00"), 1, 12))
                    Filewrite.WriteLine(StrDup(77, "-"))
                End If
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function grandtotal()
        Filewrite.WriteLine(StrDup(77, "-"))
        pagesize = pagesize + 1
        Filewrite.WriteLine(Space(16) & "Grand Total =====>" & Space(20) & Space(10 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNet), "0.00"), 1, 10) & Space(1) & Space(8 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 8))) & Mid(Format(Val(dblTax), "0.00"), 1, 8))
        pagesize = pagesize + 1
        Filewrite.WriteLine(StrDup(77, "-"))
        pagesize = pagesize + 1
    End Function
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal OUTLET As String)
        Dim I As Integer
        pagesize = 0
        Try
            pagesize = pagesize + 1
            Filewrite.WriteLine(UCase(gCompanyname))
            Filewrite.WriteLine(UCase(OUTLET))
            Filewrite.WriteLine("Sub Contract Payment Report From :" & Format(mskfromdate, "dd/MM/yyyy") & "To :" & Format(msktodate, "dd/MM/yyyy") & Space(10) & "PAGE NO:" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(77, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("|SNO  |BILLDATE  | BILLAMOUNT | TAXAMOUNT  | ROUNDOFF  |  TOTALAMOUNT|")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(77, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
