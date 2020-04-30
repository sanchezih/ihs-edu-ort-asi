<Serializable()> _
Public Class InscripcionCurso

#Region "VARIABLES DE CLASE"
    Private cd_alumno As Int32
    Private cd_curso As Int32
    Private fc_alta As Date
    Private an As String
    Private nombre_materia As String

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

    Public Property _cd_curso() As String
        Get
            Return cd_curso
        End Get
        Set(ByVal Value As String)
            cd_curso = Value
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

    Public Property _an() As String
        Get
            Return an
        End Get
        Set(ByVal Value As String)
            an = Value
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
        _cd_curso = 0
        _fc_alta = Nothing
        _an = ""
        _nombre_materia = ""

    End Sub
#End Region

End Class
