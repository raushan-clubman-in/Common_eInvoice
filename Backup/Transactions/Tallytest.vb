Imports System.Data.SqlClient
Public Class Tallytest
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pos_update As System.Windows.Forms.RadioButton
    Friend WithEvents mem_update As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Tallytest))
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.ToDate = New System.Windows.Forms.DateTimePicker
        Me.FromDate = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.pos_update = New System.Windows.Forms.RadioButton
        Me.mem_update = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "TO DATE :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FROM DATE :"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(24, 11)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 8
        Me.CmdView.Text = "Update[F7]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(384, 11)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 9
        Me.cmdexit.Text = "Exit[F11]"
        '
        'ToDate
        '
        Me.ToDate.CustomFormat = "dd-MMM-yyyy"
        Me.ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ToDate.Location = New System.Drawing.Point(384, 16)
        Me.ToDate.MaxDate = New Date(3000, 8, 14, 0, 0, 0, 0)
        Me.ToDate.MinDate = New Date(1900, 8, 14, 0, 0, 0, 0)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(144, 26)
        Me.ToDate.TabIndex = 5
        Me.ToDate.Value = New Date(2010, 8, 28, 0, 0, 0, 0)
        '
        'FromDate
        '
        Me.FromDate.CustomFormat = "dd-MMM-yyyy"
        Me.FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FromDate.Location = New System.Drawing.Point(136, 16)
        Me.FromDate.MaxDate = New Date(3000, 8, 14, 0, 0, 0, 0)
        Me.FromDate.MinDate = New Date(1900, 8, 14, 0, 0, 0, 0)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(144, 26)
        Me.FromDate.TabIndex = 4
        Me.FromDate.Value = New Date(2010, 8, 28, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(336, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(313, 35)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Tally to Clubman Update"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pos_update
        '
        Me.pos_update.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pos_update.Location = New System.Drawing.Point(368, 16)
        Me.pos_update.Name = "pos_update"
        Me.pos_update.Size = New System.Drawing.Size(160, 24)
        Me.pos_update.TabIndex = 35
        Me.pos_update.Text = "POS - Item Update"
        '
        'mem_update
        '
        Me.mem_update.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mem_update.Location = New System.Drawing.Point(16, 16)
        Me.mem_update.Name = "mem_update"
        Me.mem_update.Size = New System.Drawing.Size(200, 24)
        Me.mem_update.TabIndex = 36
        Me.mem_update.Text = "Member Details - Update"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmdView)
        Me.GroupBox1.Controls.Add(Me.cmdexit)
        Me.GroupBox1.Location = New System.Drawing.Point(208, 560)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 48)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ToDate)
        Me.GroupBox2.Controls.Add(Me.FromDate)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 56)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.pos_update)
        Me.GroupBox3.Controls.Add(Me.mem_update)
        Me.GroupBox3.Location = New System.Drawing.Point(208, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 48)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'Tallytest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 699)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Tallytest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tallytest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim myconnection As New ADODB.Connection
    Dim ssqlmem, ssqlitem, strstring, sqlitemstr, str, strTruncate As String
    Dim vfill As New ADODB.Recordset
    Dim i As Integer
    Private Sub Tallytest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'myconnection.Open(gTallyDsn)
            'Call UomUpdate()
            'Call RateUpdate()'''' Fetched in Temp_Itemmaster_tally table from Tally
            'Call ItemTaxUpdate()
            'Call PosLocUpdate()
            'Call StockGroupUpdate()
            'Call ItemMasterUpdate()
            'str = "Exec SP_ItemUpdate_Tally"
            'gconnection.dataOperation(6, str, "POSUpdate")
            'MessageBox.Show("Tally to Clubman Updation completed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
    '''''''''''''''''''''''''''''''' POS Data Fetching from Tally''''''''''''''''''''''''''''''''''''
    Function UomUpdate()
        Try
            myconnection.Open(gTallyDsn)
            strTruncate = "Truncate Table Temp_Uommaster_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")

            ssqlitem = "Select $Name,$OriginalName from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Unit'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$OriginalName").Value) = False Then
                            str = "insert into Temp_Uommaster_tally (UomCode,UomDesc) values ('"
                            str = str & Trim(vfill.Fields.Item("$Name").Value) & "','" & Trim(vfill.Fields.Item("$OriginalName").Value) & "')"
                            gconnection.dataOperation(6, str, "UomUpdate")
                            ''' Else'''' To be finished
                            '''Exit Function
                        End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function

    Function StockGroupUpdate()
        Try
            strTruncate = "Truncate Table Temp_Groupmaster_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            '''''myconnection.Open(gTallyDsn)
            ssqlitem = "Select $$Alias,$AliasName from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'StockGroup'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$$Alias").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$AliasName").Value) = False Then
                            str = "insert into Temp_Groupmaster_tally (GCode,GDesc) values ('"
                            str = str & Trim(vfill.Fields.Item("$$Alias").Value) & "','" & Trim(vfill.Fields.Item("$AliasName").Value) & "')"
                            gconnection.dataOperation(6, str, "GroupUpdate")
                            '''Else ''''To be finished
                            ''' Exit Function
                        End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function

    Function RateUpdate()
        Try
            strTruncate = "Truncate Table Temp_Ratemaster_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            '''''myconnection.Open(gTallyDsn)
            ssqlitem = "Select $$Alias,$Name,$BaseUnits,$$number:$currentstdprice,$$number:$currentstdcost from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'StockItem'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$$Alias").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                            If IsDBNull(vfill.Fields.Item("$BaseUnits").Value) = False Then
                                If IsDBNull(vfill.Fields.Item("$$number:$currentstdprice").Value) = False Then
                                    If IsDBNull(vfill.Fields.Item("$$number:$currentstdcost").Value) = False Then
                                        str = "insert into Temp_Ratemaster_tally (ICode,IDesc,UOMDesc,ISellrate,ICostRate) values ('"
                                        str = str & Trim(vfill.Fields.Item("$$Alias").Value) & "','" & Trim(vfill.Fields.Item("$Name").Value) & "',"
                                        str = str & "'" & Trim(vfill.Fields.Item("$BaseUnits").Value) & "','" & Trim(vfill.Fields.Item("$$number:$currentstdcost").Value) & "',"
                                        str = str & "'" & Trim(vfill.Fields.Item("$$number:$currentstdcost").Value) & "')"
                                        gconnection.dataOperation(6, str, "RateUpdate")
                                    End If
                                End If
                            End If
                            '''Else ''''To be finished
                            ''' Exit Function
                        End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function
    Function PosLocUpdate()
        Try
            strTruncate = "Truncate Table Temp_PosLoc_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            '''''myconnection.Open(gTallyDsn)
            ssqlitem = "Select $$Alias,$Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Godown'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$$Alias").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                            str = "insert into Temp_PosLoc_tally (Poscode,PosDesc) values ('"
                            str = str & Trim(vfill.Fields.Item("$$Alias").Value) & "','" & Trim(vfill.Fields.Item("$Name").Value) & "')"
                            gconnection.dataOperation(6, str, "PosLocUpdate")
                            '''Else ''''To be finished
                            ''' Exit Function
                        End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function
    'Function ItemTaxUpdate()
    '    Try
    '        strTruncate = "Truncate Table Temp_Itemtypemaster_tally"
    '        gconnection.dataOperation(6, strTruncate, "TruncateTable")
    '        ''''' myconnection.Open(gTallyDsn)
    '        ssqlitem = "Select $BAsicRateofExcise, $RateofVAT from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Stockitem'"
    '        vfill.Open(ssqlitem, myconnection)
    '        If Not vfill.EOF Then
    '            Do Until vfill.EOF
    '                If IsDBNull(vfill.Fields.Item("$BAsicRateofExcise").Value) = False Then
    '                    If IsDBNull(vfill.Fields.Item("$RateofVAT").Value) = False Then
    '                        str = "insert into Temp_Itemtypemaster_tally (ExciseTaxpercent,VATTaxPercent) values ('"
    '                        str = str & Trim(vfill.Fields.Item("$BAsicRateofExcise").Value) & "','" & Trim(vfill.Fields.Item("$RateofVAT").Value) & "')"
    '                        gconnection.dataOperation(6, str, "TaxUpdate")
    '                        '''Else ''''To be finished
    '                        ''' Exit Function
    '                    End If
    '                End If
    '                vfill.MoveNext()
    '            Loop
    '        End If
    '        vfill.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '    End Try
    'End Function
    Function ItemMasterUpdate()
        Try
            strTruncate = "Truncate Table Temp_ItemMAster_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            strTruncate = "Truncate Table Temp_Itemtypemaster_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            '''''myconnection.Open(gTallyDsn)
            ssqlitem = "Select $$Alias,$Name,$Parent,$BaseUnits,$$number:$currentstdprice,$BAsicRateofExcise,$RateofVAT  from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'StockItem'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$$Alias").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                            If IsDBNull(vfill.Fields.Item("$Parent").Value) = False Then
                                If IsDBNull(vfill.Fields.Item("$BaseUnits").Value) = False Then
                                    If IsDBNull(vfill.Fields.Item("$$number:$currentstdprice").Value) = False Then
                                        If IsDBNull(vfill.Fields.Item("$BAsicRateofExcise").Value) = False Then
                                            If IsDBNull(vfill.Fields.Item("$RateofVAT").Value) = False Then
                                                str = "insert into Temp_ItemMAster_tally (ICode,Idesc,GroupDesc,BaseUomStd,BaseRateStd,RateOfExcise,RateOfVat) values ('"
                                                str = str & Trim(vfill.Fields.Item("$$Alias").Value) & "','" & Trim(vfill.Fields.Item("$Name").Value) & "',"
                                                str = str & "'" & Trim(vfill.Fields.Item("$Parent").Value) & "','" & Trim(vfill.Fields.Item("$BaseUnits").Value) & "',"
                                                str = str & "'" & Trim(vfill.Fields.Item("$$number:$currentstdprice").Value) & "','" & Trim(vfill.Fields.Item("$BAsicRateofExcise").Value) & "',"
                                                str = str & "'" & Trim(vfill.Fields.Item("$RateofVAT").Value) & "')"
                                                gconnection.dataOperation(6, str, "ItemMasterUpdate")
                                                '''Else ''''To be finished
                                                ''' Exit Function
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function
    '''''''''''''''''''''''''''''''''' Member Data Fetching from Tally'''''''''''''''''''''''''''''''''''''''''
    Function MemberTypeUpdate()
        Try
            strTruncate = "Truncate Table Temp_membertype_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            'myconnection.Open(gTallyDsn)
            ssqlitem = "Select $$Alias,$Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Groups' Where $Parent='SundryDebtors'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$$Alias").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                            str = "insert into Temp_membertype_tally (Typecode,Typedesc) values ('"
                            str = str & Trim(vfill.Fields.Item("$$Alias").Value) & "','" & Trim(vfill.Fields.Item("$Name").Value) & "')"
                            gconnection.dataOperation(6, str, "MemberTypeUpdate")
                            '''Else ''''To be finished
                            ''' Exit Function
                        End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function
    Function SubscriptionUpdate()
        Try
            strTruncate = "Truncate Table Temp_SUBSCRIPTIONMAST_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            'myconnection.Open(gTallyDsn)
            'ssqlitem = "Select $$Alias,$Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'ledger' where $Parent='subscriptions' and $_PrimaryGroups='SalesAccounts'"
            ssqlitem = "Select $Name from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'ledger' where $Parent='subscriptions'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                        'If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                        str = "insert into Temp_SUBSCRIPTIONMAST_tally (Subdesc) values ('"
                        'str = "insert into Temp_SUBSCRIPTIONMAST_tally (Subcode,Subdesc) values ('"
                        str = str & Trim(vfill.Fields.Item("$Name").Value) & "')"
                        'str = str & Trim(vfill.Fields.Item("$$Alias").Value) & "','" & Trim(vfill.Fields.Item("$Name").Value) & "')"
                        gconnection.dataOperation(6, str, "SubsUpdate")
                        '''Else ''''To be finished
                        ''' Exit Function
                        'End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function
    Function MemberMasterUpdate()
        Try
            strTruncate = "Truncate Table Temp_membermaster_tally"
            gconnection.dataOperation(6, strTruncate, "TruncateTable")
            'myconnection.Open(gTallyDsn)
            'ssqlitem = "Select $Name,$$Alias,$Parent,$_Address1,$_Address2,$_Address3,$_Address4, $StateName,$Pincode,$Email,$LedgerPhone,$LedgerFax,$AlteredOn  from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger'"
            ssqlitem = "Select $Name,$$Alias,$Parent,$AlteredOn  from '" & gTallyCompanyName & "'.'" & gTallyUser & "'.'Ledger' Where $_PrimaryGroup = 'SundryDebtors'"
            vfill.Open(ssqlitem, myconnection)
            If Not vfill.EOF Then
                Do Until vfill.EOF
                    If IsDBNull(vfill.Fields.Item("$Name").Value) = False Then
                        If IsDBNull(vfill.Fields.Item("$$Alias").Value) = False Then
                            If IsDBNull(vfill.Fields.Item("$Parent").Value) = False Then
                                ' If IsDBNull(vfill.Fields.Item("$_Address1").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$_Address2").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$_Address3").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$_Address4").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$StateName").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$Pincode").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$Email").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$LedgerPhone").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$LedgerFax").Value) = False Then
                                'If IsDBNull(vfill.Fields.Item("$AlteredOn").Value) = False Then
                                'str = "insert into Temp_membermaster_tally (Mcode,Mname,MTypeDesc,Contadd1,Contadd2,Contadd3,Contcity,contstate,Contpin,contemail,contphone,contcell,$AlteredOn) values ('"
                                str = "insert into Temp_membermaster_tally (Mcode,Mname,MTypeDesc) values ("
                                str = str & "'" & Trim(vfill.Fields.Item("$Name").Value) & "','" & Trim(vfill.Fields.Item("$$Alias").Value) & "',"
                                str = str & "'" & Trim(vfill.Fields.Item("$Parent").Value) & "')"
                                'str = str & "'" & Trim(vfill.Fields.Item("$Parent").Value) & "','" & Trim(vfill.Fields.Item("$_Address1").Value) & "',"
                                'str = str & "'" & Trim(vfill.Fields.Item("$_Address2").Value) & "','" & Trim(vfill.Fields.Item("$_Address3").Value) & "',"
                                'str = str & "'" & Trim(vfill.Fields.Item("$_Address4").Value) & "','" & Trim(vfill.Fields.Item("$StateName").Value) & "',"
                                'str = str & "'" & Trim(vfill.Fields.Item("$Pincode").Value) & "','" & Trim(vfill.Fields.Item("$Email").Value) & "',"
                                'str = str & "'" & Trim(vfill.Fields.Item("$LedgerPhone").Value) & "','" & Trim(vfill.Fields.Item("$LedgerFax").Value) & "',"
                                'str = str & "'" & Trim(vfill.Fields.Item("$AlteredOn").Value) & "')"
                                gconnection.dataOperation(6, str, "MemberDetailsUpdate")
                                '''Else ''''To be finished
                                ''' Exit Function
                                'End If
                            'End If
                            'End If
                            'End If
                            'End If
                            'End If
                            'End If
                            'End If
                            'End If
                            'End If
                        End If
                    End If
                    End If
                    vfill.MoveNext()
                Loop
            End If
            vfill.Close()
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Function

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            If mem_update.Checked = True Then
                Call MemberTypeUpdate()
                Call SubscriptionUpdate()
                Call MemberMasterUpdate()
                str = "Exec SP_MemberUpdate_Tally"
                'str = "Exec SP_ItemUpdate_Tally '" & Format(FromDate.Value, "dd-MMM-yyyy") & "','" & Format(FromDate.Value, "dd-MMM-yyyy") & "' "
                gconnection.dataOperation(6, str, "MemberUpdate")
                MessageBox.Show("Tally to Clubman Member Updation completed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf pos_update.Checked = True Then
                '''''''''''''''POS - Item Update block''''''''''''''''
                Call UomUpdate()
                Call RateUpdate() '''' Fetched in Temp_Itemmaster_tally table from Tally
                Call PosLocUpdate()
                Call StockGroupUpdate()
                Call ItemMasterUpdate()
                'Call ItemTaxUpdate()
                str = "Exec SP_ItemUpdate_Tally"
                gconnection.dataOperation(6, str, "POSUpdate")
                MessageBox.Show("Tally to Clubman POS-StockItem Updation completed ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf mem_update.Checked = False And pos_update.Checked = False Then
                MessageBox.Show("Please Select an option to update ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Check The Error :  " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Tallytest_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                Call cmdexit_Click(sender, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Or e.KeyCode = Keys.Escape Then
                Call CmdView_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
