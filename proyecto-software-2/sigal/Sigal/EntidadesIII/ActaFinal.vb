<Serializable()> _
Public Class ActaFinal

#Region "VARIABLES DE CLASE"
    Private cd_alumno As Int32
    Private libro As String
    Private folio As String
    Private fc_examen_final As Date
    Private cd_curso As Int32
    Private cd_plan_estudio As String
    Private an As String
    Private calificacion As Int32
    Private fc_alta As Date
    Private fc_ultima_modificacion As Nullable(Of Date)
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

    Public Property _libro() As String
        Get
            Return libro
        End Get
        Set(ByVal Value As String)
            libro = Value
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

    Public Property _folio() As String
        Get
            Return folio
        End Get
        Set(ByVal Value As String)
            folio = Value
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

    Public Property _cd_plan_estudio() As String
        Get
            Return cd_plan_estudio
        End Get
        Set(ByVal Value As String)
            cd_plan_estudio = Value
        End Set
    End Property

    Public Property _calificacion() As Int32
        Get
            Return calificacion
        End Get
        Set(ByVal Value As Int32)
            calificacion = Value
        End Set
    End Property

    Public Property _fc_examen_final() As Date
        Get
            Return fc_examen_final
        End Get
        Set(ByVal Value As Date)
            fc_examen_final = Value
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
        _cd_alumno = 0
        _libro = ""
        _folio = ""
        _cd_curso = 0
        _cd_plan_estudio = ""
        _an = ""
        _calificacion = 0
        _fc_examen_final = Nothing
        _fc_alta = Nothing
        _fc_ultima_modificacion = Nothing
    End Sub
#End Region

End Class
