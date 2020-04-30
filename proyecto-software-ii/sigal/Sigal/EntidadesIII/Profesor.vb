<Serializable()> _
Public Class Profesor

#Region "VARIABLES DE CLASE"
    Private cd_profesor As Int32
    Private nombre_profesor As String
    Private apellido_profesor As String
    Private email_profesor As String
    Private desc_estado_general As String
    Private fc_alta As Date
    Private fc_ultima_modificacion As Nullable(Of Date)
    Public cd_estado_general As String
    Private cna As String
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_profesor() As Int32
        Get
            Return cd_profesor
        End Get
        Set(ByVal Value As Int32)
            cd_profesor = Value
        End Set
    End Property

    Public Property _nombre_profesor() As String
        Get
            Return nombre_profesor
        End Get
        Set(ByVal Value As String)
            nombre_profesor = Value
        End Set
    End Property

    Public Property _apellido_profesor() As String
        Get
            Return apellido_profesor
        End Get
        Set(ByVal Value As String)
            apellido_profesor = Value
        End Set
    End Property

    Public Property _email_profesor() As String
        Get
            Return email_profesor
        End Get
        Set(ByVal Value As String)
            email_profesor = Value
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

    Public Property _cna() As String
        Get
            Return cna
        End Get
        Set(ByVal Value As String)
            cna = Value
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
        _cd_profesor = 0
        _nombre_profesor = ""
        _apellido_profesor = ""
        _email_profesor = ""
        _desc_estado_general = ""
        _fc_alta = Nothing
        _fc_ultima_modificacion = Nothing
        _cd_estado_general = ""
        _cna = ""
    End Sub
#End Region

End Class
