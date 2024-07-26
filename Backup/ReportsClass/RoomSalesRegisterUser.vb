Imports System.Data.SqlClient
Imports System.io
Public Class RoomSalesRegisterUser
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim dblBasic, dblTax, dblNet, dblPaid As Double
    Dim dblCBasic, dblCTax, dblCNet, dblCPaid As Double
    Public Function Reportdetails(ByVal CONN As String, ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal COLUMNHEAD() As String, ByVal SIZE() As Integer, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim USERNAME, BILLNO, STRSTRING, BILLDETAILS As String
        Dim I, CHKID As Integer
        CHKID = 0
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            gconnection.getDataSet(SQLSTRING, "CASHSALEREGISTER")
            If gdataset.Tables("CASHSALEREGISTER").Rows.Count > 0 Then
                printfile = VFilePath
                pageno = 1
                Filewrite.Write(Chr(15))
                Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("CASHSALEREGISTER").Rows
                    If pagesize > 56 Then
                        Filewrite.WriteLine(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If BILLDETAILS <> dr("BILLDETAILS") Then
                        BILLDETAILS = dr("BILLDETAILS")
                    End If
                    'If USERNAME <> dr("roomno") Then
                    'STRSTRING = ""
                    'Filewrite.WriteLine()
                    ' pagesize = pagesize + 1
                    ' STRSTRING = "ROOM NO: " & Mid(CStr(dr("roomno")), 1, 10) & Space(10 - Len(Mid(dr("roomno"), 1, 10))) & " : " & Mid(dr("MNAME"), 1, 40) & Space(40 - Len(Mid(dr("MNAME"), 1, 40)))
                    ' USERNAME = dr("roomno")
                    ' Filewrite.WriteLine(STRSTRING)
                    ' pagesize = pagesize + 1
                    ' Filewrite.WriteLine()
                    ' pagesize = pagesize + 1
                    '  End If

                    ' If CHKID <> dr("CHKID") Then
                    'If CHKID <> 0 Then
                    'Filewrite.WriteLine(Space(60) & StrDup(12, "-"))
                    'pagesize = pagesize + 1
                    'STRSTRING = Space(60) & Space(12 - Len(Mid(Format(dblCNet, "0.00"), 1, 12))) & Mid(Format(dblCNet, "0.00"), 1, 12)
                    'Filewrite.WriteLine(STRSTRING)
                    'pagesize = pagesize + 1
                    'Filewrite.WriteLine(Space(60) & StrDup(12, "-"))
                    'pagesize = pagesize + 1
                    'dblCTax = 0
                    'dblCNet = 0
                    'End If
                    'Filewrite.WriteLine("CHKIN ID:" & Space(2) & CStr(dr("CHKID")))
                    'pagesize = pagesize + 1
                    'CHKID = dr("CHKID")
                    'End If
                    If BILLNO <> dr("BILLNO") Then
                        Filewrite.WriteLine("{0,-10}", Mid(CStr(dr("BILLNO")), 1, 10))
                        pagesize = pagesize + 1
                        BILLNO = dr("BILLNO")
                    End If

                    Filewrite.Write(Space(6) & Mid(dr("ITEMCODE"), 1, 5) & Space(5 - Len(Mid(dr("ITEMCODE"), 1, 5))))
                    Filewrite.Write(Space(1) & Mid(dr("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(dr("ITEMDESC"), 1, 20))))
                    Filewrite.Write(Space(1) & Mid(Format(dr("QTY"), "0"), 1, 5) & Space(5 - Len(Mid(Format(dr("QTY"), "0"), 1, 5))))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("RATE"), "0.00"), 1, 8))) & Mid(Format(dr("RATE"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(6 - Len(Mid(Format(dr("TAXAMOUNT"), "0.00"), 1, 6))) & Mid(Format(dr("TAXAMOUNT"), "0.00"), 1, 6))
                    Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(dr("TOTALAMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("TOTALAMOUNT"), "0.00"), 1, 8))
                    'Filewrite.Write(Space(1) & Mid(dr("SCODE"), 1, 5) & Space(5 - Len(Mid(dr("SCODE"), 1, 5))))
                    'Filewrite.WriteLine(Space(1) & Mid(dr("POSCODE"), 1, 3) & Space(5 - Len(Mid(dr("POSCODE"), 1, 3))))

                    dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    dblNet = dblNet + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    dblCTax = dblCTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    dblCNet = dblCNet + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    pagesize = pagesize + 1
                Next dr
                If CHKID <> 0 Then
                    Filewrite.WriteLine(Space(60) & StrDup(12, "-"))
                    pagesize = pagesize + 1
                    STRSTRING = Space(60) & Space(12 - Len(Mid(Format(dblCNet, "0.00"), 1, 12))) & Mid(Format(dblCNet, "0.00"), 1, 12)
                    Filewrite.WriteLine(STRSTRING)
                    pagesize = pagesize + 1
                    Filewrite.WriteLine(Space(60) & StrDup(12, "-"))
                    pagesize = pagesize + 1
                    dblCTax = 0
                    dblCNet = 0
                End If

                If pagesize > 56 Then
                    Filewrite.WriteLine(StrDup(75, "-"))
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    Call PrintHeader(PAGEHEAD, SIZE, FROMDATE, TODATE)
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                End If

                Call GRANDTOTAL()
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
    Private Function GRANDTOTAL()
        Filewrite.WriteLine(StrDup(75, "="))
        pagesize = pagesize + 1
        Filewrite.WriteLine(Space(13) & "Grand Total =====>" & Space(24) & Space(7 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 7))) & Mid(Format(Val(dblTax), "0.00"), 1, 8) & Space(0) & Space(10 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNet), "0.00"), 1, 10))
        pagesize = pagesize + 1
        Filewrite.WriteLine(StrDup(75, "="))
        pagesize = pagesize + 1
    End Function
    Private Function PrintHeader(ByVal Heading() As String, ByVal colsize() As Integer, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            If pageno <= 1 Then
                Filewrite.WriteLine("{0,10}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-30}{1,17}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine("{0,30}{1,-10}", "ROOM SALES  (USERWISE)", " PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(18) & StrDup(75, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("ROOM  ITEM   ITEM DESCRIPTION   QTY       RATE   AMOUNT   TAX     TOTAL ")
            pagesize = pagesize + 1
            Filewrite.WriteLine("CODE  CODE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(75, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
