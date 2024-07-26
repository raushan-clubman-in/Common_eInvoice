Imports System.Data.SqlClient
Imports System.IO
Public Class SalesChecklist1
    Dim dr As DataRow
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim rowcount, rowtotal
    Dim dblBasic, dblTax, dblNet, dblPaid, dblpack, dblserchg, Total As Double
    Dim dblUBasic, dblUTax, dblUNet, dblUPaid As Double
    Dim dblUroff As Double
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal RSNO As Integer, ByVal frm As Object)
        Dim docdate, changeno, billsdetails, servercode, billamount, totalamount, POSCode, dblBasicamt, dblnetamt As String
        Dim amount, basic, discountamount, i As Integer
        Dim GrandQty, GrandAmount, ROUNDOFF, grndpack, grndserchg As Double
        'Dim OBJ As New SalesBillChecklist1
        Dim SSQL As String
        Dim USERNAME, BILLNO, STRSTRING, BILLDETAILS, MNAME, sqlstr, sqlstr1 As String
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "SALEBILLCHECKLIST")
            rowtotal = gdataset.Tables("SALEBILLCHECKLIST").Rows.Count
            rowcount = 100 / rowtotal
            If gdataset.Tables("SALEBILLCHECKLIST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                basic = 0
                amount = 0
                ROUNDOFF = 0
                For Each dr In gdataset.Tables("SALEBILLCHECKLIST").Rows
                    If pagesize > 56 Then
                        Filewrite.WriteLine(StrDup(165, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(pageheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    'If POSCode <> dr("POSDESC") Then
                    '    Filewrite.WriteLine()
                    '    pagesize = pagesize + 1
                    '    Filewrite.WriteLine("{0,-30}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 25) & ":")
                    '    pagesize = pagesize + 1
                    '    POSCode = dr("POSDESC")
                    'End If
                    'SHAN
                    If billsdetails <> Trim(dr("BILLDETAILS")) Then
                        Filewrite.Write("{0,-12}", Mid(Format(dr("BILLDATE"), "dd/MM/yyyy"), 1, 10) & Space(10 - Len(Mid(Format(dr("BILLDATE"), "dd/MM/yyyy"), 1, 10))))
                        Filewrite.Write("{0,-17}", Mid(CStr(dr("BILLDETAILS")), 1, 17) & Space(17 - Len(Mid(CStr(dr("BILLDETAILS")), 1, 17))))
                        Filewrite.Write("{0,-9}", Mid(CStr(dr("KOTDETAILS")), 1, 9) & Space(9 - Len(Mid(CStr(dr("KOTDETAILS")), 1, 9))))
                        Filewrite.Write("{0,-6}", Mid(CStr(dr("SERVERCODE")), 1, 6) & Space(6 - Len(Mid(CStr(dr("SERVERCODE")), 1, 6))))
                        Filewrite.Write("{0,-8}", Mid(CStr(dr("MCODE")), 1, 8) & Space(8 - Len(Mid(CStr(dr("MCODE")), 1, 8))))
                        Filewrite.Write("{0,-10}", Mid(CStr(dr("ITEMCODE")), 1, 8) & Space(8 - Len(Mid(CStr(dr("ITEMCODE")), 1, 8))))
                        Filewrite.Write("{0,-25}", Mid(CStr(dr("ITEMDESC")), 1, 25) & Space(25 - Len(Mid(CStr(dr("ITEMDESC")), 1, 25))))
                        Filewrite.Write("{0,8}", Space(8 - Len(Mid(Format(Val(dr("QTY")), "0"), 1, 8))) & Mid(Format(Val(dr("QTY")), "0"), 1, 8))
                        Filewrite.Write("{0,8}", Space(8 - Len(Mid(Format(Val(dr("RATE")), "0.00"), 1, 8))) & Mid(Format(Val(dr("RATE")), "0.00"), 1, 8))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("packamount")), "0.00"), 1, 10))) & Mid(Format(Val(dr("packamount")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("ser_chg")), "0.00"), 1, 10))) & Mid(Format(Val(dr("ser_chg")), "0.00"), 1, 10))
                        gconnection.getDataSet("SELECT  roundoff FROM view_bill_roundoff where billdetails='" & Trim(dr("BILLDETAILS")) & "'", "roundoff")
                        If gdataset.Tables("roundoff").Rows.Count > 0 Then
                            Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(gdataset.Tables("roundoff").Rows(0).Item("roundoff")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("roundoff").Rows(0).Item("roundoff")), "0.00"), 1, 10))
                            ROUNDOFF = ROUNDOFF + gdataset.Tables("roundoff").Rows(0).Item("roundoff")
                        Else
                            Filewrite.Write("{0,10}", "")
                        End If
                        Filewrite.WriteLine("{0,10}", Space(10 - Len(Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        billsdetails = Trim(dr("BILLDETAILS"))
                    Else
                        Filewrite.Write("{0,-12}", Mid(Format(dr("BILLDATE"), "dd/MM/yyyy"), 1, 10) & Space(10 - Len(Mid(Format(dr("BILLDATE"), "dd/MM/yyyy"), 1, 10))))
                        Filewrite.Write("{0,-17}", Mid(CStr(dr("BILLDETAILS")), 1, 17) & Space(17 - Len(Mid(CStr(dr("BILLDETAILS")), 1, 17))))
                        Filewrite.Write("{0,-9}", Mid(CStr(dr("KOTDETAILS")), 1, 9) & Space(9 - Len(Mid(CStr(dr("KOTDETAILS")), 1, 9))))
                        Filewrite.Write("{0,-6}", Mid(CStr(dr("SERVERCODE")), 1, 6) & Space(6 - Len(Mid(CStr(dr("SERVERCODE")), 1, 6))))
                        Filewrite.Write("{0,-8}", Mid(CStr(dr("MCODE")), 1, 8) & Space(8 - Len(Mid(CStr(dr("MCODE")), 1, 8))))
                        Filewrite.Write("{0,-10}", Mid(CStr(dr("ITEMCODE")), 1, 8) & Space(8 - Len(Mid(CStr(dr("ITEMCODE")), 1, 8))))
                        Filewrite.Write("{0,-25}", Mid(CStr(dr("ITEMDESC")), 1, 25) & Space(25 - Len(Mid(CStr(dr("ITEMDESC")), 1, 25))))
                        Filewrite.Write("{0,8}", Space(8 - Len(Mid(Format(Val(dr("QTY")), "0"), 1, 8))) & Mid(Format(Val(dr("QTY")), "0"), 1, 8))
                        Filewrite.Write("{0,8}", Space(8 - Len(Mid(Format(Val(dr("RATE")), "0.00"), 1, 8))) & Mid(Format(Val(dr("RATE")), "0.00"), 1, 8))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("packamount")), "0.00"), 1, 10))) & Mid(Format(Val(dr("packamount")), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(dr("ser_chg")), "0.00"), 1, 10))) & Mid(Format(Val(dr("ser_chg")), "0.00"), 1, 10))
                        'If gdataset.Tables("roundoff").Rows.Count > 0 Then
                        '        Filewrite.Write("{0,10}", Space(10 - Len(Mid(Format(Val(gdataset.Tables("roundoff").Rows(0).Item("roundoff")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("roundoff").Rows(0).Item("roundoff")), "0.00"), 1, 10))
                        '        ROUNDOFF = ROUNDOFF + gdataset.Tables("roundoff").Rows(0).Item("roundoff")
                        'Else
                        Filewrite.Write("{0,10}", "")
                        'End If
                        Filewrite.WriteLine("{0,10}", Space(10 - Len(Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 10))) & Mid(Format(Val(dr("TOTALAMOUNT")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        billsdetails = Trim(dr("BILLDETAILS"))
                    End If

                    dblnetamt = Val(dblnetamt) + dr("TOTALAMOUNT")
                    dblBasicamt = Val(dblBasicamt) + dr("AMOUNT")
                    dblTax = Val(dblTax) + dr("TAXAMOUNT")
                    dblpack = Val(dblpack) + dr("packamount")
                    dblserchg = Val(dblserchg) + dr("ser_chg")
                    grndpack = Val(grndpack) + dr("packamount")
                    grndpack = Val(grndpack) + dr("ser_chg")

                    GrandAmount = GrandAmount + Format(Val(dr("AMOUNT")), "0.00")
                    GrandQty = GrandQty + Format(Val(dr("QTY")), "0.00")

                Next dr
                'LOCATION TOTAL
                Filewrite.WriteLine(StrDup(165, "-"))
                pagesize = pagesize + 1
                Filewrite.Write(Space(66) & "GRAND TOTAL ====>")
                Filewrite.Write(Space(6 - Len(Mid(Format(Val(GrandQty), "0"), 1, 6))) & Mid(Format(Val(GrandQty), "0"), 1, 6))
                Filewrite.Write(Space(14) & Space(10 - Len(Mid(Format(Val(dblBasicamt), "0.00"), 1, 10))) & Mid(Format(Val(dblBasicamt), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 10))) & Mid(Format(Val(dblTax), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(dblpack), "0.00"), 1, 10))) & Mid(Format(Val(dblpack), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(dblserchg), "0.00"), 1, 10))) & Mid(Format(Val(dblserchg), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(ROUNDOFF), "0.00"), 1, 10))) & Mid(Format(Val(ROUNDOFF), "0.00"), 1, 10))
                Filewrite.WriteLine(Space(10 - Len(Mid(Format(Val(dblnetamt) + Val(ROUNDOFF), "0.00"), 1, 10))) & Mid(Format(Val(dblnetamt) + Val(ROUNDOFF), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(165, "-"))
                pagesize = pagesize + 1

                'GRAND TOTAL
                Filewrite.WriteLine(StrDup(165, "-"))
                pagesize = pagesize + 1
                Filewrite.Write(Space(66) & "GRAND TOTAL ====>")
                Filewrite.Write(Space(6 - Len(Mid(Format(Val(GrandQty), "0"), 1, 6))) & Mid(Format(Val(GrandQty), "0"), 1, 6))
                Filewrite.Write(Space(14) & Space(10 - Len(Mid(Format(Val(dblBasicamt), "0.00"), 1, 10))) & Mid(Format(Val(dblBasicamt), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 10))) & Mid(Format(Val(dblTax), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(dblpack), "0.00"), 1, 10))) & Mid(Format(Val(dblpack), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(dblserchg), "0.00"), 1, 10))) & Mid(Format(Val(dblserchg), "0.00"), 1, 10))
                Filewrite.Write(Space(10 - Len(Mid(Format(Val(ROUNDOFF), "0.00"), 1, 10))) & Mid(Format(Val(ROUNDOFF), "0.00"), 1, 10))
                Filewrite.WriteLine(Space(10 - Len(Mid(Format(Val(dblnetamt) + Val(ROUNDOFF), "0.00"), 1, 10))) & Mid(Format(Val(dblnetamt) + Val(ROUNDOFF), "0.00"), 1, 10))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(165, "-"))
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
            Filewrite.WriteLine(StrDup(165, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("BILL        BILL            KOTNO     USER  MCODE   ITEM      ITEM                          QTY   RATE    AMOUNT       TAX     AC.CHG  KICH.CHG  ROUNDOFF  TOTAL")
            pagesize = pagesize + 1
            Filewrite.WriteLine("DATE         N0              NO       CODE  CODE    CODE      DESCRIPTION                                             AMOUNT   AMOUNT  AMOUNT    AMOUNT    AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(165, "-"))
            'Filewrite.WriteLine(StrDup(130, "-"))
            'pagesize = pagesize + 1
            'Filewrite.WriteLine("BILL        BILL                USER  MCODE   ITEM      ITEM                          QTY   RATE    AMOUNT       TAX     TOTAL")
            'pagesize = pagesize + 1
            'Filewrite.WriteLine("DATE        NUMBER              CODE  CODE    CODE      DESCRIPTION                                             AMOUNT   AMOUNT")
            'pagesize = pagesize + 1
            'Filewrite.WriteLine(StrDup(130, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
