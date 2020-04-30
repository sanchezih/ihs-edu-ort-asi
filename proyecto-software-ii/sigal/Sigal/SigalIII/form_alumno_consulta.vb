Public Class form_alumno_consulta

#Region "VARIABLES DE CLASE"
    Private mCancelado As Boolean = True
    Private cd_alumno As Int32 = 0
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

    Public Property _cd_alumno() As Int32
        Get
            Return cd_alumno
        End Get
        Set(ByVal Value As Int32)
            cd_alumno = Value
        End Set
    End Property

#End Region

#Region "METODOS"

    Private Sub iniciar_formulario()

        btn_aceptar.TabIndex = 0

        Dim l_entidades_materia As List(Of Entidades.Alumno)

        Dim o_negocio_materia As New Negocio.Alumno
        Try
            l_entidades_materia = o_negocio_materia.get_one(_cd_alumno)

            If l_entidades_materia.Count > 0 Then

                With l_entidades_materia(0)

                    lbl_titulo_form.Text = "Detalle de " + ._apellido_alumno + ", " + ._nombre_alumno + " - Código " + CStr(._cd_alumno)
                    tel.Text = ._tel1_alumno
                    nro_doc.Text = ._nro_doc_alumno
                    nacimiento.Text = ._fc_nacimiento
                    pais.Text = ._desc_pais
                    nombre.Text = ._nombre_alumno
                    apellido.Text = ._apellido_alumno
                    tipo_doc.Text = ._tipo_doc_alumno
                    sex.Text = ._sexo
                    mail.Text = ._email_alumno
                    lo.Text = ._direccion_alumno
                    local.Text = ._desc_localidad
                    cp.Text = ._cd_postal
                    lbl_fc_alta.Text = ._fc_alta
                    estado.Text = ._desc_estado_alumno


                    If ._fc_ultima_modificacion.HasValue = False Then
                        fc_ult.Text = "N/A"
                    Else
                        fc_ult.Text = ._fc_ultima_modificacion
                    End If

                    If ._piso_alumno Is Nothing Then
                        piso.Text = "N/A"
                    Else
                        piso.Text = ._piso_alumno
                    End If

                    If ._departamento_alumno Is Nothing Then
                        dto.Text = "N/A"
                    Else
                        dto.Text = ._departamento_alumno
                    End If

                End With
            Else
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            l_entidades_materia = Nothing
            o_negocio_materia = Nothing
        End Try
    End Sub

    Private Sub CancelarOperacion()
        'cancelo la operación y retorno al formulario llamador
        Cancelado = True
        Me.Hide()
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


End Class