Public Class defaults

    Private Sub defaults_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jokenfindthis("select DISTINCT(CATEGORY) from tblcommon_list")
        fillcombo(cbCategory, "CATEGORY", "category")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        jokenfindthis("select common_id, common_code, category, listname as 'AY & Semester', isdefault as 'Default Status' from tblcommon_list where category = '" & cbCategory.Text & "'")
        fillTable(DataGridView1, "defaults")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newdefaults.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sql As String
        If Button2.Text = "Unset Default" Then
            jokenupdate("update tblcommon_list set isdefault = 'No' where common_id = " & lbldefid.Text & "")

            Sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'AY' and isdefault =  'Yes'"
            jokenfindthis(sql)
            CheckResult("isdefaultay")

            Sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'SEMESTER' and isdefault =  'Yes'"
            jokenfindthis(sql)
            CheckResult("isdefaultsem")


        Else

            jokenupdate("update tblcommon_list set isdefault = 'Yes' where common_id = " & lbldefid.Text & "")

            Sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'AY' and isdefault =  'Yes'"
            jokenfindthis(sql)
            CheckResult("isdefaultay")

            Sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'SEMESTER' and isdefault =  'Yes'"
            jokenfindthis(sql)
            CheckResult("isdefaultsem")



        End If

        Button3_Click(sender, e)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        lbldefid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        lblDefault.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString

        If lblDefault.Text = "Yes" Then

            Button2.Text = "Unset Default"

        Else

            Button2.Text = "Set Default"

        End If
    End Sub
End Class