Imports System.data.sqlclient
Imports System.io
Public Class Datewisesaleregisterdetails
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportsDetails(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim I, J As Integer
        Dim POSDESC, PAYMENTMODE As String
        Dim dblTotalSale, dblCashrecived, dblCashPending, dblTotalSalebarwise As Double
        Dim dbltotaldoc, dblcashsale, dblcreditsale, dblroomsale, dblcouponsale, dblclubsale, dblpartysale, dblnoncreditsale, dblreciprocal, dblcashreceived As Double
        Dim dbltotaldoc1, dblcashsale1, dblcreditsale1, dblroomsale1, dblcouponsale1, dblclubsale1, dblpartysale1, dblnoncreditsale1, dblreciprocal1, dblcashreceived1 As Double
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
            gconnection.getDataSet(SQLSTRING, "DATEWISESALEREGISTERDETAILS")
            If gdataset.Tables("DATEWISESALEREGISTERDETAILS").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("DATEWISESALEREGISTERDETAILS").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                    End If
                    If POSDESC <> CStr(dr("POSDESC")) Then
                        Filewrite.Write("{0,-15}", Mid(CStr(dr("POSDESC")), 1, 15))
                        ''SQLSTRING = " SELECT COUNT(DISTINCT BILLDETAILS) AS DOCCOUNT  FROM KOT_DET"
                        'SQLSTRING = SQLSTRING & " WHERE POSDESC = '" & Trim(CStr(dr("POSDESC"))) & "' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) "
                        ''SQLSTRING = SQLSTRING & " WHERE CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) "
                        ''SQLSTRING = SQLSTRING & " BETWEEN '" & Format(FROMDATE, "dd-MMM-yyyy") & "' AND ' " & Format(TODATE, "dd-MMM-yyyy") & "' AND ISNULL(BILLDETAILS,'')<> '' GROUP BY POSCODE ORDER BY POSCODE  "
                        SQLSTRING = "SELECT COUNT(*) as DOCCOUNT FROM VIEWDATEWISESALEREGISTER_NEW WHERE POSDESC ='" & Trim(CStr(dr("POSDESC"))) & "'  AND  CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN  '" & Format(FROMDATE, "dd-MMM-yyyy") & "' AND ' " & Format(TODATE, "dd-MMM-yyyy") & "'"

                        gconnection.getDataSet(SQLSTRING, "KOTDETAILS")
                        If gdataset.Tables("KOTDETAILS").Rows.Count > 0 Then
                            Filewrite.Write("{0,8}", Mid(Format(Val(gdataset.Tables("KOTDETAILS").Rows(0).Item("DOCCOUNT")), "0"), 1, 8))
                            dbltotaldoc = Val(dbltotaldoc) + Val(gdataset.Tables("KOTDETAILS").Rows(0).Item("DOCCOUNT"))
                        End If
                        SQLSTRING = "SELECT SUM(CASH) AS CASH ,SUM(CREDIT) AS CREDIT ,SUM(CLUB) AS CLUB ,SUM(ROOM) AS ROOM ,SUM(COUPON) AS COUPON ,SUM(PARTY) AS PARTY ,"
                        'SQLSTRING = SQLSTRING & " SUM(NCREDIT) AS NCREDIT ,SUM(RMEMBER) AS RMEMBER,POSDESC,BILLDATE,POSCODE FROM VIEWSALESREGISTERDATEWISE "
                        SQLSTRING = SQLSTRING & " SUM(NCREDIT) AS NCREDIT ,SUM(RMEMBER) AS RMEMBER,POSDESC,BILLDATE FROM VIEWSALESREGISTERDATEWISE "
                        SQLSTRING = SQLSTRING & " WHERE POSDESC = '" & Trim(dr("POSDESC")) & "'  AND CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME) BETWEEN "
                        SQLSTRING = SQLSTRING & " '" & Format(FROMDATE, "dd-MMM-yyyy") & "' AND ' " & Format(TODATE, "dd-MMM-yyyy") & "'"
                        'SQLSTRING = SQLSTRING & " GROUP BY BILLDATE,POSCODE,POSDESC ORDER BY POSDESC,BILLDATE"
                        SQLSTRING = SQLSTRING & " GROUP BY BILLDATE,POSDESC ORDER BY POSDESC,BILLDATE"
                        gconnection.getDataSet(SQLSTRING, "SALESREGISTERDATEWISE")
                        If gdataset.Tables("SALESREGISTERDATEWISE").Rows.Count > 0 Then
                            For J = 0 To gdataset.Tables("SALESREGISTERDATEWISE").Rows.Count - 1
                                With gdataset.Tables("SALESREGISTERDATEWISE").Rows(J)
                                    dblcashsale = Val(dblcashsale) + Format(Val(.Item("CASH")), "0.00")
                                    dblcashsale1 = Val(dblcashsale1) + Format(Val(.Item("CASH")), "0.00")
                                    dblcreditsale = Val(dblcreditsale) + Format(Val(.Item("CREDIT")), "0.00")
                                    dblcreditsale1 = Val(dblcreditsale1) + Format(Val(.Item("CREDIT")), "0.00")
                                    dblroomsale = Val(dblroomsale) + Format(Val(.Item("ROOM")), "0.00")
                                    dblroomsale1 = Val(dblroomsale1) + Format(Val(.Item("ROOM")), "0.00")
                                    dblcouponsale = Val(dblcouponsale) + Format(Val(.Item("COUPON")), "0.00")
                                    dblcouponsale1 = Val(dblcouponsale1) + Format(Val(.Item("COUPON")), "0.00")
                                    dblclubsale = Val(dblclubsale) + Format(Val(.Item("CLUB")), "0.00")
                                    dblclubsale1 = Val(dblclubsale1) + Format(Val(.Item("CLUB")), "0.00")
                                    dblpartysale = Val(dblpartysale) + Format(Val(.Item("PARTY")), "0.00")
                                    dblpartysale1 = Val(dblpartysale1) + Format(Val(.Item("PARTY")), "0.00")
                                    dblnoncreditsale = Val(dblnoncreditsale) + Format(Val(.Item("NCREDIT")), "0.00")
                                    dblnoncreditsale1 = Val(dblnoncreditsale1) + Format(Val(.Item("NCREDIT")), "0.00")
                                    dblreciprocal = Val(dblreciprocal) + Format(Val(.Item("RMEMBER")), "0.00")
                                    dblreciprocal1 = Val(dblreciprocal1) + Format(Val(.Item("RMEMBER")), "0.00")
                                End With
                            Next
                            Filewrite.Write("{0,9}", Mid(Format(Val(dblcashsale1), "0.00"), 1, 9))
                            Filewrite.Write("{0,9}", Mid(Format(Val(dblcreditsale1), "0.00"), 1, 9))
                            Filewrite.Write("{0,9}", Mid(Format(Val(dblroomsale1), "0.00"), 1, 9))
                            Filewrite.Write("{0,9}", Mid(Format(Val(dblcouponsale1), "0.00"), 1, 9))
                            Filewrite.Write("{0,9}", Mid(Format(Val(dblclubsale1), "0.00"), 1, 9))
                            Filewrite.Write("{0,10}{1,-2}", Mid(Format(Val(dblpartysale1), "0.00"), 1, 10), "")
                            Filewrite.Write("{0,10}{1,-2}", Mid(Format(Val(dblnoncreditsale1), "0.00"), 1, 10), "")
                            Filewrite.Write("{0,10}", Mid(Format(Val(dblreciprocal1), "0.00"), 1, 10))
                        End If
                        dblTotalSalebarwise = Val(dblcashsale1) + Val(dblcreditsale1) + Val(dblroomsale1) + Val(dblcouponsale1) + Val(dblclubsale1) + Val(dblpartysale1) + Val(dblnoncreditsale1) + Val(dblreciprocal1)
                        Filewrite.Write("{0,10}", Mid(Format(Val(dblTotalSalebarwise), "0.00"), 1, 10))
                        dblTotalSale = Val(dblTotalSale) + Format(Val(dblTotalSalebarwise), "0.00")
                        dblTotalSalebarwise = 0 : dblcashsale1 = 0 : dblcreditsale1 = 0 : dblroomsale1 = 0 : dblcouponsale1 = 0 : dblclubsale1 = 0 : dblpartysale1 = 0 : dblnoncreditsale1 = 0 : dblreciprocal1 = 0
                        POSDESC = CStr(dr("POSDESC"))
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                Next dr


                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-16}", "GRAND TOTAL ===>")
                Filewrite.Write("{0,7}", Format(Val(dbltotaldoc), "0"))
                Filewrite.Write("{0,9}", Format(Val(dblcashsale), "0.00"))
                Filewrite.Write("{0,9}", Format(Val(dblcreditsale), "0.00"))
                Filewrite.Write("{0,9}", Format(Val(dblroomsale), "0.00"))
                Filewrite.Write("{0,9}", Format(Val(dblcouponsale), "0.00"))
                Filewrite.Write("{0,9}", Format(Val(dblclubsale), "0.00"))
                Filewrite.Write("{0,10}{1,-2}", Format(Val(dblpartysale), "0.00"), "")
                Filewrite.Write("{0,10}{1,-2}", Format(Val(dblnoncreditsale), "0.00"), "")
                Filewrite.Write("{0,10}", Format(Val(dblreciprocal), "0.00"))
                Filewrite.Write("{0,10}", Format(Val(dblTotalSale), "0.00"))
                Filewrite.Write("{0,10}", Format(Val(dblCashrecived), "0.00"))
                Filewrite.WriteLine("{0,10}", Format(Val(dblCashPending), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
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
            Filewrite.Write("{0,-15}{1,8}{2,9}{3,9}{4,9}{5,9}{6,9}", "LOCATION", "TOTAL", "CASH", "CREDIT", "ROOM", "COUPON", "CLUB")
            Filewrite.WriteLine("{0,10}{1,-2}{2,10}{3,-2}{4,10}{5,10}{6,10}{7,10}", "PARTY", " ", "NONCREDIT", " ", "RECIPROCAL", "TOTAL", "CASH", "CASH")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-15}{1,8}{2,9}{3,9}{4,9}{5,9}{6,9}", "NAME", "DOCUMENT", "SALE", "SALE", "SALE", "SALE", "SALE")
            Filewrite.WriteLine("{0,10}{1,-2}{2,10}{3,-2}{4,10}{5,10}{6,10}{7,10}", "SALE", " ", "SALE", " ", "SALE", "SALE", "RECEIVED", "PENDING")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-15}{1,8}{2,9}{3,9}{4,9}{5,9}{6,9}", " ", " ", "(1)", "(2)", "(3)", "(4)", "(5)")
            Filewrite.WriteLine("{0,10}{1,-2}{2,10}{3,-2}{4,10}{5,10}{6,10}{7,10}", "(6)", " ", "(7)", " ", "(8)", "(1..8)", "(9)", "(1+3+6+7+8-9)")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

End Class
