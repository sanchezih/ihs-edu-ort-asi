Public Class Usuario

    Public Function get_all_by_filtros(ByVal cd_usuario As String, ByVal password_usuario As String) As List(Of Entidades.Usuario)
        Dim o_datos_materia As Datos.Usuario
        Try
            o_datos_materia = New Datos.Usuario
            Return o_datos_materia.get_all_by_filtros(cd_usuario, password_usuario)

        Finally
            o_datos_materia = Nothing
        End Try

    End Function

    Public Function consulta_rol(ByVal cd_usuario As String) As Int32
        Dim o_datos_usuario As Datos.Usuario
        Try
            o_datos_usuario = New Datos.Usuario

            Return o_datos_usuario.consulta_rol(cd_usuario)

        Finally
            o_datos_usuario = Nothing
        End Try

    End Function

    Public Function consulta_existencia_cd_usuario(ByVal cd_usuario As String) As Int32
        Dim o_datos_usuario As Datos.Usuario
        Try
            o_datos_usuario = New Datos.Usuario

            Return o_datos_usuario.consulta_existencia_cd_usuario(cd_usuario)

        Finally
            o_datos_usuario = Nothing
        End Try

    End Function

    Public Function add(ByVal item As Entidades.Usuario) As Int32
        Dim o_datos_materia As Datos.Usuario
        Try
            o_datos_materia = New Datos.Usuario
            Return o_datos_materia.add(item)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

    Public Function update(ByVal item As Entidades.Usuario) As Int32
        Dim o_datos_materia As Datos.Usuario
        Try
            o_datos_materia = New Datos.Usuario
            Return o_datos_materia.update(item)
        Finally
            o_datos_materia = Nothing
        End Try
    End Function

End Class
