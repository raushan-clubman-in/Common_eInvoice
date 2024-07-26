Imports System.data.sqlclient
Imports System.io
Public Class rptVoucherwisesaleregister
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportsDetails(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblBasic, dblTax, dblNet, dblPaid As Double
        Dim dblItemBasic, dblItemTax, dblItemNet, dblItemPaid As Double
        Dim dblGroupBasic, dblGroupTax, dblGroupNet, dblGroupPaid As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandNet, dblgrandPaid As Double

        Dim POSDESC, BILLDETAILS, SQLSTRING1 As String
        Dim POSBOOL As Boolean
        Dim I As Integer
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
            gconnection.getDataSet(SQLSTRING, "VOUCHERWISESALEREGISTER")
            If gdataset.Tables("VOUCHERWISESALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("VOUCHERWISESALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSDESC <> Trim(dr("POSDESC")) Then
                        If POSBOOL = True Then
                            Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "TOTAL :", Mid(Format(Val(dblItemBasic), "0.00"), 1, 10))
                            Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblItemTax), "0.00"), 1, 10), "", Mid(Format(Val(dblItemNet), "0.00"), 1, 10))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "="))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "GROUP TOTAL :", Mid(Format(Val(dblGroupBasic), "0.00"), 1, 10))
                            Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblGroupTax), "0.00"), 1, 10), "", Mid(Format(Val(dblGroupNet), "0.00"), 1, 10))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "="))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", "-------------------------")
                            pagesize = pagesize + 1
                            POSDESC = Trim(dr("POSDESC"))
                            dblItemBasic = 0 : dblItemTax = 0 : dblItemNet = 0
                            dblGroupBasic = 0 : dblGroupTax = 0 : dblGroupNet = 0
                        Else
                            Filewrite.WriteLine("{0,-30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", "-------------------------")
                            pagesize = pagesize + 1
                            POSDESC = Trim(dr("POSDESC"))
                            POSBOOL = True
                        End If
                    End If
                    If BILLDETAILS <> Trim(dr("BILLDETAILS")) Then
                        Filewrite.Write("{0,-11}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-25}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 20))
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 8))
                        dblBasic = dblBasic + Format(Val(dr("BASIC")), "0.00")
                        dblItemBasic = dblItemBasic + Format(Val(dr("BASIC")), "0.00")
                        dblGroupBasic = dblGroupBasic + Format(Val(dr("BASIC")), "0.00")
                        dblGrandBasic = dblGrandBasic + Format(Val(dr("BASIC")), "0.00")
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 8))
                        dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblItemTax = dblItemTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblGroupTax = dblGroupTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblGrandTax = dblGrandTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        Filewrite.Write("{0,10}{1,10}", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 8))
                        dblNet = dblNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblItemNet = dblItemNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblGroupNet = dblGroupNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblGrandNet = dblGrandNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        If Val(dr("PAIDAMOUNT")) = 0 Then
                            Filewrite.Write("{0,10}", "")
                        Else
                            Filewrite.Write("{0,10}", Mid(Format(Val(dr("PAIDAMOUNT")), "0.00"), 1, 8))
                        End If

                        Filewrite.Write("{0,-2}{1,-18}", "", Mid(Trim(CStr(dr("RECEIPTNUMBER"))), 1, 18))
                        If Val(dr("BALANCEAMT")) = 0 Then
                            Filewrite.Write("{0,10}", "")
                        Else
                            Filewrite.Write("{0,10}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8))
                        End If
                        Filewrite.Write("{0,-2}{1,-11}", "", Mid(Trim(CStr(dr("PAYMENTMODE"))), 1, 10))
                        Filewrite.WriteLine("{0,-6}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 15))
                        pagesize = pagesize + 1
                        BILLDETAILS = Trim(dr("BILLDETAILS"))
                        SQLSTRING1 = "SELECT ITEMCODE,ITEMDESC,SUM(QTY) AS QTY,RATE,AMOUNT FROM KOT_DET WHERE Billdetails = '" & Trim(CStr(dr("BILLDETAILS"))) & "'"
                        SQLSTRING1 = SQLSTRING1 & " GROUP BY ITEMCODE,ITEMDESC,RATE,AMOUNT"
                        gconnection.getDataSet(SQLSTRING1, "Kotdetails")
                        If gdataset.Tables("Kotdetails").Rows.Count > 0 Then
                            Filewrite.Write("{0,-11}", "", "")
                            Filewrite.Write(StrDup(75, "-"))
                            Filewrite.WriteLine("{0,-32}{1,-11}", "", Mid(Trim(CStr(dr("SUBPAYMENTMODE"))), 1, 6))
                            pagesize = pagesize + 1
                            For I = 0 To gdataset.Tables("Kotdetails").Rows.Count - 1 Step 1
                                With gdataset.Tables("Kotdetails").Rows(I)
                                    Filewrite.Write("{0,-11}{1,-35}", "", Mid(Trim(CStr(.Item("ITEMDESC"))), 1, 35))
                                    Filewrite.Write("{0,10}", Mid(Format(Val(.Item("QTY")), "0"), 1, 10))
                                    Filewrite.Write("{0,10}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 10))
                                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                    pagesize = pagesize + 1
                                End With
                            Next I
                            Filewrite.Write("{0,-11}", "")
                            Filewrite.WriteLine(StrDup(75, "-"))
                            pagesize = pagesize + 1
                        End If
                    End If
                Next dr
                Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "TOTAL :", Mid(Format(Val(dblItemBasic), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblItemTax), "0.00"), 1, 10), "", Mid(Format(Val(dblItemNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "GROUP TOTAL:", Mid(Format(Val(dblGroupBasic), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblGroupTax), "0.00"), 1, 10), "", Mid(Format(Val(dblGroupNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-25}{2,10}", " ", "GRAND TOTAL ===>", Mid(Format(Val(dblGrandBasic), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblGrandTax), "0.00"), 1, 10), "", Mid(Format(Val(dblGrandNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
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
    Public Function ReportsDetails_Mem(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblBasic, dblTax, dblNet, dblPaid As Double
        Dim dblItemBasic, dblItemTax, dblItemNet, dblItemPaid As Double
        Dim dblGroupBasic, dblGroupTax, dblGroupNet, dblGroupPaid As Double
        Dim dblGrandBasic, dblGrandTax, dblGrandNet, dblgrandPaid As Double

        Dim POSDESC, BILLDETAILS, SQLSTRING1, ROWPRINT As String
        Dim POSBOOL As Boolean
        Dim I As Integer
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
            gconnection.getDataSet(SQLSTRING, "VOUCHERWISESALEREGISTER")
            If gdataset.Tables("VOUCHERWISESALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("VOUCHERWISESALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSDESC <> Trim(dr("POSDESC")) Then
                        If POSBOOL = True Then
                            Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "TOTAL :", Mid(Format(Val(dblItemBasic), "0.00"), 1, 10))
                            Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblItemTax), "0.00"), 1, 10), "", Mid(Format(Val(dblItemNet), "0.00"), 1, 10))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "="))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "GROUP TOTAL :", Mid(Format(Val(dblGroupBasic), "0.00"), 1, 10))
                            Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblGroupTax), "0.00"), 1, 10), "", Mid(Format(Val(dblGroupNet), "0.00"), 1, 10))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "="))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", "-------------------------")
                            pagesize = pagesize + 1
                            POSDESC = Trim(dr("POSDESC"))
                            dblItemBasic = 0 : dblItemTax = 0 : dblItemNet = 0
                            dblGroupBasic = 0 : dblGroupTax = 0 : dblGroupNet = 0
                        Else
                            Filewrite.WriteLine("{0,-30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-30}", "-------------------------")
                            pagesize = pagesize + 1
                            POSDESC = Trim(dr("POSDESC"))
                            POSBOOL = True
                        End If
                    End If
                    If BILLDETAILS <> Trim(dr("BILLDETAILS")) Then
                        Filewrite.Write("{0,-11}", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-25}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 20))
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("BASIC")), "0.00"), 1, 8))
                        dblBasic = dblBasic + Format(Val(dr("BASIC")), "0.00")
                        dblItemBasic = dblItemBasic + Format(Val(dr("BASIC")), "0.00")
                        dblGroupBasic = dblGroupBasic + Format(Val(dr("BASIC")), "0.00")
                        dblGrandBasic = dblGrandBasic + Format(Val(dr("BASIC")), "0.00")
                        Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 8))
                        dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblItemTax = dblItemTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblGroupTax = dblGroupTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        dblGrandTax = dblGrandTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                        Filewrite.Write("{0,10}{1,10}", "", Mid(Format(Val(dr("NETAMOUNT")), "0.00"), 1, 8))
                        dblNet = dblNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblItemNet = dblItemNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblGroupNet = dblGroupNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        dblGrandNet = dblGrandNet + Format(Val(dr("NETAMOUNT")), "0.00")
                        If Val(dr("PAIDAMOUNT")) = 0 Then
                            Filewrite.Write("{0,10}", "")
                        Else
                            Filewrite.Write("{0,10}", Mid(Format(Val(dr("PAIDAMOUNT")), "0.00"), 1, 8))
                        End If

                        Filewrite.Write("{0,-2}{1,-18}", "", Mid(Trim(CStr(dr("RECEIPTNUMBER"))), 1, 18))
                        If Val(dr("BALANCEAMT")) = 0 Then
                            Filewrite.Write("{0,10}", "")
                        Else
                            Filewrite.Write("{0,10}", Mid(Format(Val(dr("BALANCEAMT")), "0.00"), 1, 8))
                        End If
                        Filewrite.Write("{0,-2}{1,-11}", "", Mid(Trim(CStr(dr("PAYMENTMODE"))), 1, 10))
                        Filewrite.WriteLine("{0,-6}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 15))
                        ROWPRINT = dr("MNAME") + "(" + dr("MCODE") + ")"
                        Filewrite.WriteLine(ROWPRINT)
                        pagesize = pagesize + 1
                        BILLDETAILS = Trim(dr("BILLDETAILS"))
                        SQLSTRING1 = "SELECT ITEMCODE,ITEMDESC,SUM(QTY) AS QTY,RATE,AMOUNT FROM KOT_DET WHERE Billdetails = '" & Trim(CStr(dr("BILLDETAILS"))) & "'"
                        SQLSTRING1 = SQLSTRING1 & " GROUP BY ITEMCODE,ITEMDESC,RATE,AMOUNT"
                        gconnection.getDataSet(SQLSTRING1, "Kotdetails")
                        If gdataset.Tables("Kotdetails").Rows.Count > 0 Then
                            Filewrite.Write("{0,-11}", "", "")
                            Filewrite.Write(StrDup(75, "-"))
                            Filewrite.WriteLine("{0,-32}{1,-11}", "", Mid(Trim(CStr(dr("SUBPAYMENTMODE"))), 1, 6))
                            pagesize = pagesize + 1
                            For I = 0 To gdataset.Tables("Kotdetails").Rows.Count - 1 Step 1
                                With gdataset.Tables("Kotdetails").Rows(I)
                                    Filewrite.Write("{0,-11}{1,-35}", "", Mid(Trim(CStr(.Item("ITEMDESC"))), 1, 35))
                                    Filewrite.Write("{0,10}", Mid(Format(Val(.Item("QTY")), "0"), 1, 10))
                                    Filewrite.Write("{0,10}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 10))
                                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                                    pagesize = pagesize + 1
                                End With
                            Next I
                            Filewrite.Write("{0,-11}", "")
                            Filewrite.WriteLine(StrDup(75, "-"))
                            pagesize = pagesize + 1
                        End If
                    End If
                Next dr
                Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "TOTAL :", Mid(Format(Val(dblItemBasic), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblItemTax), "0.00"), 1, 10), "", Mid(Format(Val(dblItemNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-11}{1,-75}", "", StrDup(75, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-25}{2,10}", "", "GROUP TOTAL:", Mid(Format(Val(dblGroupBasic), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblGroupTax), "0.00"), 1, 10), "", Mid(Format(Val(dblGroupNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-11}{1,-25}{2,10}", " ", "GRAND TOTAL ===>", Mid(Format(Val(dblGrandBasic), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,10}{1,10}{2,10}", Mid(Format(Val(dblGrandTax), "0.00"), 1, 10), "", Mid(Format(Val(dblGrandNet), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "-"))
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
    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
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
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-11}{1,-25}{2,10}{3,10}{4,10}{5,10}", "BILL", "BILL", "BASIC", PrintTaxheading1, "SERVICE", "NET")
            Filewrite.WriteLine("{0,10}{1,-2}{2,-18}{3,10}{4,-2}{5,-11}{6,-6}", "PAID", "", "RECEIPT", "BALANCE", "", "MODE OF", "SERVER")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-11}{1,-25}{2,10}{3,10}{4,10}{5,10}", "DATE", "NUMBER", "AMOUNT", PrintTaxheading2, "CHARGE", "AMOUNT")
            Filewrite.WriteLine("{0,10}{1,-2}{2,-18}{3,10}{4,-2}{5,-11}{6,-6}", "AMOUNT", "", "NUMBER", "AMOUNT", "", "PAYMENT", "CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
