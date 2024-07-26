Imports System.Data.SqlClient
Imports System.io
Public Class rptRoomwisesaleregister
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim dblmembertot, dblCosttot, dblDoctot, dblGrand, POSCount, POSGrand, POStotal, POSGrandtotal As Double
        Dim RoomNo, Posdesc As String
        Dim Memberbool, POSbool As Boolean
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
            Call ReportHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "ROOMWISESALEREGISTER")
            If gdataset.Tables("ROOMWISESALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ROOMWISESALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call ReportHeader(pageheading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If RoomNo <> Trim(CStr(dr("ROOMNO"))) Then
                        If Memberbool = True Then
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(POSCount), "0"), "Room Total =====>", Format(Val(POStotal), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & "Guest Room No. :" & Mid(Trim(CStr(dr("ROOMNO"))), 1, 20))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            RoomNo = Trim(CStr(dr("ROOMNO")))
                            pagesize = pagesize + 1
                            POSCount = 0
                            POStotal = 0
                            Posdesc = ""
                        Else
                            Filewrite.Write("{0,-20}", Chr(14) & Chr(15) & "Guest Room No. :" & Mid(Trim(CStr(dr("ROOMNO"))), 1, 20))
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            RoomNo = Trim(CStr(dr("ROOMNO")))
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
                    If Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 10) = "01/01/1900" Then
                        Filewrite.Write("{0,-20}{1,-12}", "", "__/__/____")
                    Else
                        Filewrite.Write("{0,-20}{1,-12}", "", Mid(Format(CDate(dr("BILLDATE")), "dd/MM/yyyy"), 1, 12))
                    End If
                    Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("BILLNO"))), 1, 20))
                    Filewrite.Write("{0,-15}", Mid(Trim(CStr(dr("SCODE"))), 1, 18))
                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 8))
                    pagesize = pagesize + 1
                    POStotal = POStotal + Format(Val(dr("AMOUNT")), "0.00")
                    POSGrandtotal = POSGrandtotal + Format(Val(dr("AMOUNT")), "0.00")
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(POSCount), "0"), "Room Total =====>", Format(Val(POStotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-20}{1,-18}{2,-29}{3,10}", "Total Document :", Format(Val(POSGrand), "0"), "Grand Total =====>", Format(Val(POSGrandtotal), "0.00"))
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
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-12}{2,-20}{3,-15}{4,10}", "ROOM/", "BILL", "BILL", "SERVER", "NET")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-12}{2,-20}{3,-15}{4,10}", "LOCATION", "DATE", "NUMBER", "CODE", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINTING REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
