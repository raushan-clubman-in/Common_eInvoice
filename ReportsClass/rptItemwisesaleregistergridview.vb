Public Class rptItemwisesaleregistergridview
    Dim hrow(100) As Integer
    Dim DR As DataRow
    Dim DC As DataColumn
    Dim ROW, COL As Integer
    Dim I As Integer = 0
    Dim J As Integer = 0
    Dim gclass As New GlobalClass
    Public Function GridColumnname(ByVal GRID As AxFPSpreadADO.AxfpSpread, ByVal columnname() As String, ByVal columnname1() As String, ByVal colsize() As Integer)
        ROW = 1
        COL = 3
        GRID.Row = ROW
        GRID.Col = COL
        GRID.set_ColWidth(COL, 15)
        GRID.FontSize = 12
        GRID.FontBold = True
        GRID.BackColor = Color.White
        GRID.ForeColor = Color.Black
        GRID.Text = "             " & gridviewHeading(0)
        ROW = 2
        COL = 1
        GRID.Row = ROW
        GRID.Col = COL
        GRID.set_ColWidth(COL, colsize(I))
        GRID.FontSize = 10
        GRID.FontBold = True
        GRID.BackColor = Color.White
        GRID.ForeColor = Color.Black
        GRID.Text = "RUN DATE :" & gridviewHeading(1) & " TO " & gridviewHeading(2)
        ROW = 3
        COL = 1
        GRID.Row = ROW
        GRID.Col = COL
        For I = 0 To columnname.Length - 1
            GRID.Row = ROW
            GRID.Col = COL
            GRID.set_ColWidth(COL, colsize(I))
            GRID.FontSize = 10
            GRID.FontBold = True
            GRID.BackColor = Color.Wheat
            GRID.ForeColor = Color.Black
            GRID.Text = columnname(I)
            COL = COL + 1
        Next
        GRID.MaxCols = columnname.Length
        ROW = 4
        COL = 1
        GRID.Row = ROW
        GRID.Col = COL
        For I = 0 To columnname1.Length - 1
            GRID.Row = ROW
            GRID.Col = COL
            GRID.set_ColWidth(COL, colsize(I))
            GRID.FontSize = 10
            GRID.FontBold = True
            GRID.BackColor = Color.Wheat
            GRID.ForeColor = Color.Black
            GRID.Text = columnname1(I)
            COL = COL + 1
        Next
        GRID.MaxCols = columnname1.Length
    End Function

    Public Function BodyOfGrid(ByVal GRID As AxFPSpreadADO.AxfpSpread)
        Dim TOTALAMOUNT As Double
        Dim K As Integer
        Dim ITEMCODE As String = ""
        ROW = 5 : COL = 1 : I = 0 : J = 0 : K = 1
        ROW = ROW + 1
        For Each DR In gdataset.Tables("GRIDVIEW").Rows
            If Trim(ITEMCODE) <> Trim(gdataset.Tables("GRIDVIEW").Rows(I).Item("ITEMCODE")) Then
                GRID.Row = ROW
                GRID.Col = 1
                GRID.FontBold = True
                GRID.Text = Mid(Format(Val(K), "0") & ".", 1, 7)

                GRID.Row = ROW
                GRID.Col = 2
                GRID.FontBold = True
                GRID.Text = Mid(Trim(gdataset.Tables("gridview").Rows(I).Item("ITEMCODE")), 1, 10)

                GRID.Row = ROW
                GRID.Col = 3
                GRID.FontBold = True
                GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                GRID.Text = Mid(Trim(gdataset.Tables("gridview").Rows(I).Item("ITEMDESC")), 1, 50)

                GRID.Row = ROW
                GRID.Col = 4
                GRID.FontBold = True
                GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                GRID.Text = Mid(Format(Val(gdataset.Tables("gridview").Rows(I).Item("QTY")), "0.00"), 1, 10)

                GRID.Row = ROW
                GRID.Col = 5
                GRID.FontBold = True
                GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                GRID.Text = Mid(Format(Val(gdataset.Tables("gridview").Rows(I).Item("RATE")), "0.00"), 1, 10)

                GRID.Col = 6
                GRID.FontBold = True
                GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                TOTALAMOUNT = Val(gdataset.Tables("gridview").Rows(I).Item("QTY")) * Val(gdataset.Tables("gridview").Rows(I).Item("RATE"))
                GRID.Text = Mid(Format(Val(TOTALAMOUNT), "0.00"), 1, 13)

                ITEMCODE = Trim(CStr(gdataset.Tables("GRIDVIEW").Rows(I).Item("ITEMCODE")))
                ROW = ROW + 1
                K = K + 1
                I = I + 1
            End If
        Next
        hrow(J) = ROW - 1
        Call TOTAL(GRID, ROW, 4)
        GRID.MaxRows = ROW + 1
    End Function
    Private Function TOTAL(ByVal GRID As AxFPSpreadADO.AxfpSpread, ByVal ROW As Integer, ByVal COL As Integer)
        Dim DR As DataRow
        Dim TOT As Double = 0
        Dim QTY As Double = 0
        Dim RATE As Double = 0
        Dim I As Integer = 0
        For Each DR In gdataset.Tables("GRIDVIEW").Rows
            QTY = QTY + gdataset.Tables("GRIDVIEW").Rows(I).Item("QTY")
            RATE = RATE + gdataset.Tables("GRIDVIEW").Rows(I).Item("RATE")
            TOT = TOT + Val(gdataset.Tables("gridview").Rows(I).Item("QTY")) * Val(gdataset.Tables("gridview").Rows(I).Item("RATE"))
            I = I + 1
        Next
        GRID.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleFixedSingle
        GRID.Row = ROW
        GRID.Col = COL
        GRID.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleFixedSingle
        GRID.FontBold = True
        GRID.ForeColor = Color.Red
        GRID.Text = "GRAND TOTAL : "

        GRID.Row = ROW
        GRID.Col = COL + 2
        GRID.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleFixedSingle
        GRID.FontBold = True
        GRID.ForeColor = Color.Red
        GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        GRID.Text = Format(QTY, "0.00")

        GRID.Row = ROW
        GRID.Col = COL + 3
        GRID.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleFixedSingle
        GRID.FontBold = True
        GRID.ForeColor = Color.Red
        GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        GRID.Text = Format(RATE, "0.00")

        GRID.Row = ROW
        GRID.Col = COL + 4
        GRID.BorderStyle = FPSpreadADO.BorderStyleConstants.BorderStyleFixedSingle
        GRID.FontBold = True
        GRID.ForeColor = Color.Red
        GRID.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
        GRID.Text = Format(TOT, "0.00")
    End Function
    Public Function KeyDownEvent(ByVal GRID As AxFPSpreadADO.AxfpSpread, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent)
        If e.keyCode = Keys.Enter Then
            GRID.Col = GRID.ActiveCol
            GRID.Row = GRID.ActiveRow
            If GRID.Col = GRID.MaxCols Then
                GRID.SetActiveCell(1, GRID.Row + 1)
            Else
                GRID.SetActiveCell(GRID.Col + 1, GRID.Row)
            End If
        End If
    End Function

    Public Function DoubleClick(ByVal GRID As AxFPSpreadADO.AxfpSpread, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent)
        Dim COL, ROW As Integer
        Dim COLUMNTEXT As String
        Dim I As Integer
        COL = GRID.ActiveCol
        ROW = GRID.ActiveRow
        For I = 0 To hrow.Length - 1
            If ROW < hrow(I) Then
                GRID.GetText(1, hrow(I - 1) + 2, COLUMNTEXT)
                Exit For
            End If
        Next
        MsgBox(COLUMNTEXT)
    End Function
End Class
