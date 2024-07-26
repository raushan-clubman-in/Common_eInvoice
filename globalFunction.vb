Imports System.Text.RegularExpressions
Imports GSTINTEGRATION.ACR120U
Imports System.IO
Module globalFunction
    Dim regexp As Regex
    Public boolexp As Boolean = False
    Public boolexp1 As Boolean = False
    Public boolexp2 As Boolean = False
    Public G_dout(15) As Byte
    Dim gconnection As New GlobalClass
    Public Function CloseSmartDevicePort()
        Dim RETVALUE, HANDLE As Integer
        RETVALUE = ACR120U.ACR120_Close(HANDLE)
    End Function
    Public Function GetSMARTDEVICEPORT()
        Try
            Dim RETVALUE As Integer
            RETVALUE = ACR120U.ACR120_Open(ACR120U.PORTS.ACR120_USB1)
            'RETVALUE = ACR120U.ACR120_Open(CInt(GBL_SMARTDEVICEPORT))
            If RETVALUE < 0 Then
                smartdeviceportcount = smartdeviceportcount + 1
                If smartdeviceportcount < 2 Then
                    MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical, "NOT CONNECTED")
                End If
                ' SmartDevicePortStatus = False
            Else
                smartdeviceportcount = 0
                '                SmartDevicePortStatus = True
                '  MsgBox("SMART CARD DEVICE CONNECTION SUCCESSFUL", MsgBoxStyle.Information, "CONNECTED")
            End If
        Catch ex As Exception
            '           SmartDevicePortStatus = False
            MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.Critical, "NOT CONNECTED")
        End Try

    End Function
    Public Function GetSMART_CARDID()
        Dim RETVALUE, HANDLE As Integer
        'Variable Declarations
        Dim ResultSN(11) As Byte
        Dim ResultTag As Byte
        Dim ctr As Integer
        Dim TagType(50) As Byte

        RETVALUE = ACR120U.ACR120_Select(HANDLE, TagType(0), ResultTag, ResultSN(0))
        GBL_SMARTCARDSNO = ""
        For ctr = 0 To ResultTag - 1
            GBL_SMARTCARDSNO = GBL_SMARTCARDSNO + Format_Hex2(ResultSN(ctr))
        Next
    End Function
    Public Function GET_SERVERTIME()
        Dim sqlstring As String
        Try
            sqlstring = " Select GETDATE() AS SERVERTIME "
            gconnection.getDataSet(sqlstring, "SERVERTIME")
            If gdataset.Tables("SERVERTIME").Rows.Count > 0 Then
                GBL_SERVERTIME = Format(CDate(gdataset.Tables("SERVERTIME").Rows(0).Item("SERVERTIME")), "dd/MMM/yyyy HH:mm")
                GBL_SERVERTIME_SECONDS = Format(CDate(gdataset.Tables("SERVERTIME").Rows(0).Item("SERVERTIME")), "dd/MMM/yyyy HH:mm:ss")
            End If
        Catch ex As Exception
        End Try
    End Function
    Public Function DLLCLOSE()
        Try
            ' Dim HANDLE As Integer
            ' G_rHandle = ACR120U.ACR120_Close(HANDLE)
            G_retcode = ACR120U.ACR120_Close(G_rHandle)
            If G_retcode < 0 Then
                '  MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.Critical, "NOT CLOSE")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function DLLCONNECT()
        Try
            G_rHandle = ACR120U.ACR120_Open(ACR120U.PORTS.ACR120_USB1)
            If G_rHandle < 0 Then
                MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.Critical, "NOT CONNECTED")
                Call DLLCLOSE()
                'G_retcode = ACR120U.ACR120_Close(G_rHandle)
                MsgBox("PLEASE INSERT SMART CARD DEVICE", MsgBoxStyle.Critical, "NOT CLOSE")
            End If

        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function dlllogin(ByVal sector_l As Integer)
        Try
            Dim TempStr As String
            Dim txt1, txt2, txt3, txt4, txt5, txt6 As String
            txt1 = "FF"
            txt2 = "FF"
            txt3 = "FF"
            txt4 = "FF"
            txt5 = "FF"
            txt6 = "FF"

            G_vKeyType = ACR120U.KEYTYPES.ACR120_LOGIN_KEYTYPE_A

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt1, 2)))
            G_pKey(0) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt2, 2)))
            G_pKey(1) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt3, 2)))
            G_pKey(2) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt4, 2)))
            G_pKey(3) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt5, 2)))
            G_pKey(4) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt6, 2)))
            G_pKey(5) = CByte(TempStr)

            'set sector
            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & sector_l, 2)))
            G_Sec = CInt(TempStr)

            If G_Sec > 39 Then

                MsgBox("Sector Out of Range. Please Enter value from 0-39 only", MsgBoxStyle.Exclamation, "Log-In Fail")
                Exit Function

            End If

            'Computation for obtaining the actual Physical Sector.
            If G_Sec > 31 Then

                G_Sec = CInt(TempStr)
                G_PhysicalSector = G_Sec + ((G_Sec - 32) * 3)

            Else

                G_Sec = CInt(TempStr)
                G_PhysicalSector = G_Sec

            End If

            G_retcode = ACR120U.ACR120_Login(G_rHandle, G_PhysicalSector, G_vKeyType, G_StoredNum, G_pKey(0))

            'check if retcode is error
            If G_retcode < 0 Then
                MsgBox("PROBLEM IN SMART CARD login", MsgBoxStyle.Critical, "NOT LOGIN")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function Format_Hex2(ByVal NUM As Integer) As String
        Try
            'Format Byte into two-digit Hex
            Format_Hex2 = Microsoft.VisualBasic.Right("00" & Hex(NUM), 2)
        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function DLLSELECT()
        Try
            Dim RETVALUE, HANDLE As Integer
            'Variable Declarations
            Dim ResultSN(11) As Byte
            Dim ResultTag As Byte
            Dim ctr As Integer
            Dim TagType(50) As Byte
            RETVALUE = ACR120U.ACR120_Select(HANDLE, TagType(0), ResultTag, ResultSN(0))
            GBL_SMARTCARDSNO = ""
            For ctr = 0 To ResultTag - 1
                GBL_SMARTCARDSNO = GBL_SMARTCARDSNO + Format_Hex2(ResultSN(ctr))
            Next
        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function DLLREAD()
        Try
            Dim BLCK As Byte
            Dim dataRead(16) As Byte
            Dim dStr As String
            Dim ctr As Byte


            If G_Sec > 31 Then
                BLCK = ((G_Sec - 32) * 16) + 128 + BLCK
            Else
                BLCK = G_Sec * 4 + BLCK
            End If
            G_BlockNum = BLCK
            'read specified block
            G_retcode = ACR120U.ACR120_Read(G_rHandle, G_BlockNum, dataRead(0))

            'check if retcode is error
            If G_retcode < 0 Then
                MsgBox("PROBLEM IN SMART CARD login", MsgBoxStyle.Critical, "READ")
            End If

            dStr = ""
            For ctr = 0 To 15
                dStr = dStr + Format_Hex2(dataRead(ctr)) + " "
            Next

            MsgBox("CARD CONTENT...." & dStr, MsgBoxStyle.OKOnly, "CARD READ")

        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try

    End Function
    Public Function DLLWRITE(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal txt5 As String, ByVal txt6 As String, ByVal txt7 As String, ByVal txt8 As String, ByVal txt9 As String, ByVal txt10 As String, ByVal txt11 As String, ByVal txt12 As String, ByVal txt13 As String, ByVal txt14 As String, ByVal txt15 As String, ByVal txt16 As String)
        Try
            Dim BLCK As Byte
            Dim TempStr As String


            If G_Sec > 31 Then
                BLCK = ((G_Sec - 32) * 16) + 128 + BLCK
            Else
                BLCK = G_Sec * 4 + BLCK
            End If

            G_BlockNum = BLCK

            'if Hexadecimal was selected convert hex to byte
            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt1, 2)))
            G_dout(0) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt2, 2)))
            G_dout(1) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt3, 2)))
            G_dout(2) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt4, 2)))
            G_dout(3) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt5, 2)))
            G_dout(4) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt6, 2)))
            G_dout(5) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt7, 2)))
            G_dout(6) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt8, 2)))
            G_dout(7) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt9, 2)))
            G_dout(8) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt10, 2)))
            G_dout(9) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt11, 2)))
            G_dout(10) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt12, 2)))
            G_dout(11) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt13, 2)))
            G_dout(12) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt14, 2)))
            G_dout(13) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt15, 2)))
            G_dout(14) = CByte(TempStr)

            TempStr = ("&H" & (Microsoft.VisualBasic.Right("00" & txt16, 2)))
            G_dout(15) = CByte(TempStr)


            'G_dout(0) = Asc(txt1)
            'G_dout(1) = Asc(txt2)
            'G_dout(2) = Asc(txt3)
            'G_dout(3) = Asc(txt4)
            'G_dout(4) = Asc(txt5)
            'G_dout(5) = Asc(txt6)
            'G_dout(6) = Asc(txt7)
            'G_dout(7) = Asc(txt8)
            'G_dout(8) = Asc(txt9)
            'G_dout(9) = Asc(txt10)
            'G_dout(10) = Asc(txt11)
            'G_dout(11) = Asc(txt12)
            'G_dout(12) = Asc(txt13)
            'G_dout(13) = Asc(txt14)
            'G_dout(14) = Asc(txt15)
            'G_dout(15) = Asc(txt16)


            'execute ACR120 write, Write to Block
            G_retcode = ACR120U.ACR120_Write(G_rHandle, G_BlockNum, G_dout(0))

            'check if retcode was error
            If G_retcode < 0 Then
                MsgBox("PROBLEM IN SMART CARD WRITE", MsgBoxStyle.Critical, "NOT WRITE")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function CardIdValidate(ByVal vCardID As String) As Boolean
        Try
            Dim vSQL, vDay, vDate, vMonth As String
            'SHOWN ERROR
            'vTmp = vCardID.Substring(6, 11)
            vTmp = vCardID

            vSQL = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(vTmp) & "' AND ISNULL(CARDCODE,'')<>'' "
            vSQL = vSQL & " UNION SELECT * FROM SM_AFF_TEMP_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(vTmp) & "' AND ISNULL(CARDCODE,'')<>'' "
            gconnection.getDataSet(vSQL, "SM_MEM_LINKAGE1")
            If gdataset.Tables("SM_MEM_LINKAGE1").Rows.Count > 0 Then
                vCardcode = gdataset.Tables("SM_MEM_LINKAGE1").Rows(0).Item("CARDCODE")
            Else
                vCardcode = ""
            End If

            vDate = Format(DateTime.Today.Now, "dd/MM/yyyy")
            vDay = vDate.Substring(0, 2)
            vMonth = vDate.Substring(3, 2)
            If gdataset.Tables("SM_MEM_LINKAGE1").Rows.Count > 0 Then
                If Len(vTmp) > 13 Then
                    If Trim(vCardID.Substring(0, 2)) = Trim(vDay) And Trim(vCardID.Substring(17, 2)) = Trim(vMonth) Then
                        Cardidcheck = True
                        CardIdValidate = True
                    Else
                        vTmp = " "
                        CardIdValidate = False
                        Cardidcheck = False
                    End If
                Else
                    Cardidcheck = True
                    CardIdValidate = True
                End If

            End If

        Catch ex As Exception
            Cardidcheck = False
            CardIdValidate = False
            Exit Function
        End Try
    End Function

    '*******************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Numeric
    'Function Name:getNumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*******************************************************************
    Public Sub getNumeric(ByVal a As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(a.KeyChar)
            Case 65 To 127
                a.Handled = True
            Case 33 To 38
                a.Handled = True
            Case 40 To 44
                a.Handled = True
            Case 58 To 64
                a.Handled = True
        End Select
    End Sub
    'Public Function GetSMARTDEVICEPORT()
    '    Try
    '        Dim RETVALUE As Integer
    '        RETVALUE = ACR120U.ACR120_Open(ACR120U.PORTS.ACR120_USB1)
    '        'RETVALUE = ACR120U.ACR120_Open(CInt(GBL_SMARTDEVICEPORT))
    '        If RETVALUE < 0 Then
    '            MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.Critical, "NOT CONNECTED")
    '        Else
    '            '  MsgBox("SMART CARD DEVICE CONNECTION SUCCESSFUL", MsgBoxStyle.Information, "CONNECTED")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("PROBLEM IN SMART CARD DEVICE CONNECTION", MsgBoxStyle.Critical, "NOT CONNECTED")
    '    End Try
    'End Function
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getAlphanumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getAlphanumeric(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 47
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    Public Sub Blank(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        If Asc(b.KeyChar) > 0 And Asc(b.KeyChar) < 225 Then
            b.Handled = True
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Charater
    'Function Name:getCharater
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getCharater(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getEmail
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getEmail(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp1 As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            boolexp1 = True
            txtbox.ForeColor = Color.Black
        Else
            MsgBox(" E-mail Id field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp1 = False
            Exit Sub
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPincode
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPincode(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\d{5}(-\d{4})?$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Pincode field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If

    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPhoneno
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPhoneno(ByVal txtbox As System.Windows.Forms.TextBox)
        If regexp.IsMatch(txtbox.Text, "^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Phoneno field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If
    End Sub
    '************************************************************
    'Purpose: To Clear all the textBox control,within a group Box
    'Function Name: clearPanel
    'Input Type: panel 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub clearform(ByVal frm As System.Windows.Forms.Form)
        Dim ctrl As New Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next ctrl
    End Sub

    Public Sub OpenTextFile(ByVal VOutputfile As String)
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            If Dir(AppPath & "\Wordpad.exe") <> "" Then
                Shell(AppPath & "\Wordpad.exe " & AppPath & "\Reports\" & VOutputfile & ".txt", vbMaximizedFocus)
            Else
                MessageBox.Show("Wordpad.Exe Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Public Sub PrintTextFile(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            Filewrite = File.AppendText(AppPath & "\Reports\" & VOutputfile & ".bat")
            Filewrite.WriteLine("Type " & AppPath & "\Reports\" & VOutputfile & ".txt >prn")
            Filewrite.Close()
            Call Shell(AppPath & "\Reports\" & VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Public Sub PrintTextFile1(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(Trim(VOutputfile & "")) <> "" Then
            VOutputfile = Mid(VOutputfile, 1, VOutputfile.Length - 4)
            Filewrite = File.AppendText(VOutputfile & ".bat")
            If computername = "" Or Printername = "" Then
                Filewrite.WriteLine("Type " & VOutputfile & ".txt >> prn")
                Filewrite.WriteLine("erase " & VOutputfile & ".txt ")
            Else
                Filewrite.WriteLine("Type " & VOutputfile & ".txt > \\" & computername & "\" & Printername)
                Filewrite.WriteLine("erase " & VOutputfile & ".txt ")
            End If
            Filewrite.Close()
            Call Shell(VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Public Function Checkdaterangevalidate(ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        chkdatevalidate = False
        If (DateValue(Format(Enddate, "dd/MM/yyyy")) > DateValue(Format(SYSDATE, "dd/MM/yyyy"))) Then
            MessageBox.Show("To Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End If

        If (DateValue(Format(Startdate, "dd/MM/yyyy")) > DateValue(Format(SYSDATE, "dd/MM/yyyy"))) Then
            MessageBox.Show("From Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End If

        If CDate(Format(Startdate, "dd/MMM/yyyy")) > CDate(Format(gFinancialyearEnding, "dd/MMM/yyyy")) Then
            MsgBox("From Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
            Exit Function
        End If

        If (DateValue(Format(Startdate, "dd/MM/yyyy")) < DateValue(Format(gFinancialyearStart, "dd/MM/yyyy"))) Then
            MsgBox("From Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
            Exit Function
        End If


        If CDate(Format(Enddate, "dd/MMM/yyyy")) > CDate(Format(gFinancialyearEnding, "dd/MMM/yyyy")) Then
            MsgBox("To Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
            Exit Function
        End If

        If CDate(Format(Enddate, "dd/MMM/yyyy")) < CDate(Format(gFinancialyearStart, "dd/MMM/yyyy")) Then
            MsgBox("To Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
            Exit Function
        End If

        ''If (DateValue(Format(Startdate, "dd/MM/yyyy")) < DateValue(Format(SYSDATE, "dd/MM/yyyy"))) Then
        ''    MessageBox.Show("From Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ''    Exit Function
        ''End If

        chkdatevalidate = True
        Return chkdatevalidate
    End Function
    Public Function Checkdaterangevalidate_Financial(ByVal Financial_fromdate As Date, ByVal Financial_Todate As Date, ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        Try

            chkdatevalidate = True
            If DateDiff(DateValue(Financial_fromdate), Enddate, DateValue(Financial_Todate)) < 0 Then
                MessageBox.Show("Date Should be Between Financial Required", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Function
            End If
            If DateDiff(DateInterval.Day, Startdate, Enddate) < 0 Then
                MessageBox.Show("From Date cannot be greater than To Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Function
            End If

            If CDate(Startdate) >= CDate(Startdate) And CDate(Enddate) <= CDate(Enddate) Then
                chkdatevalidate = True
            Else
                MsgBox("Date should be within Financial Year", MsgBoxStyle.Critical)
                chkdatevalidate = False
                Exit Function
            End If
            Return chkdatevalidate
        Catch ex As Exception

        End Try
    End Function
    Public Function GetPassword(ByVal vUser As String) As String
        Dim Vdesc, vPass As String
        Dim vAsc, Loopindex As Long
        Vdesc = ""
        For Loopindex = 1 To Len(vUser)
            Vdesc = Mid(vUser, Loopindex, 1)
            vAsc = Asc(Vdesc) + 150
            vPass = Trim(vPass) & Chr(vAsc)
        Next Loopindex
        Return vPass
    End Function
    Public Function ExportTo(ByVal ssgrid As AxFPSpreadADO.AxfpSpread)
        Try
            Dim X As Boolean
            Dim vpath As String
            Dim vLog As String
            Dim strpath As String
            vpath = Application.StartupPath & "\Reports\Monprtn"
            vLog = Application.StartupPath & "\Reports\Monprtn.Txt"
            X = ssgrid.ExportRangeToTextFile(0, 0, ssgrid.Col2, ssgrid.Row2, Application.StartupPath & "\Reports\One.txt", "", ",", vbCrLf, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileCreateNewFile, Application.StartupPath & "\Reports\One.log")
            With ssgrid
                If Dir(vpath & ".Xls") <> "" Then
                    Kill(vpath & ".Xls")
                End If
                X = .ExportToExcel(vpath & ".Xls", "", "")
                strpath = strexcelpath & " " & vpath & ".xls"
                Call Shell(strpath, AppWinStyle.NormalFocus)
            End With
        Catch ex As Exception
            MessageBox.Show("Before Opening New EXCEL Sheet Close Previous EXCEL sheet", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    'REFERINVENTORY**************************************************************************************************
    Public Function CalAverageQuantity(ByVal ITEMCODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FEATCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        ''''********************************* FEATCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            Issuequantity = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("Qty")), "0.000")
            Issueamount = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Issuequantity = 0
            Issueamount = 0
        End If
        ''' ********************************* CALCULATE CLOSING BALANCE *********************************'''
        Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity))
        If Clsquantity = 0 Then
            Calrate = Val(Grnamount) / Val(Grnquantity)
        Else
            Calrate = (Val(Opamount) + Val(Grnamount) - Val(Issueamount)) / (Val(Clsquantity))
        End If
        '''********************************** COMPLETE CALCULATION OF AVERAGE FOR PARTICULAR ITEM  ********'''
        Return Clsquantity
    End Function
    Public Function ClosingQuantity(ByVal ITEMCODE As String, ByVal STORECODE As String) As Double
        Dim AdjustQty, ClsQty, MainstockQty, TransQty, TransFromQty, TransToQty As Double
        Dim OpQty, GrnQty, IssueQty, ReturnQty, ReturnFromQty, ReturnToQty, IssueToQty, IssueFromQty, ConsumedQty As Double
        Dim sqlstring As String
        Dim i As Integer
        '''*************************************** CALCULATION OF CLOSING QUANTITY FOR A PARTICULAR ITEM ***********************'''
        sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            'If Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORESTATUS")) = "M" Then
            If Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORESTATUS")) = "M" Then
                ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
                sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
                Else
                    OpQty = 0
                End If
                ''''********************************* FETCH FROM GRN_DETAILS ********************************************'''
                sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
                gconnection.getDataSet(sqlstring, "GRN_DETAILS")
                If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
                    GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
                Else
                    GrnQty = 0
                End If
                '''********************************* FROM STOCK RETURN *****************************************'''
                'sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
                'sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "' AND ISNULL(DOCTYPE,'')  = 'RET' AND ISNULL(VOID,'')<>'Y'"
                'gconnection.getDataSet(sqlstring, "STOCKRETURNDETAILS")
                'If gdataset.Tables("STOCKRETURNDETAILS").Rows.Count > 0 Then
                '    ReturnQty = Format(Val(gdataset.Tables("STOCKRETURNDETAILS").Rows(0).Item("QTY")), "0.000")
                'Else
                '    ReturnQty = 0
                'End If
                '==========================      
                MainstockQty = GrnQty + OpQty
            Else
                ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
                sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y' AND STORECODE='" & Trim(STORECODE) & "'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
                Else
                    OpQty = 0
                End If
                '    ''''********************************* FETCH FROM GRN_DETAILS ********************************************'''
                '    sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
                '    gconnection.getDataSet(sqlstring, "GRN_DETAILS")
                '    If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
                '        GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
                '    Else
                '        GrnQty = 0
                '    End If
                'End If
                ''''********************************* FROM STOCK RETURN *****************************************'''
                'sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
                'sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "' AND ISNULL(DOCTYPE,'')  = 'RET' AND ISNULL(VOID,'')<>'Y'"
                'gconnection.getDataSet(sqlstring, "STOCKRETURNDETAILS")
                'If gdataset.Tables("STOCKRETURNDETAILS").Rows.Count > 0 Then
                '    ReturnQty = Format(Val(gdataset.Tables("STOCKRETURNDETAILS").Rows(0).Item("QTY")), "0.000")
                'Else
                '    ReturnQty = 0
                'End If
                '==========================      
                MainstockQty = OpQty
            End If
        End If

        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueFromQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueFromQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND OPSTORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueToQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueToQty = 0
        End If
        IssueQty = IssueToQty - IssueFromQty
        ''''********************************* FROM STOCKADJUSTMENT ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(ADJUSTEDSTOCK),0) AS QTY FROM STOCKADJUSTDETAILS "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS")
        If gdataset.Tables("STOCKADJUSTDETAILS").Rows.Count > 0 Then
            AdjustQty = Format(Val(gdataset.Tables("STOCKADJUSTDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            AdjustQty = 0
        End If
        '''********************************* FROM STOCK TRANSFER *****************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND FROMSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS")
        If gdataset.Tables("STOCKTRANSDETAILS").Rows.Count > 0 Then
            TransFromQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            TransFromQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
        If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
            TransToQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
        Else
            TransToQty = 0
        End If
        TransQty = TransToQty - TransFromQty
        '''********************************* FROM STOCK consumption *****************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM SUBSTORECONSUMPTIONDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STORECONSUMPTIONDETAILS")
        If gdataset.Tables("STORECONSUMPTIONDETAILS").Rows.Count > 0 Then
            ConsumedQty = Format(Val(gdataset.Tables("STORECONSUMPTIONDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            ConsumedQty = 0
        End If

        ''' ********************************* CALCULATE CLOSING QUANTITY *********************************'''
        sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            If Trim(gdataset.Tables("STOREMASTER").Rows(i).Item("STORESTATUS")) = "M" Then
                ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty) - Val(ConsumedQty)
            Else
                ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty) - Val(ConsumedQty)
            End If
        End If
        '''********************************** COMPLETE CALCULATION QUANTITY ******************************'''
        Return ClsQty
    End Function
    Public Function CalAverageRate(ByVal ITEMCODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FEATCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        ''''********************************* FEATCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            Issuequantity = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("Qty")), "0.000")
            Issueamount = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Issuequantity = 0
            Issueamount = 0
        End If
        ''' ********************************* CALCULATE CLOSING BALANCE *********************************'''
        Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity))
        If Clsquantity = 0 Then
            If Grnquantity <> 0 Then
                Calrate = Val(Grnamount) / Val(Grnquantity)
            Else
                Calrate = 0
            End If
        Else
            Calrate = (Val(Opamount) + Val(Grnamount) - Val(Issueamount)) / (Val(Clsquantity))
        End If
        '''********************************** COMPLETE CALCULATION OF AVERAGE FOR PARTICULAR ITEM  ********'''
        Return Calrate
    End Function
    Public Function STOCKAVAILABILITY(ByVal GRID_OBJECT As Object, ByVal ROW As Integer) As Integer
        Dim POSITEMCODE, POSITEMUOM, SQLSTRING, VARPOSCODE As String
        Dim CHK_CLS_QUANTITY, DBLCALQTY As Double
        Dim CURQTY, PREVQTY, CLSQTY, VDIFF As Double
        Dim K As Integer
        GRID_OBJECT.row = ROW
        GRID_OBJECT.col = 3
        VARPOSCODE = (GRID_OBJECT.text & "")
        SQLSTRING = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & VARPOSCODE & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(SQLSTRING, "STOREMASTER1")
        If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
            GRID_OBJECT.Row = ROW
            GRID_OBJECT.Col = 1
            POSITEMCODE = Trim(GRID_OBJECT.Text)
            GRID_OBJECT.Row = ROW
            GRID_OBJECT.Col = 4
            POSITEMUOM = Trim(GRID_OBJECT.Text)
            SQLSTRING = "SELECT GITEMCODE,GUOM,GQTY FROM BOM_DET WHERE"
            SQLSTRING = SQLSTRING & " ITEMCODE='" & POSITEMCODE & "' AND ITEMUOM='" & POSITEMUOM & "' AND ISNULL(VOID,'') <> 'Y'"
            gconnection.getDataSet(SQLSTRING, "BOM")
            If gdataset.Tables("BOM").Rows.Count > 0 Then
                For K = 0 To gdataset.Tables("BOM").Rows.Count - 1
                    SQLSTRING = "SELECT * FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE") & "") & "' AND STORECODE='" & VARPOSCODE & "' AND ISNULL(FREEZE,'') <> 'Y'"
                    gconnection.getDataSet(SQLSTRING, "ITEMSTATUS")
                    If gdataset.Tables("ITEMSTATUS").Rows.Count <= 0 Then
                        MessageBox.Show(POSITEMCODE & " NOT AVAILABLE")
                        Return 0
                        Exit Function
                    End If
                    GRID_OBJECT.Row = ROW
                    'REFERCSC
                    'GRID_OBJECT.Col = 22
                    If GmoduleName = "KOT Entry" Then
                        GRID_OBJECT.Col = 18
                    Else
                        GRID_OBJECT.Col = 22
                    End If
                    PREVQTY = Val(GRID_OBJECT.Text) * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY"))
                    If PREVQTY <> 0 Then
                        GRID_OBJECT.Row = ROW
                        GRID_OBJECT.Col = 5
                        CURQTY = Val(GRID_OBJECT.Text) * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY"))
                        CLSQTY = ClosingQuantity(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE"), VARPOSCODE)
                        VDIFF = Val(CLSQTY) + Val(PREVQTY) - Val(CURQTY)
                        If Val(VDIFF) < 0 Then
                            MessageBox.Show("STOCK IS NOT SUFFICIENT TO  MODIFY...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return 1
                            Exit Function
                        End If
                    Else
                        CHK_CLS_QUANTITY = ClosingQuantity(gdataset.Tables("BOM").Rows(K).Item("GITEMCODE"), VARPOSCODE)
                        GRID_OBJECT.Col = 5
                        GRID_OBJECT.Row = ROW
                        DBLCALQTY = Val(GRID_OBJECT.Text)
                        If CHK_CLS_QUANTITY < (DBLCALQTY * CDbl(gdataset.Tables("BOM").Rows(K).Item("GQTY"))) Then
                            MessageBox.Show(POSITEMCODE & " NOT AVAILABLE")
                            Return 0
                            Exit Function
                        End If
                    End If
                Next
            Else
                SQLSTRING = "SELECT ITEMCODE,STOCKUOM FROM INVENTORYITEMMASTER WHERE"
                SQLSTRING = SQLSTRING & " ITEMCODE='" & POSITEMCODE & "' AND STOCKUOM='" & POSITEMUOM & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(SQLSTRING, "DIRECT_STOCK")
                If gdataset.Tables("DIRECT_STOCK").Rows.Count > 0 Then
                    GRID_OBJECT.Row = ROW
                    'REFERCSC
                    'GRID_OBJECT.Col = 22
                    If GmoduleName = "KOT Entry" Then
                        GRID_OBJECT.Col = 18
                    Else
                        GRID_OBJECT.Col = 22
                    End If
                    PREVQTY = Val(GRID_OBJECT.Text)
                    If PREVQTY <> 0 Then
                        GRID_OBJECT.Row = ROW
                        GRID_OBJECT.Col = 5
                        CURQTY = Val(GRID_OBJECT.Text)
                        CLSQTY = ClosingQuantity(gdataset.Tables("DIRECT_STOCK").Rows(K).Item("ITEMCODE"), VARPOSCODE)
                        VDIFF = Val(CLSQTY) + Val(PREVQTY) - Val(CURQTY)
                        If Val(VDIFF) < 0 Then
                            MessageBox.Show("STOCK IS NOT SUFFICIENT TO  MODIFY...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return 1
                            Exit Function
                        End If
                    Else
                        CHK_CLS_QUANTITY = ClosingQuantity(gdataset.Tables("DIRECT_STOCK").Rows(K).Item("ITEMCODE"), VARPOSCODE)
                        GRID_OBJECT.Col = 5
                        GRID_OBJECT.Row = ROW
                        DBLCALQTY = Val(GRID_OBJECT.Text)
                        If CHK_CLS_QUANTITY < DBLCALQTY Then
                            MessageBox.Show(POSITEMCODE & " NOT AVAILABLE")
                            Return 0
                            Exit Function
                        End If
                    End If
                End If
            End If
        End If
        Return 2
    End Function

    Public Function STORELOCATION(ByVal STORECODE As String) As String
        Dim sqlstring, STRLOCATION As String
        sqlstring = "SELECT STOREDESC FROM STOREMASTER WHERE STORECODE='" & STORECODE & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            STRLOCATION = (gdataset.Tables("STOREMASTER").Rows(0).Item("STOREDESC") & "")
        End If
        Return STRLOCATION
    End Function

    Public Function GetMainStore() As String
        Try
            Dim SQLSTRING, MnStore As String
            SQLSTRING = "SELECT STORECODE FROM STOREMASTER WHERE STORESTATUS='M' AND ISNULL(FREEZE,'') <> 'Y'"
            gconnection.getDataSet(SQLSTRING, "MAINSTORE")
            If gdataset.Tables("MAINSTORE").Rows.Count > 0 Then
                MnStore = Trim(gdataset.Tables("MAINSTORE").Rows(0).Item("STORECODE"))
            Else
                MnStore = ""
            End If
            Return MnStore
        Catch EX As Exception
            MsgBox(EX.Message)
            Exit Function
        End Try
    End Function
    Public Function getVoucherno(ByVal vvouchertype As String, ByVal vvouchercategory As String) As Double
        Try
            Dim ssql As String
            ssql = "Select docno from docnumbers where doctype='" & Trim(vvouchertype & "") & "'"
            gconnection.getDataSet(ssql, "docnumbers")
            If gdataset.Tables("docnuMbers").Rows.Count > 0 Then
                getVoucherno = Val(gdataset.Tables("DOCNUMBERS").Rows(0).Item(0) & "")
            Else
                ssql = "insert into docnumbers(doctype,docno) values ('" & Trim(vvouchertype) & "',1)"
                gconnection.dataOperation(6, ssql)
                getVoucherno = 1
            End If
            gconnection.dataOperation(6, "Update Docnumbers set Docno=isnull(Docno,0) +1 where Doctype='" & vvouchertype & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function Search_Item(ByVal listBox As Windows.Forms.CheckedListBox, ByVal searchText As String)
        If searchText <> "" Then
            Dim I, J As Integer
            For I = 0 To listBox.Items.Count - 1
                For J = 1 To Len(listBox.Items(I))
                    If UCase(Mid(listBox.Items(I), J, Len(Trim(searchText)))) = UCase(Trim(searchText)) Then
                        listBox.SetItemChecked(I, True)
                        listBox.SelectedIndex = I
                    End If
                Next
            Next
        End If
    End Function
    Function RupeesToWord(ByVal MyNumber)
        Dim Temp
        Dim Rupees, Paisa As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWord = "Rupees " & Words & Paisa & " Only"

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWord = "Rupees " & Words & Paisa & " Only"
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or _
                Trim(Words) = "Lakh  Thousand" Or _
                Trim(Words) = "Lakh" Or _
                Trim(Words) = "Crore" Or _
                Trim(Words) = "Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab" Or _
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or _
                   Trim(Words) = "Lakh  Thousand" Or _
                   Trim(Words) = "Lakh" Or _
                   Trim(Words) = "Crore" Or _
                   Trim(Words) = "Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWord = "Rupees " & Words & Hundreds & Paisa & " Only"
    End Function
    Private Function ConvertHundreds(ByVal MyNumber)
        Dim Result As String

        ' Exit if there is nothing to convert.
        If Val(MyNumber) = 0 Then Exit Function

        ' Append leading zeros to number.
        MyNumber = Right("000" & MyNumber, 3)

        ' Do we have a hundreds place digit to convert?
        If Left(MyNumber, 1) <> "0" Then
            Result = ConvertDigit(Left(MyNumber, 1)) & " Hundreds "
        End If

        ' Do we have a tens place digit to convert?
        If Mid(MyNumber, 2, 1) <> "0" Then
            Result = Result & ConvertTens(Mid(MyNumber, 2))
        Else
            ' If not, then convert the ones place digit.
            Result = Result & ConvertDigit(Mid(MyNumber, 3))
        End If

        ConvertHundreds = Trim(Result)
    End Function
    Private Function ConvertTens(ByVal MyTens)
        Dim Result As String

        ' Is value between 10 and 19?
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            ' .. otherwise it's between 20 and 99.
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select

            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If

        ConvertTens = Result
    End Function
    Private Function ConvertDigit(ByVal MyDigit)
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function
    Public Function Funamp(ByVal str As String) As String
        Dim str1, str2 As String
        Dim i As Integer
        str1 = str
        i = 1
        While i <> 0
            i = InStr(1, str1, "&")
            If i <> 0 Then
                str2 = str2 & Mid(str1, 1, i) & "amp;"
            End If
            str1 = Mid(str1, i + 1, Len(str1))
        End While
        Funamp = str2 & str1
    End Function
    Public Function Funapos(ByVal str As String) As String
        Dim str1, str2 As String
        Dim i As Integer
        str1 = str
        i = 1
        While i <> 0
            i = InStr(1, str1, "'")
            If i <> 0 Then
                str2 = str2 & Mid(str1, 1, (i - 1)) & "&apos;"
            End If
            str1 = Mid(str1, i + 1, Len(str1))
        End While
        Funapos = str2 & str1
    End Function
    'SMARTCARD
    ''FOR DUPLICATE CARD ID
    ''FILTER THE ADDED STRINGS IN THE 16_DIGIT_CODE
    ''DDYYYYCARDIDMM --> DUPLICATE CARD ID FORMAT
    'Public Function CardIdValidate(ByVal vCardID As String) As Boolean
    '    Try
    '        Dim vSQL, vDay, vDate, vMonth As String
    '        vTmp = vCardID.Substring(6, 11)
    '        vSQL = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(vTmp) & "' AND ISNULL(CARDCODE,'')<>'' "
    '        gconnection.getDataSet(vSQL, "SM_MEM_LINKAGE1")
    '        vCardcode = gdataset.Tables("SM_MEM_LINKAGE1").Rows(0).Item("CARDCODE")
    '        vDate = Format(DateTime.Today.Now, "dd/MM/yyyy")
    '        vDay = vDate.Substring(0, 2)
    '        vMonth = vDate.Substring(3, 2)
    '        If gdataset.Tables("SM_MEM_LINKAGE1").Rows.Count > 0 And Trim(vCardID.Substring(0, 2)) = Trim(vDay) And Trim(vCardID.Substring(17, 2)) = Trim(vMonth) Then
    '            Cardidcheck = True
    '            CardIdValidate = True
    '        Else
    '            vTmp = " "
    '            CardIdValidate = False
    '            Cardidcheck = False
    '        End If
    '    Catch ex As Exception
    '        Exit Function
    '    End Try
    'End Function

    '1--->REPLACE THIS GLOBAL FUNCTION  'FOR DUPLICATE CARD ID
    'FILTER THE ADDED STRINGS IN THE 16_DIGIT_CODE
    'DDYYYYCARDIDMM --> DUPLICATE CARD ID FORMAT


End Module
