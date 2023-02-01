Imports System.Data.SqlClient


Public Class Secretaria
    Dim con As New SqlConnection(My.Settings.conexion)

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

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs)
        Try
            Dim da As New SqlDataAdapter("Select *from Cliente", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.GunaDataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
End Class