Imports System.Data.SqlClient
Imports System.IO
Public Class rptItemmasterchecklist
    Dim dr As DataRow
    Dim pageno As Integer
    Dim pagesize As Integer
    Dim Gconnection As New GlobalClass
    Public Function printdata(ByVal SQLSTRING As String, ByVal heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim docdate As Date
        Dim boolPosdesc, boolgroupdesc, boolItemcode As Boolean
        Dim GroupDesc, POSdesc, Itemdesc, Itemcode, SSQL As String
        Dim LocItemcount, LocationTotal, GroupItemcount, GrandItemcount, GroupTotal, GrandTotal As Double
        Try
            '''********************************** Create a Wordpad for DOS mode print ******************************'''
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(heading, mskfromdate, msktodate)
            Gconnection.getDataSet(SQLSTRING, "ITEMMASTERCHECKLIST")
            If gdataset.Tables("ITEMMASTERCHECKLIST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ITEMMASTERCHECKLIST").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Filewrite.Write(Chr(15))
                        Call PrintHeader(heading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSdesc <> dr("POSDESC") Then
                        If boolPosdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                           pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-30}", "Total Document :", Format(Val(LocItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            LocItemcount = 0 : LocationTotal = 0
                        Else
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            boolPosdesc = True
                            LocItemcount = 0 : LocationTotal = 0
                        End If
                    End If
                    If GroupDesc <> CStr(dr("GROUPDESC")) Then
                        If boolgroupdesc = True Then
                            '                        Filewrite.WriteLine(StrDup(79, "-"))
                            '                        pagesize = pagesize + 1
                            '                        Filewrite.Write("{0,-20}{1,-30}", "Total Document :", Format(Val(GroupItemcount), "0"))
                            '                        Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
                            '                        pagesize = pagesize + 1
                            '                        Filewrite.WriteLine(StrDup(79, "-"))
                            '                        pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            GroupItemcount = 0 : GroupTotal = 0
                        Else
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            boolgroupdesc = True
                            GroupItemcount = 0 : GroupTotal = 0
                        End If
                    End If
                    If Itemcode <> CStr(dr("ITEMCODE")) Then
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("ITEMCODE")), 1, 20))
                        Filewrite.Write("{0,-26}", Mid(Trim(dr("ITEMDESC")), 1, 26))
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.Write("{0,-3}{1,10}", "", Mid(Format(Val(dr("PURCHASERATE")), "0.00"), 1, 10))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        Itemcode = dr("ITEMCODE")
                        LocItemcount = LocItemcount + 1
                        GroupItemcount = GroupItemcount + 1
                        GrandItemcount = GrandItemcount + 1
                        LocationTotal = LocationTotal + Format(Val(dr("ITEMRATE")), "0.00")
                        GroupTotal = GroupTotal + Format(Val(dr("ITEMRATE")), "0.00")
                        GrandTotal = GrandTotal + Format(Val(dr("ITEMRATE")), "0.00")
                    Else
                        Filewrite.Write("{0,-20}", "")
                        Filewrite.Write("{0,-26}", "")
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.Write("{0,-3}{1,10}", "", Mid(Format(Val(dr("PURCHASERATE")), "0.00"), 1, 10))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            '''************************************ GROUP TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-30}", "Total Document :", Format(Val(GroupItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '''************************************ LOCATION TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-30}", "Total Document :", Format(Val(LocItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '''************************************ GRAND TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-30}", "Total Document :", Format(Val(GrandItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Grand Total :", Format(Val(GrandTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString & ex.HelpLink)
            Exit Function
        End Try
    End Function

    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MMM/yyyy"))
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
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}{3,-3}{4,10}{5,10}", "LOCATION/ITEM", "ITEM", "UOM", "", "PURCHASE", "SALE")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}{3,-3}{4,10}{5,10}", "GROUP", "DESCRIPTION", "", "", "RATE", "RATE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Public Function printdatasale(ByVal SQLSTRING As String, ByVal heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim docdate As Date
        Dim boolPosdesc, boolgroupdesc, boolItemcode As Boolean
        Dim GroupDesc, POSdesc, Itemdesc, Itemcode, SSQL As String
        Dim LocItemcount, LocationTotal, GroupItemcount, GrandItemcount, GroupTotal, GrandTotal As Double
        Try
            '''********************************** Create a Wordpad for DOS mode print ******************************'''
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeadersale(heading, mskfromdate, msktodate)
            Gconnection.getDataSet(SQLSTRING, "ITEMMASTERCHECKLIST")
            If gdataset.Tables("ITEMMASTERCHECKLIST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ITEMMASTERCHECKLIST").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Filewrite.Write(Chr(15))
                        Call PrintHeadersale(heading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSdesc <> dr("POSDESC") Then
                        If boolPosdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(LocItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            LocItemcount = 0 : LocationTotal = 0
                        Else
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            boolPosdesc = True
                            LocItemcount = 0 : LocationTotal = 0
                        End If
                    End If
                    If GroupDesc <> CStr(dr("GROUPDESC")) Then
                        If boolgroupdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GroupItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            GroupItemcount = 0 : GroupTotal = 0
                        Else
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            boolgroupdesc = True
                            GroupItemcount = 0 : GroupTotal = 0
                        End If
                    End If
                    If Itemcode <> CStr(dr("ITEMCODE")) Then
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("ITEMCODE")), 1, 20))
                        Filewrite.Write("{0,-26}", Mid(Trim(dr("ITEMDESC")), 1, 26))
                        Filewrite.Write("{0,-6}", "")
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        Itemcode = dr("ITEMCODE")
                        LocItemcount = LocItemcount + 1
                        GroupItemcount = GroupItemcount + 1
                        GrandItemcount = GrandItemcount + 1
                        LocationTotal = LocationTotal + Format(Val(dr("ITEMRATE")), "0.00")
                        GroupTotal = GroupTotal + Format(Val(dr("ITEMRATE")), "0.00")
                        GrandTotal = GrandTotal + Format(Val(dr("ITEMRATE")), "0.00")
                    Else
                        Filewrite.Write("{0,-20}", "")
                        Filewrite.Write("{0,-26}", "")
                        Filewrite.Write("{0,-6}", "")
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            '''************************************ GROUP TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GroupItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '''************************************ LOCATION TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(LocItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '''************************************ GRAND TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GrandItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Grand Total :", Format(Val(GrandTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString & ex.HelpLink)
            Exit Function
        End Try
    End Function
    Public Function printwithoutrate(ByVal SQLSTRING As String, ByVal heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim docdate As Date
        Dim boolPosdesc, boolgroupdesc, boolItemcode As Boolean
        Dim GroupDesc, POSdesc, Itemdesc, Itemcode, SSQL As String
        Dim LocItemcount, LocationTotal, GroupItemcount, GrandItemcount, GroupTotal, GrandTotal As Double
        Try
            '''********************************** Create a Wordpad for DOS mode print ******************************'''
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeaderWithoutRate(heading, mskfromdate, msktodate)
            Gconnection.getDataSet(SQLSTRING, "ITEMMASTERCHECKLIST")
            If gdataset.Tables("ITEMMASTERCHECKLIST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ITEMMASTERCHECKLIST").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Filewrite.Write(Chr(15))
                        Call PrintHeaderWithoutRate(heading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSdesc <> dr("POSDESC") Then
                        If boolPosdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(LocItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            LocItemcount = 0 : LocationTotal = 0
                        Else
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            boolPosdesc = True
                            LocItemcount = 0 : LocationTotal = 0
                        End If
                    End If
                    If GroupDesc <> CStr(dr("GROUPDESC")) Then
                        If boolgroupdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GroupItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            GroupItemcount = 0 : GroupTotal = 0
                        Else
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            boolgroupdesc = True
                            GroupItemcount = 0 : GroupTotal = 0
                        End If
                    End If
                    If Itemcode <> CStr(dr("ITEMCODE")) Then
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("ITEMCODE")), 1, 20))
                        Filewrite.Write("{0,-26}", Mid(Trim(dr("ITEMDESC")), 1, 26))
                        Filewrite.Write("{0,-10}", "")
                        Filewrite.WriteLine("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        'Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        Itemcode = dr("ITEMCODE")
                        LocItemcount = LocItemcount + 1
                        GroupItemcount = GroupItemcount + 1
                        GrandItemcount = GrandItemcount + 1
                        LocationTotal = LocationTotal + Format(Val(dr("ITEMRATE")), "0.00")
                        GroupTotal = GroupTotal + Format(Val(dr("ITEMRATE")), "0.00")
                        GrandTotal = GrandTotal + Format(Val(dr("ITEMRATE")), "0.00")
                    Else
                        Filewrite.Write("{0,-20}", "")
                        Filewrite.Write("{0,-26}", "")
                        Filewrite.Write("{0,-10}", "")
                        Filewrite.WriteLine("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        'Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            '''************************************ GROUP TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GroupItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '''************************************ LOCATION TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(LocItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '''************************************ GRAND TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GrandItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Grand Total :", Format(Val(GrandTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString & ex.HelpLink)
            Exit Function
        End Try
    End Function
    Private Function PrintHeadersale(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MMM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SALE SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-32}{2,-6}{3,-3}{4,10}", "LOCATION/ITEM", "ITEM", "UOM", "", "SALE")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-32}{2,-6}{3,-3}{4,10}", "GROUP", "DESCRIPTION", "", "", "RATE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Private Function PrintHeaderWithoutRate(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MMM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SALE SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ")
            'Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-3}{3,10}", "LOCATION/ITEM", "ITEM", "", "UOM")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}", "GROUP", "DESCRIPTION", "")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Public Function printdatapurchase(ByVal SQLSTRING As String, ByVal heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim docdate As Date
        Dim boolPosdesc, boolgroupdesc, boolItemcode As Boolean
        Dim GroupDesc, POSdesc, Itemdesc, Itemcode, SSQL As String
        Dim LocItemcount, LocationTotal, GroupItemcount, GrandItemcount, GroupTotal, GrandTotal As Double
        Try
            '''********************************** Create a Wordpad for DOS mode print ******************************'''
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeaderpurchase(heading, mskfromdate, msktodate)
            Gconnection.getDataSet(SQLSTRING, "ITEMMASTERCHECKLIST")
            If gdataset.Tables("ITEMMASTERCHECKLIST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ITEMMASTERCHECKLIST").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Filewrite.Write(Chr(15))
                        Call PrintHeaderpurchase(heading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSdesc <> dr("POSDESC") Then
                        If boolPosdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-20}", "Total Document :", Format(Val(LocItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            LocItemcount = 0 : LocationTotal = 0
                        Else
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            boolPosdesc = True
                            LocItemcount = 0 : LocationTotal = 0
                        End If
                    End If
                    If GroupDesc <> CStr(dr("GROUPDESC")) Then
                        If boolgroupdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-20}", "Total Document :", Format(Val(GroupItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            GroupItemcount = 0 : GroupTotal = 0
                        Else
                            Filewrite.WriteLine("{0,-5}{1,-17}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            boolgroupdesc = True
                            GroupItemcount = 0 : GroupTotal = 0
                        End If
                    End If
                    If Itemcode <> CStr(dr("ITEMCODE")) Then
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("ITEMCODE")), 1, 20))
                        Filewrite.Write("{0,-26}", Mid(Trim(dr("ITEMDESC")), 1, 26))
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.WriteLine("{0,-3}{1,10}", "", Mid(Format(Val(dr("PURCHASERATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        Itemcode = dr("ITEMCODE")
                        LocItemcount = LocItemcount + 1
                        GroupItemcount = GroupItemcount + 1
                        GrandItemcount = GrandItemcount + 1
                        LocationTotal = LocationTotal + Format(Val(dr("PURCHASERATE")), "0.00")
                        GroupTotal = GroupTotal + Format(Val(dr("PURCHASERATE")), "0.00")
                        GrandTotal = GrandTotal + Format(Val(dr("PURCHASERATE")), "0.00")
                    Else
                        Filewrite.Write("{0,-20}", "")
                        Filewrite.Write("{0,-26}", "")
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.WriteLine("{0,-3}{1,10}", "", Mid(Format(Val(dr("PURCHASERATE")), "0.00"), 1, 10))
                        '                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("ITEMRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            '''************************************ GROUP TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-20}", "Total Document :", Format(Val(GroupItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '''************************************ LOCATION TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-20}", "Total Document :", Format(Val(LocItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '''************************************ GRAND TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-20}", "Total Document :", Format(Val(GrandItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Grand Total :", Format(Val(GrandTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "="))
            pagesize = pagesize + 1
            'PURCHASERATE
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString & ex.HelpLink)
            Exit Function
        End Try
    End Function

    Private Function PrintHeaderpurchase(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MMM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "PURCHASE SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}{3,-3}{4,10}", "LOCATION/ITEM", "ITEM", "UOM", "", "PURCHASE")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}{3,-3}{4,10}", "GROUP", "DESCRIPTION", "", "", "RATE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Public Function printdatasalevat(ByVal SQLSTRING As String, ByVal heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim docdate As Date
        Dim boolPosdesc, boolgroupdesc, boolItemcode As Boolean
        Dim GroupDesc, POSdesc, Itemdesc, Itemcode, SSQL As String
        Dim LocItemcount, LocationTotal, GroupItemcount, GrandItemcount, GroupTotal, GrandTotal As Double
        Try
            '''********************************** Create a Wordpad for DOS mode print ******************************'''
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".Txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeadersalevat(heading, mskfromdate, msktodate)
            Gconnection.getDataSet(SQLSTRING, "ITEMMASTERCHECKLIST")
            If gdataset.Tables("ITEMMASTERCHECKLIST").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ITEMMASTERCHECKLIST").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Filewrite.Write(Chr(15))
                        Call PrintHeadersalevat(heading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If POSdesc <> dr("POSDESC") Then
                        If boolPosdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(LocItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "."))
                            '                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            LocItemcount = 0 : LocationTotal = 0
                        Else
                            Filewrite.Write("{0,-40}", Chr(14) & Chr(15) & Mid(CStr(dr("POSDESC")), 1, 40) & ":")
                            Filewrite.WriteLine(Chr(18))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-40}", Mid("-------------------------", 1, Len(dr("POSDESC"))))
                            pagesize = pagesize + 1
                            POSdesc = dr("POSDESC")
                            boolPosdesc = True
                            LocItemcount = 0 : LocationTotal = 0
                        End If
                    End If
                    If GroupDesc <> CStr(dr("GROUPDESC")) Then
                        If boolgroupdesc = True Then
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GroupItemcount), "0"))
                            '                            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
                            '                            pagesize = pagesize + 1
                            '                            Filewrite.WriteLine(StrDup(79, "-"))
                            '                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            GroupItemcount = 0 : GroupTotal = 0
                        Else
                            Filewrite.WriteLine("{0,-5}{1,-30}", "", Mid(Trim(dr("GROUPDESC")), 1, 30))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GROUPDESC")
                            boolgroupdesc = True
                            GroupItemcount = 0 : GroupTotal = 0
                        End If
                    End If
                    If Itemcode <> CStr(dr("ITEMCODE")) Then
                        Filewrite.Write("{0,-20}", Mid(Trim(dr("ITEMCODE")), 1, 20))
                        Filewrite.Write("{0,-26}", Mid(Trim(dr("ITEMDESC")), 1, 26))
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("VATRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                        Itemcode = dr("ITEMCODE")
                        LocItemcount = LocItemcount + 1
                        GroupItemcount = GroupItemcount + 1
                        GrandItemcount = GrandItemcount + 1
                        LocationTotal = LocationTotal + Format(Val(dr("VATRATE")), "0.00")
                        GroupTotal = GroupTotal + Format(Val(dr("VATRATE")), "0.00")
                        GrandTotal = GrandTotal + Format(Val(dr("VATRATE")), "0.00")
                    Else
                        Filewrite.Write("{0,-20}", "")
                        Filewrite.Write("{0,-26}", "")
                        Filewrite.Write("{0,-10}", Mid(Trim(dr("UOM")), 1, 10))
                        Filewrite.WriteLine("{0,10}", Mid(Format(Val(dr("VATRATE")), "0.00"), 1, 10))
                        pagesize = pagesize + 1
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            '''************************************ GROUP TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GroupItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Group Total :", Format(Val(GroupTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "-"))
            '            pagesize = pagesize + 1
            '''************************************ LOCATION TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(LocItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Loc Total :", Format(Val(LocationTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "."))
            '            pagesize = pagesize + 1
            '''************************************ GRAND TOTAL CALCULATION **************************************'''
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            '            Filewrite.Write("{0,-20}{1,-17}", "Total Document :", Format(Val(GrandItemcount), "0"))
            '            Filewrite.WriteLine("{0,-16}{1,13}", "Grand Total :", Format(Val(GrandTotal), "0.00"))
            '            pagesize = pagesize + 1
            '            Filewrite.WriteLine(StrDup(79, "="))
            '            pagesize = pagesize + 1
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString & ex.HelpLink)
            Exit Function
        End Try
    End Function

    Private Function PrintHeadersalevat(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MMM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SALE SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}{3,-3}{4,10}", "LOCATION/ITEM", "ITEM", "UOM", "", "SALEVAT")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-20}{1,-26}{2,-10}{3,-3}{4,10}", "GROUP", "DESCRIPTION", "", "", "RATE")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
