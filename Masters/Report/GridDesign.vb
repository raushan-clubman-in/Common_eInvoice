Public Class GridDesign
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents Grid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents btn_Exporttoexcel As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GridDesign))
        Me.Grid = New AxFPSpreadADO.AxfpSpread
        Me.Lbl_Caption = New System.Windows.Forms.Label
        Me.btn_Exporttoexcel = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.DataSource = Nothing
        Me.Grid.Location = New System.Drawing.Point(8, 48)
        Me.Grid.Name = "Grid"
        Me.Grid.OcxState = CType(resources.GetObject("Grid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Grid.Size = New System.Drawing.Size(1008, 632)
        Me.Grid.TabIndex = 0
        '
        'Lbl_Caption
        '
        Me.Lbl_Caption.AutoSize = True
        Me.Lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Caption.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Caption.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Lbl_Caption.Location = New System.Drawing.Point(392, 8)
        Me.Lbl_Caption.Name = "Lbl_Caption"
        Me.Lbl_Caption.Size = New System.Drawing.Size(185, 31)
        Me.Lbl_Caption.TabIndex = 1
        Me.Lbl_Caption.Text = "GRID HEADER"
        '
        'btn_Exporttoexcel
        '
        Me.btn_Exporttoexcel.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_Exporttoexcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Exporttoexcel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exporttoexcel.ForeColor = System.Drawing.Color.White
        Me.btn_Exporttoexcel.Image = CType(resources.GetObject("btn_Exporttoexcel.Image"), System.Drawing.Image)
        Me.btn_Exporttoexcel.Location = New System.Drawing.Point(792, 8)
        Me.btn_Exporttoexcel.Name = "btn_Exporttoexcel"
        Me.btn_Exporttoexcel.Size = New System.Drawing.Size(104, 32)
        Me.btn_Exporttoexcel.TabIndex = 423
        Me.btn_Exporttoexcel.Text = "To Excel"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(904, 8)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 424
        Me.cmdexit.Text = "Exit[F11]"
        '
        'GridDesign
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 702)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.btn_Exporttoexcel)
        Me.Controls.Add(Me.Lbl_Caption)
        Me.Controls.Add(Me.Grid)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GridDesign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POINT OF SALES [ GRID VIEW ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

  
    Dim ObjItemwisesaleconsumption As New rptItemwisesaleregistergridview

    Private Sub GridDesign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If gridviewstatus = "ITEMWISESALEREGISTER" Then
                Lbl_Caption.Text = "CONSUMPTION REPORT"
                Dim columnname() As String = {"SLNO.", "ITEM CODE ", "ITEM DESCRIPTION", "QUANTITY", "RATE", "AMOUNT"}
                Dim columnname1() As String = {"", "", "", "", "", ""}
                Dim colsize() As Integer = {10, 10, 50, 15, 15, 15}
                ObjItemwisesaleconsumption.GridColumnname(Grid, columnname, columnname1, colsize)
                ObjItemwisesaleconsumption.BodyOfGrid(Grid)
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Grid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles Grid.KeyDownEvent
        Try
            If gridviewstatus = "ITEMWISESALEREGISTER" Then
                ObjItemwisesaleconsumption.KeyDownEvent(Grid, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Grid_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles Grid.DblClick
        Try
            If gridviewstatus = "ITEMWISESALEREGISTER" Then
                ObjItemwisesaleconsumption.DoubleClick(Grid, e)
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub btn_Exporttoexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exporttoexcel.Click
        Try
            Call ExportTo(Grid)
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
End Class