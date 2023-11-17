Imports MySql.Data.MySqlClient
Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me
            .TLlogin.Image = SMSMYSQL.My.Resources.Login
            .TLlogin.Text = "Login"

            'Home
            .tlsATMS.Enabled = False
            .tlsteacher.Enabled = False
            .tlsStudent.Enabled = False
            .tlsBroadcast.Enabled = False
            .tlsDTR.Enabled = False
            .tlsSMSlogs.Enabled = False
            .tlsGradelvel.Enabled = False
            .tlsreports.Enabled = False
            .ActionToolStripMenuItem.Enabled = False
            .SettingsToolStripMenuItem.Enabled = False
        End With

        Try
            con.Open()
            ToolStrip2.Enabled = True
            Me.dbStatsNotConnected.Text = "Database: Connected!"
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            DefaultsToolStripMenuItem.Enabled = False
            ManageUserToolStripMenuItem.Enabled = False
            ActionToolStripMenuItem.Enabled = False
            LunchATMSToolStripMenuItem.Enabled = False

            With Me
                .TLlogin.Image = SMSMYSQL.My.Resources.log_out
                .TLlogin.Text = "Logout"

                'Home
                .tlsATMS.Enabled = False
                .tlsteacher.Enabled = False
                .tlsStudent.Enabled = False
                .tlsBroadcast.Enabled = False
                .tlsDTR.Enabled = False
                .tlsSMSlogs.Enabled = False
                .tlsGradelvel.Enabled = False
                .ActionToolStripMenuItem.Enabled = False
                .SettingsToolStripMenuItem.Enabled = False
                .tlsreports.Enabled = False
                .TLlogin.Enabled = True
                'Entry


            End With

            Me.dbStatsNotConnected.Text = "Database: Not Connected!"
            TLlogin.Image = SMSMYSQL.My.Resources.remove_from_database_icon
            TLlogin.Text = "Connect Now!"
            TSUser.Text = Nothing
        End Try

    End Sub

    Private Sub LunchATMSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LunchATMSToolStripMenuItem.Click
        ATMS.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsATMS.Click
        ATMS.Show()
    End Sub



    Private Sub tlsStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsStudent.Click
        tlsMessage.Text = "List of Student"
        member = "Student"
        txtSearch.Visible = True
        tslSearch.Visible = True
        dtglistofmember.BringToFront()
        addrow(dtglistofmember, "", "checkboxMember")
        jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                         " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',  `PARENTSSECONDARYNO` as 'Sec. No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL', RFID " & _
                         " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student'")

        fillTable(dtglistofmember, "listofmembers")

        dtglistofmember.Columns(2).DefaultCellStyle.ForeColor = Color.Green
    End Sub

    Public Sub loadMember()
        txtSearch.Visible = True
        tslSearch.Visible = True
        dtglistofmember.BringToFront()
        addrow(dtglistofmember, "", "checkboxMember")
        ' lblMember.Text = "List of " & member

        If member = "Student" Then
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                          " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',  `PARENTSSECONDARYNO` as 'Sec. No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL', RFID " & _
                          " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student'")


        ElseIf member = "Teacher" Then
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                          " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',  `PARENTSSECONDARYNO` as 'Sec. No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'ADVISORY',RFID " & _
                          " FROM  `tblmembers`,course  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND   `MEMBER_TYPE` =  'Teacher'")

        End If

        fillTable(dtglistofmember, "listofmembers")

        dtglistofmember.Columns(2).DefaultCellStyle.ForeColor = Color.Green
    End Sub

    Private Sub tlsteacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsteacher.Click
        tlsMessage.Text = "List of Employee(s)"
        member = "Teacher"
        txtSearch.Visible = True
        tslSearch.Visible = True
        dtglistofmember.BringToFront()
        addrow(dtglistofmember, "", "checkboxMember")

        jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                          " `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.', EMAIL AS Position, CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'ADVISORY' " & _
                          " FROM  `tblmembers`,course  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND   `MEMBER_TYPE` =  'Teacher'")


        fillTable(dtglistofmember, "listofEmployee")

        dtglistofmember.Columns(2).DefaultCellStyle.ForeColor = Color.Green
    End Sub

    Private Sub dtglistofmember_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtglistofmember.CellClick
        Dim columnIndex As Integer
        columnIndex = e.ColumnIndex

        If columnIndex = 0 Then

        Else
            With MemberProfile

                ' If 
                .lblText.Text = "Modify " & member & " Information"
                .Label17.Text = 1
                .txtmemberid.Text = dtglistofmember.CurrentRow.Cells(1).Value.ToString
                .btngenerate.Enabled = False
                If member = "Teacher" Then
                    .LblEmail.Visible = True
                    .txtemail.Visible = True
                End If
                If member = "Student" Then
                    .LblEmail.Visible = False
                    .txtemail.Visible = False
                End If
                .txtmemberid.Enabled = False
                .txtrfid.Enabled = True
                .Show()

            End With

        End If
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        member = "Teacher"
        MemberProfile.lblText.Text = "Register new Employee"
        MemberProfile.Show()
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        member = "Student"
        MemberProfile.lblText.Text = "Register new " & member
        MemberProfile.Show()

    End Sub

    Private Sub tlsGradelvel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsGradelvel.Click

        txtSearch.Visible = False
        tslSearch.Visible = False
        DataGridView1.BringToFront()
        tlsMessage.Text = "List of Grade levels"
        addrow(DataGridView1, "", "checkboxCourse")

        'ejbselect("select `COURSE_ID`, `COURSE_NAME` as Course, `COURSE_MAJOR` as Major, `COURSE_DESC` as Description, DEPARTMENT_DESC as Department FROM  `course` c,  `department` d WHERE c.`DEPT_ID` = d.`DEPT_ID` ORDER BY COURSE_NAME, COURSE_LEVEL")

        jokenfindthis("select `COURSE_ID`, `COURSE_NAME` as 'Grade level', `COURSE_MAJOR` as Section FROM  `course` ")
        fillTable(DataGridView1, "LoadCourses")

        DataGridView1.Columns(2).DefaultCellStyle.ForeColor = Color.Green

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim columnIndex As Integer
        columnIndex = e.ColumnIndex
        If columnIndex = 2 Then
            With newgradelvl

                .Show()

                courseID = DataGridView1.CurrentRow.Cells(1).Value.ToString
                .txtCourse.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
                .txtMajor.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
                .btnSave.Text = "Update"

            End With
        End If
    End Sub

    Private Sub AddGradeLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddGradeLevelToolStripMenuItem.Click
        newgradelvl.Show()
    End Sub


    Private Sub tlsBroadcast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsBroadcast.Click
        txtSearch.Visible = False
        tslSearch.Visible = False
        dtglistofbroadcst.BringToFront()
        tlsMessage.Text = "List of Broadcast Messages"
        jokenfindthis("SELECT  `MEMBERID` AS  'ID number',  `PARENTS_GUARDIAN` AS  'Contact of Parent/Guardian',  `MessageText` , CONCAT(  `COURSE_NAME` ,  '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL' " & _
                        "FROM  `messageout` l,  `tblmembers` m,  `course` c WHERE m.`MEMBERID` = l.`UserId` AND c.`COURSE_ID` = m.GRADELEVEL AND MessageType =  'Broadcast'")
        fillTable(dtglistofbroadcst, "broadcastlogs")
    End Sub

    Private Sub AddAnnouncementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddAnnouncementToolStripMenuItem.Click
        broadcast.Show()
    End Sub

    Private Sub SMSLogsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        Database.Show()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub tlsSMSlogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsSMSlogs.Click
        tlsMessage.Text = "List of SMS log Messages"
        txtSearch.Visible = False
        tslSearch.Visible = False
        DataGridView2.BringToFront()
        ' jokenfindthis("SELECT `sender` as 'ID number',`receiver` as 'Parent/Guardian' , `msg` as 'Message' , `senttime` 'Sent Time', `receivedtime` as 'Recieved Time', `status` Status, `errormsg` as 'Error Message' FROM `ozekimessageout")
        jokenfindthis("SELECT o.`MessageTo` , o.`MessageFrom` , o.`MessageText` ,  `SendTime` ,  o.`UserInfo` ,  `ErrorText` FROM  `messageout` o,  `messagelog` l WHERE o.`Id` = l.`Id` ")
        fillTable(DataGridView2, "smslogs")
    End Sub

    Private Sub txtSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Click
       
        txtSearch_TextChanged(sender, e)


    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged


        dtglistofmember.BringToFront()
        addrow(dtglistofmember, "", "checkboxMember")
        ' lblMember.Text = "List of " & member

        If member = "Student" Then
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                          " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',  `PARENTSSECONDARYNO` as 'Sec. No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL', RFID " & _
                          " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student'  AND  lname like '%" & txtSearch.Text & "%'")

            fillTable(dtglistofmember, "listofmembers")

            dtglistofmember.Columns(2).DefaultCellStyle.ForeColor = Color.Green
        ElseIf member = "Teacher" Then
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                       " `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.', EMAIL AS Position, CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'ADVISORY' " & _
                       " FROM  `tblmembers`,course  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND   `MEMBER_TYPE` =  'Teacher' AND  lname like '%" & txtSearch.Text & "%'")


            fillTable(dtglistofmember, "listofEmployee")

            dtglistofmember.Columns(2).DefaultCellStyle.ForeColor = Color.Green
            'jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
            '              " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',  `PARENTSSECONDARYNO` as 'Sec. No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'ADVISORY',RFID " & _
            '              " FROM  `tblmembers`,course  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND   `MEMBER_TYPE` =  'Teacher'  AND  lname like '%" & txtSearch.Text & "%'")

        End If

       
    End Sub

    Private Sub tlsDTR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsDTR.Click
        tlsMessage.Text = "List of DTR logs"
        txtSearch.Visible = False
        tslSearch.Visible = False
        DataGridView2.BringToFront()
        jokenfindthis("SELECT  `MEMBERID` AS  'ID No.',  `AMLOGIN` ,  `AMLOGOUT` ,  `PMLOGIN` ,  `PMLOGOUT` ,  `CURRENTDATE` FROM `tbldtr`  ORDER BY  `tbldtr`.`CURRENTDATE` DESC ")
        fillTable(DataGridView2, "dtr")
    End Sub

    Private Sub dbSetupConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Database.Show()
    End Sub

    Private Sub DefaultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultsToolStripMenuItem.Click
        defaults.Show()


    End Sub

    Private Sub ManageUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManageUserToolStripMenuItem.Click
        useraccounts.Show()

    End Sub

    Private Sub OthersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TLlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TLlogin.Click
        If TLlogin.Text = "Login" Then
            LoginForm1.Show()
        ElseIf TLlogin.Text = "Connect Now!" Then
            Database.Show()
        Else
            TLlogin.Text = "Login"
            TLlogin.Image = SMSMYSQL.My.Resources.Login
            TSUser.Text = "Hi, Guest!"

            disabledmenu()
            DataGridView2.BringToFront()
            DataGridView2.DataSource = Nothing
            tlsMessage.Text = "l"
            txtSearch.Visible = False
            tslSearch.Visible = False

        End If

    End Sub

    Private Sub EcondaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Restart()

    End Sub

    Private Sub ActionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActionToolStripMenuItem.Click

    End Sub

   
    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        MsgBox("contact me @ http://itsourcecode.com/contact-us/")
    End Sub

    Private Sub tlsreports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlsreports.Click
        dtr.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class