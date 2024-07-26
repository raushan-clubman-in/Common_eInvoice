<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eInvoiceDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_TODATE = New System.Windows.Forms.DateTimePicker()
        Me.DTP_FROMDATE = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmdexport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "E INVOICING STATUS REGISTER"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(288, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "To date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(91, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "From date"
        '
        'DTP_TODATE
        '
        Me.DTP_TODATE.Location = New System.Drawing.Point(350, 109)
        Me.DTP_TODATE.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.DTP_TODATE.Name = "DTP_TODATE"
        Me.DTP_TODATE.Size = New System.Drawing.Size(121, 20)
        Me.DTP_TODATE.TabIndex = 43
        '
        'DTP_FROMDATE
        '
        Me.DTP_FROMDATE.Location = New System.Drawing.Point(150, 109)
        Me.DTP_FROMDATE.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.DTP_FROMDATE.Name = "DTP_FROMDATE"
        Me.DTP_FROMDATE.Size = New System.Drawing.Size(119, 20)
        Me.DTP_FROMDATE.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdexport)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Location = New System.Drawing.Point(157, 181)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(218, 54)
        Me.Panel2.TabIndex = 38
        '
        'cmdexport
        '
        Me.cmdexport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexport.Location = New System.Drawing.Point(24, 16)
        Me.cmdexport.Name = "cmdexport"
        Me.cmdexport.Size = New System.Drawing.Size(75, 23)
        Me.cmdexport.TabIndex = 6
        Me.cmdexport.Text = "Export"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(120, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        '
        'eInvoiceDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(576, 264)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP_TODATE)
        Me.Controls.Add(Me.DTP_FROMDATE)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "eInvoiceDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eInvoiceDetails"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_TODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_FROMDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdexport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
