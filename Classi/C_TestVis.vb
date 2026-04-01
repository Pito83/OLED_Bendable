
Imports System.Threading
Public Class C_TestVis

    Private _thv As Thread
    Private Kiudi As Boolean
    Private Volte As Integer

    Public Sub New()
        Kiudi = False : _Sim_Vis = True
        Volte = 0
        _thv = New Thread(AddressOf Th_TV)
        _thv.Start()
    End Sub

    Public Sub Disponi()
        Kiudi = True
        Thread.Sleep(500)
        Volte = 0
        Try
            While _thv.ThreadState = ThreadState.Running
                Thread.Sleep(50)
            End While
            If Not (_thv Is Nothing) Then
                _thv.Abort()
            End If
        Catch ex As Exception
            show_eccezione(ex)
        Finally
            _Sim_Vis = False
        End Try
    End Sub



    Private Sub Th_TV()
        Thread.Sleep(50)
_aa:    If Kiudi Then Exit Sub

        Exe_Plc_Vis_Step(1, "")  'run lettura data MAtrix OLED
        Thread.Sleep(10)
        Exe_Plc_Vis_Step(3, "") 'run Pressa OLED A
        Thread.Sleep(10)
        Exe_Plc_Vis_Step(5, "")
        Thread.Sleep(10)
        While Run_vis(1)
            Thread.Sleep(10)
        End While
        While Run_vis(3)
            Thread.Sleep(10)
        End While
        While Run_vis(5)
            Thread.Sleep(10)
        End While

        Volte += 1
        _n_Sim = Volte
        If Volte > 1000 Then
            Volte = 0
            Exit Sub
        End If
        Thread.Sleep(20)
        GoTo _aa

    End Sub

End Class
