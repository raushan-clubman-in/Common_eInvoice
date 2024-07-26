Imports System.Data.SqlClient
Imports System.IO
Public Class SaleItemwiseRegisterpurchaserate
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Detailsection(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim i As Integer
        Dim booltotal, boolgrouptotal As Boolean
        Dim GroupDesc, POSdesc, Itemdesc, Itemcode, LastUOM, Rowprint, Todaydate As String
        Dim TotalQty, GroupQty, GrandQty, Totalpurchase, GroupPurchase, Grandpurchase, Purchaseprice, Grouppurchaseamt, Grandpurcahseamt, PresentQty As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(pageheading, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "ITEMWISESALEREGISTERCOSTING")
            If gdataset.Tables("ITEMWISESALEREGISTERCOSTING").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("ITEMWISESALEREGISTERCOSTING").Rows
                    If pagesize >= 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(pageheading, mskfromdate, msktodate)
                    End If
                    If GroupDesc <> CStr(dr("GroupDesc")) Then
                        If boolgrouptotal = True Then
                            '''************************************** $ ITEM TOTAL $ ***************************************''''
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            If dr("KOTSTATUS") = "N" Then
                                TotalQty = TotalQty + PresentQty
                                GroupQty = GroupQty + PresentQty
                                Totalpurchase = Val(TotalQty) * Val(Purchaseprice)
                                Grouppurchaseamt = Grouppurchaseamt + Totalpurchase
                                Grandpurcahseamt = Grandpurcahseamt + Totalpurchase
                            End If
                            Filewrite.Write("{0,-10}{1,-18}{2,-20}", "", "ITEM TOTAL =====>", "")
                            Filewrite.Write("{0,-8}{1,-11}", Mid(Format(Val(TotalQty), "0"), 1, 8), Mid(Trim(LastUOM), 1, 10))
                            Filewrite.WriteLine("{0,8}", Mid(Format(Val(Totalpurchase), "0.00"), 1, 8))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            TotalQty = 0
                            Totalpurchase = 0
                            Purchaseprice = 0
                            booltotal = False
                            '''************************************** $ COMPLETE ITEM TOTAL $ ***************************************''''
                            '''************************************** $  ITEM GROUP TOTAL $   **********************************''''
                            Filewrite.WriteLine(StrDup(79, "."))
                            pagesize = pagesize + 1
                            If dr("KOTSTATUS") = "N" Then
                                GrandQty = GrandQty + GroupQty
                                GroupQty = GroupQty + PresentQty
                            End If
                            Filewrite.Write("{0,-10}{1,-23}{2,-15}", "", "ITEM GROUP TOTAL =====>", "")
                            Filewrite.Write("{0,-8}{1,-11}", Mid(Format(Val(GroupQty), "0"), 1, 8), "")
                            Filewrite.WriteLine("{0,8}", Mid(Format(Val(Grouppurchaseamt), "0.00"), 1, 8))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "."))
                            pagesize = pagesize + 1
                            GroupQty = 0
                            GroupPurchase = 0
                            Grouppurchaseamt = 0
                            boolgrouptotal = True
                            '''************************************** $ COMPLETE ITEM GROUP TOTAL $  **********************************''''
                        End If
                        Filewrite.WriteLine(dr("GROUPDESC"))
                        pagesize = pagesize + 1
                        GroupDesc = dr("GROUPDESC")
                        boolgrouptotal = True
                    End If
                    If Itemdesc <> dr("ITEMDESC") And Itemcode <> dr("ITEMCODE") Then
                        If booltotal = True Then
                            '''************************************** $ ITEM TOTAL $ ***************************************''''
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            TotalQty = TotalQty + PresentQty
                            GroupQty = GroupQty + PresentQty
                            Totalpurchase = Val(TotalQty) * Val(Purchaseprice)
                            Grouppurchaseamt = Grouppurchaseamt + Totalpurchase
                            Grandpurcahseamt = Grandpurcahseamt + Totalpurchase
                            Filewrite.Write("{0,-10}{1,-18}{2,-20}", "", "ITEM TOTAL =====>", "")
                            Filewrite.Write("{0,-8}{1,-11}", Mid(Format(Val(TotalQty), "0"), 1, 8), Mid(Trim(LastUOM), 1, 10))
                            Filewrite.WriteLine("{0,8}", Mid(Format(Val(Totalpurchase), "0.00"), 1, 8))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            TotalQty = 0
                            Totalpurchase = 0
                            Purchaseprice = 0
                            '''************************************** $ COMPLETE ITEM TOTAL $ ***************************************''''
                        End If
                        booltotal = True
                        Filewrite.Write("{0,-5}{1,-41}", "", Mid(Trim(dr("ITEMDESC")), 1, 40))
                        Filewrite.Write("{0,-12}", Mid("( Rs." & Format(Val(dr("PURCHASERATE")), "0.00") & ")", 1, 12))
                        Filewrite.WriteLine("{0,-12}", Mid("(" & "CODE :" & dr("ITEMCODE") & ")", 1, 12))
                        pagesize = pagesize + 1
                        Purchaseprice = Purchaseprice + Format(Val(dr("PURCHASERATE")), "0.00")
                        Filewrite.Write("{0,-10}{1,-38}", "", Mid(Trim(dr("POSDESC")), 1, 30))
                        'Filewrite.WriteLine("{0,-8}", Mid(Trim(Format(Val(dr("QTY")), "0")), 1, 8))
                        Filewrite.WriteLine("{0,-8}", " ")
                        pagesize = pagesize + 1
                        Itemdesc = dr("ITEMDESC")
                        Itemcode = dr("ITEMCODE")
                        POSdesc = dr("POSDESC")
                        PresentQty = Format(Val(dr("QTY")), "0")
                        LastUOM = Trim(dr("UOM"))
                    Else
                        If dr("kotstatus") <> "Y" Then
                            PresentQty = PresentQty + Format(Val(dr("QTY")), "0")
                        End If
                    End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''************************************** $ ITEM TOTAL $ ***************************************''''
                Filewrite.WriteLine(StrDup(79, "-"))
                pagesize = pagesize + 1
                TotalQty = TotalQty + PresentQty
                GroupQty = GroupQty + PresentQty
                Totalpurchase = Val(TotalQty) * Val(Purchaseprice)
                Grouppurchaseamt = Grouppurchaseamt + Totalpurchase
                Grandpurcahseamt = Grandpurcahseamt + Totalpurchase
                Filewrite.Write("{0,-10}{1,-18}{2,-20}", "", "ITEM TOTAL =====>", "")
                Filewrite.Write("{0,-8}{1,-11}", Mid(Format(Val(TotalQty), "0"), 1, 8), Mid(Trim(LastUOM), 1, 10))
                Filewrite.WriteLine("{0,8}", Mid(Format(Val(Totalpurchase), "0.00"), 1, 8))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "-"))
                pagesize = pagesize + 1
                TotalQty = 0
                Totalpurchase = 0
                Purchaseprice = 0
                '''************************************** $ COMPLETE ITEM TOTAL $ ***************************************''''
                '''************************************** $  ITEM GROUP TOTAL $   **********************************''''
                Filewrite.WriteLine(StrDup(79, "."))
                pagesize = pagesize + 1
                GrandQty = GrandQty + GroupQty
                Filewrite.Write("{0,-10}{1,-23}{2,-15}", "", "ITEM GROUP TOTAL =====>", "")
                Filewrite.Write("{0,-8}{1,-11}", Mid(Format(Val(GroupQty), "0"), 1, 8), "")
                Filewrite.WriteLine("{0,8}", Mid(Format(Val(Grouppurchaseamt), "0.00"), 1, 8))
                pagesize = pagesize + 1
                GroupQty = GroupQty + PresentQty
                Filewrite.WriteLine(StrDup(79, "."))
                pagesize = pagesize + 1
                GroupQty = 0
                GroupPurchase = 0
                Grouppurchaseamt = 0
                boolgrouptotal = True
                '''************************************** $ COMPLETE ITEM GROUP TOTAL $  **********************************''''
                '''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                GrandQty = GrandQty + GroupQty
                Filewrite.Write("{0,-10}{1,-17}{2,-20}", "", "GRAND TOTAL =====>", "")
                Filewrite.Write("{0,-8}{1,-11}", Mid(Format(Val(GrandQty), "0"), 1, 8), "")
                Filewrite.WriteLine("{0,8}", Mid(Format(Val(Grandpurcahseamt), "0.00"), 1, 8))
                pagesize = pagesize + 1
                GroupQty = GroupQty + PresentQty
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                '''************************************** $  COMPLETE GRAND TOTAL $   **************************************''''
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
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,60}{1,-20}", " ", "SUMMARY- WITH COSTING")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-15}{1,-25}{2,-10}{3,-15}{4,10}", "GROUP/ITEM/", "", "", "", "PURCHASE")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-15}{1,-25}{2,-10}{3,-15}{4,10}", "LOCATION", "", "", "", "TOTAL")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
