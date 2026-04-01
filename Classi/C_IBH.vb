Imports IBHNETLib
Imports System.Runtime.InteropServices
Public Class C_IBH
    '----------------IBH-----------
    Private sMPI As String = "2"
    Private nMPI As Integer = 2
    Private nStation As String = "IBH1"
    Private Server As IBHNETLib.IIBHnet ' = New IIBHnet
    Private Serv_net As IBHNETLib.IIIBHnet3 '= Server
    Private nConn As Boolean = False
    Private _Plc_name As String = ""
	Private _exc As String = " "

    Friend Enum nArea As Integer
        MK = 77
        DB = 68
        EE = 69
    End Enum
    Friend Enum PlcVar As Integer
        E = 1
        A = 2
        M = 3
        D = 4

        EB = 11
        AB = 12
        MB = 13
        DB = 14

        EW = 21
        AW = 22
        MW = 23
        DW = 24

        ED = 31
        AD = 32
        MD = 33
        DD = 34
    End Enum
    Friend Enum RPlcVar As Integer
        ER = 41
        AR = 42
        MR = 43
        DR = 44
    End Enum

    Public Sub New(ByVal Station As String, ByVal MPI As Integer)
        nStation = Station
        nMPI = MPI
    End Sub

    Friend ReadOnly Property Connesso As Boolean
        Get
            Return nConn
        End Get
    End Property
    Friend ReadOnly Property PlcName As String
        Get
            Return _Plc_name
        End Get
    End Property
    Friend ReadOnly Property Eccezione As String
        Get
            Return _exc
        End Get
    End Property

    Friend Function Connetti() As Boolean
        Try
            Server = New IBHNETLib.IIBHnet
            Serv_net = CType(Server, IIIBHnet3)
            Server.Connect(nStation, nMPI)
            Threading.Thread.Sleep(400)
            _Plc_name = Server.PLC_Mlfb
            nConn = True
        Catch ex As Exception
            nConn = False
            _exc = ex.ToString
            Return False
        End Try
        Return nConn
    End Function
    Friend Function Disconnetti() As Boolean
        Try
            Threading.Thread.Sleep(200)
            nConn = False
            Server.Disconnect()
            Threading.Thread.Sleep(300)
            Marshal.ReleaseComObject(Serv_net)
            Marshal.ReleaseComObject(Server)
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function


    Friend Function Read_Vals(ByVal Area As nArea, ByVal Offset As Integer, ByVal ArNr As Integer, ByVal Size As Integer, ByRef _Arr() As Byte) As Boolean
        Dim rcv As Object = Nothing
        ' Dim _arrB() As Byte
        Try
            If Area = nArea.DB Then
                Serv_net.DotNetReadVals(Area, Offset, ArNr, Size, rcv)
            Else
                Me.Serv_net.DotNetReadVals(Area, Offset, 0, Size, rcv)
            End If
            _Arr = CType(rcv, Byte())
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function
    Friend Function Write_Vals(ByVal Area As nArea, ByVal Offset As Integer, ByVal DbNr As Integer, ByVal Size As Integer, array() As Byte) As Boolean
        Dim _Dbn As Integer = 0
        Try
            If Area = nArea.DB Then
                _Dbn = DbNr
            Else
                _Dbn = 0
            End If
            'Select Case Area
            '    Case nArea.MK
            '        _Dbn = 0
            '    Case nArea.DB
            '        _Dbn = DbNr
            'End Select
            Serv_net.DotNetWriteVals(Area, Offset, DbNr, Size, array)
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function
    ''' <summary>
    ''' typ : 'E' = Input = 69d, 'A' Output = 65d, 'M' Flags = 77d, 'D' Datablock = 68d
    ''' nr: Start offset For Input/Output/Flags, For D the start offset within the DB
    ''' DBNr: Datablock number For typ = 'D' (68d), for Input/Output/Flags 0
    ''' size: 0..7 = The bit number within the byte read, 8 = Byte, 16 = Word, 32 = Doubleword
    ''' val: The value read from the PLC
    ''' Return Value: Successful operation returns S_OK, E_FAIL On Errors, E_ABORT If the PLC denies
    ''' access Or E_INVALIDARG if the desination Area in the PLC does Not exist Or Is too small.
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Friend Function Read_Val(ByVal Area As PlcVar, ByVal Offset As Integer, ByVal DbNr As Integer, ByVal Bit As UInteger, ByRef _Rtv As Integer) As Boolean
        Dim _Ar, _typ, _db, _sz As Integer
        Try
            _Ar = CInt(Area)
            Select Case _Ar
                Case 1      'E
                    _typ = 69 : _db = 0 : _sz = CInt(IIf(Bit > 7, 7, Bit))
                Case 2      'A
                    _typ = 65 : _db = 0 : _sz = CInt(IIf(Bit > 7, 7, Bit))
                Case 3      'M
                    _typ = 77 : _db = 0 : _sz = CInt(IIf(Bit > 7, 7, Bit))
                Case 4      'D
                    _typ = 68 : _db = DbNr : _sz = CInt(IIf(Bit > 7, 7, Bit))

                Case 11      'EB
                    _typ = 69 : _db = 0 : _sz = 8
                Case 12      'AB
                    _typ = 65 : _db = 0 : _sz = 8
                Case 13      'MB
                    _typ = 77 : _db = 0 : _sz = 8
                Case 14      'DB
                    _typ = 68 : _db = DbNr : _sz = 8

                Case 21      'EW
                    _typ = 69 : _db = 0 : _sz = 16
                Case 22      'AW
                    _typ = 65 : _db = 0 : _sz = 16
                Case 23      'MW
                    _typ = 77 : _db = 0 : _sz = 16
                Case 24      'DW
                    _typ = 68 : _db = DbNr : _sz = 16

                Case 31      'ED
                    _typ = 69 : _db = 0 : _sz = 32
                Case 32      'AD
                    _typ = 65 : _db = 0 : _sz = 32
                Case 33      'MD
                    _typ = 77 : _db = 0 : _sz = 32
                Case 34      'DD
                    _typ = 68 : _db = DbNr : _sz = 32

            End Select
            Server.ReadVal(_typ, Offset, _db, _sz, _Rtv)
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function
    Friend Function Write_Val(ByVal Area As PlcVar, ByVal Offset As Integer, ByVal DbNr As Integer, ByVal Bit As UInteger, ByVal _val As Integer) As Boolean
        Dim _Ar, _typ, _db, _sz As Integer
        Try
            _Ar = CInt(Area)
            Select Case _Ar
                Case 1      'E
                    _typ = 69 : _db = 0 : _sz = CInt(IIf(Bit > 7, 7, Bit))
                Case 2      'A
                    _typ = 65 : _db = 0 : _sz = CInt(IIf(Bit > 7, 7, Bit))
                Case 3      'M
                    _typ = 77 : _db = 0 : _sz = CInt(IIf(Bit > 7, 7, Bit))
                Case 4      'D
                    _typ = 68 : _db = DbNr : _sz = CInt(IIf(Bit > 7, 7, Bit))

                Case 11      'EB
                    _typ = 69 : _db = 0 : _sz = 8
                Case 12      'AB
                    _typ = 65 : _db = 0 : _sz = 8
                Case 13      'MB
                    _typ = 77 : _db = 0 : _sz = 8
                Case 14      'DB
                    _typ = 68 : _db = DbNr : _sz = 8

                Case 21      'EW
                    _typ = 69 : _db = 0 : _sz = 16
                Case 22      'AW
                    _typ = 65 : _db = 0 : _sz = 16
                Case 23      'MW
                    _typ = 77 : _db = 0 : _sz = 16
                Case 24      'DW
                    _typ = 68 : _db = DbNr : _sz = 16

                Case 31      'ED
                    _typ = 69 : _db = 0 : _sz = 32
                Case 32      'AD
                    _typ = 65 : _db = 0 : _sz = 32
                Case 33      'MD
                    _typ = 77 : _db = 0 : _sz = 32
                Case 34      'DD
                    _typ = 68 : _db = DbNr : _sz = 32

            End Select
            Server.WriteVal(_typ, Offset, _db, _sz, _val)
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function
    Friend Function Read_Val_R(ByVal Area As RPlcVar, ByVal Offset As Integer, ByVal DbNr As Integer, ByRef _valr As Single) As Boolean
        Dim _Ar, _typ, _db, _sz, _val As Integer
        Dim _by() As Byte
        _sz = 32
        Try
            _Ar = CInt(Area)
            Select Case _Ar
                Case 41     'ER
                    _typ = 69 : _db = 0
                Case 42      'AR
                    _typ = 65 : _db = 0
                Case 43      'MR
                    _typ = 77 : _db = 0
                Case 44      'DR
                    _typ = 68 : _db = DbNr
            End Select
            ' Serv_net.DotNetWriteVals(Area, Offset, _db, 4, _by)
            Server.ReadVal(_typ, Offset, _db, _sz, _val)
            _by = BitConverter.GetBytes(_val)
            _valr = BitConverter.ToSingle(_by, 0)
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function
    Friend Function Write_Val_R(ByVal Area As nArea, ByVal Offset As Integer, ByVal DbNr As Integer, ByVal _val As Single) As Boolean
        Dim _Ar, _db As Integer
        Dim _by() As Byte
        Try
            _Ar = CInt(Area)
            Select Case _Ar
                Case 77     'MR
                    _db = 0
                Case 68      'DR
                    _db = DbNr
                Case Else
                    Return False
            End Select
            _by = BitConverter.GetBytes(_val)
            Array.Reverse(_by)
            Serv_net.DotNetWriteVals(Area, Offset, _db, 4, _by)
        Catch ex As Exception
            _exc = ex.ToString
            Return False
        End Try
        Return True
    End Function


End Class
