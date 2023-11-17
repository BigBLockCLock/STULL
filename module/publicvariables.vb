Imports MySql.Data.MySqlClient

Module publicvariables
    Public con As MySqlConnection = myconn()
    Public member As String = "Student"
    Public checkboxcolumnCreditSubjects As New DataGridViewCheckBoxColumn
    Public checkboxcolumnDeleteCreditSubjects As New DataGridViewCheckBoxColumn
    Public checkboxcolumnCreditMembers As New DataGridViewCheckBoxColumn
    Public checkboxcolumnDeleteMembers As New DataGridViewCheckBoxColumn
    Public ALLID As String = ""
    Public sendr As String
    Public usertype As String
    Public usersname As String
    Public reciever As String
    Public message As String = ""
    Public msgstatus As String
    Public membername As String
    Public AMPM As String
    Public courseID As Integer
    Public varDate As Integer
    Dim isempt As Integer
    Public reportselect, reportname As String
End Module
