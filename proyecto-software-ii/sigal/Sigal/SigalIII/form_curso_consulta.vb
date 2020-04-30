Public Class form_curso_consulta
#Region "VARIABLES DE CLASE"
    Private mCancelado As Boolean = True
    Private cd_curso As Int32 = 0
#End Region

#Region "PROPIEDADES DE CONTROL"

    Public Property Cancelado() As Boolean
        Get
            Return mCancelado
        End Get
        Set(ByVal value As Boolean)
            mCancelado = value
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

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        btn_aceptar.TabIndex = 0

        Dim l_entidades_materia As List(Of Entidades.Curso)

        Dim o_negocio_materia As New Negocio.Curso
        Try
            l_entidades_materia = o_negocio_materia.get_one(_cd_curso)

            If l_entidades_materia.Count > 0 Then

                With l_entidades_materia(0)

                    lbl_titulo_form.Text = "Detalle del curso " + CStr(._cd_curso)
                    Label5.Text = ._cd_plan_estudio
                    Label7.Text = ._cn
                    Label8.Text = ._semestre
                    Label9.Text = ._anio
                    Label12.Text = ._nombre_profesor
                    Label14.Text = ._fc_alta

                    If ._fc_baja.HasValue = False Then
                        Label6.Text = "N/A"
                    Else
                        Label6.Text = ._fc_baja
                    End If

                End With
            Else
            End If

        Catch ex As Exception
            'Muestra el error ocurrido
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            'Liberamos memoria
            l_entidades_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

#End Region

#Region "EVENTOS"

    Private Sub form_curso_consulta_Show(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        iniciar_formulario()
    End Sub

    Private Sub btn_aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click
        Me.Close()
    End Sub

#End Region

    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
    End Sub

End Class