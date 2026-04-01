
Imports Oled.DataLayer
Imports Oled.TraceDataLayer
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports Microsoft.EntityFrameworkCore


Public Class Bootstrapper
    Public Shared ReadOnly Current As Bootstrapper = New Bootstrapper() 'Static
    Private _host As IHost

    Public Sub New()

    End Sub

    Public ReadOnly Property Services As IServiceProvider
        Get
            Return _host.Services
        End Get
    End Property

    Public Sub Start(ConfigConnection As ConnectionString)
        Try
            If (_host IsNot Nothing) Then
                Exit Sub
            End If



            _host = Host.CreateDefaultBuilder().ConfigureServices(Function(x)
                                                                      x.AddDbContext(Of ProcessDataContext)(Function(o) o.UseSqlServer(ConfigConnection.ProcessData))
                                                                      Return x.AddDbContext(Of TraceDataContext)(Function(o) o.UseSqlServer(ConfigConnection.TraceData))
                                                                  End Function).Build

            _host.Start()

            Dim scope = Services.CreateScope()
            scope.ServiceProvider.GetRequiredService(Of ProcessDataContext).Database.Migrate()
            scope.ServiceProvider.GetRequiredService(Of TraceDataContext).Database.Migrate()

        Catch ex As Exception
            show_eccezione(ex)
        End Try
    End Sub 'Async Task
End Class

Public Class ConnectionString
    Public ProcessData As String
    Public TraceData As String
End Class
