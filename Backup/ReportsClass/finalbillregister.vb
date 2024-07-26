Imports System.Data.SqlClient
Imports System.IO
Public Class finalbillregister
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow

    Public Function ReportDetails(ByVal Sqlstring As String, ByVal pageheading() As String, ByVal columnheading() As String, ByVal Columnsize() As Integer)
        Dim BILLNO, MNAME, ROWPRINT, ITEMCODE, ITEMDESC, SSQL, ROUND, RUPEESWORD, Roundedvalue() As String
        Dim BILLAMOUNT, TAXAMT, ROUNDOFF, ROUNDDIFF As Double
        BILLAMOUNT = 0 : TAXAMT = 0 : ROUNDOFF = 0 : ROUNDDIFF = 0
        Dim I, J, VCOUNT, ROWCOUNT As Integer
        Dim CountItem As Integer = 1
        Dim MCODE, PAYMENTMODE As String
        Dim TAXPERC As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1 : pagesize = 1
            Filewrite.Write(Chr(15))
            gconnection.getDataSet(Sqlstring, "FINALBILLREGISTER")
            Call ReportHeader(pageheading, columnheading, Columnsize) '''---> Report Header
            If gdataset.Tables("FINALBILLREGISTER").Rows.Count > 0 Then
                Sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader FROM POSSETUP"
                gconnection.getDataSet(Sqlstring, "POSSETUP")
                If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                    If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader")) = "YES" Then
                        vheader = Space((65 - Len(gCompanyname)) / 2) & Chr(14) & Chr(15) & gCompanyname & Chr(18)
                        Filewrite.WriteLine(vheader)
                        vheader = Space((65 - Len(Trim(gCompanyAddress(0)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18)
                        Filewrite.WriteLine(vheader)
                        vheader = Space((65 - Len(Trim(gCompanyAddress(1)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18)
                        Filewrite.WriteLine(vheader)
                    End If
                End If
                Filewrite.WriteLine("")
                If gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("DELFLAG") <> "Y" Then
                    vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                Else
                    vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & " V O U C H E R [D E L E T E D]"
                End If
                Filewrite.WriteLine("")
                Filewrite.WriteLine(vheader)
                Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("BILL   NO:", 1, 10), Mid(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("BILLDETAILS"), 1, 20), "")
                Filewrite.WriteLine("{0,-8}{1,-10}", "TIME   :", Format(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("ADDDATETIME"), "HH:mm:ss"))
                Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("SERVER NO:", 1, 10), Mid(CStr(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("SERVERNAME")) & "   [" & CStr(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("STCODE")) & "]", 1, 24), "")
                Filewrite.WriteLine("{0,-8}{1,-10}", "DATE   :", Format(CDate(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("KOTDATE")), "dd/MM/yyyy"))
                pagesize = pagesize + 4
                Call ColumnHeader(columnheading, Columnsize)  '''---> Column Header
                BILLNO = CStr(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("Billdetails"))
            Else
                Exit Try
            End If
            Dim COUNT As Integer = 1
            For J = 0 To gdataset.Tables("FINALBILLREGISTER").Rows.Count - 1
                With gdataset.Tables("FINALBILLREGISTER").Rows(J)
                    If BILLNO <> CStr(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("Billdetails")) Then
                        COUNT = COUNT + 1           ''***************************** FOR PER PAGE TWO RECORDS 
                        If pagesize <= 16 Then
                            For I = 1 To 16 - pagesize
                                Filewrite.WriteLine("")
                            Next
                        End If
                        If Val(COUNT) > 2 Then
                            Filewrite.WriteLine(Chr(12))
                            COUNT = 1
                            pagesize = 1
                            Call ReportHeader(pageheading, columnheading, Columnsize) '''---> Report Header
                        End If
                        If gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE") = "ROOM" Then
                            Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE"), 1, 20))
                            Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("GUEST") & "       [" & gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("ROOMNO") & "]", 1, 45))
                            pagesize = pagesize + 1
                        ElseIf gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE") = "CREDIT" Then
                            Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE"), 1, 20))
                            Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("MNAME") & "       [" & gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("MCODE") & "]", 1, 45))
                            pagesize = pagesize + 1
                        ElseIf gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE") = "COUPON" Then
                            Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE"), 1, 20))
                            Filewrite.WriteLine("{0,-45}", ":")
                            pagesize = pagesize + 1
                        ElseIf gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE") = "R.MEMBER" Then
                            Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE"), 1, 20))
                            Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
                            pagesize = pagesize + 1
                        Else
                            Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE"), 1, 20))
                            Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("MNAME") & "       [" & gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("MCODE") & "]", 1, 45))
                            pagesize = pagesize + 1
                        End If
                        Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")), "0.00"))
                        pagesize = pagesize + 1
                        Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("TAXCODE")) & "' "
                        gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
                        If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                            Filewrite.Write("{0,-31}{1,38}", "BILL PAYBLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX")), "0.00"))
                            pagesize = pagesize + 1
                        End If
                        If Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT")) > 0 Then
                            Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                            Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT"))), "0.00"))
                            pagesize = pagesize + 1
                        End If
                        If Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("DISCOUNTAMT")) > 0 Then
                            Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                            Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                            pagesize = pagesize + 1
                        End If
                        Filewrite.WriteLine("{0,-79}", "")
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write("{0,-50}{1,19}", " ", "TOTAL :")
                        Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT"))), "0.00"))
                        pagesize = pagesize + 1
                        ROUNDOFF = Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT")))
                        ROUND = CStr(ROUNDOFF)
                        If ROUND.IndexOf(".") <= 0 Then
                            ROUND = ROUND.Insert(ROUND.Length - 1, ".00")
                        End If
                        Roundedvalue = Split(ROUND, ".")
                        If Format(Val(Roundedvalue(1)), "00") >= 50 Then
                            ROUNDOFF = Math.Ceiling(ROUNDOFF)
                        Else
                            ROUNDOFF = Math.Floor(ROUNDOFF)
                        End If
                        If Val(ROUNDOFF) > Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT"))) Then
                            ROUNDDIFF = ROUNDOFF - (Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT")))
                            Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
                        Else
                            ROUNDDIFF = (Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT"))) - ROUNDOFF
                            Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
                        End If
                        Filewrite.WriteLine("{0,10}", Format(Val(ROUNDDIFF), "0.00"))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(79, "-"))
                        pagesize = pagesize + 1
                        RUPEESWORD = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT"))), "0.00"))
                        Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & RUPEESWORD & " ONLY."), 1, 69))
                        Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("PACKAMT"))), "0.00"))


                        pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(79, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write("{0,-14}{1,-46}", "PREPARED BY:", Mid(UCase(gUsername), 1, 40))
                        Filewrite.WriteLine("{0,-20}", Mid(MyCompanyName, 1, 20))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("REMARKS"), 1, 20))
                        pagesize = pagesize + 1
                        '------------------------------------------------------------------------
                        Sqlstring = "SELECT ISNULL(BillPrintHeader,'') AS BillPrintHeader FROM POSSETUP"
                        gconnection.getDataSet(Sqlstring, "POSSETUP")
                        If gdataset.Tables("POSSETUP").Rows.Count > 0 Then
                            If Trim(gdataset.Tables("POSSETUP").Rows(0).Item("BillPrintHeader")) = "YES" Then
                                vheader = Space((65 - Len(gCompanyname)) / 2) & Chr(14) & Chr(15) & gCompanyname & Chr(18)
                                Filewrite.WriteLine(vheader)
                                vheader = Space((65 - Len(Trim(gCompanyAddress(0)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18)
                                Filewrite.WriteLine(vheader)
                                vheader = Space((65 - Len(Trim(gCompanyAddress(1)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18)
                                Filewrite.WriteLine(vheader)
                            End If
                        End If
                        Filewrite.WriteLine("")
                        If gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("DELFLAG") <> "Y" Then
                            vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & Gheader
                        Else
                            vheader = Chr(14) & Chr(15) & Space((40 / 2) - (Len(Gheader) / 2)) & " V O U C H E R [D E L E T E D]"
                        End If
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(vheader)
                        Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("BILL   NO:", 1, 10), Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("BILLDETAILS"), 1, 18), "")
                        Filewrite.WriteLine("{0,-8}{1,-10}", "TIME   :", Format(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("ADDDATETIME"), "HH:mm:ss"))
                        Filewrite.Write("{0,-12}{1,-24}{2,-24}", Mid("SERVER NO:", 1, 10), Mid(CStr(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("SERVERNAME")) & "   [" & CStr(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("STCODE")) & "]", 1, 24), "")
                        Filewrite.WriteLine("{0,-8}{1,-10}", "DATE   :", Format(CDate(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("KOTDATE")), "dd/MM/yyyy"))
                        pagesize = pagesize + 4
                        Call ColumnHeader(columnheading, Columnsize)  '''---> Column Header
                        BILLNO = Trim(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("Billdetails"))
                        VCOUNT = 1
                        BILLAMOUNT = 0 : TAXAMT = 0
                        pagesize = pagesize + 4
                        If Val(pagesize) > 55 Then
                            Filewrite.WriteLine(Chr(12))
                        End If
                    ElseIf ITEMCODE <> CStr(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("ITEMCODE")) Then
                        VCOUNT = VCOUNT + 1
                        ITEMCODE = CStr(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("ITEMCODE"))
                    End If
                    With gdataset.Tables("FINALBILLREGISTER").Rows(J)
                        Filewrite.Write("{0,-6}{1,-6}", Mid(CountItem & ".", 1, 5), Mid(Trim(.Item("ITEMCODE")), 1, 6))
                        Filewrite.Write("{0,-36}{1,-8}{2,-8}", Mid(Trim(.Item("ITEMDESC")) & Trim(".............................."), 1, 36), Mid(Format(Val(.Item("QTY")), "0.00"), 1, 8), Mid(Trim(.Item("UOM")), 1, 8))
                        Filewrite.WriteLine("{0,-8}{1,-10}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 8), Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 10))
                    End With
                    BILLAMOUNT = Val(BILLAMOUNT) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("AMOUNT"))
                    TAXAMT = Val(TAXAMT) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("TAXAMOUNT"))
                    MCODE = Trim(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("MCODE"))
                    MNAME = Trim(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("MNAME"))
                    PAYMENTMODE = Trim(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("PAYMENTTYPE"))
                    TAXPERC = Val(gdataset.Tables("FINALBILLREGISTER").Rows(J).Item("TAXPERC"))
                End With
                pagesize = pagesize + 1
            Next
            If pagesize <= 16 Then
                For I = 1 To 16 - pagesize
                    Filewrite.WriteLine("")
                Next
            ElseIf pagesize > 16 Then
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.WriteLine("{0,79}", "Contd....")
                For I = 1 To 38 - pagesize + 1
                    Filewrite.WriteLine("")
                Next
                pagesize = 6
            End If
            If gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE") = "ROOM" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("GUEST") & "       [" & gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("ROOMNO") & "]", 1, 45))
            ElseIf gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE") = "CREDIT" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("MNAME") & "       [" & gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("MCODE") & "]", 1, 45))
            ElseIf gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE") = "COUPON" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", ":")
            ElseIf gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE") = "R.MEMBER" Then
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & "RECIPROCAL MEMBER", 1, 45))
            Else
                Filewrite.Write("{0,-20}", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PAYMENTTYPE"), 1, 20))
                Filewrite.WriteLine("{0,-45}", Mid(":" & gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("MNAME") & "       [" & gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("MCODE") & "]", 1, 45))
            End If
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
            Filewrite.WriteLine("{0,-69}{1,10}", "", Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")), "0.00"))
            Sqlstring = "SELECT ISNULL(TAXCODE,'') AS TAXCODE,ISNULL(TAXDESC,'') AS TAXDESC,ISNULL(TAXPERCENTAGE,0) AS TAXPERCENTAGE FROM ACCOUNTSTAXMASTER WHERE TAXCODE ='" & Trim(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TAXCODE")) & "' "
            gconnection.getDataSet(Sqlstring, "ACCOUNTSTAXMASTER")
            If gdataset.Tables("ACCOUNTSTAXMASTER").Rows.Count > 0 Then
                Filewrite.Write("{0,-31}{1,38}", "BILL PAYBLE ON PRESENTATION", Mid(Trim(CStr(gdataset.Tables("ACCOUNTSTAXMASTER").Rows(0).Item("TAXDESC"))) & ":", 1, 35))
                Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX")), "0.00"))
            End If
            If Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT")) > 0 Then
                Filewrite.Write("{0,69}", "                                      PACKING CHARGES @ 5% :")
                Filewrite.WriteLine("{0,10}", Format((Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT"))), "0.00"))
                pagesize = pagesize + 6
            End If
            pagesize = pagesize + 3
            If Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("DISCOUNTAMT")) > 0 Then
                Filewrite.Write("{0,69}", "                                       DISCOUNT PERCENTAGE :")
                Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("DISCOUNTAMT")), "0") & "%", 1, 10))
                pagesize = pagesize + 1
            End If
            Filewrite.WriteLine("{0,-79}", "")
            Filewrite.WriteLine("{0,-69}{1,10}", "", StrDup(10, "-"))
            pagesize = pagesize + 2
            Filewrite.Write("{0,-50}{1,19}", " ", "TOTAL :")
            Filewrite.WriteLine("{0,10}", Format(Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTALTAX") + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT"))), "0.00"))
            pagesize = pagesize + 1
            ROUNDOFF = Val(gdataset.Tables("FINALBILLREGISTER").Rows(0).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX") + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT")))
            ROUND = CStr(ROUNDOFF)
            If ROUND.IndexOf(".") <= 0 Then
                ROUND = ROUND.Insert(ROUND.Length - 1, ".00")
            End If
            Roundedvalue = Split(ROUND, ".")
            If Format(Val(Roundedvalue(1)), "00") >= 50 Then
                ROUNDOFF = Math.Ceiling(ROUNDOFF)
            Else
                ROUNDOFF = Math.Floor(ROUNDOFF)
            End If
            If Val(ROUNDOFF) > Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX") + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT"))) Then
                ROUNDDIFF = ROUNDOFF - (Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT")))
                Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(+):")
            Else
                ROUNDDIFF = (Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT"))) - ROUNDOFF
                Filewrite.Write("{0,-50}{1,19}", "", "ROUNDED OFF(-):")
            End If
            Filewrite.WriteLine("{0,10}", Format(Val(ROUNDDIFF), "0.00"))
            Filewrite.WriteLine(StrDup(79, "-"))
            RUPEESWORD = ConvertRupees(Format(Math.Round(Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT"))), "0.00"))
            Filewrite.Write("{0,-69}", Mid(Trim("RUPEES " & RUPEESWORD & " ONLY."), 1, 69))
            Filewrite.WriteLine("{0,10}", Format(Math.Round(Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTAL")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("TOTALTAX")) + Val(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("PACKAMT"))), "0.00"))
            Filewrite.WriteLine(StrDup(79, "-"))
            Filewrite.Write("{0,-14}{1,-46}", "PREPARED BY:", Mid(UCase(gUsername), 1, 40))
            Filewrite.WriteLine("{0,-20}", Mid(MyCompanyName, 1, 20))
            Filewrite.WriteLine("{0,-14}{1,-20}", "REMARKS :   ", Mid(gdataset.Tables("FINALBILLREGISTER").Rows(J - 1).Item("REMARKS"), 1, 20))
            pagesize = pagesize + 6
            If pagesize <= 32 Then
                For I = 1 To 32 - pagesize
                    Filewrite.WriteLine("")
                Next
            End If
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

    Private Function ReportHeader(ByVal pageheading() As String, ByVal columnheading() As String, ByVal colsize() As Integer)
        Dim headerprint As String
        Try
            pagesize = 0
            headerprint = Chr(14) & Chr(15) & Space((40 / 2) - (Len(pageheading(0)) / 2)) & pageheading(0)
            Filewrite.WriteLine(headerprint)
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            headerprint = Space((80 / 2) - (Len(pageheading(1)) / 2)) & pageheading(1)
            Filewrite.WriteLine(headerprint)
            pagesize = pagesize + 1
            headerprint = Space((80 / 2) - (Len(pageheading(2)) / 2)) & pageheading(2)
            Filewrite.WriteLine(headerprint)
            pagesize = pagesize + 1
        Catch ex As Exception
            MessageBox.Show("Could not print the Report Header", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Function ColumnHeader(ByVal columnheading() As String, ByVal colsize() As Integer)
        Dim i As Integer
        Dim columnprint As String
        Try
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-6}{1,-6}{2,-36}{3,-8}{4,-8}{5,-8}{6,-10}", columnheading(0), columnheading(1), columnheading(2), columnheading(3), columnheading(4), columnheading(5), columnheading(6))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            MessageBox.Show("Could not print the Column header", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Public Function ConvertRupees(ByVal Value As Double) As String
        Dim strText, TempString, TxtArray(5) As String
        Dim locNumber, AbsValue, DecimalValue, NumArray(5), Remain, Loopindex As Double
        NumArray(0) = 7
        NumArray(1) = 5
        NumArray(2) = 3
        NumArray(3) = 2
        TxtArray(0) = " CRORE"
        TxtArray(1) = " LAKH(S)"
        TxtArray(2) = " THOUSAND"
        TxtArray(3) = " HUNDRED"
        AbsValue = Value
        For Loopindex = 0 To 3
            locNumber = (AbsValue - (AbsValue Mod (10 ^ NumArray(Loopindex)))) / (10 ^ NumArray(Loopindex))
            If locNumber > 99 Then
                strText = strText & ConvertRupees(locNumber) & TxtArray(Loopindex)
                AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
            Else
                If locNumber <> 0 Then
                    If locNumber > 19 Then
                        strText = strText & NumValString(((locNumber - (locNumber Mod 10)) / 10) * 10) & NumValString(locNumber Mod 10) & TxtArray(Loopindex)
                    Else
                        strText = strText & NumValString(locNumber) & TxtArray(Loopindex)
                    End If
                    AbsValue = AbsValue - (locNumber * (10 ^ NumArray(Loopindex)))
                End If
            End If
        Next Loopindex
        If AbsValue <> 0 Then
            If AbsValue > 19 Then
                strText = strText & NumValString(((AbsValue - (AbsValue Mod 10)) / 10) * 10) & NumValString(AbsValue Mod 10) & TxtArray(Loopindex)
            Else
                strText = strText & NumValString(AbsValue)
            End If
        End If
        ConvertRupees = strText
    End Function
    Private Function NumValString(ByVal Value As Double)
        Select Case Value
            Case 1
                NumValString = " ONE"
            Case 2
                NumValString = " TWO"
            Case 3
                NumValString = " THREE"
            Case 4
                NumValString = " FOUR"
            Case 5
                NumValString = " FIVE"
            Case 6
                NumValString = " SIX"
            Case 7
                NumValString = " SEVEN"
            Case 8
                NumValString = " EIGHT"
            Case 9
                NumValString = " NINE"
            Case 10
                NumValString = " TEN"
            Case 11
                NumValString = " ELEVEN"
            Case 12
                NumValString = " TWELVE"
            Case 13
                NumValString = " THIRTEEN"
            Case 14
                NumValString = " FOURTEEN"
            Case 15
                NumValString = " FIFTEEN"
            Case 16
                NumValString = " SIXTEEN"
            Case 17
                NumValString = " SEVENTEEN"
            Case 18
                NumValString = " EIGHTEEN"
            Case 19
                NumValString = " NINETEEN"
            Case 20
                NumValString = " TWENTY"
            Case 30
                NumValString = " THIRTY"
            Case 40
                NumValString = " FOURTY"
            Case 50
                NumValString = " FIFTY"
            Case 60
                NumValString = " SIXTY"
            Case 70
                NumValString = " SEVENTY"
            Case 80
                NumValString = " EIGHTY"
            Case 90
                NumValString = " NINETY"
            Case Else
                NumValString = ""
        End Select
    End Function
End Class
