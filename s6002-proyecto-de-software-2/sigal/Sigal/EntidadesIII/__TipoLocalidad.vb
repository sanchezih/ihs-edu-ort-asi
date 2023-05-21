Public Class __TipoLocalidad

#Region "Declaracion de Propiedades"

    Private mCdLocalidad As Int32
    Public Property CdLocalidad() As Int32
        Get
            Return mCdLocalidad
        End Get
        Set(ByVal Value As Int32)
            mCdLocalidad = Value
        End Set
    End Property

    Private mDescLocalidad As String
    Public Property DescLocalidad() As String
        Get
            Return mDescLocalidad
        End Get
        Set(ByVal Value As String)
            mDescLocalidad = Value
        End Set
    End Property
#End Region

#Region "Inicializaci�n"

    ''' <summary>
    ''' Constructor. Inicializa la entidad al instanciarse con valores por defecto
    ''' </summary>
    ''' <remarks>Reutiliza un m�todo p�blico para realizar la tarea</remarks>
    Public Sub New()
        Reset()
    End Sub

#End Region

#Region "M�todos P�blicos"

    ''' <summary>
    ''' Inicializa la entidad a los valores por defecto 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Reset()
        mCdLocalidad = 0
        mDescLocalidad = ""
    End Sub
#End Region
End Class
