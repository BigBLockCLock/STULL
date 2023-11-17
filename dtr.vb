
Public Class dtr
    Dim dtrkey As String
    Dim id As String
    Dim paramstrng As String = ""

    Private Sub dtr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        jokenfindthis("select COURSE_ID, CONCAT(  `COURSE_NAME` ,  ' - ',  `COURSE_MAJOR` ) AS GRADELVL from course")
        fillcombo(cbgradelvl, "GRADELVL", "COURSE_ID")

    End Sub
    
   
    Private Sub dtgmaster_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgmaster.CellClick
        Dim i As String = dtgmaster.CurrentRow.Cells(0).Value.ToString
        id = i
        'jokenfindthis("SELECT `sender` as 'ID number',`receiver` as 'Parent/Guardian' , `msg` as 'Message' , `senttime` 'Sent Time', `receivedtime` as 'Recieved Time', `status` Status, `errormsg` as 'Error Message' FROM ozekimessageout where sender='" & i & "'")
        'fillTable(dtgslave, "smslogs")
        If dtrkey = "studentdtrlogs" Then
            jokenfindthis("SELECT d.`MEMBERID` ,  `AMLOGIN` ,  `AMLOGOUT` ,  `PMLOGIN` ,  `PMLOGOUT` ,  `CURRENTDATE` " & _
                    " FROM  `tbldtr` d,  `tblmembers` m " & _
                    " WHERE d.`MEMBERID` = m.`MEMBERID` " & _
                    " and m.`MEMBERID`= '" & i & "'")
            fillTable(dtgslave, "StudentDTRLogs")
        ElseIf dtrkey = "Employeedtrlogs" Then

            jokenfindthis("SELECT d.`MEMBERID` ,  `AMLOGIN` ,  `AMLOGOUT` ,  `PMLOGIN` ,  `PMLOGOUT` ,  `CURRENTDATE` , TIMEDIFF( '7:30',  `AMLOGIN` ) AS LATE" & _
                        " FROM  `tbldtr` d,  `tblmembers` m " & _
                        " WHERE d.`MEMBERID` = m.`MEMBERID` " & _
                        " AND  `MEMBER_TYPE` =  'Teacher'  and m.`MEMBERID`= '" & i & "'")
            fillTable(dtgslave, "TeacherDTRLogs")
        ElseIf dtrkey = "studentSMSlogs" Then
            jokenfindthis("SELECT  `MessageTo` ,  `MessageText` ,  `MessageType` ,  `PARENTS_GUARDIAN` as 'Parent/Guardian' " & _
                            " FROM  `messageout` m, tblmembers t " & _
                            " WHERE t.`MEMBERID` = m.UserID " & _
                            " AND  `MEMBER_TYPE` =  'Student' and t.`MEMBERID`= '" & i & "'")
            fillTable(dtgslave, "smslogs")
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                         " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL' " & _
                         " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student' AND GRADELEVEL= " & cbgradelvl.SelectedValue & "")
        fillTable(dtgmaster, "studentdtr")
        paramstrng = "SudentbyAdvisory"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Rad1.Checked = True Then
            paramstrng = "StudentDtr"
            dtgslave.DataSource = Nothing
            dtrkey = "studentdtrlogs"
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                              " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL' " & _
                              " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student'")

            fillTable(dtgmaster, "studentdtr")
            GrpList.Text = "List of Student"
            GrpRecords.Text = "DTR of Selected Student from the list"
            btnprint.Enabled = True
        ElseIf Rad2.Checked = True Then
            paramstrng = "EmployeeDtr"
            dtgslave.DataSource = Nothing
            dtrkey = "Employeedtrlogs"
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                           " `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.', EMAIL AS Position" & _
                           " FROM  `tblmembers`,course  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND   `MEMBER_TYPE` =  'Teacher'")
            fillTable(dtgmaster, "DTREmployee")
            GrpList.Text = "List of Employee"
            GrpRecords.Text = "DTR of Selected Employee from the list"
            btnprint.Enabled = True
        ElseIf Rad3.Checked = True Then
            dtgslave.DataSource = Nothing
            dtrkey = "studentSMSlogs"
            jokenfindthis("SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                              " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL' " & _
                              " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student'")
            fillTable(dtgmaster, "studentdtr")
            GrpList.Text = "List of Student"
            GrpRecords.Text = "SMS Logs of Selected Student from the list"
            btnprint.Enabled = False
        ElseIf Rad4.Checked = True Then
            dtgslave.DataSource = Nothing
            jokenfindthis("SELECT  `MEMBERID` AS  'ID number',  `PARENTS_GUARDIAN` AS  'Contact of Parent/Guardian',  `MessageText` , CONCAT(  `COURSE_NAME` ,  '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL' " & _
                        "FROM  `messageout` l,  `tblmembers` m,  `course` c WHERE m.`MEMBERID` = l.`UserId` AND c.`COURSE_ID` = m.GRADELEVEL AND MessageType =  'Broadcast'")
            fillTable(dtgmaster, "broadcastlogs")
            GrpList.Text = "List of Student"
            GrpRecords.Text = "SMS Logs of Selected Student from the list"
            btnprint.Enabled = False
        Else
            MsgBox("Please filter reports!")
            btnprint.Enabled = False
        End If
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

        If paramstrng = "StudentDtr" Then
            reportname = "CrystalReport1"
            reportselect = "SELECT tblmembers.`MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name,  `PARENTS_GUARDIAN` AS  'Parent/Guardian',  `PARENTS_MOBILE`  'Parent Contac No.',  `AMLOGIN` ,  `AMLOGOUT` ,  `PMLOGIN` ,  `PMLOGOUT` ,  `CURRENTDATE` " & _
                            "FROM  `tblmembers` ,  `course` , tbldtr " & _
                            "WHERE tblmembers.GRADELEVEL = course.`COURSE_ID`  " & _
                            "AND  `MEMBER_TYPE` =  'Student' " & _
                            "AND tbldtr.`MEMBERID` = tblmembers.`MEMBERID`  " & _
                            "AND tblmembers.`MEMBERID` =  '" & id & "'"
            frmReports.Show()
        ElseIf paramstrng = "EmployeeDtr" Then
            reportname = "EmployeeDTR"
            reportselect = "SELECT tblmembers.`MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name,  `PARENTS_GUARDIAN` AS  'Parent/Guardian',  `PARENTS_MOBILE`  'Parent Contac No.',`EMAIL` , `AMLOGIN` , `AMLOGOUT` ,  `PMLOGIN` ,  `PMLOGOUT` , TIMEDIFF( '7:30',  `AMLOGIN` ) AS LATE, `CURRENTDATE` " & _
                            "FROM  `tblmembers` ,  `course` , tbldtr " & _
                            "WHERE tblmembers.GRADELEVEL = course.`COURSE_ID`  " & _
                            "AND  `MEMBER_TYPE` =  'Teacher' " & _
                            "AND tbldtr.`MEMBERID` = tblmembers.`MEMBERID` " & _
                             "AND tblmembers.`MEMBERID` =  '" & id & "'"
            frmReports.Show()
        ElseIf paramstrng = "SudentbyAdvisory" Then
            reportname = "StudSMSLogs"
            reportselect = "SELECT  `MEMBERID` AS  'ID No.', CONCAT( UPPER( lname ) ,  ', ', UPPER( fname ) ,  ' ', UPPER( LEFT(  `MNAME` , 1 ) ) ,  '.' ) AS Name, " & _
                         " `MOBILENO` AS Contact,  `PARENTS_GUARDIAN` as 'Parent/Guardian',  `PARENTS_MOBILE` 'Parent Contac No.',`STATUS` , CONCAT(  `COURSE_NAME` , '- ',  `COURSE_MAJOR` ) AS  'GRADE LEVEL' " & _
                         " FROM  `tblmembers` ,  `course`  WHERE tblmembers.GRADELEVEL = course.`COURSE_ID` AND  `MEMBER_TYPE` =  'Student' AND GRADELEVEL= " & cbgradelvl.SelectedValue & ""
            frmReports.Show()
        End If
      




    End Sub
End Class