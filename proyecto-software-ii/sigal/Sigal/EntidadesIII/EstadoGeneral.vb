<Serializable()> _
Public Class EstadoGeneral

#Region "VARIABLES DE CLASE"
    Private cd_estado_general As String
    Private desc_estado_general As String
#End Region

    Public Property _cd_estado_general() As String
        Get
            Return cd_estado_general
        End Get
        Set(ByVal Value As String)
            cd_estado_general = Value
        End Set
    End Property

    Public Property _desc_estado_general() As String
        Get
            Return desc_estado_general
        End Get
        Set(ByVal Value As String)
            desc_estado_general = Value
        End Set
    End Property

#Region "Inicialización"

    ''' <summary>
    ''' Constructor. Inicializa la entidad al instanciarse con valores por defecto
    ''' </summary>
    ''' <remarks>Reutiliza un método público para realizar la tarea</remarks>
    Public Sub New()
        Reset()
    End Sub

#End Region

#Region "Métodos Públicos"
    Public Sub Reset()
        _cd_estado_general = ""
        _desc_estado_general = ""
    End Sub
#End Region
End Class
