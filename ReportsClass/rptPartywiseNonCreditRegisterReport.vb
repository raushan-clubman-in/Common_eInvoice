''Done by ALOKESH 20.08.2008
''==========================
Imports System.Data.SqlClient
Imports System.IO
Public Class rptPartywiseNonCreditRegisterReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal SQLSTRING2 As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim J, I, POSCOUNT, POSGRAND, POSTOTAL, docCount As Integer
        Dim POSDAYTOTAL, MEMBERTOTAL, GRANDTOTAL As Double
        Dim POSDESC, MEMBERCODE As String
        Dim POSBOOL, MEMBERBOOL As Boolean
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call ReportHeader(PAGEHEADER, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "NONCREDITREGISTERPARTYWISE")
            If gdataset.Tables("NONCREDITREGISTERPARTYWISE").Rows.Count > 0 Then
                gconnection.getDataSet(SQLSTRING2, "COUNT")
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("NONCREDITREGISTERPARTYWISE").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(PAGEHEADER, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If MEMBERCODE <> Trim(CStr(dr("MCODE"))) Then
                        If MEMBERBOOL = True Then
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(gdataset.Tables("COUNT").Rows(I).Item(0), "0"), "Member Total =====>", Format(Math.Round(Val(MEMBERTOTAL)), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 30) & "-" & Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-17}{1,-20}", "Contact Address. :", Mid(Trim(CStr(dr("ADDRESS1"))), 1, 30))
                            If Trim(CStr(dr("ADDRESS2"))) <> "" Then
                                Filewrite.WriteLine("{0,-20}", Mid(Trim(CStr(dr("ADDRESS2"))), 1, 30))
                                pagesize = pagesize + 1
                            Else
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine("{0,-18}{1,-20}", "", Mid(Trim(CStr(dr("STATE"))), 1, 15))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-18}{1,-20}", "", "Pin No. :" & Mid(Trim(CStr(dr("PINNO"))), 1, 10))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-18}{1,-20}", "", "Telephone No. :" & Mid(Trim(CStr(dr("PHONENO"))), 1, 15))
                            pagesize = pagesize + 1
                            MEMBERCODE = Trim(CStr(dr("MCODE")))
                            pagesize = pagesize + 1
                            POSCOUNT = 0
                            MEMBERTOTAL = 0
                            POSDESC = ""
                            POSBOOL = False
                            docCount = docCount + Val(gdataset.Tables("COUNT").Rows(I).Item(0))
                            I = I + 1
                        Else
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("MNAME"))), 1, 30) & "-" & Mid(Trim(CStr(dr("MCODE"))), 1, 10))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-17}{1,-20}", "Contact Address. :", Mid(Trim(CStr(dr("ADDRESS1"))), 1, 30))
                            If Trim(CStr(dr("ADDRESS2"))) <> "" Then
                                Filewrite.WriteLine("{0,-20}", Mid(Trim(CStr(dr("ADDRESS2"))), 1, 30))
                                pagesize = pagesize + 1
                            Else
                                Filewrite.WriteLine()
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine("{0,-18}{1,-20}", "", Mid(Trim(CStr(dr("STATE"))), 1, 15))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-18}{1,-20}", "", "Pin No. :" & Mid(Trim(CStr(dr("PINNO"))), 1, 10))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-18}{1,-20}", "", "Telephone No. :" & Mid(Trim(CStr(dr("PHONENO"))), 1, 15))
                            pagesize = pagesize + 1
                            MEMBERCODE = Trim(CStr(dr("MCODE")))
                            pagesize = pagesize + 1
                            POSCOUNT = 0
                            MEMBERBOOL = True
                            POSDESC = ""
                            POSBOOL = False
                        End If
                    End If
                    If POSDESC <> Trim(CStr(dr("POSDESC"))) Then
                        If POSBOOL = True Then
                            Filewrite.Write("{0,-5}", "")
                            Filewrite.Write("{0,-15}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("POSDESC"))), 1, 15))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            POSDESC = Trim(CStr(dr("POSDESC")))
                            POSCOUNT = POSCOUNT + 1
                            POSGRAND = POSGRAND + 1
                            POSDAYTOTAL = 0
                        Else
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-5}", "")
                            Filewrite.Write("{0,-15}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("POSDESC"))), 1, 15))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            POSDESC = Trim(CStr(dr("POSDESC")))
                            POSCOUNT = POSCOUNT + 1
                            POSGRAND = POSGRAND + 1
                            POSBOOL = True
                        End If
                    End If
                    Filewrite.Write("{0,-20}{1,-12}", "", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                    Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLDETAILS"))), 1, 20))
                    Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("SERVERCODE"))), 1, 18))
                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 8))
                    POSDAYTOTAL = POSDAYTOTAL + Format(Val(dr("AMOUNT")), "0.00")
                    MEMBERTOTAL = MEMBERTOTAL + Format(Val(dr("AMOUNT")), "0.00")
                    GRANDTOTAL = GRANDTOTAL + Format(Val(dr("AMOUNT")), "0.00")
                    pagesize = pagesize + 1
                Next dr


                '''**************************************** PRINT TOTAL DOCUMENT  ************************************************'''
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(gdataset.Tables("COUNT").Rows(I).Item(0), "0"), "Member Total =====>", Format(Math.Round(Val(MEMBERTOTAL)), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                docCount = docCount + Val(gdataset.Tables("COUNT").Rows(I).Item(0))
                '''**************************************** COMPLETE  TOTAL DOCUMENT   ************************************************'''
                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(docCount), "0"), "Grand Total =====>", Format(Math.Round(Val(GRANDTOTAL)), "0.00"))
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
    Private Function ReportHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
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
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
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
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
