Imports System.Data.SqlClient
Imports System.IO
Public Class UnreleasedBillRegisterReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim dc As DataColumn
    Dim pageno As Integer
    Dim pagesize As Integer
    Dim gconnection As New GlobalClass
    Public Function printdata(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim billdate, billdetails, billamount, taxamount, totalamount, PayMentmode, scode As String
        Dim docdate, pos As String
        Dim bool As Boolean
        Dim J, I As Integer
        Dim TOT(10) As Double
        Dim TOT1(10) As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "UNRELEASEDBILLREGISTERREPORT")
            If gdataset.Tables("UNRELEASEDBILLREGISTERREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In ds.Tables("UNRELEASEDBILLREGISTERREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If pos <> dr("posdesc") Then
                        If bool = True Then
                            Filewrite.WriteLine("{0,-10}{1,-40}{2,-10}", "GROUP TOTAL :", "", TOT)
                            For I = 0 To 9
                                TOT(I) = 0
                            Next
                            bool = False
                        End If
                        Filewrite.WriteLine(dr("posdesc") & " - " & dr("ServerCODE"))
                        pagesize = pagesize + 1
                        pos = dr("posdesc")
                        bool = True

                    End If
                    'Filewrite.WriteLine("{0,-10}{1,-40}{2,-10}", "GROUP TOTAL :", "", TOT)
                    'Filewrite.Write(Trim(dr("BILLDATE")))
                    'Filewrite.Write(Space(colsize(1) - Trim(dr("BILLDATE")).Length))
                    'Filewrite.Write(Trim(dr("BILLDETAILS")))
                    'Filewrite.Write(Space(colsize(2) - Trim(dr("billdetails")).Length))
                    'TOT(0) = TOT(0) + 1
                    'TOT1(0) = TOT1(0) + 1
                    'Filewrite.Write(Space(colsize(3)))
                    'Filewrite.Write(Space(colsize(4)))
                    'Filewrite.Write(Space(colsize(5) - Len(Trim(Format(dr("amount"), "0.00"))) - 2))
                    'Filewrite.Write(Trim(Format(dr("amount"), "0.00")))
                    'Filewrite.Write(Space(2))
                    'TOT(1) = TOT(1) + dr("amount")
                    'TOT1(1) = TOT1(1) + dr("amount")
                    'Filewrite.WriteLine()
                    'pagesize = pagesize + 1

                Next
                'grandtotal("GROUP TOTAL :", colsize, TOT)
                'Filewrite.WriteLine()
                'pagesize = pagesize + 1
                'Filewrite.WriteLine()
                'pagesize = pagesize + 1
                'grandtotal("GRAND TOTAL :", colsize, TOT1)
                'For J = 0 To 123
                '    Filewrite.Write("-")
                'Next
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14}{1,-18}{2,12}{3,12}{4,12}", "BILL", "BILL", "BASIC", PrintTaxheading1, "NET")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-12}", "PAID", "", "RECEIPT", "RECEIPT", "BALANCE", "", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-14}{1,-18}{2,12}{3,12}{4,12}", "DATE", "NUMBER", "AMOUNT", PrintTaxheading2, "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,-4}{2,-18}{3,-12}{4,10}{5,-4}{6,-12}", "AMOUNT", "", "NUMBER", "DATE", "AMOUNT", "", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
