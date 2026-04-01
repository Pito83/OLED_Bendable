Imports System.IO
Imports System.Text
Imports Oled.TraceDataLayer
Imports Microsoft.Extensions.DependencyInjection
Imports System.Linq

Public Class Form_Esiti

    Private T_Product As New List(Of Product)
    Private T_Oled As New List(Of InfoOled)
    Private Loc_Context As TraceDataContext
    Private Loc_Scope As IServiceScope
    Private _BindingS As New BindingSource
    Private Find_Prod As New List(Of Product)
    Private Find_Oled As New List(Of InfoOled)

    Private _ggg, _ST As Boolean
    Private New_Data As DateTime
    Private P_ID, ID_Mod, ID_Vers, _r_m As Integer

#Region "Form"
    Private Sub Form_storico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        req_dati_ready = False : req_dati = False

        Me.Location = Loc_mdi
        N_MDI_from = 96
        Loc_Scope = Bootstrapper.Current.Services.CreateScope
        Loc_Context = Loc_Scope.ServiceProvider.GetRequiredService(Of TraceDataContext)()
        If Carica_Dati(Now.AddDays(-1), Now, _ST) Then
            popola_griglia(_ST)
        End If
        Label1.Text = Now.ToShortDateString
    End Sub
    Private Sub Form_Esiti_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
    Private Sub Form_storico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Loc_Context IsNot Nothing Then
            Loc_Context.Dispose()
        End If
        If Loc_Scope IsNot Nothing Then
            Loc_Scope.Dispose()
        End If
    End Sub
    Private Sub Form_storico_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
#End Region


#Region "DATA-BASE"

    Private Function Carica_Dati(ByVal _Date1 As Date, ByVal _Date2 As Date, ByVal _Stati As Boolean) As Boolean
        Try
            T_Product = Loc_Context.Products.Where(Function(X) (_Date2.Day.CompareTo(X.DateTime.Day) = 0) And (_Date2.Month.CompareTo(X.DateTime.Month) = 0) And (_Date2.Year.CompareTo(X.DateTime.Year) = 0)).OrderByDescending(Function(y) y.DateTime.TimeOfDay).ToList
            If T_Product Is Nothing Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "!!! LISTA PRODOTTI VUOTA !!!"}
                _RTV = _FP.ShowDialog
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Function Cerca_product(ByVal _Mtx As String) As Boolean
        Try
            Find_Prod = Loc_Context.Products.Where(Function(X) X.DatamatrixPCB.Equals(_Mtx)).ToList
            If Find_Prod.Count < 1 Then
                Dim _RTV As DialogResult
                Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "!!! DATAMATRIX PRODOTTO NON TROVATO !!!"}
                _RTV = _FP.ShowDialog
                Return False
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function
    Private Sub popola_griglia(ByVal _Stati As Boolean)
        Try
            _BindingS.DataSource = T_Product
            DGrid1.DataSource = _BindingS
            DGrid1.Name = "Lista prodotti"
            Format_dg_All()
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub
    Private Sub Format_dg_All()
        Try
            With DGrid1
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(0).Width = 50
                .Columns(0).ReadOnly = True
                .Columns(0).Visible = False

                .Columns(1).HeaderText = "DATA"
                .Columns(1).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(1).Width = 110
                .Columns(1).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                .Columns(1).ReadOnly = True
                .Columns(1).Visible = True

                .Columns(2).HeaderText = "Modello"
                .Columns(2).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(2).Width = 50
                .Columns(2).ReadOnly = True
                .Columns(2).Visible = True

                .Columns(3).HeaderText = "Versione"
                .Columns(3).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(3).Width = 90
                .Columns(3).ReadOnly = True
                .Columns(3).Visible = True

                .Columns(4).HeaderText = "ID Modello"
                .Columns(4).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(4).Width = 50
                .Columns(4).ReadOnly = True
                .Columns(4).Visible = True

                .Columns(5).HeaderText = "ID Versione"
                .Columns(5).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(5).Width = 50
                .Columns(5).ReadOnly = True
                .Columns(5).Visible = True

                .Columns(6).HeaderText = "PCB Matrix"
                .Columns(6).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(6).Width = 300
                .Columns(6).ReadOnly = True
                .Columns(6).Visible = True

                .Columns(7).HeaderText = "Esito globale"
                .Columns(7).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(7).Width = 60
                .Columns(7).ReadOnly = True
                .Columns(7).Visible = True

                .Columns(8).HeaderText = "Esito Viti"
                .Columns(8).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(8).Width = 60
                .Columns(8).ReadOnly = True
                .Columns(8).Visible = True

                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        New_Data = DateTimePicker1.Value
        If Carica_Dati(New_Data.AddDays(-1), New_Data, _ST) Then
            popola_griglia(_ST)
        End If
        Label1.Text = New_Data.ToLongDateString
    End Sub


    Private Sub DGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGrid1.CellClick
        _r_m = e.RowIndex
        P_ID = -1
        If _r_m > -1 Then
            P_ID = CInt(DGrid1.Rows(_r_m).Cells(0).Value)
            If P_ID > 0 Then
                DGrid2.DataSource = Nothing
                DGrid2.Refresh()
                T_Oled = Loc_Context.InfoOleds.Where(Function(X) (X.ProductID = P_ID)).ToList
                If T_Oled IsNot Nothing Then
                    DGrid2.DataSource = T_Oled
                    DGrid2.Name = "Esiti OLED"
                    Format_dg2()
                    Panel1.BackgroundImage = Nothing
                    ID_Mod = T_Oled(0).Product.ModelID
                    ID_Vers = T_Oled(0).Product.VersionID
                End If
            End If
        End If
    End Sub

    Private Sub Format_dg2()
        Try
            With DGrid2
                .Columns(0).HeaderText = "ID"
                .Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(0).Width = 50
                .Columns(0).ReadOnly = True
                .Columns(0).Visible = False

                .Columns(1).HeaderText = "SX"
                .Columns(1).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(1).Width = 50
                .Columns(1).ReadOnly = True
                .Columns(1).Visible = True

                .Columns(2).HeaderText = "DATA"
                .Columns(2).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(2).Width = 120
                .Columns(2).DefaultCellStyle.Format = "yyyy/MM/dd HH:mm:ss"
                .Columns(2).ReadOnly = True
                .Columns(2).Visible = True

                .Columns(3).HeaderText = "MATRIX"
                .Columns(3).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(3).Width = 250
                .Columns(3).ReadOnly = True
                .Columns(3).Visible = True

                .Columns(4).HeaderText = "Immagine"
                .Columns(4).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(4).Width = 250
                .Columns(4).ReadOnly = True
                .Columns(4).Visible = True

                .Columns(5).HeaderText = "Or. X"
                .Columns(5).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(5).Width = 50
                .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(5).ReadOnly = True
                .Columns(5).Visible = True

                .Columns(6).HeaderText = "Or. Y"
                .Columns(6).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(6).Width = 50
                .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(6).ReadOnly = True
                .Columns(6).Visible = True

                .Columns(7).HeaderText = "Or. A"
                .Columns(7).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(7).Width = 50
                .Columns(6).DefaultCellStyle.Format = "0.0"
                .Columns(7).ReadOnly = True
                .Columns(7).Visible = True

                .Columns(8).HeaderText = "Esito Viti"
                .Columns(8).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(8).Width = 60
                .Columns(8).ReadOnly = True
                .Columns(8).Visible = True

                .Columns(9).HeaderText = "Esito visioni"
                .Columns(9).SortMode = DataGridViewColumnSortMode.Automatic
                .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Columns(9).Width = 60
                .Columns(9).ReadOnly = True
                .Columns(9).Visible = True

                .Columns(10).HeaderText = "Product"
                .Columns(10).Visible = False

                .Refresh()
            End With
        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub

    Private Sub T_Box_Prod_TextChanged(sender As Object, e As EventArgs) Handles T_Box_Prod.TextChanged

    End Sub


#End Region

    Private Function Load_Images(ByVal _data As String, _M As Integer, _V As Integer) As Boolean
        Try
            Dim File_imm1 As String = "D:\TRACEABILITY\" & _M.ToString & "\" & _V.ToString & "\" & _data
            If File.Exists(File_imm1) Then
                Panel1.BackgroundImage = Image.FromFile(File_imm1)
            Else
                show_eccezione("Immagine OLED non esiste: " & File_imm1)
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Function Load_ImagesRaw(ByVal data As String) As Boolean
        Try
            Dim File_imm1 As String = data
            If File.Exists(File_imm1) Then
                Panel1.BackgroundImage = Image.FromFile(File_imm1)
            Else
                show_eccezione("Immagine OLED non esiste: " & File_imm1)
            End If
        Catch ex As Exception
            show_eccezione(ex)
            Return False
        End Try
        Return True
    End Function

    Private Sub DGrid2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGrid2.CellClick
        Try
            Dim _imm As String
            If e.RowIndex > -1 Then
                _imm = DGrid2.Rows(e.RowIndex).Cells(4).Value.ToString

                Dim _immDaVerificare As String = _imm.Substring(7, _imm.Length - 7)
                _immDaVerificare = String.Join("_", _immDaVerificare.Split(Path.GetInvalidFileNameChars()))
                Dim _immDaCercare As String = _imm.Substring(0, 7) & _immDaVerificare

                'Load_Images(_immDaCercare, ID_Mod, ID_Vers)

                Load_ImagesRaw(_immDaCercare)
            End If
        Catch ex As Exception
            show_eccezione(ex)
        End Try

    End Sub

    Private Sub T_Box_Prod_Aschii_Enter(_ok As Boolean, _txt As String, _tag As Object) Handles T_Box_Prod.Aschii_Enter
        If _ok Then
            Try
                T_Box_Oled.Text = ""
                If Cerca_product(_txt) Then
                    _BindingS.DataSource = Find_Prod
                    DGrid1.DataSource = _BindingS
                    DGrid1.Name = "Lista prodotti"
                    Format_dg_All()

                    DGrid2.DataSource = Nothing
                    DGrid2.Refresh()
                    T_Oled = Loc_Context.InfoOleds.Where(Function(X) (X.ProductID = Find_Prod(0).Id)).ToList
                    If T_Oled IsNot Nothing Then
                        DGrid2.DataSource = T_Oled
                        DGrid2.Name = "Esiti OLED"
                        Format_dg2()
                        Panel1.BackgroundImage = Nothing
                        ID_Mod = T_Oled(0).Product.ModelID
                        ID_Vers = T_Oled(0).Product.VersionID
                    End If
                End If
            Catch ex As Exception
                show_eccezione(ex)
            End Try
        End If
    End Sub

    Private Sub T_Box_Oled_Aschii_Enter(_ok As Boolean, _txt As String, _tag As Object) Handles T_Box_Oled.Aschii_Enter
        Dim i As Integer
        If _ok Then
            Try
                T_Box_Prod.Text = ""
                Find_Oled = Loc_Context.InfoOleds.Where(Function(x) x.Datamatrix.Equals(_txt)).ToList
                If Find_Oled.Count > 0 Then
                    Dim _Binding2 As New BindingSource
                    _Binding2.DataSource = Find_Oled
                    DGrid2.DataSource = _Binding2
                    DGrid2.Name = "Esiti OLED"
                    Format_dg2()
                    Panel1.BackgroundImage = Nothing
                    If Find_Oled.Count < 2 Then
                        Find_Prod = Loc_Context.Products.Where(Function(x) x.Id = Find_Oled(0).ProductID).ToList
                    Else
                        Find_Prod.Clear()
                        For i = 0 To Find_Oled.Count - 1
                            Dim _pro As Product = Loc_Context.Products.Where(Function(x) x.Id = Find_Oled(i).ProductID).FirstOrDefault
                            If Not _pro Is Nothing Then
                                Find_Prod.Add(_pro)
                            End If
                        Next
                    End If
                    _BindingS.DataSource = Find_Prod
                    DGrid1.Refresh()
                    '  ID_Mod = T_Oled(0).Product.ModelID
                    '  ID_Vers = T_Oled(0).Product.VersionID
                    '  _imm = Find_Oled(0).PhotoFileName
                    '  Load_Images(_imm, ID_Mod, ID_Vers)

                Else
                    Dim _RTV As DialogResult
                    Dim _FP As New Form_PopUp_YN With {._Canc = False, ._Ok = True, ._Label = "!!! DATAMATRIX OLED NON TROVATO !!!"}
                    _RTV = _FP.ShowDialog
                End If
            Catch ex As Exception
                show_eccezione(ex)
            End Try
        End If
    End Sub
End Class