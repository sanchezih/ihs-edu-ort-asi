<Serializable()> _
Public Class Curso

#Region "VARIABLES DE CLASE"

    Private cd_curso As Int32
    Private cd_materia As String
    Private cd_profesor As Int32
    Private cd_plan_estudio As String
    Private semestre As Int32
    Private anio As Int32
    Private fc_alta As Date
    Private fc_baja As Nullable(Of Date)

    Private nombre_materia As String
    Private nombre_profesor As String
    Private titulo As String
    Private cn As String


#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_curso() As Int32
        Get
            Return cd_curso
        End Get
        Set(ByVal Value As Int32)
            cd_curso = Value
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

    Public Property _cd_profesor() As Int32
        Get
            Return cd_profesor
        End Get
        Set(ByVal Value As Int32)
            cd_profesor = Value
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

    Public Property _semestre() As Int32
        Get
            Return semestre
        End Get
        Set(ByVal Value As Int32)
            semestre = Value
        End Set
    End Property

    Public Property _anio() As Int32
        Get
            Return anio
        End Get
        Set(ByVal Value As Int32)
            anio = Value
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

    Public Property _fc_baja() As Nullable(Of Date)
        Get
            Return fc_baja
        End Get
        Set(ByVal Value As Nullable(Of Date))
            fc_baja = Value
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

    Public Property _nombre_profesor() As String
        Get
            Return nombre_profesor
        End Get
        Set(ByVal Value As String)
            nombre_profesor = Value
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

    ''' <summary>
    ''' Inicializa la entidad a los valores por defecto 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Reset()
        _cd_curso = 0
        _cd_materia = ""
        _cd_profesor = 0
        _cd_plan_estudio = ""
        _semestre = 0
        _anio = 0
        _fc_alta = Nothing
        _fc_baja = Nothing
        _nombre_materia = ""
        _nombre_profesor = ""
        _titulo = ""
        _cn = ""
    End Sub
#End Region

End Class
