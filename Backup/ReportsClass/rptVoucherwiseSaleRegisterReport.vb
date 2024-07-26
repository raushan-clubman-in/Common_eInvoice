Imports System.Data.SqlClient
Imports System.IO
Public Class rptVoucherwiseSaleRegisterReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim DocTotal, NetAmount, basicamount, taxamount As Double
        Dim TDocTotal, TNetAmount, Tbasicamount, Ttaxamount As Double

        Dim POSDESC, SSQL As String
        Dim I, J As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "VOUCHERWISESALEREGISTER")
            If gdataset.Tables("VOUCHERWISESALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("VOUCHERWISESALEREGISTER").Rows
                    If pagesize > 58 Then
                        For I = 0 To 135
                            Filewrite.Write("-")
                        Next
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEAD, FROMDATE, TODATE)
                    End If

                    '                    TNetAmount = TNetAmount + Val(dr("NETAMOUNT"))
                    '                    Ttaxamount = Ttaxamount + Val(dr("TAXAMOUNT"))
                    '                    Tbasicamount = Tbasicamount + Val(dr("BASICAMOUNT"))

                    If POSDESC <> Trim(dr("POSDESC")) Then
                        Filewrite.WriteLine("{0,-20}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 20) & ":")
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-20}", "-------------------------")
                        pagesize = pagesize + 1
                        Filewrite.Write("{0,-20}", "")

                        SSQL = "SELECT COUNT(DISTINCT(B.BILLDETAILS)) AS DOCTOTAL,MIN(K.BILLDETAILS) AS BILLFROM, MAX(K.BILLDETAILS) AS BILLTO FROM KOT_DET AS K INNER JOIN BILL_HDR AS B"
                        SSQL = SSQL & " ON B.BILLDETAILS = K.BILLDETAILS INNER JOIN POSMASTER AS P ON P.POSCODE = K.POSCODE"
                        SSQL = SSQL & " WHERE POSDESC='" & Trim(dr("posdesc")) & "' AND BILLDATE BETWEEN"
                        SSQL = SSQL & " '" & Format(FROMDATE, "yyyy-MM-dd") & "' AND ' " & Format(TODATE, "yyyy-MM-dd") & "'"
                        gconnection.getDataSet(SSQL, "KOT_DET")

                        If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                            Filewrite.Write("{0,-25}", Mid(Trim(gdataset.Tables("KOT_DET").Rows(0).Item("BILLFROM")), 1, 25))
                        Else
                            Filewrite.Write("{0,-25}", Mid(1, 1, 25))
                        End If

                        If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                            Filewrite.Write("{0,-20}", Mid(Trim(gdataset.Tables("KOT_DET").Rows(0).Item("BILLTO")), 1, 20))
                        Else
                            Filewrite.Write("{0,-20}", Mid(1, 1, 20))
                        End If

                        '                        Filewrite.Write("{0,-20}", Mid(CStr(dr("BILLTO")), 1, 25))


                        If gdataset.Tables("KOT_DET").Rows.Count > 0 Then
                            Filewrite.Write("{0,15}", Mid(Format(Val(gdataset.Tables("KOT_DET").Rows(0).Item("DOCTOTAL")), "0"), 1, 15))
                        Else
                            Filewrite.Write("{0,15}", Mid(1, 1, 15))
                        End If


                        Filewrite.Write("{0,15}", Mid(Trim(Format(Val(dr("BASICAMOUNT")), "0.00")), 1, 15))
                        Filewrite.Write("{0,15}", Mid(Trim(Format(Val(dr("TAXAMOUNT")), "0.00")), 1, 15))
                        Filewrite.Write("{0,15}", Mid(Trim(Format(Val(dr("NETAMOUNT")), "0.00")), 1, 15))
                        DocTotal = DocTotal + Val(gdataset.Tables("KOT_DET").Rows(0).Item("DOCTOTAL"))


                        NetAmount = NetAmount + Val(dr("NETAMOUNT"))
                        taxamount = taxamount + Val(dr("TAXAMOUNT"))
                        basicamount = basicamount + Val(dr("BASICAMOUNT"))

                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                        POSDESC = Trim(dr("POSDESC"))
                Next dr
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-20}", "Grand Total ====>")
                Filewrite.Write("{0,-25}{1,-20}{2,15}", "", "", Mid(Trim(Format(Val(DocTotal), "0")), 1, 15))
                Filewrite.Write("{0,15}{1,15}{2,15}", Mid(Trim(Format(Val(basicamount), "0.00")), 1, 15), Mid(Trim(Format(Val(taxamount), "0.00")), 1, 15), Mid(Trim(Format(Val(NetAmount), "0.00")), 1, 15))
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,10}{1,-33}{2,-35}", "", "VOUCHER NUMBER(s)", "TILL REGISTER AMOUNT")
                Filewrite.Write("{0,-30}{1,-20}", "COMPUTER AMOUNT", "REMARKS")
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                For J = 1 To 4
                    Filewrite.WriteLine(J & ".")
                    pagesize = pagesize + 1
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                Next J
                Filewrite.WriteLine(StrDup(135, "="))
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
    Private Function ReportHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
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
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-25}{2,-20}{3,15}{4,15}", "COST", "BILL", "BILL", "TOTAL", "BASIC")
            Filewrite.WriteLine("{0,15}{1,15}", "VAT", "TOTAL")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-25}{2,-20}{3,15}{4,15}", "CENTER", "FROM", "TO", "DOCUMENT", "TOTAL")
            Filewrite.WriteLine("{0,15}{1,15}", "TOTAL", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
