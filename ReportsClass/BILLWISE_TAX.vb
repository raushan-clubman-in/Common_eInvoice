Imports System.Data.SqlClient
Imports System.IO
Public Class BILLWISE_TAX
    Dim pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Detailsection(ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal HNAME As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim i As Integer = 1
        Dim j As Integer
        Dim boolitem, boolgrouptotal As Boolean
        Dim SSQL, Itemdesc, Itemcode, Uom As String
        Dim GrandQty, TotalAmount, TotalQty, TotalRate, GrandAmount, ItemAmount, TaxAmount, PACKAMT, KICHAMT, GRNDKICHAMT, GRDPACKAMT As Double
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
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                GrandAmount = 0 : ItemAmount = 0 : TaxAmount = 0 : PACKAMT = 0
                For Each dr In gdataset.Tables("SALEREGISTERSUMMARY").Rows
                    If pagesize >= 58 Then
                        Filewrite.Write(StrDup(149, "-"))
                        pagesize = pagesize + 1
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(HNAME, mskfromdate, msktodate)
                    End If
                    'If Itemcode <> Trim(CStr(dr("ITEMCODE"))) And Uom <> Trim(CStr(dr("UOM"))) Then
                    Filewrite.Write("{0,-7}{1,-10}", Mid(Format(Val(i), "0") & ".", 1, 7), Mid(Trim(dr("ITEMCODE")), 1, 10))
                    Filewrite.Write("{0,-27}", Mid(Trim(dr("ITEMDESC")), 1, 27))
                    Filewrite.Write("{0,-11}", Format(dr("KOTDATE"), "dd/MM/yyyy"))
                    Filewrite.Write("{0,10}", Mid(dr("kotdetails"), 1, 10))
                    Filewrite.Write("{0,6}", Mid(dr("mcode"), 1, 6))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("QTY")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(dr("POSCODE"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(dr("GROUPCODE"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(dr("TAXCODE"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("AMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("TAXAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("PACKAMOUNT")), "0.00"), 1, 10))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("SER_CHG")), "0.00"), 1, 10))
                    Filewrite.WriteLine("{0,13}", Mid(Format(Val(dr("BILLAMOUNT")), "0.00"), 1, 13))
                    pagesize = pagesize + 1
                    GrandAmount = Val(GrandAmount) + Val(dr("BILLAMOUNT"))
                    ItemAmount = Val(ItemAmount) + Val(dr("AMOUNT"))
                    TaxAmount = Val(TaxAmount) + Val(dr("TAXAMOUNT"))
                    GRDPACKAMT = GRDPACKAMT + Val(dr("PACKAMOUNT"))
                    PACKAMT = PACKAMT + Val(dr("PACKAMOUNT"))
                    KICHAMT = KICHAMT + Val(dr("SER_CHG"))
                    GRNDKICHAMT = GRNDKICHAMT + Val(dr("SER_CHG"))
                    i = i + 1
                    Itemcode = dr("ITEMCODE")
                    'Uom = dr("UOM")
                    TotalAmount = 0 : TotalQty = 0 : TotalRate = 0
                    'End If
                Next
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                '''******************************************** $  GRAND TOTAL $   ****************************************''''
                Filewrite.WriteLine(StrDup(177, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-17}{1,-27}", "", "GRAND TOTAL =====>")
                Filewrite.Write("{0,-11}{0,10}{0,10}{0,10}{0,10}{0,10}{0,10}", "", "", "", "", "", "", "")
                Filewrite.Write("{0,16}", Mid(Format(Val(ItemAmount), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(TaxAmount), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(GRDPACKAMT), "0.00"), 1, 10))
                Filewrite.Write("{0,10}", Mid(Format(Val(GRNDKICHAMT), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,13}", Mid(Format(Val(GrandAmount), "0.00"), 1, 13))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(177, "="))
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
    Private Function PrintHeader(ByVal HNAME As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I, HLEN As Integer
        HLEN = Len(Trim(HNAME))
        pagesize = 0
        Try
            '''*********************************************** PRINT REPORTS HEADING  *********************************'''
            Filewrite.Write(Chr(15))
            'Filewrite.WriteLine("{0,Len(Trim(HNAME))}{1,20}{2,30}{3,25}", "", Mid(HNAME, 1, Len(Trim(HNAME))), " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            'Filewrite.Write("{0," & Len(Trim(HNAME)) & "}", Mid(HNAME, 1, Len(Trim(HNAME))))
            'Filewrite.WriteLine("{0,20}{1,30}{2,25}", "", " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            'pagesize = pagesize + 1
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-60}", Mid(MyCompanyName, 1, 60))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,50}", "BILL TYPE:" & Trim(HNAME))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,65}", "BILLNO WISE SUMMARY FROM :" & Format(MSKFROMDATE, "dd/MM/yyyy") & " TO: " & Format(MSKTODATE, "dd/MM/yyyy") & Space(110) & "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(177, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-7}{1,-10}{2,-27}{3,11}{4,10}{5,6}{6,10}{7,10}{8,10}{9,10}{10,10}{11,10}{12,10}{13,10}{14,10}{15,13}", "SLNO.", "ITEM CODE", "ITEM DESCRIPTION", "KOTDATE", "KOTNO", " MCODE ", "QUANTITY", "RATE", "POSCODE", "GROUPCODE", "TAXCODE", "AMOUNT", "TAXAMOUNT", "AC CHG", "KICH CHG", "TOTALAMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(177, "="))
            pagesize = pagesize + 1
            '''*********************************************** COMPLETE PRINT REPORTS HEADING  *********************************'''
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
