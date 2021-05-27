<Serializable()> _
Public Class PMC

#Region "VARIABLES DE CLASE"
    Private cd_plan_estudio As String
    Private cd_materia As String
    Private cuatrimestre_carrera As Int32
    Private nombre_materia As String
    Private titulo As String
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

    Public Property _cd_materia() As String
        Get
            Return cd_materia
        End Get
        Set(ByVal Value As String)
            cd_materia = Value
        End Set
    End Property

    Public Property _cuatrimestre_carrera() As Int32
        Get
            Return cuatrimestre_carrera
        End Get
        Set(ByVal Value As Int32)
            cuatrimestre_carrera = Value
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

    Public Property _titulo() As String
        Get
            Return titulo
        End Get
        Set(ByVal Value As String)
            titulo = Value
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
        _cd_materia = ""
        _cuatrimestre_carrera = 0
        _nombre_materia = ""
        _titulo = ""

    End Sub
#End Region

End Class
