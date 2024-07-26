'=====================================================================================
'
'   Company:  Advanced Card Systems LTD.
'
'   Module :  MyRoutine Module
'
'   Author :  Aileen Grace Sarte
'
'   Date   :  July 31, 2006
'
'   Description:
'             Module of Common Routines
'           
'
'======================================================================================
Imports System
Imports Microsoft.VisualBasic
Imports System.Runtime.InteropServices
Module MyRoutine
    Public G_rHandle As Integer
    Public G_retcode As Integer
    Public G_SID As Byte
    Public G_Sec As Integer
    Public G_pKey(5) As Byte
    Public G_vKeyType As Byte
    Public G_StoredNum As Integer
    Public G_Cancel As Boolean
    Public G_PhysicalSector As Integer
    Public G_BlockNum As Byte


    '=======================================================================================
    '
    ' String Definition of Error Codes
    '
    '=======================================================================================
    Public Function ErrDef(ByVal ErrCode As Integer) As String
        Select Case (ErrCode)

            Case -1000 : ErrDef = "( X ) Unexpected Internal Library Error : -1000"

            Case -2000 : ErrDef = "( X ) Invalid Port : -2000"

            Case -2010 : ErrDef = "( X ) Port Occupied by Another Application : -2010"

            Case -2020 : ErrDef = "( X ) Invalid Handle : -2020"

            Case -2030 : ErrDef = "( X ) Incorrect Parameter : -2030"

            Case -3000 : ErrDef = "( X ) No TAG Selected or in Reachable Range : -3000"

            Case -3010 : ErrDef = "( X ) Read Failed after Operation : -3010"

            Case -3020 : ErrDef = "( X ) Block doesn't contain value : -3020"

            Case -3030 : ErrDef = "( X ) Operation Failed : -3030"

            Case -3040 : ErrDef = "( X ) Unknown Reader Error : -3040"

            Case -4010 : ErrDef = "( X ) Invalid stored key format in login process : -4010"

            Case -4020 : ErrDef = "( X ) Reader can't read after write operation : -4020"

            Case -4030 : ErrDef = "( X ) Decrement Failure (Empty) : -4030"

            Case -4031 : ErrDef = "( X ) Increment Overflow : -4031"

            Case -4032 : ErrDef = "( X ) Value Operations failure : -4032"

            Case -4033 : ErrDef = "( X ) Block doesn't contain value : -4033"

            Case -4034 : ErrDef = "( X ) Value Access failure : -4034"
            Case Else
                ErrDef = "( X ) Error : " & ErrCode
        End Select

    End Function
    Public Function KeyVerify(ByVal key As Integer) As Boolean
        If key >= 48 And key <= 57 Then
            KeyVerify = False
        ElseIf key >= 65 And key <= 70 Then
            KeyVerify = False
        ElseIf key >= 97 And key <= 102 Then
            KeyVerify = False
        ElseIf key = 8 Then
            KeyVerify = False
        Else
            KeyVerify = True
        End If
    End Function
End Module



