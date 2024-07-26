Imports System.Data.SqlClient
Imports System.IO
Public Class NonCreditRegisterReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
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

        Dim pos As String

        Dim billdate, billdetails, billamount, taxamount, totalamount, PayMentmode, scode As String
        Dim docdate As String
        Dim bool As Boolean
        Dim i As Integer
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(pageheading, colsize, mskfromdate, msktodate)
            gconnection.getDataSet(SQLSTRING, "master1")
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            For Each dr In gdataset.Tables("master1").Rows
                If pagesize > 55 Then
                    For i = 0 To 135
                        Filewrite.Write("-")
                    Next
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    Call PrintHeader(pageheading, colsize, mskfromdate, msktodate)
                End If

                If pos <> dr("posdesc") Then
                    If bool = True Then
                        grandtotal("GROUP TOTAL :", colsize, TOT)
                        For i = 0 To 9
                            TOT(i) = 0
                        Next
                        bool = False
                    End If
                    Filewrite.WriteLine(dr("posdesc"))
                    pagesize = pagesize + 1
                    pos = dr("posdesc")
                    bool = True

                End If

                Filewrite.Write(Space(colsize(0)))

                Filewrite.Write(Trim(dr("BILLDATE")))
                Filewrite.Write(Space(colsize(1) - Trim(dr("BILLDATE")).Length))

                Filewrite.Write(Trim(dr("BILLDETAILS")))
                Filewrite.Write(Space(colsize(2) - Trim(dr("billdetails")).Length))

                Filewrite.Write(Trim(dr("servercode")))
                Filewrite.Write(Space(colsize(3) - Trim(dr("servercode")).Length))


                Filewrite.Write(Trim(Format(dr("amount"), "0.00")))
                Filewrite.WriteLine(Space(colsize(4) - Len(Trim(Format(dr("amount"), "0.00")))))
                pagesize = pagesize + 1
                TOT(0) = TOT(0) + dr("amount")
                TOT1(0) = TOT1(0) + dr("amount")
                Filewrite.WriteLine()
                pagesize = pagesize + 1

            Next

            grandtotal("GROUP TOTAL :", colsize, TOT)
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            grandtotal("GRAND TOTAL :", colsize, TOT1)
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal colsize() As Integer, ByVal mskfromdate As Date, ByVal msktodate As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-26}{1,88}{2,20}", "THE CALCUTTA SWIMMING CLUB", " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-15}{1,42}{2,23}{3,30} {4,25}", "1, STRAND ROAD", " ", Heading(0), " ", "01-04-2006 TO 31-03-2007")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-15}{1,40}{2,25}", "KOLKATA -700001", " ", "-----------------------")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : ", pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            For I = 0 To 135
                Filewrite.Write("-")
            Next
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-22}{2,-20}{3,-20}{4,-20}", "CLUB/", "BILL", "SERVER", "BASIC", "TAX")
            Filewrite.WriteLine("{0,-20}", "NET")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-22}{2,-20}{3,-20}{4,-20}", "LOCATION", "NUMBER", "NAME", "AMOUNT", "AMOUNT")
            Filewrite.WriteLine("{0,-20}", "AMOUNT")
            pagesize = pagesize + 1
            For I = 0 To 135
                Filewrite.Write("-")
            Next
        Catch ex As Exception
            Exit Function
        End Try
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
        Filewrite.Write(Space((colsize(0) + colsize(1) + colsize(2) + colsize(3)) - (Len(captot))))

        Filewrite.Write(Trim(Format(total(0), "0.00")))

        Filewrite.WriteLine()
        pagesize = pagesize + 1
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
    End Function
End Class
