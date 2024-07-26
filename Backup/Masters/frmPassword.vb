Public Class frmPassword
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim pass As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOld = New System.Windows.Forms.TextBox
        Me.txtNew = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdClear = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OLD PASSWORD  :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NEW PASSWORD :"
        '
        'txtOld
        '
        Me.txtOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOld.Location = New System.Drawing.Point(149, 16)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Microsoft.VisualBasic.ChrW(64)
        Me.txtOld.Size = New System.Drawing.Size(153, 22)
        Me.txtOld.TabIndex = 1
        Me.txtOld.Text = ""
        '
        'txtNew
        '
        Me.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNew.Location = New System.Drawing.Point(149, 46)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Microsoft.VisualBasic.ChrW(64)
        Me.txtNew.Size = New System.Drawing.Size(153, 22)
        Me.txtNew.TabIndex = 2
        Me.txtNew.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdClear)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 56)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.Location = New System.Drawing.Point(193, 17)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 24)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "Exit[F6]"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label5.Location = New System.Drawing.Point(193, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Label5"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdClear.Location = New System.Drawing.Point(102, 16)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(80, 24)
        Me.cmdClear.TabIndex = 4
        Me.cmdClear.Text = "Clear[F3]"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label4.Location = New System.Drawing.Point(102, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.Location = New System.Drawing.Point(11, 17)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(80, 24)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add[F10]"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(12, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'frmPassword
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
        Me.ClientSize = New System.Drawing.Size(320, 150)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P A S S W O R D"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtOld_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOld.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Is_exist()
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim Pass, ssql As String
        Dim i As Integer
        If Is_exist() Then
            For i = 1 To Len(Trim(txtNew.Text))
                Pass = Pass & Chr(Asc(Mid(UCase(Trim(txtNew.Text)), i, 1)) + 150)
            Next
            ssql = "UPDATE PASSWORD SET PASSWORD ='" & Pass & "'"
            gconnection.dataOperation(1, ssql)
            Call cmdClear_Click(sender, e)
            cmdExit.Focus()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub txtNew_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNew.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmdAdd.Focus()
        End If
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtOld.Text = ""
        txtNew.Text = ""
        cmdAdd.Text = "Add[F10]"
    End Sub
    Private Sub txtOld_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOld.Leave
        Call Is_exist()
    End Sub
    Private Function Is_exist() As Boolean
        gconnection.getDataSet("SELECT ISNULL(PASSWORD,'') AS PASSWORD FROM PASSWORD", "PASSWORD")
        If gdataset.Tables("PASSWORD").Rows(0).Item(0) = GetPassword(UCase(Trim(txtOld.Text))) Then
            txtNew.Focus()
            cmdAdd.Text = "Update[F10]"
            Is_exist = True
        Else
            MsgBox("You have provided wrong password", MsgBoxStyle.Critical)
            txtOld.Text = ""
            txtNew.Text = ""
            txtOld.Focus()
            Is_exist = False
        End If
    End Function
End Class
