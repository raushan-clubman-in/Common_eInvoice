Imports System.Data.SqlClient
Imports System.IO
Public Class CASHSalegROUP
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Dim dblBasic, dblTax, dblNet, dblPaid As Double
    Dim dblNBasic, dblNTax, dblNNet, dblNPaid As Double
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal columnheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, KICH_CHG, GRNKICH_CHG, GRNPACKAMT, PACKAMT, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim USERNAME, BILLNO, BILLDETAILS As String
        Dim I As Integer
        Dim STRSTRING As String
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(columnheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "CREDITSALEREGISTER")
            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                I = 0
                For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(93, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(columnheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If USERNAME <> dr("MCODE") Then
                        If Val(dblNNet) > 0 Then
                            Filewrite.WriteLine(StrDup(93, "-"))
                            Filewrite.Write(Mid(UCase(USERNAME), 1, 20) & "  Total =====> " & Space(35) & Space(10 - Len(Mid(Format(Val(dblNNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNNet), "0.00"), 1, 10))
                            Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(Val(dblNTax), "0.00"), 1, 8))) & Mid(Format(Val(dblNTax), "0.00"), 1, 8))
                            Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(Val(GRNPACKAMT), "0.00"), 1, 8))) & Mid(Format(Val(GRNPACKAMT), "0.00"), 1, 8))
                            Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(Val(KICH_CHG), "0.00"), 1, 8))) & Mid(Format(Val(KICH_CHG), "0.00"), 1, 8))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(93, "-"))
                        End If
                        Filewrite.WriteLine("{0,-6}", Mid(CStr(dr("MCODE")), 1, 6) & " : " & Mid(dr("MNAME"), 1, 40) & Space(40 - Len(Mid(dr("MNAME"), 1, 40))))
                        pagesize = pagesize + 1
                        USERNAME = dr("MCODE")
                        dblNTax = 0
                        dblNNet = 0
                        KICH_CHG = 0
                        PACKAMT = 0
                    End If

                    Filewrite.Write(Space(4) & Mid(dr("BILLDETAILS"), 1, 8) & Space(8 - Len(Mid(dr("BILLDETAILS"), 1, 8))))
                    Filewrite.Write(Space(1) & Mid(dr("ITEMCODE"), 1, 5) & Space(5 - Len(Mid(dr("ITEMCODE"), 1, 5))))
                    Filewrite.Write(Space(1) & Mid(dr("ITEMDESC"), 1, 20) & Space(20 - Len(Mid(dr("ITEMDESC"), 1, 20))))
                    Filewrite.Write(Space(2) & Space(5 - Len(Mid(Format(dr("QTY"), "0"), 1, 5))) & Mid(Format(dr("QTY"), "0"), 1, 5))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("RATE"), "0.00"), 1, 8))) & Mid(Format(dr("RATE"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("AMOUNT"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("TAXAMOUNT"), "0.00"), 1, 8))) & Mid(Format(dr("TAXAMOUNT"), "0.00"), 1, 8))
                    Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(dr("PACKAMOUNT"), "0.00"), 1, 6))) & Mid(Format(dr("PACKAMOUNT"), "0.00"), 1, 6))
                    Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(dr("ser_chg"), "0.00"), 1, 6))) & Mid(Format(dr("ser_chg"), "0.00"), 1, 6))
                    'Filewrite.WriteLine(Space(1) & Mid(dr("SCODE"), 1, 5) & Space(5 - Len(Mid(dr("SCODE"), 1, 5))))

                    dblTax = dblTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    PACKAMT = PACKAMT + Format(Val(dr("PACKAMOUNT")), "0.00")
                    KICH_CHG = KICH_CHG + Format(Val(dr("SER_CHG")), "0.00")

                    GRNPACKAMT = GRNPACKAMT + Format(Val(dr("PACKAMOUNT")), "0.00")
                    GRNKICH_CHG = GRNKICH_CHG + Format(Val(dr("SER_CHG")), "0.00")


                    dblNet = dblNet + Format(Val(dr("AMOUNT")), "0.00")
                    dblNTax = dblNTax + Format(Val(dr("TAXAMOUNT")), "0.00")
                    dblNNet = dblNNet + Format(Val(dr("AMOUNT")), "0.00")
                    pagesize = pagesize + 1
                Next dr
                Filewrite.WriteLine(StrDup(93, "="))
                pagesize = pagesize + 1
                Filewrite.Write(Mid(UCase(USERNAME), 1, 20) & "  Total =====>" & Space(35) & Space(10 - Len(Mid(Format(Val(dblNNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNNet), "0.00"), 1, 10))
                Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(Val(dblNTax), "0.00"), 1, 8))) & Mid(Format(Val(dblNTax), "0.00"), 1, 8))
                Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(Val(PACKAMT), "0.00"), 1, 8))) & Mid(Format(Val(PACKAMT), "0.00"), 1, 8))
                Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(Val(KICH_CHG), "0.00"), 1, 8))) & Mid(Format(Val(KICH_CHG), "0.00"), 1, 8))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(93, "="))
                pagesize = pagesize + 1
                ''Call grandtotal()

                Filewrite.Write(Space(5) & " Grand Total =====>" & Space(29) & Space(10 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNet), "0.00"), 1, 10))
                Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 8))) & Mid(Format(Val(dblTax), "0.00"), 1, 8))
                Filewrite.Write(Space(1) & Space(8 - Len(Mid(Format(Val(GRNPACKAMT), "0.00"), 1, 8))) & Mid(Format(Val(GRNPACKAMT), "0.00"), 1, 8))
                Filewrite.WriteLine(Space(1) & Space(8 - Len(Mid(Format(Val(GRNKICH_CHG), "0.00"), 1, 8))) & Mid(Format(Val(GRNKICH_CHG), "0.00"), 1, 8))
                Filewrite.WriteLine(StrDup(93, "="))



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




        Filewrite.WriteLine(StrDup(93, "="))
        pagesize = pagesize + 1
        Filewrite.WriteLine(Space(16) & "Grand Total =====>" & Space(20) & Space(10 - Len(Mid(Format(Val(dblNet), "0.00"), 1, 10))) & Mid(Format(Val(dblNet), "0.00"), 1, 10) & Space(1) & Space(8 - Len(Mid(Format(Val(dblTax), "0.00"), 1, 8))) & Mid(Format(Val(dblTax), "0.00"), 1, 8))
        pagesize = pagesize + 1
        Filewrite.WriteLine(StrDup(93, "="))
        pagesize = pagesize + 1
    End Function
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.WriteLine(Mid(MyCompanyName, 1, 50))
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine("CASH SALES REGISTER FROM :" & Format(mskfromdate, "dd/MM/yyyy") & " " & "To" & " " & Format(msktodate, "dd/MM/yyyy") & Space(20) & "Pageno:" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(93, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("MEM. KOT     ITEM   ITEM DESCRIPTION       QTY    RATE    AMOUNT    TAX     AC_CHG  KICH_CHG")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(93, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
