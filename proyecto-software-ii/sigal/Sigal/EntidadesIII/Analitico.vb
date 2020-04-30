<Serializable()> _
Public Class Analitico

#Region "VARIABLES DE CLASE"
    Private cd_alumno As Int32
    Private cd_materia As String
    Private cd_curso As Int32
    Private cd_estado_materia As String
    Private an As String
    Private desc_estado_materia As String
    Private fc_ultima_modificacion As Date
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

    Public Property _cd_materia() As String
        Get
            Return cd_materia
        End Get
        Set(ByVal Value As String)
            cd_materia = Value
        End Set
    End Property

    Public Property _desc_estado_materia() As String
        Get
            Return desc_estado_materia
        End Get
        Set(ByVal Value As String)
            desc_estado_materia = Value
        End Set
    End Property

    Public Property _an() As String
        Get
            Return an
        End Get
        Set(ByVal Value As String)
            an = Value
        End Set
    End Property

    Public Property _cd_curso() As Int32
        Get
            Return cd_curso
        End Get
        Set(ByVal Value As Int32)
            cd_curso = Value
        End Set
    End Property

    Public Property _cd_estado_materia() As String
        Get
            Return cd_estado_materia
        End Get
        Set(ByVal Value As String)
            cd_estado_materia = Value
        End Set
    End Property

    Public Property _fc_ultima_modificacion() As Date
        Get
            Return fc_ultima_modificacion
        End Get
        Set(ByVal Value As Date)
            fc_ultima_modificacion = Value
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
        _cd_materia = ""
        _cd_curso = 0
        _cd_estado_materia = ""
        _fc_ultima_modificacion = Nothing
        _desc_estado_materia = ""
        _an = ""

    End Sub
#End Region

End Class
