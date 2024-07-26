Imports System.Data.SqlClient
Imports System.IO
Public Class SaleItemwiseRegister2
    Dim dr As DataRow
    Dim pageno As Integer
    Dim pagesize As Integer
    Dim Gconnection As New GlobalClass
    Public Function printdata(ByVal SQLSTRING As String, ByVal heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal SQLSTRINGCANCEL As String)
        Dim docdate As Date
        Dim booltotal, boolgrouptotal As Boolean
        Dim GroupDesc, POSdesc, itemdesc, itemcode, LastUOM, Rowprint As String
        Dim changeno, billsdetails, servercode, billamount, totalamount As String
        Dim kotdate, kotnumber, kottime, SSQL, posdescription As String
        Dim amount, basic, discountamount, i, J As Integer
        Dim QtySum, AmountSum, GrandQty, GrandAmount, GroupQty, GroupAmount As Double
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
            Gconnection.getDataSet(SQLSTRING, "ITEMWISESALEREGISTER")
            If gdataset.Tables("ITEMWISESALEREGISTER").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                basic = 0
                amount = 0
                For Each dr In gdataset.Tables("ITEMWISESALEREGISTER").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(79, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Filewrite.Write(Chr(15))
                        Call PrintHeader(heading, mskfromdate, msktodate)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If

                    ''''If dr("itemcode") = "613" Then
                    ''''    Filewrite.WriteLine()
                    ''''End If

                    If GroupDesc <> CStr(dr("GroupDesc")) Then
                        If boolgrouptotal = True Then
                            '''************************************** $ ITEM TOTAL $ ***************************************''''
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,27}", "ITEM TOTAL =====>")
                            Filewrite.Write("{0,-18}{1,5}{2,-4}", "", Mid(Format(Val(QtySum), "0"), 1, 5), "")

                            Filewrite.WriteLine("{0,-6}{1,8}{2,11}", Mid(Trim(LastUOM), 1, 6), "", Mid(Format(Val(AmountSum), "0.00"), 1, 8))

                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            QtySum = 0
                            AmountSum = 0
                            booltotal = False
                            '''************************************** $ COMPLETE ITEM TOTAL $ ***************************************''''
                            '''************************************** $  ITEM GROUP TOTAL $   **********************************''''
                            Filewrite.WriteLine(StrDup(79, "."))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,33}", "ITEM GROUP TOTAL =====>")
                            Filewrite.Write("{0,-12}{1,5}{2,-4}", "", Mid(Format(Val(Trim(GroupQty)), "0"), 1, 4), "")
                            Filewrite.WriteLine("{0,-6}{1,8}{2,11}", "", "", Mid(Format(Val(GroupAmount), "0.00"), 1, 8))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "."))
                            pagesize = pagesize + 1
                            GroupQty = 0
                            GroupAmount = 0
                            boolgrouptotal = True
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            '''************************************** $ COMPLETE ITEM GROUP TOTAL $  **********************************''''
                        End If
                        If dr("KOTSTATUS") = "Y" Then
                            Filewrite.WriteLine("CANCEL GROUP")
                            pagesize = pagesize + 1
                            GroupDesc = "CANCEL GROUP"
                        Else
                            Filewrite.WriteLine(dr("GroupDesc"))
                            pagesize = pagesize + 1
                            GroupDesc = dr("GroupDesc")
                        End If
                        boolgrouptotal = True
                    End If

                    If itemdesc <> dr("ITEMDESC") And itemcode <> dr("ITEMCODE") Then
                        If booltotal = True Then
                            '''************************************** $ ITEM TOTAL $ ***************************************''''
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,27}", "ITEM TOTAL =====>")
                            Filewrite.Write("{0,-18}{1,5}{2,-4}", "", Mid(Format(Val(QtySum), "0"), 1, 5), "")

                            Filewrite.WriteLine("{0,-6}{1,8}{2,11}", Mid(Trim(LastUOM), 1, 6), "", Mid(Format(Val(AmountSum), "0.00"), 1, 8))

                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(79, "-"))
                            pagesize = pagesize + 1
                            QtySum = 0
                            AmountSum = 0
                            booltotal = False
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            '''************************************** $ COMPLETE ITEM TOTAL $ ***************************************''''
                            billsdetails = ""
                        End If
                        If dr("KOTSTATUS") = "Y" Then
                            Filewrite.Write("{0,-5}{1,-40}", "", Mid(Trim("CANCEL ITEM"), 1, 40))
                            Filewrite.WriteLine("{0,-5}{1,-15}", "", Mid("(" & "CODE :" & "00001" & ")", 1, 15))
                            pagesize = pagesize + 1
                            itemdesc = "CANCEL ITEM"
                            itemcode = "00001"
                        Else
                            Filewrite.Write("{0,-5}{1,-40}", "", Mid(Trim(dr("ITEMDESC")), 1, 40))
                            Filewrite.WriteLine("{0,-5}{1,-15}", "", Mid("(" & "CODE :" & dr("ITEMCODE") & ")", 1, 15))
                            pagesize = pagesize + 1
                            itemdesc = dr("ITEMDESC")
                            itemcode = dr("ITEMCODE")
                        End If
                        Filewrite.WriteLine("{0,-10}{1,-15}", "", Mid(Trim(dr("POSDESC")), 1, 20))
                        pagesize = pagesize + 1
                        POSdesc = dr("POSDESC")
                        posdescription = dr("POSDESC")
                        booltotal = True
                    End If
                    If billsdetails <> dr("KOTDETAILS") Or J > 1 Then
                        If dr("kotstatus") = "N" Then
                            ' SSQL = "Seelct kotdate from kot_hdr where kotdetails='" & dr("kotdetails") & "'"
                            'Gconnection.getDataSet(SSQL, "kotdate")
                            'If gdataset.Tables("kotdate").Rows.Count > 0 Then
                            'Filewrite.Write("{0,-15}{1,-12}", "[" & Format(gdataset.Tables("kotdate").Rows(0).Item(0), "HH:mm:ss") & "]", Mid(Format(dr("KOTDATE"), "dd/MM/yyyy"), 1, 12))
                            'End If
                            Filewrite.Write("{0,-15}{1,-12}", "[" & Format(dr("KOTDATE"), "HH:mm:ss") & "]", Mid(Format(dr("KOTDATE"), "dd/MM/yyyy"), 1, 12))
                            Filewrite.Write("{0,-18}", Mid(Trim(dr("KOTDETAILS")), 1, 20))
                        billsdetails = dr("KOTDETAILS")
                        J = J + 1
                    End If
                    Else
                    Filewrite.Write("{0,-15}{1,-12}{2,-18}", "", "", "")
                    End If
                    If dr("KOTSTATUS") = "N" Then
                        Filewrite.Write("{0,5}{1,-4}", Mid(Format(Val(Trim(dr("QTY"))), "0"), 1, 4), "")
                        Filewrite.Write("{0,-6}", Mid(Trim(CStr(dr("UOM"))), 1, 6))
                        LastUOM = Trim(dr("baseUOMstd"))
                    End If

                    SSQL = " SELECT ISNULL(RATIO2,0) AS RATIO2 FROM UOMRELATION WHERE UOM1 = '" & Trim(CStr(dr("UOM"))) & "' AND UOM2 = '" & Trim(LastUOM) & "'"
                    Gconnection.getDataSet(SSQL, "UOMRELATION")
                    If gdataset.Tables("UOMRELATION").Rows.Count > 0 Then
                        If dr("KOTSTATUS") = "N" Then
                            QtySum = QtySum + (Format(Val(dr("QTY")), "0") * gdataset.Tables("UOMRELATION").Rows(0).Item("RATIO2"))
                            GroupQty = GroupQty + (Format(Val(dr("QTY")), "0") * gdataset.Tables("UOMRELATION").Rows(0).Item("RATIO2"))
                            GrandQty = GrandQty + (Format(Val(dr("QTY")), "0") * gdataset.Tables("UOMRELATION").Rows(0).Item("RATIO2"))
                        End If
                    Else
                        If dr("KOTSTATUS") = "N" Then
                            QtySum = QtySum + Format(Val(dr("QTY")), "0")
                            GroupQty = GroupQty + Format(Val(dr("QTY")), "0")
                            GrandQty = GrandQty + Format(Val(dr("QTY")), "0")
                        End If
                    End If
                    If dr("KOTSTATUS") = "N" Then
                        Filewrite.Write("{0,8}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 8))
                        Filewrite.Write("{0,11}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 8))
                        'If dr("KOTSTATUS") = "N" Then
                        AmountSum = AmountSum + Format(Val(dr("AMOUNT")), "0.00")
                        GroupAmount = GroupAmount + Format(Val(dr("AMOUNT")), "0.00")
                        GrandAmount = GrandAmount + Format(Val(dr("AMOUNT")), "0.00")
                    End If
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''************************************** $ ITEM TOTAL $ ***************************************''''
                Filewrite.WriteLine(StrDup(79, "-"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,27}", "ITEM TOTAL =====>")
                Filewrite.Write("{0,-18}{1,5}{2,-4}", "", Mid(Format(Val(QtySum), "0"), 1, 5), "")
                Filewrite.WriteLine("{0,-6}{1,8}{2,11}", Mid(Trim(LastUOM), 1, 6), "", Mid(Format(Val(AmountSum), "0.00"), 1, 8))


                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "-"))
                pagesize = pagesize + 1
                QtySum = 0
                AmountSum = 0
                booltotal = False
                '''************************************** $ COMPLETE ITEM TOTAL $ ***************************************''''
                '''************************************** $  ITEM GROUP TOTAL $   **********************************''''
                Filewrite.WriteLine(StrDup(79, "."))
                pagesize = pagesize + 1
                Filewrite.Write("{0,33}", "ITEM GROUP TOTAL =====>")
                Filewrite.Write("{0,-12}{1,5}{2,-4}", "", Mid(Format(Val(Trim(GroupQty)), "0"), 1, 4), "")
                Filewrite.WriteLine("{0,-6}{1,8}{2,11}", "", "", Mid(Format(Val(GroupAmount), "0.00"), 1, 8))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(79, "."))
                pagesize = pagesize + 1
                GroupQty = 0
                GroupAmount = 0
                boolgrouptotal = True
                ''=========================CANCEL ITEM PRINTING ===================================================
                Gconnection.getDataSet(SQLSTRINGCANCEL, "CANCELGROUP")
                Dim cItemDesc, cPosDesc As String
                If gdataset.Tables("cancelgroup").Rows.Count > 0 Then

                    Filewrite.WriteLine("CANCEL GROUP")
                    Filewrite.Write("{0,-5}{1,-40}", "", Mid(Trim("CANCEL ITEM"), 1, 40))
                    Filewrite.WriteLine("{0,-5}{1,-15}", "", Mid("(" & "CODE :" & "00001" & ")", 1, 15))
                    Filewrite.WriteLine()
                    For J = 0 To gdataset.Tables("cancelgroup").Rows.Count - 1
                        If cPosDesc <> gdataset.Tables("cancelgroup").Rows(J).Item("posdesc") Then
                            Filewrite.WriteLine("{0,-10}{1,-15}", "", Mid(Trim(gdataset.Tables("cancelgroup").Rows(J).Item("posdesc")), 1, 20))
                            Filewrite.WriteLine()
                        End If
                        Filewrite.Write("{0,-15}{1,-12}", "[" & Format(gdataset.Tables("cancelgroup").Rows(J).Item("KOTDATE"), "HH:mm:ss") & "]", Mid(Format(gdataset.Tables("cancelgroup").Rows(J).Item("KOTDATE"), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-18}", Mid(Trim(gdataset.Tables("cancelgroup").Rows(J).Item("KOTDETAILS")), 1, 20))
                        Filewrite.Write("{0,5}{1,-4}", Mid(Format(Val(Trim(gdataset.Tables("cancelgroup").Rows(J).Item("QTY"))), "0"), 1, 4), "")
                        Filewrite.Write("{0,-6}", Mid(Trim(CStr(gdataset.Tables("cancelgroup").Rows(J).Item("UOM"))), 1, 6))
                        Filewrite.Write("{0,8}", Mid(Format(Val(0), "0.00"), 1, 8))
                        Filewrite.Write("{0,11}", Mid(Format(Val(0), "0.00"), 1, 8))
                        Filewrite.WriteLine()
                        cPosDesc = gdataset.Tables("cancelgroup").Rows(J).Item("posdesc")
                    Next
                    Filewrite.WriteLine(StrDup(79, "="))
                    Filewrite.Write("{0,27}", "ITEM TOTAL =====>")
                    Filewrite.WriteLine("{0,-18}{1,5}{2,-4}", "", Mid(Format(Val(0), "0"), 1, 5), "")
                End If


                ''=================================================================================================
                '''************************************** $ COMPLETE ITEM GROUP TOTAL $  **********************************''''
                '''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(79, "."))
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-10}{1,-38}", "", "GRAND TOTAL =====>")
                Filewrite.Write("{0,-21}", Mid(Format(Val(Trim(GrandQty)), "0"), 1, 8))
                Filewrite.WriteLine("{0,10}", Mid(Format(Val(GrandAmount), "0.00"), 1, 8))
                Filewrite.WriteLine(StrDup(79, "="))
                pagesize = pagesize + 1
                '''************************************** $  COMPLETE GRAND TOTAL $   **************************************''''
                If posdescription = "BAR 1" Or posdescription = "BAR 2" Or posdescription = "BAR 3" Then
                    Filewrite.WriteLine(StrDup(79, "-"))
                    pagesize = pagesize + 1
                    Filewrite.Write("{0,-20}", "Bulk Liter : Spirit")
                    Filewrite.Write("{0,15}{1,-15}", "0.000", "")
                    Filewrite.WriteLine("{0,-18}{1,9}", "Alcohol Sale       :", Mid(Format(Val(GrandAmount), "0.00"), 1, 8))
                    Filewrite.Write("{0,-20}", "           : Beer")
                    Filewrite.Write("{0,15}{1,-15}", "0.000", "")
                    Filewrite.WriteLine("{0,-18}{1,9}", "Soft Drinks Sale   :", Mid(Format(Val(GrandAmount), "0.00"), 1, 8))
                    Filewrite.WriteLine(StrDup(79, "="))
                    pagesize = pagesize + 1
                End If
                Filewrite.WriteLine()
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
            MsgBox(ex.Message & ex.Source & ex.ToString & ex.HelpLink)
            Exit Function
        End Try
    End Function

    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''

            ' Filewrite.Write(Chr(15))
            Filewrite.Write(Chr(18) & Chr(27) + "E" & Chr(27) + "F")
            Filewrite.WriteLine("{0,23}{1,20}{2,11}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.Write(Chr(15))
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
            Filewrite.WriteLine("{0,-15}{1,-12}{2,-18}{3,5}{4,-4}{5,-6}{6,8}{7,11}", "GROUP/ITEM/", "KOT", "KOT", "QTY", "", "UOM", "RATE", "NET")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-15}{1,-12}{2,-18}{3,5}{4,-4}{5,-6}{6,8}{7,11}", "LOCATION", "DATE", "NUMBER", "", "", "", "", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
