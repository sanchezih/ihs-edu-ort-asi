Public Class __TipoPais

#Region "Declaracion de Propiedades"

    Private mCdPais As Int32
    Public Property CdPais() As Int32
        Get
            Return mCdPais
        End Get
        Set(ByVal Value As Int32)
            mCdPais = Value
        End Set
    End Property

    Private mDescPais As String
    Public Property DescPais() As String
        Get
            Return mDescPais
        End Get
        Set(ByVal Value As String)
            mDescPais = Value
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
        mCdPais = 0
        mDescPais = ""
    End Sub
#End Region
End Class
