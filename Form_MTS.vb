Imports System.Data
Imports System.IO

Public Class Form_MTS

#Region "Form"
    Private Sub Form_MTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If popola_form() Then
            Format_Grid()
        End If
        ToolNewDb.Visible = Log_3
    End Sub
    Private Sub Form_MTS_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Test_Fasi()
    End Sub

    Private Sub Form_MTS_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region

    Private Sub Tool_abort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_abort.Click
        Test_Fasi()
        Me.Close()
    End Sub
    Private Sub Tool_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_OK.Click
        Test_Fasi()
        If Conferma() Then
            Run_TMS()
            Me.Close()
        End If
    End Sub



    Private Function popola_form() As Boolean
        Try
            GroupBox1.Visible = Log_3

            If Carica_DSM_Liste() Then
                Carica_ListaFasi()


                Gr_Fasi.Visible = True
                Chk_Cons.Checked = Sett.DSM_Remove_Hash

                With DSM_Gen_Data.Gen
                    T_Pr_Id.Value = CDbl(.Line_Id_1)
                    T_Pr_Des.Text = .Line_Descr_1

                    T_Pr_Id_d.Value = CDbl(.Line_Id_2)
                    T_Pr_Des_d.Text = .Line_Descr_2

                    T_S_IDs.Value = CDbl(.Oper_Id_1)
                    T_S_De_s.Text = .Oper_Descr_1
                    T_S_IDd.Value = CDbl(.Oper_Id_2)
                    T_S_De_d.Text = .Oper_Descr_2

                    Txt_BaseAdd.Text = .Base_Addr
                    Txt_BaseAddD.Text = .Base_Addr2

                    Txt_Alarms.Text = .Alarms_Thread
                    Txt_AlarmTok.Text = .Alarm_Token

                    Txt_Consist.Text = .Consist_Thread
                    Txt_Traceab.Text = .Trace_Thread
                    Txt_ConsistD.Text = .Consist_ThreadD
                    Txt_TraceabD.Text = .Trace_ThreadD

                    Txt_ConsTok.Text = .Cons_Token
                    Txt_TraceTok.Text = .Trace_Token
                    Txt_ConsTokD.Text = .Cons_TokenD
                    Txt_TraceTokD.Text = .Trace_TokenD

                End With

                If DSM_Gen_Data.DSM_Fasi_List.Count > 5 Then
                    With DSM_Gen_Data.DSM_Fasi_List(0)
                        IDS0.Value = CDbl(.leftPhaseID) : DesS0.Text = .leftPhaseName : IDD0.Value = CDbl(.rightPhaseID) : DesD0.Text = .rightPhaseName : Sc0.Value = CDbl(.Scrap_Code)
                    End With
                    With DSM_Gen_Data.DSM_Fasi_List(1)
                        IDS1.Value = CDbl(.leftPhaseID) : DesS1.Text = .leftPhaseName : IDD1.Value = CDbl(.rightPhaseID) : DesD1.Text = .rightPhaseName : Sc1.Value = CDbl(.Scrap_Code)
                    End With
                    With DSM_Gen_Data.DSM_Fasi_List(2)
                        IDS2.Value = CDbl(.leftPhaseID) : DesS2.Text = .leftPhaseName : IDD2.Value = CDbl(.rightPhaseID) : DesD2.Text = .rightPhaseName : Sc2.Value = CDbl(.Scrap_Code)
                    End With
                    With DSM_Gen_Data.DSM_Fasi_List(3)
                        IDS3.Value = CDbl(.leftPhaseID) : DesS3.Text = .leftPhaseName : IDD3.Value = CDbl(.rightPhaseID) : DesD3.Text = .rightPhaseName : Sc3.Value = CDbl(.Scrap_Code)
                    End With
                    With DSM_Gen_Data.DSM_Fasi_List(4)
                        IDS4.Value = CDbl(.leftPhaseID) : DesS4.Text = .leftPhaseName : IDD4.Value = CDbl(.rightPhaseID) : DesD4.Text = .rightPhaseName : Sc4.Value = CDbl(.Scrap_Code)
                    End With
                    With DSM_Gen_Data.DSM_Fasi_List(5)
                        IDS5.Value = CDbl(.leftPhaseID) : DesS5.Text = .leftPhaseName : IDD5.Value = CDbl(.rightPhaseID) : DesD5.Text = .rightPhaseName : Sc5.Value = CDbl(.Scrap_Code)
                    End With
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Carica_ListaFasi() As Boolean
        '---------carica e/o genera la lista delle operazioni di lavoro----
        Dim _file As String = Articoli_dir & "DsmListaFasi.xml"
        Try
            If File.Exists(_file) Then
                Tab_Lista_Fasi = New DataTable
                Tab_Lista_Fasi.ReadXml(_file)
            Else
                Crea_tab_fasi(_file)
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Sub Crea_tab_fasi(ByVal _file As String)
        Try
            Tab_Lista_Fasi = New DataTable("ListaFasi")
            '-------carica file di intestazione colonne--------
            Dim myDataColumn As DataColumn
            '-----------prima colonna---
            myDataColumn = New DataColumn("Fase", GetType(String))
            myDataColumn.AllowDBNull = True
            myDataColumn.ReadOnly = False
            Tab_Lista_Fasi.Columns.Add(myDataColumn)

            myDataColumn = New DataColumn("Index", GetType(Short))
            myDataColumn.AllowDBNull = True
            myDataColumn.ReadOnly = False
            Tab_Lista_Fasi.Columns.Add(myDataColumn)

            Dim _riga As DataRow

            _riga = Tab_Lista_Fasi.NewRow()
            _riga.Item(0) = "Electric" : _riga(1) = 0
            Tab_Lista_Fasi.Rows.Add(_riga)

            _riga = Tab_Lista_Fasi.NewRow()
            _riga.Item(0) = "Leakage" : _riga(1) = 1
            Tab_Lista_Fasi.Rows.Add(_riga)

            _riga = Tab_Lista_Fasi.NewRow()
            _riga.Item(0) = "Vision" : _riga(1) = 2
            Tab_Lista_Fasi.Rows.Add(_riga)

            _riga = Tab_Lista_Fasi.NewRow()
            _riga.Item(0) = "Height" : _riga(1) = 3
            Tab_Lista_Fasi.Rows.Add(_riga)

            _riga = Tab_Lista_Fasi.NewRow()
            _riga.Item(0) = "Components" : _riga(1) = 4
            Tab_Lista_Fasi.Rows.Add(_riga)

            _riga = Tab_Lista_Fasi.NewRow()
            _riga.Item(0) = "Customer Code" : _riga(1) = 5
            Tab_Lista_Fasi.Rows.Add(_riga)

            Tab_Lista_Fasi.AcceptChanges()

            Tab_Lista_Fasi.WriteXml(_file, XmlWriteMode.WriteSchema)

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Format_Grid()
        Dim i As Integer
        Dim _riga As DataGridViewRow
        Try
            Dim colCombo As New DataGridViewComboBoxColumn()
            colCombo.HeaderText = "Steps"
            colCombo.Name = "Fase"
            colCombo.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            colCombo.DataSource = Tab_Lista_Fasi
            colCombo.ValueMember = Tab_Lista_Fasi.Columns(1).ColumnName        'valore
            colCombo.DisplayMember = Tab_Lista_Fasi.Columns(0).ColumnName      'stringa
            colCombo.Width = 130
            'colCombo.ReadOnly = False
            DG1.Columns.Add(colCombo)

            DG1.Rows.Clear()

            For i = 0 To DSM_Gen_Data.DSM_Fasi_List.Count - 1
                _riga = New DataGridViewRow
                _riga.CreateCells(DG1)
                _riga.Cells(0).Value = CShort(DSM_Gen_Data.DSM_Fasi_List(i).Index)
                _riga.Height = 28
                '_riga.DefaultHeaderCellType.
                DG1.Rows.Add(_riga)
            Next

            'DG1.Columns(0).Width = 200

            DG1.PerformLayout()

        Catch ex As Exception
            show_eccezione(ex)
        End Try

    End Sub

    Private Function Conferma() As Boolean
        Try
            Sett.DSM_Remove_Hash = Chk_Cons.Checked
            With DSM_Gen_Data.Gen
                .Line_Id_1 = CInt(T_Pr_Id.Value) : .Line_Descr_1 = T_Pr_Des.Text
                .Line_Id_2 = CInt(T_Pr_Id_d.Value) : .Line_Descr_2 = T_Pr_Des_d.Text
                .Oper_Id_1 = CInt(T_S_IDs.Value) : .Oper_Descr_1 = T_S_De_s.Text
                .Oper_Id_2 = CInt(T_S_IDd.Value) : .Oper_Descr_2 = T_S_De_d.Text

                .Base_Addr = Txt_BaseAdd.Text
                .Base_Addr2 = Txt_BaseAddD.Text

                .Alarms_Thread = Txt_Alarms.Text
                .Alarm_Token = Txt_AlarmTok.Text

                .Consist_Thread = Txt_Consist.Text
                .Trace_Thread = Txt_Traceab.Text
                .Consist_ThreadD = Txt_ConsistD.Text
                .Trace_ThreadD = Txt_TraceabD.Text

                .Cons_Token = Txt_ConsTok.Text
                .Trace_Token = Txt_TraceTok.Text
                .Cons_TokenD = Txt_ConsTokD.Text
                .Trace_TokenD = Txt_TraceTokD.Text
            End With

            DSM_Gen_Data.DSM_Fasi_List.Clear()

            With DSM_Fase_Struct
                .leftPhaseID = CInt(IDS0.Value) : .leftPhaseName = DesS0.Text : .rightPhaseID = CInt(IDD0.Value) : .rightPhaseName = DesD0.Text : .Scrap_Code = CInt(Sc0.Value) : .Index = CShort(DG1.Rows(0).Cells(0).Value)
            End With
            DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)
            With DSM_Fase_Struct
                .leftPhaseID = CInt(IDS1.Value) : .leftPhaseName = DesS1.Text : .rightPhaseID = CInt(IDD1.Value) : .rightPhaseName = DesD1.Text : .Scrap_Code = CInt(Sc1.Value) : .Index = CShort(DG1.Rows(1).Cells(0).Value)
            End With
            DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)
            With DSM_Fase_Struct
                .leftPhaseID = CInt(IDS2.Value) : .leftPhaseName = DesS2.Text : .rightPhaseID = CInt(IDD2.Value) : .rightPhaseName = DesD2.Text : .Scrap_Code = CInt(Sc2.Value) : .Index = CShort(DG1.Rows(2).Cells(0).Value)
            End With
            DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)
            With DSM_Fase_Struct
                .leftPhaseID = CInt(IDS3.Value) : .leftPhaseName = DesS3.Text : .rightPhaseID = CInt(IDD3.Value) : .rightPhaseName = DesD3.Text : .Scrap_Code = CInt(Sc3.Value) : .Index = CShort(DG1.Rows(3).Cells(0).Value)
            End With
            DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)
            With DSM_Fase_Struct
                .leftPhaseID = CInt(IDS4.Value) : .leftPhaseName = DesS4.Text : .rightPhaseID = CInt(IDD4.Value) : .rightPhaseName = DesD4.Text : .Scrap_Code = CInt(Sc4.Value) : .Index = CShort(DG1.Rows(4).Cells(0).Value)
            End With
            DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)
            With DSM_Fase_Struct
                .leftPhaseID = CInt(IDS5.Value) : .leftPhaseName = DesS5.Text : .rightPhaseID = CInt(IDD5.Value) : .rightPhaseName = DesD5.Text : .Scrap_Code = CInt(Sc5.Value) : .Index = CShort(DG1.Rows(5).Cells(0).Value)
            End With
            DSM_Gen_Data.DSM_Fasi_List.Add(DSM_Fase_Struct)

            Salva_DSM_Liste()

            Salva_Sett = True
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function



    Private Sub Test_Fasi()
        Try
            If DSM_Gen_Data.DSM_Fasi_List.Count > 4 Then

                If DSM_Gen_Data.DSM_Fasi_List(0).leftPhaseID < 1 Then
                    IDS0.BackColor = Color.Orange
                Else
                    IDS0.BackColor = Color.Gainsboro
                End If
                If DSM_Gen_Data.DSM_Fasi_List(0).rightPhaseID < 1 Then
                    IDD0.BackColor = Color.Orange
                Else
                    IDD0.BackColor= Color.Gainsboro
                End If

                If DSM_Gen_Data.DSM_Fasi_List(1).leftPhaseID < 1 Then
                    IDS1.BackColor = Color.Orange
                Else
                    IDS1.BackColor = Color.Gainsboro
                End If
                If DSM_Gen_Data.DSM_Fasi_List(1).rightPhaseID < 1 Then
                    IDD1.BackColor = Color.Orange
                Else
                    IDD1.BackColor = Color.Gainsboro
                End If

                If DSM_Gen_Data.DSM_Fasi_List(2).leftPhaseID < 1 Then
                    IDS2.BackColor = Color.Orange
                Else
                    IDS2.BackColor = Color.Gainsboro
                End If
                If DSM_Gen_Data.DSM_Fasi_List(2).rightPhaseID < 1 Then
                    IDD2.BackColor = Color.Orange
                Else
                    IDD2.BackColor = Color.Gainsboro
                End If

                If DSM_Gen_Data.DSM_Fasi_List(3).leftPhaseID < 1 Then
                    IDS3.BackColor = Color.Orange
                Else
                    IDS3.BackColor = Color.Gainsboro
                End If
                If DSM_Gen_Data.DSM_Fasi_List(3).rightPhaseID < 1 Then
                    IDD3.BackColor = Color.Orange
                Else
                    IDD3.BackColor = Color.Gainsboro
                End If

                If DSM_Gen_Data.DSM_Fasi_List(4).leftPhaseID < 1 Then
                    IDS4.BackColor = Color.Orange
                Else
                    IDS4.BackColor = Color.Gainsboro
                End If
                If DSM_Gen_Data.DSM_Fasi_List(4).rightPhaseID < 1 Then
                    IDD4.BackColor = Color.Orange
                Else
                    IDD4.BackColor = Color.Gainsboro
                End If

                If DSM_Gen_Data.DSM_Fasi_List(5).leftPhaseID < 1 Then
                    IDS5.BackColor = Color.Orange
                Else
                    IDS5.BackColor = Color.Gainsboro
                End If
                If DSM_Gen_Data.DSM_Fasi_List(5).rightPhaseID < 1 Then
                    IDD5.BackColor = Color.Orange
                Else
                    IDD5.BackColor = Color.Gainsboro
                End If

            End If

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub Gr_Fasi_Enter(sender As Object, e As EventArgs) Handles Gr_Fasi.Enter

    End Sub

    Private Sub Txt_ConsTok_TextChanged(sender As Object, e As EventArgs) Handles Txt_ConsTok.TextChanged

    End Sub

    Private Sub DesS0_TextChanged(sender As Object, e As EventArgs) Handles DesS0.TextChanged

    End Sub

    Private Sub Txt_Consist_TextChanged(sender As Object, e As EventArgs) Handles Txt_Consist.TextChanged

    End Sub

    Private Sub T_Pr_Id_TextChanged(sender As Object, e As EventArgs) Handles T_Pr_Id.TextChanged

    End Sub

    Private Sub DesS1_TextChanged(sender As Object, e As EventArgs) Handles DesS1.TextChanged

    End Sub

    Private Sub Chk_Cons_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Cons.CheckedChanged

    End Sub

    Private Sub Txt_TraceTok_TextChanged(sender As Object, e As EventArgs) Handles Txt_TraceTok.TextChanged

    End Sub
End Class