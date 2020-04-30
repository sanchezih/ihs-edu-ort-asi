<Serializable()> _
Public Class Materia

#Region "VARIABLES DE CLASE"
    Private cd_materia As String
    Private nombre_materia As String
    Private desc_estado_general As String
    Private fc_alta As Date
    Private fc_ultima_modificacion As Nullable(Of Date)
    Public cd_estado_general As String
    Private cn As String
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_materia() As String
        Get
            Return cd_materia
        End Get
        Set(ByVal Value As String)
            cd_materia = Value
        End Set
    End Property

    Public Property _nombre_materia() As String
        Get
            Return nombre_materia
        End Get
        Set(ByVal Value As String)
            nombre_materia = Value
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

    Public Property _cn() As String
        Get
            Return cn
        End Get
        Set(ByVal Value As String)
            cn = Value
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
        _cd_materia = ""
        _nombre_materia = ""
        _desc_estado_general = ""
        _fc_alta = Nothing
        _fc_ultima_modificacion = Nothing
        _cd_estado_general = ""
        _cn = ""
    End Sub
#End Region

End Class
