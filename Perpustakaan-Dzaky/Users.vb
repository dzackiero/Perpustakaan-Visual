﻿Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private usernameDB As String = "root"
    Private passwordDB As String = ""
    Private database As String = "perpustakaan"

    Private TripleDes As New TripleDESCryptoServiceProvider
    Private UsersData As New ArrayList()

    Public loginUsername As String

    Public Property GSusername As String
        Set(value As String)
            loginUsername = value
        End Set
        Get
            Return loginUsername
        End Get
    End Property
    Public Function AddUserDatabase(username As String, password As String)
        Try
            Dim today = Date.Now()
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + usernameDB + ";" + "password= " + passwordDB + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO  USERS( username, password, registered_at) VALUE('" &
                    username & "', '" & EncryptMD5(password) & "', '" & today.ToString("yyyy/MM/dd") & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDatabase(username As String, password As String) As List(Of String)
        Try
            Dim result As New List(Of String)
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " + usernameDB + ";" + "password= " + passwordDB + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users WHERE username='" & username & "' AND password='" & EncryptMD5(password) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Shared Function EncryptMD5(password As String)
        Using x As New MD5CryptoServiceProvider()
            Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
            bs = x.ComputeHash(bs)
            Dim s As New System.Text.StringBuilder()
            For Each b As Byte In bs
                s.Append(b.ToString("x2").ToLower())
            Next
            Return s.ToString()
        End Using
    End Function

    Public Sub addNewUser(Username As String, plainPassword As String)
        UsersData.Add({Username, EncryptData(plainPassword)})
    End Sub


    Public Function EncryptData(plaintext As String) As String
        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream

        Dim encStream As New CryptoStream(ms,
                                          TripleDes.CreateEncryptor(),
                                          System.Security.Cryptography.CryptoStreamMode.Write
                                          )

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function checkAuth(Username As String, plainPassword As String) As Boolean
        For Each User In UsersData
            If String.Compare(Username, User(0)) = 0 And String.Compare(EncryptData(plainPassword), User(1)) = 0 Then
                Return True
            End If
        Next
        Return False
    End Function

End Class
