Imports System.Text.RegularExpressions
Imports System.IO
Imports System.data.SqlClient
Imports System.Drawing.Imaging
Imports MSCommLib
Imports Microsoft.VisualBasic.Strings
Module SMART_READER_SC
    Private WithEvents MSComm1 As MSComm
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Dim ComPort As Integer
    Public msginit, outString As String
    Public ANTISIG As String
    Dim Reader_Found As Boolean
    Public Enum Key
        KEYA = 0
        KEYB = 4
    End Enum
    Dim Signal As String
    Public Sub INITIALIZE()
        On Error GoTo CommErr
        'Dim chkstr As String
        Dim reader As String
        MSComm1 = New MSComm
        For ComPort = COMPORT_SC To COMPORT_SC
            Reader_Found = True
            MSComm1.CommPort = ComPort
            'chkstr = MSComm1.Settings
            'If Mid(chkstr, 1, 4) = "1152" Then
            ' MSComm1.Settings = "19200,N,8,1"
            MSComm1.Settings = "9600,N,8,1"
            'Else
            'MSComm1.Settings = "9600,N,8,1"
            'End If
            MSComm1.PortOpen = True
            msginit = Reset_Card_chk()
            If Reader_Found = True Then
                reader = Reset_Card()
                If Mid(reader, 1, 1) = "0" Then
                    Exit Sub
                ElseIf Mid(reader, 3, 1) = "0" Then
                    Exit Sub
                End If
                MSComm1.PortOpen = False
            End If
        Next
        Err.Raise(12000)
CommErr:
        If Err.Number = 8002 Or Err.Number = 8005 Then
            Reader_Found = False
            Resume Next
        ElseIf Err.Number = 12000 Then
            MsgBox("Reader Not Connected ")
        End If
        '        MSComm1.Output = "t" & vbCr
        '        reader = WaitForInput
        '        If Mid(reader, 3, 1) = "0" Then
        '            MsgBox "Reader Present"
        '        End If
    End Sub
    Public Function Reset_Card() As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "t" & vbCr
            Reset_Card = WaitForInput()
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function
    Public Function Request_Card() As Boolean
        Dim Req_Signal As String
        Dim pos As String
        If MSComm1.PortOpen = True Then

            Reset_Card()
            outString = "r"
            outString = outString & "0" & vbCr
            MSComm1.Output = outString

            '    If WaitForInput = "" Then
            '        reques_card = False
            '        Exit Function
            '    End If
            Req_Signal = WaitForInput()
            pos = InStr(1, Req_Signal, 0, vbTextCompare)
            If pos = 1 Then
                Req_Signal = Mid(Req_Signal, 1, 1)
            Else
                Req_Signal = Mid(Req_Signal, 3, 1)
            End If

            If Req_Signal = "0" Then
                Request_Card = True
            Else
                Request_Card = False
            End If
            'Else
            '    MsgBox "Port is not opened"
            '    Exit Function
        End If

    End Function
    Public Function AntiCollu_Card() As String
        Dim Anti_Signal As String
        Dim anti As String
        Dim pos As String
        Dim STR As String
        If MSComm1.PortOpen = True Then
            outString = "a" & vbCr
            MSComm1.Output = outString
            Anti_Signal = WaitForInput()
            STR = Anti_Signal
            pos = InStr(1, Anti_Signal, 0, vbTextCompare)
            If pos = 1 Then
                anti = Mid(Anti_Signal, 4, 4)   '6
            Else
                anti = Mid(Anti_Signal, 6, 4)   '6
            End If
            Anti_Signal = Data_Asc_Hex(anti)
            AntiCollu_Card = Anti_Signal
            STR = Mid(STR, 2, 4)

            ANTISIG = Data_Asc_Hex(STR)
            GBL_SmartCardID = ANTISIG
            'Else
            '    MsgBox "Port is not opened"
            '    Exit Function
        End If

    End Function
    Public Function Select_Card() As Boolean
        Dim Sel_Signal As String
        Dim pos As String
        If MSComm1.PortOpen = True Then
            outString = "s" & vbCr
            MSComm1.Output = outString
            Sel_Signal = WaitForInput()
            pos = InStr(1, Sel_Signal, 0, vbTextCompare)

            If pos = 1 Then
                Sel_Signal = Mid(Sel_Signal, 1, 1)
            Else
                Sel_Signal = Mid(Sel_Signal, 3, 1)
            End If

            If Sel_Signal = "0" Then
                Select_Card = True
            Else
                Select_Card = False
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function

    Public Function Write_Card(ByVal SectorNO As Integer, ByVal BlockNo As Integer, ByVal buffer As String) As Boolean
        Dim HSectorNo As String
        Dim HBlockNo As String
        Dim RedCrd_Signal, Data As String
        Data = "@@@@@@@@@@@@@@@@"
        If MSComm1.PortOpen = True Then
            LSet(Data = buffer, 16)
            If Len(Data) = 16 Then
                If SectorNO >= 0 And SectorNO < 16 Then
                    HSectorNo = SectorNO
                    If Len(HSectorNo) = 1 Then
                        HSectorNo = "0" & HSectorNo
                    End If
                End If
                If BlockNo >= 0 And BlockNo < 64 Then
                    HBlockNo = BlockNo
                    If Len(HBlockNo) = 1 Then
                        HBlockNo = "0" & HBlockNo
                    End If
                    MSComm1.Output = "W0" & "0" & HSectorNo & HBlockNo & Data & vbCr
                    RedCrd_Signal = WaitForInput()

                    If Mid(RedCrd_Signal, 1, 1) = "0" Then
                        Write_Card = True
                    ElseIf Mid(RedCrd_Signal, 3, 1) = "0" Then
                        Write_Card = True
                    Else
                        Write_Card = False
                    End If
                End If
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function

    Public Function Read_Card(ByVal SectorNO As Integer, ByVal BlockNo As Integer) As String
        Dim HSectorNo As String
        Dim HBlockNo As String
        Dim RedCrd_Signal As String
        Dim pos As String
        If MSComm1.PortOpen = True Then
            If SectorNO >= 0 And SectorNO < 16 Then
                HSectorNo = SectorNO
                If Len(HSectorNo) = 1 Then
                    HSectorNo = "0" & HSectorNo
                End If
            End If
            If BlockNo >= 0 And BlockNo < 64 Then
                HBlockNo = BlockNo
                If Len(HBlockNo) = 1 Then
                    HBlockNo = "0" & HBlockNo
                End If
                MSComm1.Output = "R0" & "0" & HSectorNo & HBlockNo & vbCr
                RedCrd_Signal = WaitForInput()
                pos = InStr(1, RedCrd_Signal, 0, vbTextCompare)
                If pos = 1 Then
                    Read_Card = Mid(RedCrd_Signal, 6, 16)
                ElseIf pos = 3 Then
                    Read_Card = Mid(RedCrd_Signal, 8, 16)
                End If

            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function
    Public Function GateClose() As Boolean
        Dim relaysignal As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "O011" & vbCr
            relaysignal = WaitForInput()
            If relaysignal = 0 Then
                GateClose = True
            Else
                GateClose = False
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function
    Public Function GateOpen() As Boolean
        Dim relaysignal As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "O010" & vbCr
            relaysignal = WaitForInput()
            If relaysignal = 0 Then
                GateOpen = True
            Else
                GateOpen = False
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function

    Public Function Authenticate(ByVal SectorNO As Integer, ByVal BlockNo As Integer) As Boolean
        Dim HBlockNo, HSectorNo As String
        Dim Auth_Signal As String
        If MSComm1.PortOpen = True Then
            If SectorNO >= 0 And SectorNO < 16 Then
                HSectorNo = SectorNO
                If Len(HSectorNo) = 1 Then
                    HSectorNo = "0" & HSectorNo
                End If
                If BlockNo >= SectorNO * 4 And BlockNo < (SectorNO + 1) * 4 Then
                    HBlockNo = BlockNo
                    If Len(HBlockNo) = 1 Then
                        HBlockNo = "0" & HBlockNo
                    End If
                    MSComm1.Output = "A0" & HSectorNo & HBlockNo & vbCr
                    Auth_Signal = WaitForInput()

                    If Mid(Auth_Signal, 1, 1) = "0" Then
                        Authenticate = True
                    ElseIf Mid(Auth_Signal, 3, 1) = "0" Then
                        Authenticate = True
                    Else
                        Authenticate = False
                    End If
                Else
                    MsgBox("Block Number Should  be in between " & SectorNO * 4 & " and  " & ((SectorNO + 1) * 4) - 1)
                End If
            Else
                MsgBox("Sector Number should be in between 0 to 15")
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function
    Public Function Load_Keys(ByVal SectorNO As Integer, ByVal Key As String) As Boolean
        Dim HSectorNo As String
        Dim LodKey_Signal As String
        If MSComm1.PortOpen = True Then
            If SectorNO >= 0 And SectorNO < 16 Then
                HSectorNo = SectorNO
                If Len(HSectorNo) = 1 Then
                    HSectorNo = "0" & HSectorNo
                End If
                If Len(Trim(Key)) = 12 Then
                    MSComm1.Output = "L" & "0" & HSectorNo & Key & vbCr
                    LodKey_Signal = WaitForInput()

                    If Mid(LodKey_Signal, 1, 1) = "0" Then
                        Load_Keys = True
                    ElseIf Mid(LodKey_Signal, 3, 1) = "0" Then
                        Load_Keys = True
                    Else
                        Load_Keys = False
                    End If
                Else
                    MsgBox("Length of Key Should be 12 Hex Digits (0-F)")
                End If
            Else
                MsgBox("Sector Number should be in between 0 to 15")
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function
    Private Function WaitForInput() As String
        Dim Signal As String
        Dim i As Integer
        i = 0
        Sleep(200)
        Signal = MSComm1.Input
        '    While Right(signal, 1) <> "!"
        '        signal = signal & MSComm1.Input
        '        Sleep 1
        '        i = i + 1
        '        If (i > 1000) Then
        '            signal = ""
        '            Exit Function
        '        End If
        '    Wend
        WaitForInput = Signal
    End Function

    Private Function Data_Asc_Hex(ByVal Data As String) As String
        Dim Data1 As String
        While Len(Data) > 0
            Data1 = Data1 & Hex(Asc(Right(Data, 1)))
            Data = Left(Data, Len(Data) - 1)
            'Data1 = ""
        End While
        Data_Asc_Hex = Data1
    End Function
    Private Function Data_Hex_Asc(ByVal Data As String) As String
        Dim Data1 As String
        While Len(Data) > 0
            Data1 = Data1 & Chr(CLng("&H" & Left(Data, 2)))
            Data = Right(Data, Len(Data) - 2)
        End While
        Data_Hex_Asc = Data1
    End Function


    Public Function Terminate()
        If MSComm1.PortOpen = True Then
            MSComm1.PortOpen = False
        End If
    End Function


    Public Function Fast_Read_Card(ByVal SectorNO As Integer, ByVal BlockNo As Integer) As String

        Dim HSectorNo As String
        Dim HBlockNo As String
        Dim RedCrd_Signal As String
        Dim pos As String

        Dim KEYSET As String

        KEYSET = "FFFFFFFFFFFF"

        HSectorNo = SectorNO
        If Len(HSectorNo) = 1 Then
            HSectorNo = "0" & HSectorNo
        End If

        HBlockNo = BlockNo
        If Len(HBlockNo) = 1 Then
            HBlockNo = "0" & HBlockNo
        End If

        If Request_Card() = False Then
            '            MsgBox("Request Failed........")
        End If
        If Select_Card() = False Then
            '           MsgBox("Select Failed........")
        End If

        If Load_Keys(HSectorNo, KEYSET) Then
            '          MsgBox("Load Failed........")
        End If

        If Authenticate(HSectorNo, HBlockNo) = False Then
            '         MsgBox("Authenticate Failed........")
        End If

        If MSComm1.PortOpen = True Then
            If SectorNO >= 0 And SectorNO < 16 Then
                HSectorNo = SectorNO
                If Len(HSectorNo) = 1 Then
                    HSectorNo = "0" & HSectorNo
                End If
            End If
            If BlockNo >= 0 And BlockNo < 64 Then
                HBlockNo = BlockNo
                If Len(HBlockNo) = 1 Then
                    HBlockNo = "0" & HBlockNo
                End If
                MSComm1.Output = "R0" & "0" & HSectorNo & HBlockNo & vbCr
                RedCrd_Signal = WaitForInput()
                pos = InStr(1, RedCrd_Signal, 0, vbTextCompare)
                If pos = 1 Then
                    Fast_Read_Card = Mid(RedCrd_Signal, 6, 16)
                ElseIf pos = 3 Then
                    Fast_Read_Card = Mid(RedCrd_Signal, 8, 16)
                End If

            End If
            '            MsgBox(Fast_Read_Card)
            '            Return Fast_Read_Card
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function

    Public Function Fast_Write_Card(ByVal SectorNO As Integer, ByVal BlockNo As Integer, ByVal buffer As String) As Boolean
        Dim HSectorNo As String
        Dim HBlockNo, Data As String
        Dim RedCrd_Signal As String
        Dim KEYSET As String

        KEYSET = "FFFFFFFFFFFF"

        HSectorNo = SectorNO
        If Len(HSectorNo) = 1 Then
            HSectorNo = "0" & HSectorNo
        End If

        HBlockNo = BlockNo
        If Len(HBlockNo) = 1 Then
            HBlockNo = "0" & HBlockNo
        End If

        If Request_Card() = False Then
            '            MsgBox("Request Failed........")
        End If
        If Select_Card() = False Then
            '           MsgBox("Select Failed........")
        End If

        If Load_Keys(HSectorNo, KEYSET) Then
            '          MsgBox("Load Failed........")
        End If

        If Authenticate(HSectorNo, HBlockNo) = False Then
            '         MsgBox("Authenticate Failed........")
        End If

        '        Data = "@@@@@@@@@@@@@@@@"
        Data = buffer & Space(16 - Len(buffer))

        If MSComm1.PortOpen = True Then
            '    LSet(Data = buffer, 16)

            If Len(Data) = 16 Then
                If SectorNO >= 0 And SectorNO < 16 Then
                    HSectorNo = SectorNO
                    If Len(HSectorNo) = 1 Then
                        HSectorNo = "0" & HSectorNo
                    End If
                End If
                If BlockNo >= 0 And BlockNo < 64 Then
                    HBlockNo = BlockNo
                    If Len(HBlockNo) = 1 Then
                        HBlockNo = "0" & HBlockNo
                    End If
                    MSComm1.Output = "W0" & "0" & HSectorNo & HBlockNo & Data & vbCr
                    RedCrd_Signal = WaitForInput()

                    If Mid(RedCrd_Signal, 1, 1) = "0" Then
                        Fast_Write_Card = True
                    ElseIf Mid(RedCrd_Signal, 3, 1) = "0" Then
                        Fast_Write_Card = True
                    Else
                        Fast_Write_Card = False
                    End If
                End If
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If

    End Function
    Public Function Reset_Card1() As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "t" & vbCr
            Reset_Card1 = WaitForInput()
            If Reset_Card1 <> "" Then

                ' MsgBox "Reset Sucess"
                Reset_Card1 = "Y"
            Else
                'MsgBox "Reset Failed"
                Reset_Card1 = "N"

            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function

    Public Function Reset_Card9600() As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "x0096D" & vbCr
            Reset_Card9600 = WaitForInput()
            If Reset_Card9600 <> "" Then

                'MsgBox "9600 Baud Rate set Sucess"
                Reset_Card9600 = "Y"
            Else
                'MsgBox "Baud Rate Changed Failed"
                Reset_Card9600 = "N"
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function

    Public Function Reset_Card1152() As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "x1152D" & vbCr
            Reset_Card1152 = WaitForInput()
            If Reset_Card1152 <> "" Then

                'MsgBox "115200 Baud Rate set Sucess"
                Reset_Card1152 = "Y"
            Else
                'MsgBox "Baud Rate Changed Failed"
                Reset_Card1152 = "N"
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function
    Public Function Reset_Card19200() As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "x0192D" & vbCr
            Reset_Card19200 = WaitForInput()
            If Reset_Card19200 <> "" Then
                Reset_Card19200 = "Y"
                ' Reset_Card19200 = "19200 Baud Rate set Sucess"

            Else
                '  Reset_Card19200 = "Baud Rate Changed Failed"
                Reset_Card19200 = "N"
            End If
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function
    Public Function Reset_Card_chk() As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "t" & vbCr
            Reset_Card_chk = WaitForInput()
            If Reset_Card_chk <> "" Then
                Reset_Card_chk = "Reader Connected with 115200 Baud Rate"
            Else
                MSComm1.Settings = "9600,N,8,1"

                Reset_Card_chk = "Reader Connected with 9600 Baud Rate"
            End If

        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function

    Public Function Reset_Card_Beep_on() As String
        Dim Reset_Card_Beep As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "O010" & vbCr
            Reset_Card_Beep = WaitForInput()
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function
    Public Function Reset_Card_Beep_off() As String
        Dim Reset_Card_Beep As String
        If MSComm1.PortOpen = True Then
            MSComm1.Output = "O011" & vbCr
            Reset_Card_Beep = WaitForInput()
        Else
            MsgBox("Port is not opened")
            Exit Function
        End If
    End Function
End Module