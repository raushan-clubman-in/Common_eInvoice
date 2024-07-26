Public Class frmPosKotupdation
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
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPosKotupdation))
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ForeColor = System.Drawing.Color.White
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(136, 55)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(104, 32)
        Me.cmdUpdate.TabIndex = 1
        Me.cmdUpdate.Text = "RESET"
        '
        'frmPosKotupdation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.ClientSize = New System.Drawing.Size(376, 142)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Name = "frmPosKotupdation"
        Me.Text = "K O T F L A G : : U P D A T I O N"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As GlobalClass
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim sstr As String
        Try

            If MsgBox("Are yo sure you want to reset", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                sstr = "UPDATE POSKOTDOC SET DOCFLAG='N'"
                gconnection.dataOperation(2, sstr)
                Me.Close()
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("There is an error Try again", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
            Exit Sub
        End Try


    End Sub
End Class
