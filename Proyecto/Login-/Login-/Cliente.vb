Imports System.Data.SqlClient

Public Class Cliente

    Dim con As New SqlConnection(My.Settings.conexion)
    Dim mensaje, sentencia As String

    Sub ejecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        sentencia = "INSERT INTO Cliente VALUES ('" + txtid.Text + "','" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtdireccion.Text + "','" + txtTelefono.Text + "') "
        MsgBox("Datos ingresados correctamente")
        ejecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from Cliente", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class