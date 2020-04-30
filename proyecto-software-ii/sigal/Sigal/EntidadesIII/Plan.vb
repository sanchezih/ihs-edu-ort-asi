<Serializable()> _
Public Class Plan

#Region "VARIABLES DE CLASE"
    Private cd_plan_estudio As String
    Private titulo As String
    Private desc_estado_general As String
    Private fc_alta As Date
    Private fc_ultima_modificacion As Nullable(Of Date)
    Public cd_estado_general As String
    Private cd_plan_estudio_y_titulo As String
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_plan_estudio() As String
        Get
            Return cd_plan_estudio
        End Get
        Set(ByVal Value As String)
            cd_plan_estudio = Value
        End Set
    End Property

    Public Property _titulo() As String
        Get
            Return titulo
        End Get
        Set(ByVal Value As String)
            titulo = Value
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

    Public Property _fc_alta() As Date
        Get
            Return fc_alta
        End Get
        Set(ByVal Value As Date)
            fc_alta = Value
        End Set
    End Property

    Public Property _fc_ultima_modificacion() As Nullable(Of Date)
        Get
            Return fc_ultima_modificacion
        End Get
        Set(ByVal Value As Nullable(Of Date))
            fc_ultima_modificacion = Value
        End Set
    End Property

    Public Property _cd_estado_general() As String
        Get
            Return cd_estado_general
        End Get
        Set(ByVal Value As String)
            cd_estado_general = Value
        End Set
    End Property

    Public Property _cd_plan_estudio_y_titulo() As String
        Get
            Return cd_plan_estudio_y_titulo
        End Get
        Set(ByVal Value As String)
            cd_plan_estudio_y_titulo = Value
        End Set
    End Property

#End Region

#Region "INICIALIZACION"

    ''' <summary>
    ''' Constructor. Inicializa la entidad al instanciarse con valores por defecto
    ''' </summary>
    ''' <remarks>Reutiliza un método público para realizar la tarea</remarks>
    Public Sub New()
        Reset()
    End Sub

#End Region

#Region "METODOS PUBLICOS"
    Public Sub Reset()
        _cd_plan_estudio = ""
        _titulo = ""
        _desc_estado_general = ""
        _fc_alta = Nothing
        _fc_ultima_modificacion = Nothing
        _cd_estado_general = ""
        _cd_plan_estudio_y_titulo = ""
    End Sub
#End Region

End Class