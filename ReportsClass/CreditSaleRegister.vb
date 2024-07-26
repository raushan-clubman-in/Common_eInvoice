Imports System.Data.SqlClient
Imports System.IO
Public Class CreditSaleRegister
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow

    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal columnheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, doccount, gdoccount, POSGrand, POStotal, POSGrandtotal As Double
        Dim Membername, Posdesc As String
        Dim Memberbool, POSbool As Boolean
        Dim I As Integer
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
            gconnection.getDataSet(SQLSTRING2, "DOCCOUNT")

            If gdataset.Tables("CREDITSALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                I = 0
                For Each dr In gdataset.Tables("CREDITSALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(columnheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If Membername <> Trim(CStr(dr("MNAME"))) Then
                        If Memberbool = True Then
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            'Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(doccount), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                            '''''Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(gdataset.Tables("DOCCOUNT").Rows(I).Item(0)), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                            If I >= gdataset.Tables("doccount").Rows.Count Then
                                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(gdataset.Tables("DOCCOUNT").Rows(gdataset.Tables("doccount").Rows.Count - 1).Item(0)), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                            Else
                                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(gdataset.Tables("DOCCOUNT").Rows(I).Item(0)), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                            End If
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 60) & "-" & Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Membername = Trim(CStr(dr("MNAME")))
                            pagesize = pagesize + 1
                            POSCount = 0
                            POStotal = 0
                            doccount = 0
                            Posdesc = ""
                            If I >= gdataset.Tables("doccount").Rows.Count Then
                                gdoccount = gdoccount + Val(gdataset.Tables("DOCCOUNT").Rows(gdataset.Tables("doccount").Rows.Count - 1).Item(0))
                            Else
                                gdoccount = gdoccount + Val(gdataset.Tables("DOCCOUNT").Rows(I).Item(0))
                            End If
                            I = I + 1
                        Else
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 60) & "-" & Mid(Trim(CStr(dr("MCODE"))), 1, 5))
                                Filewrite.WriteLine(Chr(18))
                                pagesize = pagesize + 1
                                Membername = Trim(CStr(dr("MNAME")))
                                pagesize = pagesize + 1
                                Memberbool = True
                                POSCount = 0
                                POStotal = 0
                            End If
                        End If
                    If Posdesc <> Trim(CStr(dr("POSDESC"))) Then
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        Filewrite.Write("{0,-5}", "")
                        Filewrite.Write("{0,-15}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("POSDESC"))), 1, 15))
                        Filewrite.WriteLine(Chr(18))
                        pagesize = pagesize + 1
                        Posdesc = Trim(CStr(dr("POSDESC")))
                        POSCount = POSCount + 1
                        POSGrand = POSGrand + 1
                    End If
                    Filewrite.Write("{0,-20}{1,-12}", "", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLNO"))), 1, 20))
                    Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("SCODE"))), 1, 18))
                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 8))
                    pagesize = pagesize + 1
                    POStotal = POStotal + Format(Val(dr("AMOUNT")), "0.00")
                    POSGrandtotal = POSGrandtotal + Format(Val(dr("AMOUNT")), "0.00")
                    'gdoccount = gdoccount + 1
                    doccount = doccount + 1
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                If I >= gdataset.Tables("doccount").Rows.Count Then
                    Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(gdataset.Tables("DOCCOUNT").Rows(gdataset.Tables("doccount").Rows.Count - 1).Item(0)), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                Else
                    Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(gdataset.Tables("DOCCOUNT").Rows(I).Item(0)), "0"), "Member Total =====>", Format(Val(POStotal), "0.00"))
                End If
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                If I >= gdataset.Tables("doccount").Rows.Count Then
                    gdoccount = gdoccount + Val(gdataset.Tables("DOCCOUNT").Rows(gdataset.Tables("doccount").Rows.Count - 1).Item(0))

                Else
                    gdoccount = gdoccount + Val(gdataset.Tables("DOCCOUNT").Rows(I).Item(0))
                End If

                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(gdoccount), "0"), "Grand Total =====>", Format(Val(POSGrandtotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
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
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-12}{2,-20}{3,-15}{4,10}", "MEMBER/", "BILL", "BILL", "SERVER", "NET")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-12}{2,-20}{3,-15}{4,10}", "LOCATION", "DATE", "NUMBER", "CODE", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
