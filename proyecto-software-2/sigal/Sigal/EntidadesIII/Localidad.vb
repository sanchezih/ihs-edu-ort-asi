<Serializable()> _
Public Class Localidad

#Region "VARIABLES DE CLASE"
    Private cd_localidad As Int32
    Private desc_localidad As String
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_localidad() As Int32
        Get
            Return cd_localidad
        End Get
        Set(ByVal Value As Int32)
            cd_localidad = Value
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
        _cd_localidad = 0
        _desc_localidad = ""
    End Sub
#End Region

End Class