Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Form1
    Public con As SqlConnection = New SqlConnection(My.Settings.conexion)
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim pantalla As New Administrador

    Private Sub btnacceder_Click(sender As Object, e As EventArgs) Handles btnacceder.Click
        Try
            con.Open()
            comando = New SqlCommand("Select Usuario, Contraseña From Persona where Usuario = @vusuario and Contraseña = @vcontraseña", con)
            comando.Parameters.AddwithValue("@vusuario", txtusuario.Text)
            comando.Parameters.AddWithValue("@vcontraseña", txtcontraseña.Text)
            If txtusuario.Text = "Administrador" Then
                MsgBox("Usuario Administrador")
                pantalla.Show()
                Me.Hide()


            Else
                If txtusuario.Text = "Secretaria" Then
                    MsgBox("Usuario Secretaria")
                    Secretaria.Show()
                    Me.Hide()
                Else
                    If txtusuario.Text = "Cliente" Then
                        MsgBox("Usuario Cliente")
                        Cliente.Show()
                        Me.Hide()
                    End If
                End If
            End If

            MsgBox("Bienvenido ")
            lector = comando.ExecuteReader()

        Catch ex As Exception
            MsgBox("Los datos son incorrectos")
        End Try
    End Sub


End Class
