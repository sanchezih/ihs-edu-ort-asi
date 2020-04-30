<Serializable()> _
Public Class __Rol

    Private cd_rol As Int32
    Public Property CdRol() As Int32
        Get
            Return cd_rol
        End Get
        Set(ByVal Value As Int32)
            cd_rol = Value
        End Set
    End Property

    Private desc_rol As String
    Public Property descRol() As String
        Get
            Return desc_rol
        End Get
        Set(ByVal Value As String)
            desc_rol = Value
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
        CdRol = 0
        descRol = ""
    End Sub
#End Region
End Class
