Imports System.Data.SqlClient
Imports System.IO
Public Class rptSaleregistersummary_TAXTYPE
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Detailsection(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal HNAME As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim i As Integer = 1
        Dim j As Integer
        Dim boolitem, boolgrouptotal As Boolean
        Dim SSQL, Itemdesc, Itemcode, Uom, GROUPCODE, GROUPNAME As String
        Dim GrandQty, TotalAmount, TotalQty, TotalRate, GrandAmount, ItemAmount, TaxAmount, GRDPACKAMT, PACKAMT, GRNDKICHAMT, KICHAMT As Double
        Dim GRPQty, GRPAmount, GRPRate, GRPGrnamount, GrpItemAmount, grpTaxAmount As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(HNAME, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "SALEREGISTERSUMMARY")
            If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
                pagesize = pagesize + 1
                GrandAmount = 0 : ItemAmount = 0 : TaxAmount = 0
                GROUPCODE = gdataset.Tables("SALEREGISTERSUMMARY").Rows(0).Item("GROUPCODE")
                GROUPNAME = gdataset.Tables("SALEREGISTERSUMMARY").Rows(0).Item("GROUPNAME")
                GRPQty = 0 : GRPAmount = 0 : GRPRate = 0 : GRPGrnamount = 0 : GRNDKICHAMT = 0 : GrpItemAmount = 0 : grpTaxAmount = 0 : PACKAMT = 0
                For Each dr In gdataset.Tables("SALEREGISTERSUMMARY").Rows
                    If Trim(dr("GROUPCODE")) <> GROUPCODE Then
                        Filewrite.WriteLine("								------------------------------------------------------------------------")
                        pagesize = pagesize + 1
                        Filewrite.Write("{0,-17}{1,-27}", "", GROUPNAME)
                        Filewrite.Write("{0,5}", "")
                        Filewrite.Write("{0,15}", "GROUP TOTAL :")
                        Filewrite.Write("{0,10}", Mid(Format(Val(GrpItemAmount), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(grpTaxAmount), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(PACKAMT), "0.00"), 1, 10))
                        Filewrite.Write("{0,10}", Mid(Format(Val(KICHAMT), "0.00"), 1, 10))
                        Filewrite.WriteLine("{0,13}", Mid(Format(Val(GRPGrnamount), "0.00"), 1, 13))
                        Filewrite.WriteLine("								------------------------------------------------------------------------")
                        GROUPCODE = Trim(dr("GROUPCODE"))
                        GROUPNAME = Trim(dr("GROUPNAME"))
                        GRPQty = 0 : GRPAmount = 0 : KICHAMT = 0 : GRPRate = 0 : PACKAMT = 0 : GRPGrnamount = 0 : GrpItemAmount = 0 : grpTaxAmount = 0
                    End If

                    If pagesize >= 58 Then
                        Filewrite.Write(StrDup(120, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(HNAME, mskfromdate, msktodate)
                    End If

                    'If Itemcode <> Trim(CStr(dr("ITEMCODE"))) And Uom <> Trim(CStr(dr("UOM"))) Then
                    Filewrite.Write("{0,-7}{1,-10}", Mid(Format(Val(i), "0") & ".", 1, 7), Mid(Trim(dr("ITEMCODE")), 1, 10))
                    Filewrite.Write("{0,-27}", Mid(Trim(dr("ITEMDESC")), 1, 27))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("QTY")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("PACKAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("SER_CHG")), "0.00"), 1, 10))
                    Filewrite.WriteLine("{0,13}", Mid(Format(Val(dr("BILLAMOUNT")), "0.00"), 1, 13))
                    pagesize = pagesize + 1
                    GrandAmount = Val(GrandAmount) + Val(dr("BILLAMOUNT"))
                    ItemAmount = Val(ItemAmount) + Val(dr("AMOUNT"))
                    GRDPACKAMT = Val(GRDPACKAMT) + Val(dr("PACKAMOUNT"))
                    PACKAMT = Val(PACKAMT) + Val(dr("PACKAMOUNT"))
                    KICHAMT = Val(KICHAMT) + Val(dr("SER_CHG"))
                    TaxAmount = Val(TaxAmount) + Val(dr("TAXAMOUNT"))

                    GRNDKICHAMT = Val(GRNDKICHAMT) + Val(dr("SER_CHG"))
                    GRPGrnamount = GRPGrnamount + Val(dr("BILLAMOUNT"))
                    GrpItemAmount = GrpItemAmount + Val(dr("AMOUNT"))
                    grpTaxAmount = grpTaxAmount + Val(dr("TAXAMOUNT"))

                    i = i + 1
                    Itemcode = dr("ITEMCODE")
                    'Uom = dr("UOM")
                    TotalAmount = 0 : TotalQty = 0 : TotalRate = 0
                    'End If
                Next
                Filewrite.WriteLine("								------------------------------------------------------------------------")
                Filewrite.Write("{0,-17}{1,-27}", "", GROUPNAME)
                Filewrite.Write("{0,5}", "")
                Filewrite.Write("{0,15}", "GROUP TOTAL :")
                Filewrite.Write("{0,10}", Mid(Format(Val(GrpItemAmount), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(grpTaxAmount), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(PACKAMT), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(KICHAMT), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,13}", Mid(Format(Val(GRPGrnamount), "0.00"), 1, 13))
                Filewrite.WriteLine(StrDup(120, "="))
                Filewrite.Write("{0,-17}{1,-27}", "", "GRAND TOTAL =====>")
                Filewrite.Write("{0,10}", "")
                Filewrite.Write("{0,10}", "")
                Filewrite.Write("{0,10}", Mid(Format(Val(ItemAmount), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(TaxAmount), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(GRDPACKAMT), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(GRNDKICHAMT), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,13}", Mid(Format(Val(GrandAmount), "0.00"), 1, 13))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(120, "="))
                pagesize = pagesize + 1
                ''Filewrite.WriteLine("      (BAR MAN)                     (BAR CASHIER)                     (CASHIER)")
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
    Private Function PrintHeader(ByVal HNAME As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I, HLEN As Integer
        HLEN = Len(Trim(HNAME))
        pagesize = 0
        Try
            Filewrite.WriteLine(Mid(MyCompanyName, 1, 50))
            Filewrite.WriteLine("BILLING TYPE:" & Trim(HNAME))
            pagesize = pagesize + 1
            Filewrite.WriteLine("ITEM WISE SUMMARY FROM:" & Format(MSKFROMDATE, "MMM dd,yyyy") & " T0 :" & Format(MSKTODATE, "MMM dd,yyyy") & Space(60) & "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(120, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-7}{1,-10}{2,-27}{3,10}{4,10}{5,10}{6,10}{7,10}{8,10}{9,13}", "SLNO.", "ITEM CODE", "ITEM DESCRIPTION", "QUANTITY", "RATE", "AMOUNT", "TAXAMOUNT", "AC.CHG", "KICH.TAX", "TOTALAMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(120, "="))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
