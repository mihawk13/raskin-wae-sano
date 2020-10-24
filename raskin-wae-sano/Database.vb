Imports MySql.Data.MySqlClient

Public Class Database
    Protected SQL As String
    Protected Cn As New MySqlConnection
    Protected Cmd As New MySqlCommand
    Protected Da As New MySqlDataAdapter
    Protected Ds As New DataSet
    Protected Dt As DataTable

    Public Function OpenConn() As Boolean
        Cn = New MySqlConnection("server=localhost;user id=root;password=;database=raskin-wae_sano; pooling=false;Connection Timeout=5")
        Cn.Open()
        If Cn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub

    Public Function getQuery(ByVal Query As String) As DataTable
        Dim hasil As New DataTable

        Try
            If Not OpenConn() Then
                MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
                Return Nothing
                Exit Function
            End If
            Cmd = New MySql.Data.MySqlClient.MySqlCommand(Query, Cn)
            Da = New MySql.Data.MySqlClient.MySqlDataAdapter
            Da.SelectCommand = Cmd
            Ds = New Data.DataSet
            Da.Fill(Ds)
            Dt = Ds.Tables(0)
            hasil = Dt
            Dt = Nothing
            Ds = Nothing
            Da = Nothing
            Cmd = Nothing
            CloseConn()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return hasil
    End Function

    Public Function setQuery(ByVal Query As String)
        Dim hasil As Boolean
        Try
            If Not OpenConn() Then
                MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
                Return Nothing
                Exit Function
            End If
            Cmd = New MySql.Data.MySqlClient.MySqlCommand
            Cmd.Connection = Cn
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Query
            Cmd.ExecuteNonQuery()
            Cmd = Nothing
            CloseConn()
            hasil = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            hasil = False
        End Try
        Return hasil
    End Function
End Class
