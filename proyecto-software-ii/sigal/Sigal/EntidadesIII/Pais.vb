<Serializable()> _
Public Class Pais

#Region "VARIABLES DE CLASE"
    Private cd_pais As Int32
    Private desc_pais As String
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_pais() As Int32
        Get
            Return cd_pais
        End Get
        Set(ByVal Value As Int32)
            cd_pais = Value
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
        _cd_pais = 0
        _desc_pais = ""
    End Sub
#End Region

End Class
