<Serializable()> _
Public Class EstadoMateria

#Region "VARIABLES DE CLASE"

    Private cd_estado_materia As String
    Private desc_estado_materia As String

#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property _cd_estado_materia() As String
        Get
            Return cd_estado_materia
        End Get
        Set(ByVal Value As String)
            cd_estado_materia = Value
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

#End Region

#Region "INICIALIZACION"

    Public Sub New()
        Reset()
    End Sub

#End Region

#Region "METODOS PUBLICOS"

    Public Sub Reset()
        _cd_estado_materia = ""
        _desc_estado_materia = ""
    End Sub

#End Region


End Class
