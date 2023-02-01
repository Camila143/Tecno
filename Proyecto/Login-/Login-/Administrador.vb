Imports System.Data.SqlClient

Public Class Administrador

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

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            Dim da As New SqlDataAdapter("Select *from Cliente", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
        sentencia = "INSERT INTO Provedores VALUES ('" + txtid_prov.Text + "','" + txtnombre_prov.Text + "','" + txtdireccion_prov.Text + "','" + txtTelefono_prov.Text + "') "
        MsgBox("Datos ingresados correctamente")
        ejecutarSql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select *from Provedores", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnbuscar_Prov_Click(sender As Object, e As EventArgs) Handles btnbuscar_Prov.Click
        Dim da As New SqlDataAdapter("SELECT * FROM provedores WHERE Id_Prov='" + txtid_prov.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.GunaDataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btnbuscar_clie_Click(sender As Object, e As EventArgs) Handles btnbuscar_clie.Click
        Dim da As New SqlDataAdapter("SELECT * FROM cliente WHERE Id_cliente='" + txtid_cliente.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.GunaDataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
        Try
            Dim da As New SqlDataAdapter("Select *from Provedores", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class