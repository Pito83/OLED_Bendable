Imports System.Data
Imports System.IO
Imports System.Linq
Imports System.Runtime.Remoting.Contexts
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Xml.Serialization
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.DependencyInjection
Imports Oled.DataLayer


Public Module Pub_module
    Friend _bootstrapper As Bootstrapper
    Friend DB_Modelli_Sel As Model
    Friend _Tools() As ProductionConfiguration
    Friend _Modelli() As Model
    Friend _MappeMagazz As New List(Of MagazineMap)
    Friend _P_MA As New List(Of RobotPoint)
    Friend _P_MB As New List(Of RobotPoint)

    Friend DM_DSM_M_ID As List(Of DMDSMMID)
    Friend Modello_Attuale As Model
    Friend Prodotto_Act As ProductionConfiguration
    Friend Avvitatura_Act As ScrewingStationConfiguration
    Friend Visioni_Attuali As New List(Of VisionConfiguration)

    Friend HoLettoDM_SX As Boolean = False
    Friend HoLettoDM_DX As Boolean = False
    Friend ScannedDM_Text As String = String.Empty
    Public Structure settaggi
        Public n_piastra As Integer
        Public modello As String
        Public versione As String
        Public Prodotto As String
        Public Descriz As String
        Public n_posaggi As Integer
        Public Contr_elettrico As Boolean
        Public Contr_visione As Boolean
        Public Matrix_sx As Boolean
        Public Matrix_dx As Boolean
        Public Key_dir As String
        Public Language As String
        Public Code_page As Integer
        Public Id_Modello As Integer
        Public Id_Tool As Integer
        Public Giorno As Integer
        Public N_test As Integer
        Public Act_test As Integer
        Public ID_pos_dx As Integer
        Public ID_prec_dx As Integer
        Public ID_pos_sx As Integer
        Public ID_prec_sx As Integer
        Public Ore_macchina As Long
        Public Operatore As String
        Public Wip_Pico As Boolean
        Public Trace_Sql As Boolean
        Public CodMag1 As String
        Public CodMag2 As String
        Public LIN As Boolean
        Public TMServer As Boolean
        Public LIN_Test As Boolean
        Public MTS_ID As Integer
        Public MTS_Descr As String
        Public MTS_Server As String
        Public MTS_DB As String
        Public MTS_Stat_ids, MTS_Stat_idd As Integer
        Public MTS_Stat_De_S, MTS_Stat_De_D As String
        Public MTS_User As String
        Public MTS_Passw As String
        Public MTS_Trust As Boolean
        Public OffBoard As Boolean
        Public CycleJump As Boolean
        Public DSM_Remove_Hash As Boolean
    End Structure
    Friend Sett As settaggi
    Friend Sub Defalut_Sett()
        Sett = New settaggi
        With Sett
            .n_piastra = 1
            .modello = "Moodel"
            .versione = "Version"
            .Prodotto = ""
            .Descriz = ""
            .n_posaggi = 2
            .Contr_elettrico = False
            .Contr_visione = True
            .Matrix_sx = False
            .Matrix_dx = False
            .Key_dir = "c:\windows\system32\osk.exe"
            .Language = "IT"
            .Code_page = 1250
            .Id_Modello = 1
            .Id_Tool = 2
            .Giorno = 0
            .N_test = 0
            .Act_test = 0
            .ID_pos_dx = 0
            .ID_prec_dx = 0
            .ID_pos_sx = 0
            .ID_prec_sx = 0
            .Ore_macchina = 100
            .Operatore = ","
            .Wip_Pico = False
            .Trace_Sql = False
            .CodMag1 = "0"
            .CodMag2 = "0"
            .LIN = True
            .TMServer = False
            .LIN_Test = False
            .MTS_ID = 2
            .MTS_Descr = "Description"
            .MTS_Server = "Server"
            .MTS_DB = "DataBase"
            .MTS_Stat_ids = 16
            .MTS_Stat_idd = 17
            .MTS_Stat_De_S = "sx"
            .MTS_Stat_De_D = "dx"
            .MTS_User = "User"
            .MTS_Passw = "Password"
            .MTS_Trust = False
            .OffBoard = False
            .DSM_Remove_Hash = False
        End With
        write_xml(Articoli_dir & "sett.txt", Sett)
    End Sub
    Friend Function read_struct_xml(ByVal _file As String, ByVal _tipo As Type, ByRef _str As Object) As Boolean
        Dim flux As FileStream = Nothing
        Dim ser As New XmlSerializer(_tipo)
        Try
            flux = New FileStream(_file, FileMode.OpenOrCreate)
            If File.Exists(_file) Then
                _str = ser.Deserialize(flux)    'riempie la struttura
                flux.Close()
                flux.Dispose()
            Else
                MessageBox.Show("File " & _file & "   not exist", "ERRORE", MessageBoxButtons.OK)
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            If Not (flux Is Nothing) Then
                flux.Close()
                flux.Dispose()
            End If
        End Try
        Return True
    End Function
    Friend Function write_xml(ByVal _file As String, ByVal _ogg As Object) As Boolean
        Dim flux As FileStream = Nothing
        Try
            flux = New FileStream(_file, FileMode.Create)
            Dim ser As New XmlSerializer(_ogg.GetType)

            ser.Serialize(flux, _ogg)   'salva la struttura (SETT)
            flux.Close()
        Catch ex As Exception
            show_eccezione(ex)
            If Not flux Is Nothing Then
                flux.Close()
                flux.Dispose()
            End If
            Return False
        Finally
            If Not (flux Is Nothing) Then
                flux.Close()
                flux.Dispose()
            End If
        End Try
        Return True
    End Function


    Public Function StartBootloader(ByVal _dbInst As String) As Boolean
        Try
            _bootstrapper = Bootstrapper.Current

            'Dim dbServerInstance As String = "DESKTOP-A7JRGUJ\SQLEXPRESS"
            Dim dbServerInstance As String = "192.168.0.85"
            Dim dbName As String = "SetUpOLED"
            Dim dbTraceName As String = "ST20XDB"
            Dim dbUserName As String = "SAIEE"
            Dim dbPassword As String = "saiee35227"

            Dim dbConnectionConfig As ConnectionString = New ConnectionString()
            dbConnectionConfig.ProcessData = "Data Source=" & dbServerInstance & ";" & "Initial Catalog=" & dbName & ";" & "User id=" & dbUserName + "; " & "Password=" + dbPassword & ";" + "MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30"
            dbConnectionConfig.TraceData = "Data Source=" & dbServerInstance & ";" & "Initial Catalog=" & dbTraceName & ";" & "User id=" & dbUserName + "; " & "Password=" + dbPassword & ";" + "MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30"

            _bootstrapper.Start(dbConnectionConfig)
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Load_Modelli() As Boolean
        Try
            Dim _Scope = Bootstrapper.Current.Services.CreateScope
            Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
            ' Dim _Modello As Model
            ' DB_Modelli_Sel = Context.Models.Where(Function(x) x.Id = Sett.Act_Articolo).FirstOrDefault()

            ' DB_Modelli_Sel = Context.Models.Where(Function(x) x.Id = 3).FirstOrDefault()

            _Modelli = Context.Models.AsNoTracking.ToArray

            '  _Tools = Context.Tools.ToArray
            ' _Magazzini = Context.MagazinMaps.ToArray


            '  For i = 0 To _Tools.Count - 1
            '      n = _Tools(i).ModelId
            '      _Modello = Context.Models.Where(Function(x) x.Id = n).FirstOrDefault
            '      If Not _Modello Is Nothing Then
            '
            '      Else
            '
            '      End If
            '  Next

            'Dim _MM As New List(Of Oled.DataLayer.Model)
            '_MM = Context.Model

            If _Modelli Is Nothing Then
                'Nome_articolo = DB_Modelli_Sel.Name
                show_eccezione("!!! Tabella modelli non trovata. Controllare DB !!!")
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Friend Function Get_Tool_F_Moldel(ByVal _M As Integer) As Boolean
        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            _Tools = Context.Tools.Where(Function(x) x.ModelId = _M).ToArray
            If _Tools Is Nothing Then
                Return False
            Else
                Context.MagazinMaps.Load()
                Context.PalletConfigurations.Load
                Context.RobotPoints.Load
                Context.ScrewPoints.Load
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            _Scope.Dispose()
            Context.Dispose()
        End Try
        Return True
    End Function
    Friend Function Get_Mag_Maps(ByVal _n As Integer) As Boolean
        Dim _Scope = Bootstrapper.Current.Services.CreateScope
        Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
        Try
            '     _Magazzini = Context.MagazinMaps.Where(Function(x) x.Id = _Tools(_n).MagazinA.Id).ToList
            _MappeMagazz.Clear() : _P_MA.Clear() : _P_MB.Clear()

            If True Then
                _MappeMagazz.Add(_Tools(_n).MagazinA)
                '  _P_MA = Context.RobotPoints.Where(Function(x) x.Id = _Tools(_n).MagazinA.Id).OrderBy(Function(y) y.Order).ToList
                'Dim PIPPO = Context.MagazinMaps.Where(Function(x) x.Id = _Tools(_n).MagazinA.Id).FirstOrDefault
                '_P_MA = Context.RobotPoints.Where(Function(x) x.Id = PIPPO.RobotPoints.).ToList
                _P_MA = _Tools(_n).MagazinA.RobotPoints.OrderBy(Function(y) y.Order).ToList
            End If
            If True Then
                If _Tools(_n).MagazinB.Id <> _Tools(_n).MagazinA.Id Then
                    _MappeMagazz.Add(_Tools(_n).MagazinB)
                    _P_MB = _Tools(_n).MagazinB.RobotPoints.OrderBy(Function(y) y.Order).ToList
                End If
            End If

            If _MappeMagazz Is Nothing Then Return False
            If _MappeMagazz.Count < 1 Then Return False
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        Finally
            _Scope.Dispose()
            Context.Dispose()
        End Try
        Return True
    End Function

    Friend Function Crea_mod() As Boolean
        Dim i As Integer
        Try
            Dim _Scope = Bootstrapper.Current.Services.CreateScope
            Dim Context = _Scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()

            Dim m_Q7Q9 = New Model() With {.Name = "Q7-Q9", .RobotCode = 1, .Description = "Fanale Q7-Q9", .Version = "ECE-SAE"}
            Context.Models.Add(m_Q7Q9)

            Dim RobotPointMagazzinoA As List(Of RobotPoint) = New List(Of RobotPoint) 'Per Auto => Magazzino A = SX
            For i = 1 To 2
                RobotPointMagazzinoA.Add(New RobotPoint() With {.Name = "MAG_A_Q7-Q9_DX_" & i.ToString("00"), .Order = i, .X = 0, .Y = 0, .Z = 0, .RotazioneZ = 0})
            Next
            Context.RobotPoints.AddRange(RobotPointMagazzinoA)

            Dim RobotPointMagazzinoB As List(Of RobotPoint) = New List(Of RobotPoint) 'Per Auto => Magazzino B = DX
            For i = 1 To 2
                RobotPointMagazzinoB.Add(New RobotPoint() With {.Name = "MAG_B_Q7-Q9_DX_" & i.ToString("00"), .Order = i, .X = 0, .Y = 0, .Z = 0, .RotazioneZ = 0})
            Next
            Context.RobotPoints.AddRange(RobotPointMagazzinoB)



            Dim MappaA As New MagazineMap() With {.Name = "MAG_A_Q7-Q9_DX", .Description = "MAG_A_Q7-Q9_DX", .DeviceCode = 3, .Rows = 2, .Columns = 4}
            For i = 0 To RobotPointMagazzinoA.Count - 1
                MappaA.RobotPoints.Add(RobotPointMagazzinoA(i))
            Next
            Context.MagazinMaps.Add(MappaA)

            Dim MappaB As New MagazineMap() With {.Name = "MAG_B_Q7-Q9_DX", .Description = "MAG_B_Q7-Q9_DX", .DeviceCode = 3, .Rows = 2, .Columns = 4}
            For i = 0 To RobotPointMagazzinoB.Count - 1
                MappaB.RobotPoints.Add(RobotPointMagazzinoB(i))
            Next
            Context.MagazinMaps.Add(MappaB)


            'Per Auto => Pallet A = SX
            Dim PalletNastroSX = New PalletConfiguration() With {
                    .Name = "Pallet_A_Q7-Q9_DX",
                    .Description = "Pallet_A_Q7-Q9_DX",
                    .DeviceCode = 1,
                    .PuntoDepositoOled = New RobotPoint() With {.Name = "PAL_A_Q7Q9_DEP_OLED_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoAdesivo = New RobotPoint() With {.Name = "PAL_A_Q7Q9_PREL_ADESIVO_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoSupporto = New RobotPoint() With {.Name = "PAL_A_Q7Q9_PREL_SUPPORTO_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoSfoglioLinerOled = New RobotPoint() With {.Name = "PAL_A_Q7Q9_SFOGLIO_LINER_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0}
                }
            Context.PalletConfigurations.Add(PalletNastroSX)

            'Per Auto => Pallet B = DX
            Dim PalletNastroDX = New PalletConfiguration() With {
                    .Name = "Pallet_B_Q7-Q9_DX",
                    .Description = "Pallet_B_Q7-Q9_DX",
                    .DeviceCode = 1,
                    .PuntoDepositoOled = New RobotPoint() With {.Name = "PAL_B_Q7Q9_DEP_OLED_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoAdesivo = New RobotPoint() With {.Name = "PAL_B_Q7Q9_PREL_ADESIVO_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoSupporto = New RobotPoint() With {.Name = "PAL_B_Q7Q9_PREL_SUPPORTO_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoSfoglioLinerOled = New RobotPoint() With {.Name = "PAL_B_Q7Q9_SFOGLIO_LINER_DX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0}
                }
            Context.PalletConfigurations.Add(PalletNastroDX)

            Dim ScrewingStationConfiguration As New ScrewingStationConfiguration() With {.Name = "Viti_Q7Q9_DX", .Description = "Q7-Q9"}
            For i = 1 To 3
                ScrewingStationConfiguration.PalletNastroSxScrewPoints.Add(New ScrewPoint() With {.Name = "Viti_Q7Q9_DX_PallNastroA_ViteNum_" & i.ToString, .Order = i, .X = 10 * i, .Y = 5 * i, .Z = 0, .Sequence = i})
            Next
            For i = 1 To 3
                ScrewingStationConfiguration.PalletNastroDxScrewPoints.Add(New ScrewPoint() With {.Name = "Viti_Q7Q9_DX_PallNastroB_ViteNum_" & i.ToString, .Order = i, .X = 10 * i, .Y = 5 * i, .Z = 0, .Sequence = i})
            Next
            Context.ScrewingStationConfigurations.Add(ScrewingStationConfiguration)

            Dim t_Q7Q9_DX As New ProductionConfiguration() With
            {
            .Name = "Q7-Q9_DX",
            .Description = "Q7-Q9_DX",
            .Model = m_Q7Q9,
            .MagazinA = MappaA,
            .MagazinB = MappaA,
            .PalletNastroSxConfiguration = PalletNastroSX,
            .PalletNastroDxConfiguration = PalletNastroDX,
            .ScrewingStationConfiguration = ScrewingStationConfiguration
            }
            Context.Tools.Add(t_Q7Q9_DX)

            Dim VisionConfigurations As New List(Of VisionConfiguration)
            For i = 1 To 4
                VisionConfigurations.Add(New VisionConfiguration() With {.Name = "Visione_Q7Q9_DX_" & i.ToString,
                        .VisionOrderId = i,
                        .VisionStep = i,
                        .RobotPoint = New RobotPoint() With {.Name = "Visione", .Order = 0, .X = 0, .Y = 0, .Z = 0, .RotazioneZ = 0},
                        .Description = "blabla",
                        .ProductionConfiguration = t_Q7Q9_DX})
            Next
            Context.VisionConfigurations.AddRange(VisionConfigurations)

            '****************************_ProdSx

            Dim RobotPointMagazzinoA_ProdSx As List(Of RobotPoint) = New List(Of RobotPoint) 'Per Auto => Magazzino A = SX
            For i = 1 To 2
                RobotPointMagazzinoA_ProdSx.Add(New RobotPoint() With {.Name = "MAG_A_Q7-Q9_SX_" & i.ToString("00"), .Order = i, .X = 0, .Y = 0, .Z = 0, .RotazioneZ = 0})
            Next
            Context.RobotPoints.AddRange(RobotPointMagazzinoA_ProdSx)

            Dim RobotPointMagazzinoB_ProdSx As List(Of RobotPoint) = New List(Of RobotPoint) 'Per Auto => Magazzino B = DX
            For i = 1 To 2
                RobotPointMagazzinoB_ProdSx.Add(New RobotPoint() With {.Name = "MAG_B_Q7-Q9_SX_" & i.ToString("00"), .Order = i, .X = 0, .Y = 0, .Z = 0, .RotazioneZ = 0})
            Next
            Context.RobotPoints.AddRange(RobotPointMagazzinoB_ProdSx)



            Dim MappaA_ProdSx As New MagazineMap() With {.Name = "MAG_A_Q7-Q9_SX", .Description = "MAG_A_Q7-Q9_SX", .DeviceCode = 3, .Rows = 2, .Columns = 4}
            For i = 0 To RobotPointMagazzinoA_ProdSx.Count - 1
                MappaA_ProdSx.RobotPoints.Add(RobotPointMagazzinoA_ProdSx(i))
            Next
            Context.MagazinMaps.Add(MappaA_ProdSx)

            Dim MappaB_ProdSx As New MagazineMap() With {.Name = "MAG_B_Q7-Q9_SX", .Description = "MAG_B_Q7-Q9_SX", .DeviceCode = 3, .Rows = 2, .Columns = 4}
            For i = 0 To RobotPointMagazzinoB_ProdSx.Count - 1
                MappaB_ProdSx.RobotPoints.Add(RobotPointMagazzinoB_ProdSx(i))
            Next
            Context.MagazinMaps.Add(MappaB_ProdSx)


            'Per Auto => Pallet A = SX
            Dim PalletNastroSX_ProdSx = New PalletConfiguration() With {
                    .Name = "Pallet_A_Q7-Q9_SX",
                    .Description = "Pallet_A_Q7-Q9_SX",
                    .DeviceCode = 1,
                    .PuntoDepositoOled = New RobotPoint() With {.Name = "PAL_A_Q7Q9_DEP_OLED_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoAdesivo = New RobotPoint() With {.Name = "PAL_A_Q7Q9_PREL_ADESIVO_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoSupporto = New RobotPoint() With {.Name = "PAL_A_Q7Q9_PREL_SUPPORTO_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoSfoglioLinerOled = New RobotPoint() With {.Name = "PAL_A_Q7Q9_SFOGLIO_LINER_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0}
                }
            Context.PalletConfigurations.Add(PalletNastroSX_ProdSx)

            'Per Auto => Pallet B = DX
            Dim PalletNastroDX_ProdSx = New PalletConfiguration() With {
                    .Name = "Pallet_B_Q7-Q9_SX",
                    .Description = "Pallet_B_Q7-Q9_SX",
                    .DeviceCode = 1,
                    .PuntoDepositoOled = New RobotPoint() With {.Name = "PAL_B_Q7Q9_DEP_OLED_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoAdesivo = New RobotPoint() With {.Name = "PAL_B_Q7Q9_PREL_ADESIVO_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoPrelievoSupporto = New RobotPoint() With {.Name = "PAL_B_Q7Q9_PREL_SUPPORTO_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0},
                    .PuntoSfoglioLinerOled = New RobotPoint() With {.Name = "PAL_B_Q7Q9_SFOGLIO_LINER_SX", .Order = 0, .X = 10, .Y = 2, .Z = 0, .RotazioneZ = 0}
                }
            Context.PalletConfigurations.Add(PalletNastroDX_ProdSx)

            Dim ScrewingStationConfiguration_ProdSx As New ScrewingStationConfiguration() With {.Name = "Viti_Q7Q9_SX", .Description = "Q7-Q9"}
            For i = 1 To 3
                ScrewingStationConfiguration_ProdSx.PalletNastroSxScrewPoints.Add(New ScrewPoint() With {.Name = "Viti_Q7Q9_SX_PallNastroA_ViteNum_" & i.ToString, .Order = i, .X = 10 * i, .Y = 5 * i, .Z = 0, .Sequence = i})
            Next
            For i = 1 To 3
                ScrewingStationConfiguration_ProdSx.PalletNastroDxScrewPoints.Add(New ScrewPoint() With {.Name = "Viti_Q7Q9_SX_PallNastroB_ViteNum_" & i.ToString, .Order = i, .X = 10 * i, .Y = 5 * i, .Z = 0, .Sequence = i})
            Next
            Context.ScrewingStationConfigurations.Add(ScrewingStationConfiguration_ProdSx)

            Dim t_Q7Q9_SX As New ProductionConfiguration() With
            {
            .Name = "Q7-Q9_SX",
            .Description = "Q7-Q9_SX",
            .Model = m_Q7Q9,
            .MagazinA = MappaA_ProdSx,
            .MagazinB = MappaA_ProdSx,
            .PalletNastroSxConfiguration = PalletNastroSX_ProdSx,
            .PalletNastroDxConfiguration = PalletNastroDX_ProdSx,
            .ScrewingStationConfiguration = ScrewingStationConfiguration_ProdSx
            }
            Context.Tools.Add(t_Q7Q9_SX)

            Dim VisionConfigurations_ProdSx As New List(Of VisionConfiguration)
            For i = 1 To 4
                VisionConfigurations_ProdSx.Add(New VisionConfiguration() With {.Name = "Visione_Q7Q9_SX_" & i.ToString,
                        .VisionOrderId = i,
                        .VisionStep = i,
                        .RobotPoint = New RobotPoint() With {.Name = "Visione", .Order = 0, .X = 0, .Y = 0, .Z = 0, .RotazioneZ = 0},
                        .Description = "blabla",
                        .ProductionConfiguration = t_Q7Q9_SX})
            Next
            Context.VisionConfigurations.AddRange(VisionConfigurations_ProdSx)

            Context.SaveChanges()

            Context.Dispose()
            _Scope.Dispose()


        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


    Friend Function Carica_Active(ByVal _mid As Integer, ByVal _tid As Integer) As Boolean

        Try
            If ByPassTrueInit Then
                'Faccio già questo giro dentro il Prep_Tx in Form_versioni... esco
                ByPassTrueInit = False
                Return True
            End If
            Dim scope = Bootstrapper.Current.Services.CreateScope
            Dim context = scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
            Dim productId As Integer = _tid
            Dim modelId As Integer = _mid

            Prodotto_Act = context.Tools.Where(Function(x) x.Id = productId).FirstOrDefault
            If Prodotto_Act.Name.Contains("_DX") Then
                Device = 2 'PEZZI DESTRI
            Else
                If Prodotto_Act.Name.Contains("_SX") Then
                    Device = 1    'Due prodotti = 2 datamatix e 2 oled
                Else
                    show_eccezione(New Exception("NEL NOME DEL PRODOTTO NON E' INDICATO SE _DX o _SX"))
                    Return False
                End If
            End If

            Modello_Attuale = context.Models.Where(Function(x) x.Id = modelId).FirstOrDefault
            If Modello_Attuale Is Nothing Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "Modello non trovato: id=" & modelId.ToString}
                _RTV = _FP.ShowDialog
                Return False
            Else
                With Sett
                    .modello = Modello_Attuale.Name
                    .versione = Modello_Attuale.Version
                End With
            End If


            If Prodotto_Act Is Nothing Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "Prodotto non trovato: id=" & productId.ToString}
                _RTV = _FP.ShowDialog
                Return False
            Else
                DSM_Model_ID = Prodotto_Act.DSM_ModelID
                With Sett
                    .Prodotto = Prodotto_Act.Name
                    .Descriz = Prodotto_Act.Description
                End With
                context.ScrewingStationConfigurations.Load
                context.MagazinMaps.Load
                context.PalletConfigurations.Load
                context.RobotPoints.Load
                context.ScrewPoints.Load
                context.VisionConfigurations.Load

                DM_DSM_M_ID = context.DMDSMMIDs.ToList()

                Sett.CodMag1 = Prodotto_Act.MagazinA.DeviceCode.ToString
                Sett.CodMag2 = Prodotto_Act.MagazinB.DeviceCode.ToString

                Prodotto_Act.ScrewingStationConfiguration.PalletNastroDxScrewPoints.OrderBy(Function(x) x.Sequence)
                Prodotto_Act.ScrewingStationConfiguration.PalletNastroSxScrewPoints.OrderBy(Function(x) x.Sequence)



            End If
            Visioni_Attuali = Prodotto_Act.VisionConfigurations.OrderBy(Function(y) y.VisionOrderId).ToList
            'Sett.CodMag1 = Prodotto_Act.MagazinA.DeviceCode.ToString
            'Sett.CodMag2 = Prodotto_Act.MagazinB.DeviceCode.ToString



            Salva_Sett = True
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function


    Friend Function Prep_Tx(ByRef _Rob_C As Integer, ByRef tt As ProductionConfiguration) As Boolean
        Try
            If tt.Name.Contains("_DX") Then
                Device = 2 'PEZZI DESTRI
            Else
                If tt.Name.Contains("_SX") Then
                    Device = 1    'Due prodotti = 2 datamatix e 2 oled
                Else
                    show_eccezione(New Exception("NEL NOME DEL PRODOTTO NON E' INDICATO SE _DX o _SX"))
                    Return False
                End If
            End If

            Sett.CodMag1 = tt.MagazinA.DeviceCode.ToString
            Sett.CodMag2 = tt.MagazinB.DeviceCode.ToString

            Dim scope = Bootstrapper.Current.Services.CreateScope
            Dim context = scope.ServiceProvider.GetRequiredService(Of ProcessDataContext)()
            Dim productId As Integer = tt.Id
            Dim modelId As Integer = tt.ModelId
            Modello_Attuale = context.Models.Where(Function(x) x.Id = modelId).FirstOrDefault
            If Modello_Attuale Is Nothing Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "Modello non trovato: id=" & modelId.ToString}
                _RTV = _FP.ShowDialog
                Return False
            Else
                With Sett
                    .modello = Modello_Attuale.Name
                    .versione = Modello_Attuale.Version
                End With
            End If

            Prodotto_Act = context.Tools.Where(Function(x) x.Id = productId).FirstOrDefault
            If Prodotto_Act Is Nothing Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "Prodotto non trovato: id=" & productId.ToString}
                _RTV = _FP.ShowDialog
                Return False
            Else
                DSM_Model_ID = Prodotto_Act.DSM_ModelID
                With Sett
                    .Prodotto = Prodotto_Act.Name
                    .Descriz = Prodotto_Act.Description
                End With
                context.ScrewingStationConfigurations.Load
                context.MagazinMaps.Load
                context.PalletConfigurations.Load
                context.RobotPoints.Load
                context.ScrewPoints.Load
                context.VisionConfigurations.Load

                DM_DSM_M_ID = context.DMDSMMIDs.ToList()
            End If
            Visioni_Attuali = Prodotto_Act.VisionConfigurations.OrderBy(Function(y) y.VisionOrderId).ToList
            Sett.CodMag1 = Prodotto_Act.MagazinA.DeviceCode.ToString
            Sett.CodMag2 = Prodotto_Act.MagazinB.DeviceCode.ToString


            Dim visionConfig As List(Of VisionConfiguration) = context.VisionConfigurations.Where(Function(x) x.ProductionConfigurationId = Prodotto_Act.Id).ToList()
            Try
                Dim cameraBassaVisionConfig = visionConfig.Where(Function(x) x.VisionStep = 2).First
                Dim cameraBassaOffset As VisionOffset = context.VisionOffsets.Where(Function(x) x.VisionConfigurationId = cameraBassaVisionConfig.Id).First
                StatiMacchina.OffsetVisioneCameraBassa.X = cameraBassaOffset.X
                StatiMacchina.OffsetVisioneCameraBassa.Y = cameraBassaOffset.Y
                StatiMacchina.OffsetVisioneCameraBassa.Rotazione = cameraBassaOffset.Angle

                StatiMacchina.OffsetUtenteVisioneCameraBassa.X = cameraBassaOffset.SecondX
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Y = cameraBassaOffset.SecondY
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione = cameraBassaOffset.SecondAngle
            Catch ex As Exception
                StatiMacchina.OffsetVisioneCameraBassa.X = 0
                StatiMacchina.OffsetVisioneCameraBassa.Y = 0
                StatiMacchina.OffsetVisioneCameraBassa.Rotazione = 0

                StatiMacchina.OffsetUtenteVisioneCameraBassa.X = 0
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Y = 0
                StatiMacchina.OffsetUtenteVisioneCameraBassa.Rotazione = 0
            End Try

            Try
                Dim cameraAltaVisionConfig = visionConfig.Where(Function(x) x.VisionStep = 4).First
                Dim cameraAltaOffset As VisionOffset = context.VisionOffsets.Where(Function(x) x.VisionConfigurationId = cameraAltaVisionConfig.Id).First
                StatiMacchina.OffsetVisioneCameraAlta.X = cameraAltaOffset.X
                StatiMacchina.OffsetVisioneCameraAlta.Y = cameraAltaOffset.Y
                StatiMacchina.OffsetVisioneCameraAlta.Rotazione = cameraAltaOffset.Angle

                StatiMacchina.OffsetUtenteVisioneCameraAlta.X = cameraAltaOffset.SecondX
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Y = cameraAltaOffset.SecondY
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione = cameraAltaOffset.SecondAngle
            Catch ex As Exception
                StatiMacchina.OffsetVisioneCameraAlta.X = 0
                StatiMacchina.OffsetVisioneCameraAlta.Y = 0
                StatiMacchina.OffsetVisioneCameraAlta.Rotazione = 0

                StatiMacchina.OffsetUtenteVisioneCameraAlta.X = 0
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Y = 0
                StatiMacchina.OffsetUtenteVisioneCameraAlta.Rotazione = 0
            End Try

            Salva_Sett = True

        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try

        Return True
    End Function


End Module
