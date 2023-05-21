<Serializable()> _
Public Class Correlatividad

#Region "VARIABLES DE CLASE"
    Private cd_plan_estudio As String
    Private cd_materia As String
    Private cd_materia_correlativa As String
    Private nombre_materia As String
    Private correl As String

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

    Public Property _cd_materia_correlativa() As String
        Get
            Return cd_materia_correlativa
        End Get
        Set(ByVal Value As String)
            cd_materia_correlativa = Value
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

    Public Property _correl() As String
        Get
            Return correl
        End Get
        Set(ByVal Value As String)
            correl = Value
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
        _cd_materia_correlativa = ""
        _nombre_materia = ""
        _correl = ""

    End Sub
#End Region

End Class
