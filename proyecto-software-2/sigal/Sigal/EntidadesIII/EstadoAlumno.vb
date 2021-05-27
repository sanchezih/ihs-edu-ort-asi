Public Class EstadoAlumno

#Region "Declaracion de Propiedades"

    Private mCdEstadoAlumno As Int32
    Public Property CdEstadoAlumno() As Int32
        Get
            Return mCdEstadoAlumno
        End Get
        Set(ByVal Value As Int32)
            mCdEstadoAlumno = Value
        End Set
    End Property

    Private mDescEstadoAlumno As String
    Public Property DescEstadoAlumno() As String
        Get
            Return mDescEstadoAlumno
        End Get
        Set(ByVal Value As String)
            mDescEstadoAlumno = Value
        End Set
    End Property
#End Region

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
        mCdEstadoAlumno = 0
        mDescEstadoAlumno = ""
    End Sub
#End Region
End Class
