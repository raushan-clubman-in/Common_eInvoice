Imports System.Data.SqlClient
Imports System.IO
Public Class SaleRegisterVoucherwiseReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As DataRow
    Dim dc As DataColumn
    Dim pageno As Integer
    Dim pagesize As Integer
    Function begin()
        AppPath = Application.StartupPath
    End Function
    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal pageheading() As String, ByVal columnheading() As String, ByVal colsize() As Integer, ByVal lstpos As CheckedListBox, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal total() As Integer)
        printdata(con, sqlstring, pageheading, columnheading, colsize, lstpos, mskfromdate, msktodate, total)
    End Function
    Private Function printdata(ByVal con As String, ByVal SQLSTRING As String, ByVal pageheading() As String, ByVal columnheading() As String, ByVal colsize() As Integer, ByVal lstpos As CheckedListBox, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal total() As Integer)
        Dim x As String
        Dim J As Integer
        Dim TOT(10) As Double
        Dim TOT1(10) As Double
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            HEADER(pageheading, columnheading, colsize)
            columnheader(columnheading, colsize)
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Dim pos As String
            Dim billdate, billdetails, billamount, taxamount, totalamount, PayMentmode, server As String
            Dim docdate As String
            Dim bool As Boolean
            Dim i As Integer

            For Each dr In ds.Tables("master1").Rows
                If pagesize > 55 Then
                    For i = 0 To 123
                        Filewrite.Write("-")
                    Next
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    HEADER(pageheading, columnheading, colsize)
                    columnheader(columnheading, colsize)
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                End If

                If pos <> dr("posdesc") Then
                    Filewrite.WriteLine(dr("posdesc") & ":")
                    pagesize = pagesize + 1
                    pos = dr("posdesc")
                End If

                If billdate <> dr("billdate") Then
                    Filewrite.Write(Trim(dr("BILLDATE")))
                    Filewrite.Write(Space(colsize(0) - Trim(dr("BILLDATE")).Length))
                    billdate = dr("billdate")
                Else
                    Filewrite.Write(Space(colsize(0)))
                End If
                If billdetails <> dr("billdetails") Then
                    Filewrite.Write(Trim(dr("BILLDETAILS")))
                    Filewrite.Write(Space(colsize(1) - Trim(dr("billdetails")).Length))
                    billdetails = dr("billdetails")
                Else
                    Filewrite.Write(Space(colsize(1)))
                End If

                Filewrite.Write(Trim(Format(dr("BASIC"), "0.00")))
                Filewrite.Write(Space(colsize(2) - Len(Trim(Format(dr("BASIC"), "0.00")))))
                'TOT(0) = TOT(0) + dr("BASIC")
                'TOT1(0) = TOT1(0) + dr("billamount")

                Filewrite.Write(Trim(Format(dr("SALESTAX"), "0.00")))
                Filewrite.Write(Space(colsize(3) - Len(Trim(Format(dr("SALESTAX"), "0.00")))))
                'TOT(1) = TOT(1) + dr("SALESTAX")
                'TOT1(1) = TOT1(1) + dr("SALESTAX")

                'Filewrite.Write(Trim(Format(dr("SERVICECHARGE"), "0.00")))
                'Filewrite.Write(Space(colsize(4) - Len(Trim(Format(dr("SERVICECHARGE"), "0.00")))))
                'TOT(2) = TOT(2) + dr("SERVICECHARGE")
                'TOT1(2) = TOT1(2) + dr("SERVICECHARGE")

                Filewrite.Write(Trim(Format(dr("NETAMOUNT"), "0.00")))
                Filewrite.Write(Space(colsize(5) - Len(Trim(Format(dr("NETAMOUNT"), "0.00")))))
                'TOT(2) = TOT(2) + dr("NETAMOUNT")
                'TOT1(2) = TOT1(2) + dr("NETAMOUNT")

                'Filewrite.Write(Trim(Format(dr("PAIDAMOUNT"), "0.00")))
                'Filewrite.Write(Space(colsize(6) - Len(Trim(Format(dr("PAIDAMOUNT"), "0.00")))))
                'TOT(2) = TOT(2) + dr("NETAMOUNT")
                'TOT1(2) = TOT1(2) + dr("NETAMOUNT")
                Filewrite.Write(Space(colsize(7)))
                Filewrite.Write(Space(colsize(8)))

                If PayMentmode <> dr("paymentmode") Then
                    Filewrite.Write(Mid(Trim(dr("PAYMENTMODE")), 1, 10))
                    Filewrite.Write(Space(colsize(9) - Mid(Trim(dr("PAYMENTMODE")), 1, 10).Length))
                    PayMentmode = dr("paymentmode")
                Else
                    Filewrite.Write(Space(colsize(9)))
                End If
                If server <> dr("server") Then
                    Filewrite.Write(Trim(dr("SERVER")))
                    Filewrite.Write(Space(colsize(10)))
                    server = dr("server")
                Else
                    Filewrite.Write(Space(colsize(10)))
                End If
                Filewrite.WriteLine()
                pagesize = pagesize + 1
            Next
            'grandtotal("GROUP TOTAL :", colsize, TOT)
            'Filewrite.WriteLine()
            'Filewrite.WriteLine()
            'grandtotal("GRAND TOTAL :", colsize, TOT1)
            For J = 0 To 123
                Filewrite.Write("-")
            Next
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
    Private Function HEADER(ByVal pageheading() As String, ByVal columnheading() As String, ByVal colsize() As Integer)
        Dim I, COLUMNCOUNT As Integer
        Dim CHECKEDITEMSNO As Integer
        Dim head As String
        Dim x As String
        pagesize = 0
        'counts the colummns in the checkbox and assign page size 
        Try
            Filewrite.Write("THE CALCUTTA SWIMMING CLUB" & Chr(18))
            Filewrite.Write(Space(76) & Chr(18))
            Filewrite.WriteLine("ACCOUNTING PERIODS" & Chr(18))
            pagesize = pagesize + 1
            Filewrite.Write("1, STRAND ROAD")
            Filewrite.Write(Space((109 - (Len(pageheading(0))) - 24) / 2))
            Filewrite.Write(pageheading(0))
            Filewrite.Write(Space((109 - (Len(pageheading(0))) - 24) / 2))
            Filewrite.WriteLine("01-04-2006 TO 31-03-2007")
            pagesize = pagesize + 1
            Filewrite.Write("KOLKATA -700001")
            Filewrite.Write(Space(29))
            For I = 0 To pageheading(0).Length - 1
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.Write(Space(50))
            Filewrite.WriteLine("SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.Write("DATE : ")
            Filewrite.Write(Format(Date.Today, "dd-MM-yyyy"))
            Filewrite.Write(Space(95))
            Filewrite.Write("PAGE :")
            Filewrite.WriteLine(pageno)
            pagesize = pagesize + 1
            Filewrite.Write(Space(106))
            Filewrite.WriteLine("AMOUNT IN RUPEES")
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Function columnheader(ByVal columnheading() As String, ByVal colsize() As Integer)
        Dim x As String
        Dim i As Integer
        i = 0
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        i = 0
        For Each x In columnheading
            Filewrite.Write(x)
            Filewrite.Write(Space(colsize(i) - x.Length))
            i = i + 1
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        For i = 0 To 123
            Filewrite.Write("-")
        Next
    End Function
    Private Function grandtotal(ByVal captot As String, ByVal colsize() As Integer, ByVal total() As Double)
        Dim x, y As String
        Dim bool As Boolean
        Dim i, j As Integer
        i = 0
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        Filewrite.Write(captot)
        Filewrite.Write(Space((colsize(0) + colsize(1)) - (Len(captot))))

        Filewrite.Write(Trim(Format(total(0), "0.00")))
        Filewrite.Write(Space(colsize(2) - Len(Trim(Format(total(0), "0.00")))))
        Filewrite.Write(Trim(Format(total(1), "0.00")))
        Filewrite.Write(Space(colsize(3) - Len(Trim(Format(total(1), "0.00")))))
        Filewrite.Write(Trim(Format(total(2), "0.00")))
        Filewrite.Write(Space(colsize(4) - Len(Trim(Format(total(2), "0.00")))))
        Filewrite.Write(Trim(Format(total(3), "0.00")))
        Filewrite.Write(Space(colsize(5) - Len(Trim(Format(total(3), "0.00")))))
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
    End Function
End Class
