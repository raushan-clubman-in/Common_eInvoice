Imports System.Data.SqlClient
Imports System.io
Public Class SalesMember
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim dblBasic, dblTax, dblNet, dblPaid, dblAmount, dblpack, dblser As Double
    Public Function Reportdetails(ByVal CONN As String, ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal COLUMNHEAD() As String, ByVal SIZE() As Integer, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING As String
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "CREDITSALEREGISTER")
            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(97, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                    End If
                    If USERNAME <> dr("mcode") Then
                        Filewrite.WriteLine("{0,-6}", Mid(CStr(dr("MCODE")), 1, 6) & " : " & Mid(dr("MNAME"), 1, 40) & Space(40 - Len(Mid(dr("MNAME"), 1, 40))))
                        pagesize = pagesize + 1
                        USERNAME = dr("MCODE")
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    Filewrite.Write(Space(7) & Mid(dr("ITEMCODE"), 1, 5) & Space(5 - Len(Mid(dr("ITEMCODE"), 1, 5))))
                    Filewrite.Write(Space(1) & Mid(dr("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(dr("ITEMDESC"), 1, 20))))
                    Filewrite.Write(Space(1) & Space(4 - Len(Mid(Format(dr("QTY"), "0"), 1, 4))) & Mid(Format(dr("QTY"), "0"), 1, 4))
                    Filewrite.Write(Space(1) & Space(6 - Len(Mid(Format(dr("RATE"), "0.00"), 1, 6))) & Mid(Format(dr("RATE"), "0.00"), 1, 6))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("TAXAMT"), "0.00"), 1, 8))) & Mid(Format(dr("TAXAMT"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("Packamount"), "0.00"), 1, 8))) & Mid(Format(dr("Packamount"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("Ser_chg"), "0.00"), 1, 8))) & Mid(Format(dr("Ser_chg"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("TOTALAMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("TOTALAMOUNT"), "0.00"), 1, 8))
                    Filewrite.WriteLine(Space(3) & Mid(dr("SCODE"), 1, 5) & Space(5 - Len(Mid(dr("SCODE"), 1, 5))))
                    dblAmount = dblAmount + Format(Val(dr("AMOUNT")), "0.00")
                    dblTax = dblTax + Format(Val(dr("TAXAMT")), "0.00")
                    dblpack = dblpack + Format(Val(dr("Packamount")), "0.00")
                    dblser = dblser + Format(Val(dr("SER_CHG")), "0.00")
                    dblNet = dblNet + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    pagesize = pagesize + 1
                Next dr
                Call grandtotal()
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
        Filewrite.WriteLine(StrDup(97, "="))
        pagesize = pagesize + 1
        Filewrite.Write(Space(16) & "Grand Total =====>" & Space(12) & Space(8 - Len(Mid(Format(Val(dblAmount), "0.00"), 1, 8))) & Mid(Format(Val(dblAmount), "0.00"), 1, 8))
        Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 8))) & Mid(Format(Val(dblTax), "0.00"), 1, 8) & Space(1) & Space(8 - Len(Mid(Format(Val(dblpack), "0.00"), 1, 8))) & Mid(Format(Val(dblpack), "0.00"), 1, 8) & Space(1) & Space(8 - Len(Mid(Format(Val(dblser), "0.00"), 1, 8))) & Mid(Format(Val(dblser), "0.00"), 1, 8) & Space(10 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNet), "0.00"), 1, 10))
        pagesize = pagesize + 1
        Filewrite.WriteLine(StrDup(97, "="))
        pagesize = pagesize + 1
    End Function
    Private Function PrintHeader(ByVal Heading() As String, ByVal colsize() As Integer, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            'If pageno <= 1 Then
            '    Filewrite.WriteLine(Chr(18) & "{0,10}{1,15}{2,10}", " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            '    pagesize = pagesize + 1
            '    Filewrite.WriteLine("{0,-30}{1,17}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", " ")
            '    pagesize = pagesize + 1
            'End If
            'Filewrite.WriteLine(Chr(18) & "{0,40}{1,-10}", "SALES SUMMARY(MEMBERWISE)", " PAGE : " & pageno)
            'pagesize = pagesize + 1
            'Filewrite.WriteLine(StrDup(97, "-"))
            'pagesize = pagesize + 1
            'Filewrite.WriteLine("MEM.   ITEM  ITEM DESCRIPTION      QTY  RATE   AMOUNT    TAX AMT  TOT AMT SCODE")
            'pagesize = pagesize + 1
            'Filewrite.WriteLine("KOTDETAILS")
            'pagesize = pagesize + 1
            'Filewrite.WriteLine(StrDup(97, "-"))
            'pagesize = pagesize + 1

            Filewrite.WriteLine("{0,-65}", Chr(14) & Chr(15) & " " & Mid(MyCompanyName, 1, 65) & Chr(18))
            Filewrite.WriteLine("{0,-80}", "SALES SUMMARY(MEMBERWISE) FROM:" & Format(mskfromdate, "dd/MM/yyyy") & " TO:" & Format(msktodate, "dd/MM/yyyy") & Space(32) & "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(97, "-"))
            Filewrite.WriteLine("MEM.   ITEM  ITEM DESCRIPTION      QTY  RATE   AMOUNT    TAX AMT  A.C-Chg  Kich-Chg  TOTAMT  SCODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine("KOTDETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(97, "-"))
            pagesize = pagesize + 1

        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
