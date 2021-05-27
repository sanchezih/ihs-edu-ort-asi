<Serializable()> _
Public Class Usuario

#Region "VARIABLES DE CLASE"
    Private cd_usuario As String
    Private password_usuario As String
    Private desc_estado_general As String
    Private desc_rol As String
    Private fc_alta As Date
    Private fc_ultima_modificacion As Nullable(Of Date)
    Public cd_estado_general As String
    Public cd_rol As Int32

#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_usuario() As String
        Get
            Return cd_usuario
        End Get
        Set(ByVal Value As String)
            cd_usuario = Value
        End Set
    End Property

    Public Property _password_usuario() As String
        Get
            Return password_usuario
        End Get
        Set(ByVal Value As String)
            password_usuario = Value
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

    Public Property _desc_rol() As String
        Get
            Return desc_rol
        End Get
        Set(ByVal Value As String)
            desc_rol = Value
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

    Public Property _cd_rol() As Int32
        Get
            Return cd_rol
        End Get
        Set(ByVal Value As Int32)
            cd_rol = Value
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
        _cd_usuario = ""
        _password_usuario = ""
        _desc_estado_general = ""
        _fc_alta = Nothing
        _fc_ultima_modificacion = Nothing
        _cd_estado_general = ""
        _cd_rol = 0
        _desc_rol = ""
    End Sub
#End Region

End Class
