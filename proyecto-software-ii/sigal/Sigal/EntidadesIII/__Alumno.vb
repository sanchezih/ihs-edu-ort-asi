<Serializable()> _
Public Class __Alumno

#Region "VARIABLES DE CLASE"
    Private cd_alumno As Int32
    Private nombre_alumno As String
    Private apellido_alumno As String
    Private tipo_doc_alumno As String


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

    Public Property _nombre_alumno() As String
        Get
            Return nombre_alumno
        End Get
        Set(ByVal Value As String)
            nombre_alumno = Value
        End Set
    End Property

    Public Property _apellido_alumno() As String
        Get
            Return apellido_alumno
        End Get
        Set(ByVal Value As String)
            apellido_alumno = Value
        End Set
    End Property

    Public Property _tipo_doc_alumno() As String
        Get
            Return tipo_doc_alumno
        End Get
        Set(ByVal Value As String)
            tipo_doc_alumno = Value
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

#End Region

End Class
