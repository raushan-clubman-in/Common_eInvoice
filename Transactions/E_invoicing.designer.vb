<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_invoicing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_invoicing))
        Me.Label_Freeze = New System.Windows.Forms.Label()
        Me.BTN_EXIT = New System.Windows.Forms.Button()
        Me.lbl_eventno = New System.Windows.Forms.Label()
        Me.lbl_functionno = New System.Windows.Forms.Label()
        Me.gridFNStatus = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DTP_FROMDATE = New System.Windows.Forms.DateTimePicker()
        Me.DTP_TODATE = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.Pic_QR = New System.Windows.Forms.PictureBox()
        Me.OPERATION_TYPE = New System.Windows.Forms.Label()
        CType(Me.gridFNStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_QR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Freeze
        '
        Me.Label_Freeze.AutoSize = True
        Me.Label_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Label_Freeze.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Freeze.Location = New System.Drawing.Point(12, 620)
        Me.Label_Freeze.Name = "Label_Freeze"
        Me.Label_Freeze.Size = New System.Drawing.Size(294, 15)
        Me.Label_Freeze.TabIndex = 15
        Me.Label_Freeze.Text = "Double click On the row to View or Generate E_invoice"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.BackgroundImage = CType(resources.GetObject("BTN_EXIT.BackgroundImage"), System.Drawing.Image)
        Me.BTN_EXIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_EXIT.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Image = CType(resources.GetObject("BTN_EXIT.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(1160, 8)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(51, 28)
        Me.BTN_EXIT.TabIndex = 30
        Me.BTN_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_EXIT.UseVisualStyleBackColor = True
        '
        'lbl_eventno
        '
        Me.lbl_eventno.AutoSize = True
        Me.lbl_eventno.Location = New System.Drawing.Point(84, 27)
        Me.lbl_eventno.Name = "lbl_eventno"
        Me.lbl_eventno.Size = New System.Drawing.Size(40, 15)
        Me.lbl_eventno.TabIndex = 32
        Me.lbl_eventno.Text = "Label1"
        Me.lbl_eventno.Visible = False
        '
        'lbl_functionno
        '
        Me.lbl_functionno.AutoSize = True
        Me.lbl_functionno.Location = New System.Drawing.Point(130, 27)
        Me.lbl_functionno.Name = "lbl_functionno"
        Me.lbl_functionno.Size = New System.Drawing.Size(42, 15)
        Me.lbl_functionno.TabIndex = 33
        Me.lbl_functionno.Text = "Label2"
        Me.lbl_functionno.Visible = False
        '
        'gridFNStatus
        '
        Me.gridFNStatus.AllowUserToAddRows = False
        Me.gridFNStatus.AllowUserToDeleteRows = False
        Me.gridFNStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridFNStatus.ColumnHeadersHeight = 50
        Me.gridFNStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gridFNStatus.Location = New System.Drawing.Point(1, 134)
        Me.gridFNStatus.Name = "gridFNStatus"
        Me.gridFNStatus.ReadOnly = True
        Me.gridFNStatus.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(1)
        Me.gridFNStatus.RowTemplate.Height = 50
        Me.gridFNStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridFNStatus.Size = New System.Drawing.Size(1238, 480)
        Me.gridFNStatus.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "E INVOICING STATUS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(205, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Search Details"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 104)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(279, 23)
        Me.TextBox1.TabIndex = 37
        '
        'DTP_FROMDATE
        '
        Me.DTP_FROMDATE.Location = New System.Drawing.Point(692, 104)
        Me.DTP_FROMDATE.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.DTP_FROMDATE.Name = "DTP_FROMDATE"
        Me.DTP_FROMDATE.Size = New System.Drawing.Size(119, 23)
        Me.DTP_FROMDATE.TabIndex = 38
        '
        'DTP_TODATE
        '
        Me.DTP_TODATE.Location = New System.Drawing.Point(875, 105)
        Me.DTP_TODATE.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.DTP_TODATE.Name = "DTP_TODATE"
        Me.DTP_TODATE.Size = New System.Drawing.Size(121, 23)
        Me.DTP_TODATE.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(621, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "From date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(821, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 15)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "To date"
        '
        'BtnReload
        '
        Me.BtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnReload.Image = CType(resources.GetObject("BtnReload.Image"), System.Drawing.Image)
        Me.BtnReload.Location = New System.Drawing.Point(1103, 8)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(51, 28)
        Me.BtnReload.TabIndex = 52
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'Pic_QR
        '
        Me.Pic_QR.Location = New System.Drawing.Point(24, 47)
        Me.Pic_QR.Name = "Pic_QR"
        Me.Pic_QR.Size = New System.Drawing.Size(28, 31)
        Me.Pic_QR.TabIndex = 726
        Me.Pic_QR.TabStop = False
        Me.Pic_QR.Visible = False
        '
        'OPERATION_TYPE
        '
        Me.OPERATION_TYPE.AutoSize = True
        Me.OPERATION_TYPE.Location = New System.Drawing.Point(811, 19)
        Me.OPERATION_TYPE.Name = "OPERATION_TYPE"
        Me.OPERATION_TYPE.Size = New System.Drawing.Size(42, 15)
        Me.OPERATION_TYPE.TabIndex = 727
        Me.OPERATION_TYPE.Text = "Label5"
        '
        'E_invoicing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1242, 643)
        Me.Controls.Add(Me.OPERATION_TYPE)
        Me.Controls.Add(Me.Pic_QR)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP_TODATE)
        Me.Controls.Add(Me.DTP_FROMDATE)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridFNStatus)
        Me.Controls.Add(Me.lbl_functionno)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.lbl_eventno)
        Me.Controls.Add(Me.Label_Freeze)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "E_invoicing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HSN Master"
        CType(Me.gridFNStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_QR,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label_Freeze As Label
    Friend WithEvents GRP_DEPARTMENT As GroupBox
    Friend WithEvents BTN_EXIT As Button
    Friend WithEvents lbl_eventno As Label
    Friend WithEvents lbl_functionno As Label
    Friend WithEvents gridFNStatus As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DTP_FROMDATE As DateTimePicker
    Friend WithEvents DTP_TODATE As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnReload As Button
    Friend WithEvents Pic_QR As PictureBox
    Friend WithEvents OPERATION_TYPE As System.Windows.Forms.Label
End Class
