﻿Imports MySql.Data.MySqlClient

Module save

    Dim result As Integer
    Dim cmd As New MySqlCommand

    '
    Public Sub jokeninsert(ByVal sql As String)

        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql

                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    'MsgBox("No Data has been Inserted!")
                Else
                    'MsgBox("New Data is inserted succesfully!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try
        con.Close()

    End Sub

    Public Sub jokenupdate(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("No Data has been Updated!")
                Else
                    'MsgBox("New Data is updated succesfully!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try
        con.Close()

    End Sub

    Public Sub ejbdelete(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("No Data has been Updated!")
                Else
                    'MsgBox("New Data is updated succesfully!")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)

        End Try
        con.Close()

    End Sub

End Module
