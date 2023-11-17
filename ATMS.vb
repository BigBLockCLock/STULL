Imports MySql.Data.MySqlClient

Public Class ATMS

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        txtsearchid.Focus()
        txtsearchid.Select()

        Panel4.Hide()
        Dim sql As String
        sql = "SELECT listname FROM(tblcommon_list) WHERE category = 'AY' and isdefault =  'Yes'"
        jokenfindthis(sql)
        CheckResult("maindefault")
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLTIME.Text = TimeOfDay
        AMPM = Format(Now, "tt")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'LBLDATE.Text = My.Computer.Clock.LocalTime.Date
        LBLDATE.Text = Format(Now, "Long Date")
        StatLbltime.Text = Date.Now.ToString("H:mm:ss")
    End Sub
    Private Sub txtsearchid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtsearchid.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                              " `MOBILENO` AS Contact,EMAIL,  `PARENTS_GUARDIAN` AS  'Parent/Guardian',  `PARENTS_MOBILE`  'Parent Contac No.',  `PARENTSSECONDARYNO` AS 'Secondary No.', " & _
                              " `STATUS` , CONCAT(  `COURSE_NAME` ,  '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL',MEMBERPHOTO,MEMBER_TYPE FROM  `tblmembers` ,  `course` WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND RFID = '" & txtsearchid.Text & "'")
                filldata(picMain, "Main")

                'sendr = txtsearchid.Text
                'txtsearchid.Text = Nothing
                statsTimein.Text = "Time recorded: " & LBLTIME.Text
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


        End If

        AMPM = Format(Now, "tt")
    End Sub

    Private Sub txtsearchid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsearchid.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
