

Imports MySql.Data.MySqlClient

Module db

    Dim MysqlConn As New MySqlConnection

    Public server As String
    Public userid As String
    Public password As String
    Public database As String

    Public Sub setCOnfig()
        Dim FILE_NAME As String = Application.StartupPath & "\config.txt"

        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            server = objReader.ReadLine()
            userid = objReader.ReadLine() & vbNewLine
            password = objReader.ReadLine() & vbNewLine & vbNewLine
            database = objReader.ReadLine() & vbNewLine & vbNewLine & vbNewLine


        Else

            MsgBox("Config File Does Not Exist!")

        End If
    End Sub
    Public Function myconn() As MySqlConnection
        setCOnfig()
        Return New MySqlConnection("server=" & server & ";user id=" & userid & ";password=" & password & ";database=" & database & "")
    End Function

End Module

