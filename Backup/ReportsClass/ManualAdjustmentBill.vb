Imports System.Data.SqlClient
Imports System.IO
Public Class ManualAdjustmentBill
    Dim dr As DataRow
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Public Function Reportdetails(ByVal CONN As String, ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal COLUMNHEAD() As String, ByVal SIZE() As Integer, ByVal FROMDATE As Date, ByVal TODATE As Date, ByVal BILLSTARTDATE As Date, ByVal BILLENDDATE As Date)
        Dim GRANDTOTAL As Double
        Dim I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("MBR" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE, BILLSTARTDATE, BILLENDDATE)
            gconnection.getDataSet(SQLSTRING, "MANUALBILLADJUST")
            If gdataset.Tables("MANUALBILLADJUST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("MANUALBILLADJUST").Rows
                    If pagesize > 60 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE, BILLSTARTDATE, BILLENDDATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    Filewrite.Write("{0,-16}", Mid(Trim(CStr(dr("BILLNO"))), 1, 16))
                    Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("ADJDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-16}", Mid(Trim(CStr(dr("PAYMENTMODE"))), 1, 16))
                    If Trim(CStr(dr("MCODE"))) <> "" Then
                        Filewrite.Write("{0,-12}", Mid(Trim(CStr(dr("MCODE"))), 1, 12))
                    ElseIf Trim(CStr(dr("ROOMNO"))) <> "" And Val(dr("ROOMNO")) <> 0 Then
                        Filewrite.Write("{0,-12}", Mid(Trim(CStr(dr("ROOMNO"))), 1, 12))
                    Else
                        Filewrite.Write("{0,-12}", " ")
                    End If
                    Filewrite.WriteLine("{0,12}", Mid(Format(Val(dr("BILLAMOUNT")), "0.00"), 1, 12))
                    GRANDTOTAL = GRANDTOTAL + Format(Val(dr("BILLAMOUNT")), "0.00")
                    pagesize = pagesize + 1
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-47}{1,20} {2,12}", " ", "Grand Total =====>", Format(Val(GRANDTOTAL), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal colsize() As Integer, ByVal DTPfromdate As Date, ByVal DTPtodate As Date, ByVal DTPBILLSTARTdate As Date, ByVal DTPBILLENDdate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,53}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-14} {1,-38} {2,23} ", "ADJUST DATE :", Format(DTPBILLSTARTdate, "MMM dd,yyyy") & " " & "To" & " " & Format(DTPBILLENDdate, "MMM dd,yyyy"), "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14} {1,-40} {2,6} {3,16}", " BILL  DATE :", Format(DTPfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(DTPtodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-16}{1,-12}{2,-12}{3,-16}{4,-12}{5,12} ", "BILL NO.", "BILL DATE", "ADJUST DATE", "PAYMENT MODE", "CODE", "BILL AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class