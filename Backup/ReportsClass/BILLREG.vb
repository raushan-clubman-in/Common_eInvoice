Imports System.Data.SqlClient
Imports System.IO
Public Class BILLREG
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim dblBasic, dblTax, dblNet, dblPaid As Double
    Dim dblNBasic, dblNTax, dblNNet, dblNPaid As Double
    Public Function Reportdetails(ByVal PAYTYPE As String, ByVal POSDESC1 As String, ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal columnheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc, server_name, server_code As String
        Dim Memberbool, POSbool As Boolean
        Dim SAMT As Double
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I, SNO As Integer
        Dim STRSTRING As String
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Call PrintHeader(PAYTYPE, POSDESC1, columnheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "CREDITSALEREGISTER")
            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                pagesize = pagesize + 1
                I = 0
                dblNet = 0
                SNO = 1
                server_code = gdataset.Tables("CREDITSALEREGISTER").Rows(0).Item("scode")
                server_name = gdataset.Tables("CREDITSALEREGISTER").Rows(0).Item("sname")
                SAMT = 0
                For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
                        'Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAYTYPE, POSDESC1, columnheading, mskfromdate, msktodate)
                        pagesize = pagesize + 1
                    End If
                    If server_code <> dr("scode") Then
                        Filewrite.WriteLine(StrDup(80, "-"))
                        Filewrite.Write("|" & Space(5))
                        Filewrite.Write("{0,-36}", server_name)
                        Filewrite.Write("|")
                        Filewrite.Write("{0,8}", Format(SAMT, "0.00"))
                        Filewrite.WriteLine("|")
                        Filewrite.WriteLine(StrDup(80, "-"))
                        SAMT = 0
                        SNO = 1
                        server_code = dr("scode")
                        server_name = dr("sNAME")
                    End If

                    Filewrite.Write("|" & Mid(Str(SNO) & ".", 1, 5) & Space(5 - Len(Mid(Str(SNO) & ".", 1, 5))))
                    Filewrite.Write("|" & Mid(dr("BILLDETAILS"), 1, 17) & Space(17 - Len(Mid(dr("BILLDETAILS"), 1, 17))))
                    Filewrite.Write("|" & Mid(Trim(Format(dr("BILLDATE"), "dd/MM/yyyy")), 1, 10), Space(10 - Len(Mid(Trim(Format(dr("BILLDATE"), "dd/MM/yyyy")), 1, 10))))
                    Filewrite.Write("|" & Mid(dr("MCODE"), 1, 6) & Space(6 - Len(Mid(dr("MCODE"), 1, 6))))
                    Filewrite.Write("|" & Space(8 - Len(Mid(Format(dr("TOTALAMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("TOTALAMOUNT"), "0.00"), 1, 8))
                    Filewrite.Write("|" & Mid(dr("PAYMENTMODE"), 1, 6) & Space(6 - Len(Mid(dr("PAYMENTMODE"), 1, 6))) & "|")
                    Filewrite.WriteLine(Mid(dr("REMARKS"), 1, 20) & Space(20 - Len(Mid(dr("REMARKS"), 1, 20))) & "|")

                    'If Format(dr("CRODATE"), "dd/MM/yyyy") <> "01/01/1900" Then
                    '    Filewrite.Write(Mid(Trim(Format(dr("CRODATE"), "dd/MM/yyyy")), 1, 10), Space(10 - Len(Mid(Trim(Format(dr("CRODATE"), "dd/MM/yyyy")), 1, 10))))
                    '    Filewrite.WriteLine("|")
                    'Else
                    '    Filewrite.WriteLine(Space(10) & "|")
                    'End If

                    dblNet = dblNet + Format(Val(dr("TOTALAMOUNT")), "0.00")
                    pagesize = pagesize + 1
                    SNO = SNO + 1
                    SAMT = SAMT + Format(dr("TOTALAMOUNT"), "0.00")
                Next dr
                Filewrite.WriteLine(StrDup(80, "-"))
                Filewrite.Write("|" & Space(5))
                Filewrite.Write("{0,-36}", server_name)
                Filewrite.Write("|")
                Filewrite.Write("{0,8}", Format(SAMT, "0.00"))
                Filewrite.WriteLine("|")
                Filewrite.WriteLine(StrDup(80, "="))

                pagesize = pagesize + 1
                Filewrite.WriteLine(Mid(UCase(USERNAME), 1, 20) & "  Total =====>" & Space(29) & Space(8 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 8))) & Mid(Format(Val(dblNet), "0.00"), 1, 8) & "|")
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(80, "="))
                pagesize = pagesize + 1
                'Call grandtotal()
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
        Filewrite.WriteLine(StrDup(89, "="))
        pagesize = pagesize + 1
        Filewrite.WriteLine(Space(16) & "Grand Total =====>" & Space(20) & Space(10 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNet), "0.00"), 1, 10) & Space(1) & Space(8 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 8))) & Mid(Format(Val(dblTax), "0.00"), 1, 8))
        pagesize = pagesize + 1
        Filewrite.WriteLine(StrDup(89, "="))
        pagesize = pagesize + 1
    End Function
    Private Function PrintHeader(ByVal PAYTYPE As String, ByVal POSDESC As String, ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            pagesize = pagesize + 1
            Filewrite.WriteLine(MyCompanyName)
            Filewrite.WriteLine(Heading(0) & " From :" & Format(mskfromdate, "dd/MM/yyyy") & "TO :" & Format(msktodate, "dd/MM/yyyy") & Space(15) & "PAGE NO:" & pageno)
            'pagesize = pagesize + 1
            'Filewrite.WriteLine("PAYMENT TYPE=" & PAYTYPE)
            pagesize = pagesize + 1
            Filewrite.WriteLine("LOCATION=" & Mid(POSDESC, 1, 70))
            pagesize = pagesize + 1
            If Mid(POSDESC, 71, 70) <> "" Then
                Filewrite.WriteLine("LOCATION=" & Mid(POSDESC, 71, 70))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine("{0,19}{1,-10}", "", PAYTYPE)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(80, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("SNO   |BILLNO           | BILLDATE |MCODE |B.AMOUNT|P.TYPE |REMARKS            |")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(80, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
