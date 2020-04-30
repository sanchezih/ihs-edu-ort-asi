<Serializable()> _
Public Class Alumno

#Region "VARIABLES DE CLASE"
    Private cd_alumno As Int32
    Private nombre_alumno As String
    Private apellido_alumno As String
    Private tipo_doc_alumno As String
    Private nro_doc_alumno As Int32
    Private fc_nacimiento As Date
    Private sexo As String
    Public cd_pais As Int32
    Private direccion_alumno As String
    Private piso_alumno As String
    Private departamento_alumno As String
    Private cd_postal As String
    Public cd_localidad As Int32
    Public tel1_alumno As String
    Private email_alumno As String
    Public cd_estado_alumno As Int32
    Private fc_alta As Date
    Private fc_ultima_modificacion As Nullable(Of Date)
    Private desc_pais As String
    Private desc_localidad As String
    Private desc_estado_alumno As String
    Private cna As String
    Private documento As String

#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_alumno() As Int32
        Get
            Return cd_alumno
        End Get
        Set(ByVal Value As Int32)
            cd_alumno = Value
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

    Public Property _documento() As String
        Get
            Return documento
        End Get
        Set(ByVal Value As String)
            documento = Value
        End Set
    End Property

    Public Property _nombre_alumno() As String
        Get
            Return nombre_alumno
        End Get
        Set(ByVal Value As String)
            nombre_alumno = Value
        End Set
    End Property

    Public Property _apellido_alumno() As String
        Get
            Return apellido_alumno
        End Get
        Set(ByVal Value As String)
            apellido_alumno = Value
        End Set
    End Property

    Public Property _tipo_doc_alumno() As String
        Get
            Return tipo_doc_alumno
        End Get
        Set(ByVal Value As String)
            tipo_doc_alumno = Value
        End Set
    End Property

    Public Property _nro_doc_alumno() As Int32
        Get
            Return nro_doc_alumno
        End Get
        Set(ByVal Value As Int32)
            nro_doc_alumno = Value
        End Set
    End Property

    Public Property _fc_nacimiento() As Date
        Get
            Return fc_nacimiento
        End Get
        Set(ByVal Value As Date)
            fc_nacimiento = Value
        End Set
    End Property

    Public Property _sexo() As String
        Get
            Return sexo
        End Get
        Set(ByVal Value As String)
            sexo = Value
        End Set
    End Property

    Public Property _cd_pais() As Int32
        Get
            Return cd_pais
        End Get
        Set(ByVal Value As Int32)
            cd_pais = Value
        End Set
    End Property

    Public Property _direccion_alumno() As String
        Get
            Return direccion_alumno
        End Get
        Set(ByVal Value As String)
            direccion_alumno = Value
        End Set
    End Property

    Public Property _piso_alumno() As String
        Get
            Return piso_alumno
        End Get
        Set(ByVal Value As String)
            piso_alumno = Value
        End Set
    End Property

    Public Property _departamento_alumno() As String
        Get
            Return departamento_alumno
        End Get
        Set(ByVal Value As String)
            departamento_alumno = Value
        End Set
    End Property

    Public Property _cd_postal() As String
        Get
            Return cd_postal
        End Get
        Set(ByVal Value As String)
            cd_postal = Value
        End Set
    End Property

    Public Property _cd_localidad() As Int32
        Get
            Return cd_localidad
        End Get
        Set(ByVal Value As Int32)
            cd_localidad = Value
        End Set
    End Property

    Public Property _email_alumno() As String
        Get
            Return email_alumno
        End Get
        Set(ByVal Value As String)
            email_alumno = Value
        End Set
    End Property

    Public Property _cd_estado_alumno() As Int32
        Get
            Return cd_estado_alumno
        End Get
        Set(ByVal Value As Int32)
            cd_estado_alumno = Value
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

    Public Property _desc_pais() As String
        Get
            Return desc_pais
        End Get
        Set(ByVal Value As String)
            desc_pais = Value
        End Set
    End Property

    Public Property _desc_localidad() As String
        Get
            Return desc_localidad
        End Get
        Set(ByVal Value As String)
            desc_localidad = Value
        End Set
    End Property

    Public Property _desc_estado_alumno() As String
        Get
            Return desc_estado_alumno
        End Get
        Set(ByVal Value As String)
            desc_estado_alumno = Value
        End Set
    End Property

    Public Property _tel1_alumno() As String
        Get
            Return tel1_alumno
        End Get
        Set(ByVal Value As String)
            tel1_alumno = Value
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
        _cd_alumno = 0
        _nombre_alumno = ""
        _apellido_alumno = ""
        _tipo_doc_alumno = ""
        _nro_doc_alumno = 0
        _fc_nacimiento = Nothing
        _sexo = ""
        _cd_pais = 0
        _direccion_alumno = ""
        _piso_alumno = Nothing
        _departamento_alumno = Nothing
        _cd_postal = ""
        _cd_localidad = 0
        _email_alumno = ""
        _cd_estado_alumno = 0
        _fc_alta = Nothing
        _fc_ultima_modificacion = Nothing
        _desc_pais = ""
        _desc_localidad = ""
        _desc_estado_alumno = ""
        _tel1_alumno = ""
        _cna = ""
        _documento = ""

    End Sub
#End Region

End Class
