<Serializable()> _
Public Class __Usuario
    Private cd_usuario As String
    Public Property cdUsuario() As String
        Get
            Return cd_usuario
        End Get
        Set(ByVal Value As String)
            cd_usuario = Value
        End Set
    End Property

    Private cd_rol As Int32
    Public Property cdRol() As Int32
        Get
            Return cd_rol
        End Get
        Set(ByVal Value As Int32)
            cd_rol = Value
        End Set
    End Property

    Private password_usuario As String
    Public Property passwordUsuario() As String
        Get
            Return password_usuario
        End Get
        Set(ByVal Value As String)
            password_usuario = Value
        End Set
    End Property

    Private fc_alta As Date
    Public Property fcAlta() As Date
        Get
            Return fc_alta
        End Get
        Set(ByVal Value As Date)
            fc_alta = Value
        End Set
    End Property

    Private fc_ultima_modificacion As Date
    Public Property fcUltimaModificacion() As Date
        Get
            Return fc_ultima_modificacion
        End Get
        Set(ByVal Value As Date)
            fc_ultima_modificacion = Value
        End Set
    End Property

    Private fc_baja As Date
    Public Property fcBaja() As Date
        Get
            Return fc_baja
        End Get
        Set(ByVal Value As Date)
            fc_baja = Value
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

    ''' <summary>
    ''' Inicializa la entidad a los valores por defecto 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Reset()
        cdUsuario = 0
        cdRol = 0
        passwordUsuario = ""
    End Sub
#End Region
End Class
