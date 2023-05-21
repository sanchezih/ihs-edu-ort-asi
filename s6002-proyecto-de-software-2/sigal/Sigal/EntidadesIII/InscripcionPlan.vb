<Serializable()> _
Public Class InscripcionPlan

#Region "VARIABLES DE CLASE"
    Private cd_alumno As Int32
    Private cd_plan_estudio As String
    Private fc_alta As Date
    Private titulo As String
    Private an As String

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

    Public Property _cd_plan_estudio() As String
        Get
            Return cd_plan_estudio
        End Get
        Set(ByVal Value As String)
            cd_plan_estudio = Value
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

    Public Property _titulo() As String
        Get
            Return titulo
        End Get
        Set(ByVal Value As String)
            titulo = Value
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
        _cd_plan_estudio = ""
        _fc_alta = Nothing
        _titulo = ""
        _an = ""

    End Sub
#End Region

End Class
