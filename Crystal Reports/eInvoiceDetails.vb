Public Class eInvoiceDetails

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cmdexport_Click(sender As Object, e As EventArgs) Handles cmdexport.Click
        Try
            Dim sqlstring As String
            Dim _export As New exportexcel
            ''sqlstring = "select Module,BillDetails,cast(convert(varchar(11),billdate,106) as datetime) AS BILLDATE,success,msg,ackno from GST_eInvoice_Details Where cast(convert(varchar(11),billdate,106) as datetime) between '" & Format(DTP_FROMDATE.Value, "dd-MMM-yyyy") & "' And '" & Format(DTP_TODATE.Value, "dd-MMM-yyyy") & "'"
            sqlstring = "select * from GST_eInvoice_Details Where cast(convert(varchar(11),billdate,106) as datetime) between '" & Format(DTP_FROMDATE.Value, "dd-MMM-yyyy") & "' And '" & Format(DTP_TODATE.Value, "dd-MMM-yyyy") & "'"
            _export.Show()
            Call _export.export(sqlstring, "eInvoice Details " & Format(DTP_FROMDATE.Value, "dd-MMM-yyyy") & "   TO   " & Format(DTP_TODATE.Value, "dd-MMM-yyyy"), "")
            Exit Sub
        Catch ex As Exception
            MsgBox("Sorry!, Export to Excel is Terminated Abnormally, Bcoz " & ex.Message.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try
    End Sub
End Class