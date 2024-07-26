Imports System
Imports System.Data
Imports System.Data.OleDb
Namespace COMMON
    Public Class commonClass
        Public comDataset As System.Data.DataSet
        Private ad As System.Data.OleDb.OleDbDataAdapter
        Private con As System.Data.OleDb.OleDbConnection
        Dim cmd As OleDb.OleDbCommand
        Dim tables() As String = {"MST_EMP", "MST_ACCESS_GRANT", "MST_LOGININFO", "MST_SCREENDESC", "MST_TOPOGRAM", "MST_AREA"}
        Dim s As String
        Enum Action
            fetchData
            manipulateData
        End Enum
        Public Sub New()
            '' Initialising the components 
            con = New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
            comDataset = New DataSet
            Call StoreUniqChr()
        End Sub
        Private Sub fill_the_dataset(Optional ByVal table() As String = Nothing)
            Dim i As Integer
            If table Is Nothing Then
                comDataset.Clear()
                For i = 0 To tables.Length - 1
                    Dim temp_ad As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tables(i), con) 'CHANGES BY ANIL
                    temp_ad.Fill(comDataset, tables(i))
                Next
            Else
                For i = 0 To table.Length - 1
                    Dim temp_ad As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & table(i), con)
                    comDataset.Tables.Remove(table(i))
                    temp_ad.Fill(comDataset, table(i))
                Next
            End If
        End Sub
        Public Function DataAction(ByVal action As Action, ByVal qry As String, Optional ByVal Table() As String = Nothing) As System.Data.DataSet
            cmd = New OleDb.OleDbCommand(qry)
            ad = New OleDb.OleDbDataAdapter(qry, con)
            Select Case action
                Case action.fetchData

                Case action.manipulateData
            End Select
            Call fill_the_dataset(Table)
            DataAction = comDataset
        End Function
        Public Function DataTransaction(ByVal qry() As String, Optional ByRef msg As String = Nothing) As Boolean 'System.Data.DataSet
            Dim returnValue As Boolean
            Dim i As Integer
            Dim myTrans As OleDb.OleDbTransaction
            Dim myConnection As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=synergy;Password=synergy;")
            Try
                myConnection.Open()
                Dim myCommand As OleDb.OleDbCommand = myConnection.CreateCommand()
                myTrans = myConnection.BeginTransaction()
                myCommand.Connection = myConnection
                myCommand.Transaction = myTrans
                For i = 0 To qry.Length - 1
                    myCommand.CommandText = qry(i)
                    myCommand.ExecuteNonQuery()
                Next
                myTrans.Commit()
                returnValue = True
            Catch e As Exception
                Try
                    myTrans.Rollback()
                    msg = e.Message
                Catch ex As OleDb.OleDbException
                    msg = ex.Message
                End Try
                returnValue = False
            Finally
                myConnection.Close()
            End Try
            Return returnValue
        End Function
        ''''Public Function DataTransaction(ByVal qry As String, Optional ByRef msg As String = Nothing) As Boolean 'System.Data.DataSet
        ''''    Dim i As Integer
        ''''    Dim returnValue As Boolean
        ''''    Dim myTrans As OleDb.OleDbTransaction
        ''''    Dim myConnection As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
        ''''    Try
        ''''        myConnection.Open()
        ''''        Dim myCommand As OleDb.OleDbCommand = myConnection.CreateCommand()
        ''''        myTrans = myConnection.BeginTransaction()
        ''''        myCommand.Connection = myConnection
        ''''        myCommand.Transaction = myTrans
        ''''        myCommand.CommandText = qry
        ''''        myCommand.ExecuteNonQuery()
        ''''        myTrans.Commit()
        ''''        returnValue = True
        ''''    Catch e As Exception
        ''''        Try
        ''''            myTrans.Rollback()
        ''''            msg = e.Message
        ''''        Catch ex As OleDb.OleDbException
        ''''            msg = ex.Message
        ''''        End Try
        ''''        returnValue = False
        ''''    Finally
        ''''        myConnection.Close()
        ''''    End Try
        ''''    Return (returnValue)
        ''''End Function
        Public Function DataTransaction(ByVal qry As String, Optional ByRef msg As String = Nothing, Optional ByVal cmdtype As String = Nothing, Optional ByVal param1 As String = Nothing, Optional ByVal param2 As Integer = Nothing, Optional ByVal namepara1 As String = Nothing, Optional ByVal namepara2 As String = Nothing) As Boolean 'System.Data.DataSet
            Dim i As Integer
            Dim returnValue As Boolean
            Dim myTrans As OleDb.OleDbTransaction

            Dim myConnection As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
            Try
                myConnection.Open()
                Dim myCommand As OleDb.OleDbCommand = myConnection.CreateCommand()
                myTrans = myConnection.BeginTransaction()
                myCommand.Connection = myConnection
                If cmdtype = "StoredProc" Then
                    myCommand.CommandType = CommandType.StoredProcedure
                    ''Dim p As Object = New OleDbParameter("@org", OleDbType.PropVariant)
                    ''myCommand.Parameters.Add(p)
                    Dim myparam As New OleDb.OleDbParameter
                    Dim myparam1 As New OleDb.OleDbParameter
                    myparam = myCommand.Parameters.Add(namepara1, OleDbType.VarChar)
                    myparam.Value = param1
                    myparam1 = myCommand.Parameters.Add(namepara2, OleDbType.Numeric)
                    myparam1.Value = param2

                    myCommand.Transaction = myTrans
                    myCommand.CommandText = qry
                    myCommand.ExecuteNonQuery()
                    myTrans.Commit()
                Else
                    myCommand.Transaction = myTrans
                    myCommand.CommandText = qry
                    myCommand.ExecuteNonQuery()
                    myTrans.Commit()
                End If
                returnValue = True
            Catch e As Exception
                Try
                    myTrans.Rollback()
                    msg = e.Message
                Catch ex As OleDb.OleDbException
                    msg = ex.Message
                End Try
                returnValue = False
            Finally
                myConnection.Close()
            End Try
            Return (returnValue)
        End Function
        Public Function CheckPassword(ByVal user As String, ByVal password As String) As Boolean
            Dim con As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
            Dim adp As New OleDb.OleDbDataAdapter("select * from mst_logininfo where V_USERNAME='" + user + "' and V_PASSWORD='" + password + "'", con)
            adp.SelectCommand.Connection.Open()
            Try
                Return adp.SelectCommand.ExecuteReader.HasRows()
            Catch
                Return Nothing
            End Try
        End Function
        Public Function AutoGen(ByVal FieldLength As Integer, ByVal table As String, ByVal field As String, Optional ByVal prefix As String = Nothing, Optional ByVal suffix As String = Nothing, Optional ByVal addnum As Integer = Nothing) As String
            Dim dr() As Data.DataRow
            Dim rd As System.Data.OleDb.OleDbDataReader
            Dim i As Integer
            Dim field_length As Integer
            Dim stringFormat As String
            Dim qry As String '= "select * from " & table & " where " & field & "=max(" & field & ")"
            If suffix = Nothing And prefix = Nothing Then
                qry = "select max(" & field & ") as VALUE from " & table
                field_length = FieldLength
            Else
                qry = "select max(substr(" & field & "," & (Len(prefix) + 1) & ")) as VALUE from " & table
                If suffix = Nothing Then
                    field_length = FieldLength
                Else
                    field_length = FieldLength - suffix.Length
                End If
                If prefix = Nothing Then
                    field_length = FieldLength
                Else
                    field_length = FieldLength - prefix.Length
                End If
            End If
            Dim con As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
            Dim adp As New OleDb.OleDbDataAdapter(qry, con)
            adp.SelectCommand.Connection.Open()
            rd = adp.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection)
            For i = 1 To field_length
                stringFormat = stringFormat + "0"
            Next
            rd.Read()

            If IsDBNull(rd.Item("VALUE")) = True Then
                If addnum = Nothing Then
                    Return prefix & Format(1, stringFormat)
                Else
                    addnum = addnum + 1
                    Return prefix & Format(addnum, stringFormat)

                End If

            Else
                Dim str As String = rd.Item("VALUE")
                i = Val(rd.Item("VALUE"))
                i += 1
                If addnum = Nothing Then
                    Return prefix & Format(i, stringFormat)
                Else
                    i = i + addnum
                    Return prefix & Format(i, stringFormat)
                End If

            End If
        End Function
        Public Sub CommonFillCombo(ByVal ds1 As System.Data.DataSet, ByVal combo As System.Object, ByVal Table1 As String, ByVal field1 As String, Optional ByVal other_data As String = Nothing, Optional ByVal filter_exp As String = Nothing)
            Dim i As Integer
            Dim dr() As System.Data.DataRow
            combo.Items.Clear()
            If filter_exp = Nothing Then
                For i = 0 To ds1.Tables(Table1).Rows.Count - 1
                    Dim opt1 As New ListItem
                    opt1.Text = ds1.Tables(Table1).Rows(i).Item(field1)
                    opt1.Value = ds1.Tables(Table1).Rows(i).Item(other_data)
                    combo.Items.Add(opt1)
                Next
            Else
                dr = ds1.Tables(Table1).Select(filter_exp)
                For i = 0 To dr.Length - 1
                    combo.Items.Add(dr(i).Item(0))
                Next
            End If
        End Sub
        ''''Public Sub FillCombo(ByVal combo As System.Object, ByVal Table1 As String, ByVal field1 As String, Optional ByVal other_data As String = Nothing, Optional ByVal RequiredNone As Boolean = False)
        ''''    Dim i As Integer
        ''''    Dim con As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
        ''''    Dim qry As String
        ''''    qry = "select * from " & Table1 & " where V_DEL_FLAG='N'"
        ''''    Dim adp As New OleDb.OleDbDataAdapter(qry, con)
        ''''    combo.Items.Clear()
        ''''    adp.SelectCommand.Connection.Open()
        ''''    Dim dr As Data.OleDb.OleDbDataReader = adp.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection)
        ''''    While dr.Read
        ''''        Dim opt1 As New ListItem
        ''''        opt1.Text = dr.Item(field1)
        ''''        If other_data = Nothing Then
        ''''            opt1.Value = dr.Item(field1)
        ''''        Else
        ''''            opt1.Value = dr.Item(other_data)
        ''''        End If
        ''''        combo.Items.Add(opt1)
        ''''    End While
        ''''    If RequiredNone = True Then
        ''''        combo.Items.Add("NONE")
        ''''    End If
        ''''    dr.Close()
        ''''End Sub
        Public Sub FillCombo(ByVal combo As System.Object, ByVal Query As String, ByVal Field1 As Integer, Optional ByVal Field2 As Integer = Nothing, Optional ByVal RequiredNone As Boolean = False)
            Dim i As Integer
            Dim con As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=ORCL;User Id=Synergy;Password=Synergy;")
            Dim adp As New OleDb.OleDbDataAdapter(Query, con)
            combo.Items.Clear()
            adp.SelectCommand.Connection.Open()
            Dim dr As Data.OleDb.OleDbDataReader = adp.SelectCommand.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                Dim opt1 As New ListItem
                opt1.Text = dr.Item(Field1)
                If Field2 = Nothing Then
                    opt1.Value = dr.Item(Field1)
                Else
                    opt1.Value = dr.Item(Field2)
                End If
                combo.Items.Add(opt1)
            End While
            If RequiredNone = True Then
                combo.Items.Add("NONE")
            End If
            dr.Close()
        End Sub
        Public Function Search(ByVal qry As String) As Data.OleDb.OleDbDataReader
            Dim con As New OleDb.OleDbConnection("Provider=Msdaora;Data Source=orcl;User Id=Synergy;Password=Synergy;")
            Dim adp As New OleDb.OleDbDataAdapter(qry, con)
            adp.SelectCommand.Connection.Open()
            Try
                Return adp.SelectCommand.ExecuteReader()
            Catch ex As Exception
                Dim str As String = ex.Message
                Return Nothing
            End Try
            adp.SelectCommand.Connection.Close()
        End Function
        Public Sub clear(ByVal ctrl As System.Object)
            Dim i As Integer
            For i = 0 To ctrl.Controls.Count - 1
                If ctrl.Controls(i).GetType.ToString = "System.Web.UI.WebControls.TextBox" Then
                    ctrl.Controls(i).text = ""
                ElseIf ctrl.Controls(i).GetType.ToString = "System.Web.UI.WebControls.DropDownList" Then
                    ctrl.Controls(i).Items.Clear()
                End If
            Next
        End Sub
        Public Function CheckSpecial(ByVal ss As String)
            Dim pos As Integer = InStr(1, ss, "'")
            Dim temp As String
            temp = Replace(ss, "'", "''")
            temp = Trim(temp)
            ''If pos > 0 Then
            ''    temp = Mid(ss, 1, pos) + "'" + Mid(ss, pos + 1, Len(ss))
            ''Else
            ''    temp = ss
            ''End If
            Return temp
        End Function
        Public Function NewId_Gen() As String
            Try
                Dim counter, CurrentUserid, CurrentOrgid As Integer
                Dim newid As String
                Dim datevar As Date = Now()
                CurrentUserid = 1
                CurrentOrgid = 1
                Dim tim, hr, min As Integer
                hr = DatePart(DateInterval.Hour, datevar)
                min = DatePart(DateInterval.Minute, datevar)
                tim = (hr * 60 * 60) + (min * 60) + DatePart(DateInterval.Second, datevar)

                If counter > 124 Then counter = 0
                newid = DecimalToBase125(DatePart(DateInterval.Year, datevar), 3) & _
                        DecimalToBase125(DatePart(DateInterval.Month, datevar)) & _
                        DecimalToBase125(DatePart(DateInterval.Day, datevar)) & _
                        DecimalToBase125(tim * 10, 3) & _
                        ChrSet125(counter) & _
                        ChrSet125(CurrentUserid) & _
                        ChrSet125(CurrentOrgid)
                counter = counter + 1
                Return (newid)
            Catch X As Exception
                MsgBox(X.Message)
            End Try
        End Function
        Public Sub fetchdataarr(ByVal qry As String, ByRef arr As String())
            Dim dr As OleDb.OleDbDataReader
            Dim i As Integer
            i = 0
            Dim com As New OleDb.OleDbCommand(qry, con)
            con.Open()
            dr = com.ExecuteReader()
            While dr.Read()
                ReDim Preserve arr(i)
                arr(i) = dr.Item(0)
                i = i + 1
            End While
            con.Close()
        End Sub
        Public Function fetchdatarow(ByVal qry As String) As Data.DataRow
            Dim dr As New OleDb.OleDbDataAdapter(qry, con)
            Dim datr As New Data.DataTable
            'Dim com As New OleDb.OleDbCommand(qry, con)
            'Dim i As Integer
            dr.Fill(datr)
            If datr.Rows.Count = 0 Then
                Return Nothing
            Else
                Return datr.Rows(0)
            End If
        End Function
        Public Function fetchdatasingval(ByVal qry As String) As Object
            Dim value As Object
            Dim com As New OleDb.OleDbCommand(qry, con)
            con.Open()
            value = com.ExecuteScalar()
            con.Close()
            Return value
        End Function
        Public Function Decode(ByVal CID As String) As String
            Try
                Dim CYear As String, CMonth As String, Cday As String, nSecond As Long, CTime As String
                Dim nmin As Integer, nhour As Integer, nsec As Integer, nCUserID As Integer, CUserLoginName As String, decodecid As String
                Dim nUUserID As String, UUserLoginName As String, rowver As String
                CYear = DeCodeToBase10(Mid(CID, 1, 3))
                CMonth = DeCodeToBase10(Mid(CID, 4, 1))
                Cday = DeCodeToBase10(Mid(CID, 5, 1))
                nSecond = DeCodeToBase10(Mid(CID, 6, 3))
                nSecond = nSecond / 10
                nsec = nSecond Mod 60
                nmin = Int(nSecond / 60) Mod 60
                nhour = Int(Int(nSecond / 60) / 60)
                CTime = str(nhour) & ":" & str(nmin) & ":" & str(nsec)
                rowver = DeCodeToBase10(Mid(CID, 9, 1))
                nCUserID = DeCodeToBase10(Mid(CID, 10, 3))

                ' CUserLoginName = fetchdatasingval("select v_user from my_mst_logininfo where v_userid='" & nCUserID & "'")
                Decode = "Date :" & Cday & "/" & CMonth & "/" & CYear & " ; Time:" & CTime & ";Row Version :" & rowver & " ; User:" & nCUserID

                If CID.Length > 12 Then
                    nUUserID = DeCodeToBase10(Mid(CID, 13, 3))
                    'UUserLoginName = fetchdatasingval("select v_user from my_mst_logininfo where v_userid='" & nUUserID & "'")
                    Decode = "Date :" & Cday & "/" & CMonth & "/" & CYear & " ; Time:" & CTime & ";Row Version :" & rowver & ";  Created:" & nCUserID & ";  Modified: " & nUUserID
                End If
                Return Decode
            Catch X As Exception
                ' MsgBox(X.Message)
            End Try
        End Function
        Public ChrSet125(124) As String
        Public Function StoreUniqChr()
            Try
                Dim ChrCounter As Integer, ChrIncri As Integer
                ChrCounter = 49
                Do While ChrIncri < 125
                    ChrSet125(ChrIncri) = Chr(ChrCounter)
                    ChrCounter = ChrCounter + 1
                    ChrIncri = ChrIncri + 1
                    'the IF are given to omit the characters between 50 to 51
                    If ChrCounter > 49 And ChrCounter < 52 Then
                        ChrCounter = 52
                    End If
                    If ChrCounter > 64 And ChrCounter < 91 Then
                        ChrCounter = 91
                    End If
                    If ChrCounter > 126 And ChrCounter < 128 Then
                        ChrCounter = 128
                    End If
                    If ChrCounter > 128 And ChrCounter < 131 Then
                        ChrCounter = 131
                    End If
                    If ChrCounter > 138 And ChrCounter < 140 Then
                        ChrCounter = 140
                    End If
                    If ChrCounter > 140 And ChrCounter < 146 Then
                        ChrCounter = 146
                    End If

                    If ChrCounter > 146 And ChrCounter < 149 Then
                        ChrCounter = 149
                    End If
                    If ChrCounter > 149 And ChrCounter < 151 Then
                        ChrCounter = 151
                    End If
                    If ChrCounter > 153 And ChrCounter < 159 Then
                        ChrCounter = 159
                    End If
                    If ChrCounter > 159 And ChrCounter < 161 Then
                        ChrCounter = 161
                    End If

                    If ChrCounter > 170 And ChrCounter < 172 Then
                        ChrCounter = 172
                    End If
                    If ChrCounter > 172 And ChrCounter < 174 Then
                        ChrCounter = 174
                    End If
                    If ChrCounter > 184 And ChrCounter < 186 Then
                        ChrCounter = 186
                    End If
                    If ChrCounter > 186 And ChrCounter < 188 Then
                        ChrCounter = 188
                    End If
                    If ChrCounter > 191 And ChrCounter < 196 Then
                        ChrCounter = 196
                    End If
                    If ChrCounter > 227 Then
                        Exit Do
                    End If
                Loop
            Catch X As Exception

            End Try
        End Function
        Public Function DecimalToBase125(ByVal DecimalValue As Long, Optional ByVal Width As Integer = 1) As String
            Try
                Dim Remainder As Integer
                Dim Dividend As Long
                Dim result As String
                Dim res, i As Integer
                While DecimalValue > 0
                    Remainder = DecimalValue Mod 125
                    DecimalValue = DecimalValue \ 125
                    result = ChrSet125(Remainder) & result
                End While
                If Len(result) < Width Then
                    res = Width - Len(result)
                    For i = 1 To res
                        result = ChrSet125(0) & result
                    Next
                End If
                DecimalToBase125 = result
            Catch X As Exception
                MsgBox(X.Message)
            End Try
        End Function
        Public Function DeCodeToBase10(ByVal Bstr125 As String) As Integer
            Try
                Dim x As Integer
                Select Case Len(Bstr125)
                    Case Is = 1
                        DeCodeToBase10 = Array.IndexOf(ChrSet125, Mid(Bstr125, 1))
                    Case Is = 2
                        x = Array.IndexOf(ChrSet125, Mid(Bstr125, 1, 1))
                        DeCodeToBase10 = x * 125 + Array.IndexOf(ChrSet125, Mid(Bstr125, 2, 1))
                    Case Is = 3
                        x = Array.IndexOf(ChrSet125, Mid(Bstr125, 1, 1))
                        x = x * 125 + Array.IndexOf(ChrSet125, Mid(Bstr125, 2, 1))
                        DeCodeToBase10 = x * 125 + Array.IndexOf(ChrSet125, Mid(Bstr125, 3, 1))
                End Select
            Catch X As Exception
                MsgBox(X.Message)
            End Try
        End Function
        Public Function RowIdentifier(ByVal lastupdate As Date, ByVal rowver As Integer, Optional ByVal UUserid As String = Nothing, Optional ByVal Cuserid As String = Nothing) As String
            Try
                Dim rowid As String
                Dim datevar As Date = lastupdate
                Dim tim, hr, min As Integer
                hr = DatePart(DateInterval.Hour, datevar)
                min = DatePart(DateInterval.Minute, datevar)
                tim = (hr * 60 * 60) + (min * 60) + DatePart(DateInterval.Second, datevar)
                ''rowid = DecimalToBase125(DatePart(DateInterval.Year, datevar), 3) & _
                ''        DecimalToBase125(DatePart(DateInterval.Month, datevar)) & _
                ''        DecimalToBase125(DatePart(DateInterval.Day, datevar)) & _
                ''        DecimalToBase125(tim * 10, 3) & _
                ''        DecimalToBase125(rowver) & DecimalToBase125(Cuserid, 3)
                rowid = DecimalToBase125(DatePart(DateInterval.Year, datevar), 3)
                rowid = rowid + DecimalToBase125(DatePart(DateInterval.Month, datevar))
                rowid = rowid + DecimalToBase125(DatePart(DateInterval.Day, datevar))
                rowid = rowid + DecimalToBase125(tim * 10, 3)
                rowid = rowid + DecimalToBase125(rowver) & DecimalToBase125(Cuserid, 3)
                Return rowid
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function rowidentifierupd(ByVal rowid As String, ByVal Uuserid As String, ByVal lastupdate As Date) As String
            Try
                Dim datevar As Date = lastupdate
                Dim tim, hr, min As Integer
                Dim uprowid As String, cuser As String, rowver As String
                hr = DatePart(DateInterval.Hour, datevar)
                min = DatePart(DateInterval.Minute, datevar)
                tim = (hr * 60 * 60) + (min * 60) + DatePart(DateInterval.Second, datevar)
                uprowid = DecimalToBase125(DatePart(DateInterval.Year, datevar), 3) & _
                          DecimalToBase125(DatePart(DateInterval.Month, datevar)) & _
                          DecimalToBase125(DatePart(DateInterval.Day, datevar)) & _
                          DecimalToBase125(tim * 10, 3)
                cuser = Mid(rowid, 10, 3)
                rowver = DeCodeToBase10(Mid(rowid, 9, 1))
                rowver = CInt(rowver) + 1
                uprowid = uprowid & DecimalToBase125(rowver) & cuser & DecimalToBase125(Uuserid, 3)
                Return uprowid
            Catch ex As Exception
            End Try
        End Function

        Public Sub ErrorHandler(ByRef Es As Exception, ByRef ErStore() As String)
            Try
                Select Case Es.Message.Substring(InStr(Es.Message, "ORA") - 1, 9)
                    Case "ORA-00900"
                        MsgBox("invalid SQL statement")
                    Case "ORA-00942"
                        MsgBox("table or view does not exist")
                    Case "ORA-00904"
                        MsgBox("Invalid column name")
                    Case "ORA-01722"
                        MsgBox("Value mismatch")
                    Case "ORA-00001"
                        MsgBox("unique constraint violated")
                    Case "ORA-01438"
                        MsgBox("value larger than specified precision allows for this column")
                    Case "ORA-02291"
                        MsgBox("Integrity constraint violated")
                    Case "ORA-02292"
                        MsgBox("Referential Integrity constraint violated")
                    Case Else
                        'MsgBox(Es.Message)
                End Select
            Catch X As Exception
                'MsgBox(X.Message)
            End Try
        End Sub
        Public Sub treepopulate(ByRef TVW As Microsoft.Web.UI.WebControls.TreeView, ByVal tablename As String, ByVal fieldname As String, ByVal fieldid As String, ByVal parentid As String, ByVal condition As String, ByRef TREEID() As String)
            'This common code will be used for populating  hierarchical structures
            'This procedure recursively calls another procedure treepop
            'input parameters: treeview control,array to store keyid and nodeindexes,fieldid,fieldname & parentid columns
            'fieldname is the column whose data will be shown in treeview,
            'fieldid is the key value,tname is the name of the table,
            'parentid is the column that determines hierarchy ,
            'treeid is array which 'll store the keyid & corresponding nodeindex concatenetaed by "//"
            Dim ary() As String
            Dim s As String
            Dim j As Integer, count As Integer
            Dim i As Integer = 0
            Dim dr As Data.DataRow
            Dim nd As Microsoft.Web.UI.WebControls.TreeNode
            TVW.Nodes.Clear()
            If condition <> "" Then
                s = "select " & fieldid & " from " & tablename & " where " & parentid & " is null AND V_DEL_FLAG='N' and " & condition
            Else
                s = "select " & fieldid & " from " & tablename & " where " & parentid & " is null AND V_DEL_FLAG='N'"
            End If
            fetchdataarr(s, ary)
            If ary Is Nothing Then
            Else
                For i = LBound(ary) To UBound(ary)
                    dr = fetchdatarow("select " & fieldname & " from " & tablename & " where " & fieldid & " ='" & ary(i) & "'")
                    nd = New Microsoft.Web.UI.WebControls.TreeNode
                    nd.Text = dr.Item(fieldname)
                    nd.NodeData = ary(i)
                    TVW.Nodes.Add(nd)
                    'If TREEID Is Nothing Then
                    '    Call treepop(i, nd, fieldname, fieldid, tablename, parentid, condition)
                    'Else
                    ''ReDim Preserve TREEID(count)
                    If TREEID Is Nothing Then
                        count = 0
                    Else
                        count = UBound(TREEID) + 1
                    End If
                    ReDim Preserve TREEID(count)
                    TREEID(count) = nd.NodeData & "//" & i
                    Call treepop(i, nd, fieldname, fieldid, tablename, parentid, condition, TREEID)
                    'End If
                Next
            End If

        End Sub
        Public Sub treepop(ByVal nodeindex As String, ByRef nd As Microsoft.Web.UI.WebControls.TreeNode, ByVal field As String, ByVal fieldid As String, ByVal tname As String, ByVal parentid As String, ByVal condition As String, ByRef TREEID() As String)
            'recursive procedure called from treepopulate & itself
            'inputs:nodeindex whose child nodes will be populated,node,
            ' field is the column whose data will be shown in treeview,
            'fieldid is the key value,tname is the name of the table,
            'parentid is the column that determines hierarchy ,
            'treeid is array which 'll store the keyid & corresponding nodeindex concateneted by "//"
            Dim idarr() As String, nodeindex1 As String, s As String
            Dim i As Integer
            Dim dr As Data.DataRow
            If condition <> "" Then
                s = "select " & fieldid & " from " & tname & "  where " & parentid & " ='" & nd.NodeData & "' AND V_DEL_FLAG='N' and " & condition
            Else
                s = "select " & fieldid & " from " & tname & "  where " & parentid & " ='" & nd.NodeData & "' AND V_DEL_FLAG='N'"
            End If
            fetchdataarr(s, idarr)
            If idarr Is Nothing Then
            Else
                For i = LBound(idarr) To UBound(idarr)
                    dr = fetchdatarow("select " & field & " from " & tname & " where " & fieldid & " ='" & idarr(i) & "'")
                    Dim nd1 As New Microsoft.Web.UI.WebControls.TreeNode
                    nd1.Text = dr.Item(0)
                    nd1.NodeData = idarr(i)
                    nd.Nodes.Add(nd1)
                    nodeindex1 = nodeindex & "." & i
                    'If TREEID Is Nothing Then
                    '    nd.Expanded = True
                    '    Call treepop(nodeindex1, nd1, field, fieldid, tname, parentid, condition)
                    'Else
                    ReDim Preserve TREEID(UBound(TREEID) + 1)
                    TREEID(UBound(TREEID)) = nd1.NodeData & "//" & nodeindex1
                    nd.Expanded = True
                    Call treepop(nodeindex1, nd1, field, fieldid, tname, parentid, condition, TREEID)
                    'End If
                Next
            End If
        End Sub
        Public Sub Search_Tree(ByVal key As String, ByRef treeview1 As Object, ByRef treeid() As String)
            Dim i As Integer
            Dim temparr() As String
            If treeid Is Nothing Then
            Else
                For i = LBound(treeid) To UBound(treeid)
                    temparr = Split(treeid(i), "//")
                    If key = temparr(0) Then
                        treeview1.SelectedNodeIndex = temparr(1)
                    End If
                Next
            End If
        End Sub
        Public Function CheckCircularRefrence(ByVal MainField As String, ByVal MainFieldValue As String, ByVal ParentField As String, ByVal ParentFieldValue As String, ByVal Table As String) As Boolean
            Dim ary() As String
            Dim i As Integer
            Dim s As String
            Dim dr As Data.DataRow
            fetchdataarr("SELECT " & MainField & " FROM " & Table & " START WITH " & MainField & "='" & MainFieldValue & "'CONNECT BY PRIOR " & MainField & "=" & ParentField & " and V_DEL_FLAG not in 'Y'", ary)
            ary.Sort(ary)
            If ary.BinarySearch(ary, ParentFieldValue) >= 0 Then
                Return True
            Else
                Return False
            End If
        End Function
    End Class
End Namespace
