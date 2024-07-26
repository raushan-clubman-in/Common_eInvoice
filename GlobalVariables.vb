Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Module GlobalVariables
    Public doclength, doctypelength As Integer
    ''MC SMARTCARD 
    Dim ListOperattion1 As New ListOperattion1
    Public StrPOSCODE, strDocType As String
    Public GBL_SERVERTIME, GBL_SERVERTIME_SECONDS, SYSDATE As DateTime
    Public KOTLEVELDEDUCT As String = "N"
    'FOR SMART CARD

    'for version information
    'begin
    Public Filepath As String
    Public FileSize As Long
    Public dtCreationDate As DateTime
    Public dtLastAccessTime As DateTime
    Public dtLastWriteTime As DateTime
    Public GModule As String = "ACCOUNTS INTEGRATION"
    Public GVerValidate As Boolean = True
    'end
    Public GSTSQL As String
    Public gFinancialyearEnding As Date
    Public gFinancialyearStart As Date
    Public clearcheck As Boolean
    Public Cardidcheck As Boolean
    Public smartdeviceportcount As Integer
    Public vCardcode, vTmp As String
    Public GBL_SmartCardID As String
    Public GBL_ReadDelay As Integer
    Public COMPORT_SC As Integer
    Public GBL_SMARTCARDSNO As String
    Public rHandle As Integer
    Public retcode As Integer

    Public SMCardCostApplicable As Boolean

    Public SID As Byte
    Public Sec As Integer
    Public pKey(5) As Byte
    Public gReaderType_code As String = "2"
    Public gReaderDesc As String
    Public gShortName As String
    Public gFoto As String = "Y"
    Public gReaderType_Flag As Boolean = False

    Public listop As String
    Public CARDID_GBL As String
    Public ttime As Double
    Public MIN_BALANCE_GBL, MAX_BALANCE_GBL, BALANCE_HDR, MIN_USAGE_BALANCE_HDR As Double
    Public STRPHOTOPATH As String
    Public ACCESS_CHECK_GBL As Boolean
    Public CARD_Mcode_GBL, CARD_Subcode_GBL, CARD_CardHolderName_GBL As String
    Public CARD_Balance_GBL, PRINTREP As Double
    Public TOCARD_Balance_GBL As Double
    Public CARD_CardCode_GBL, TOCARD_CardCode_GBL As String
    Public BILL_FROM_ACCESS As Boolean
    Public gdataset1 As New DataSet
    Public vrowcnt As Int16
    Public ACC_ENTRY, POS_ENTREE As Boolean
    Public MCODE_GBL As String
    Public POSCODE_GBL, POSTYPE_GBL, DOCTYPE_GBL, BILLNO_GBL As String
    Public POSNAME_GBL As String
    Public POS_CHECK, D_CARDUPDATE As Boolean
    Public cardcode As String
    Public POS_AMT_GBL As Double 'AMT WITHOUT TAX
    Public POS_RATE_GBL, BILLAMT_GBL As Double 'BILL_AMT WITH TAX
    Public dc_trans_closed As Boolean
    Public NAME_GBL, KOT_NO_GBL As String
    Public MNAME_GBL, PAYMENTMODE_GBL As String
    Public SQLSTRING, SSTR As String
    'FOR SMART CARD


    'FOR SMART CARD
    'SMARTCARD ENDS 
    'KARTHI

    Public BOOLCHECKKOT As Boolean


    Public chkdatevalidate As Boolean
    Public dblMsg As Double
    Public kotdetails As String
    Public strexcelpath As String
    Public kotupdate As Boolean
    Public MDIParentobj As Object
    Public gSQLString As String
    Public M_Groupby As String
    Public gridviewstatus As String
    Public gridviewHeading(5) As String
    Public gridviewPos As String
    Public M_WhereCondition As String

    'CSC SMARTCARD
    Public rac As Integer
    'NOV 10 CARD VARIABLES
    Public CARD_CardStatus_GBL As String
    Public CARD_Cmb_Validfrom_GBL, CARD_Cmb_ValidTo_GBL As Date
    'CSC SMARTCARD ENDS 


    'KARTHI
    Public DefaultPayment As String
    Public BillPrefix As String
    Public kotentrybool As Boolean
    'KARTHI

    ' KARTHI SEP 26 MICROSMART
    Public strAltKey As String
    Public intKey As Integer
    ' KARTHI SEP 26 MICROSMART

    'for tally
    Public gTallyOdbc As String
    Public gTallyPort As Integer
    Public gTallyDsn As String
    Public gTallyIntegration As String
    Public gTallyKotFlag As String
    Public gacessFlag As String
    Public gTallyFBillFlag As String
    Public gTallyDBillFlag As String
    Public gTallyBatchFlag As String
    Public gTallyCompanyName As String
    Public gTallyServer As String
    Public gTallymonthbill As String
    Public gTallyUser As String
    Public gSqlUserName As String
    Public gSqlUserPassword As String
    Public gClosingBalanceFlag As String
    Public gRoundOffFlag As Boolean = False
    Public gProductKey As String
    Public gTallyBulkUpdateFBill As String
    Public gTallyBulkUpdateKOT As String
    Public gKotWithBill As String
    Public gPosUserControl As String
    Public gPosPaymentControl As String
    Public gTcpProvider As String



    Public gUsername As String
    Public gPoSUsername As String
    Public gPrint As Boolean
    Public AppPath As String
    Public gCompanyname As String
    Public gCompanyAddress(10) As String
    Public gDatabase As String
    Public gDivCode As String
    Public gDivName As String
    Public gSeasion As String
    Public gUserCategory As String
    '    Public rac As Integer
    Public wemp1, wemp2, wemp3 As String
    Public Reportsql As String
    Public tables As String
    Public Gheader As String
    Public gserver As String
    Public gdataset As New DataSet
    Public gdreader As SqlDataReader
    Public gadapter As SqlDataAdapter
    Public gcommand As SqlCommand
    Public gfstream As FileStream
    Public gtrans As SqlTransaction
    Public Billstatusbool As Boolean
    Public Accountpostingbool As Boolean

    Public Tallypostingbool As Boolean
    Public AutoServicebillbool As Boolean
    Public itemtypebool As Boolean
    Public itemmasterbool As Boolean
    Public GroupMasterbool As Boolean
    Public Paymentmodebool As Boolean
    Public POSMastbool As Boolean
    Public RateMastbool As Boolean
    Public UOMRelabool As Boolean
    Public ServerMastbool As Boolean
    Public StewardMastbool As Boolean
    Public TableMastbool As Boolean
    Public Possetupbool As Boolean
    Public UOMMastbool As Boolean
    Public UserAdminbool As Boolean
    Public gFinancalyearStart As String
    Public gFinancialYearEnd As String
    Public subpaymentmodebool As Boolean
    Public posdocumentbool As Boolean
    Public vOutfile, vheader, vLine As String
    Public Filewrite As StreamWriter
    Public VFilePath As String
    Public printfile As String
    '    Public kotentrybool As Boolean
    Public finalbillbool As Boolean
    Public manualbillbool As Boolean
    Public cashreceiptbool As Boolean
    Public Printername As String
    Public computername As String
    Public Search As String
    Public MyCompanyName, gCompName As String
    Public Address1 As String
    Public Address2 As String
    Public gCity As String
    Public gState As String
    Public gPincode As String
    '    Public BillPrefix As String
    '   Public DefaultPayment As String
    Public PrintTaxheading1 As String
    Public PrintTaxheading2 As String
    Public gCreditors As String
    Public gDebitors As String
    Public GmoduleName As String

    Public gCompanyAddresses(10), gMAINCompanyname As String
    Public strFinancialYearStart, strFinancialYearEnd As DateTime

    'REFERINVENTORY
    Public CockTailRatioTransbool As Boolean

    Public CtrlAltX As Boolean
    Public fdataset As New DataSet

    Public prnpagefrom As Integer
    Public BILLROUNDYESNO As String
    Public Subledger_flag, rndoff_acode, rndoff_desc As String
    Public SMENTTYPE As String = "NO"


End Module
