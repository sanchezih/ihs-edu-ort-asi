<Serializable()> _
Public Class __PlanEstudio_figuls
    Private cd_plan_estudio As Int32
    Public Property cdPlanEstudio() As Int32
        Get
            Return cd_plan_estudio
        End Get
        Set(ByVal Value As Int32)
            cd_plan_estudio = Value
        End Set
    End Property

    Private mititulo As String
    Public Property titulo() As String
        Get
            Return mititulo
        End Get
        Set(ByVal Value As String)
            mititulo = Value
        End Set
    End Property

    Private miestado As String
    Public Property estado() As String
        Get
            Return miestado
        End Get
        Set(ByVal Value As String)
            miestado = Value
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

    Private fc_ultima_modificacion As String
    Public Property fcUltimaModificacion() As String
        Get
            Return fc_ultima_modificacion
        End Get
        Set(ByVal Value As String)
            fc_ultima_modificacion = Value
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
        cdPlanEstudio = 0
        mititulo = ""
        estado = ""

    End Sub
#End Region
End Class
