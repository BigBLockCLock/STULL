Imports MySql.Data.MySqlClient
Module jokenselectstatements
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter

    Dim sql As String

    Public Sub jokenfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
           
        End Try
        con.Close()
        da.Dispose()

    End Sub

    Public Function DefaultResult() As Boolean
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then
                ' MsgBox("Not empty")
                Return True
            Else
                ' MsgBox("empty")
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub fillpicbox(ByVal picimage As Object)

        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Function CHECCKLOGS(ByVal MEMBERID As String) As Boolean

        Dim RESULTTABLE As New DataTable

        If AMPM = "AM" Then
            '  MsgBox("iTS am")
            jokenfindthis("SELECT `DTRID`, `MEMBERID`, TIME_FORMAT(  `AMLOGIN` ,  '%H:%i:%s' ) AS TIME,`AMLOGOUT`, `PMLOGIN`, `PMLOGOUT`, `CURRENTDATE` FROM  `tbldtr` WHERE MEMBERID = '" & MEMBERID & "' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "'")
            Try
                da.SelectCommand = cmd
                da.Fill(RESULTTABLE)
                If RESULTTABLE.Rows.Count > 0 Then
                    Dim res As Integer
                    Dim d1 As Date = TimeOfDay
                    'Dim gettime As Date = RESULTTABLE.Rows(0).Item(2)
                    'Dim 
                    Dim gettime As Date = RESULTTABLE.Rows(0).Item(2)
                    res = DateDiff(DateInterval.Minute, gettime, d1)
                    If res > 15 Then
                        Return UPDATE_AM_OUT()


                    End If


                Else
                    'RECORD NOT EXIST DO INSERT A RECORD
                    Return AM_IN()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        If AMPM = "PM" Then

            jokenfindthis("SELECT * FROM tbldtr WHERE MEMBERID = '" & MEMBERID & "' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "' ")
            Try
                da.SelectCommand = cmd
                da.Fill(RESULTTABLE)

                If RESULTTABLE.Rows.Count > 0 Then
                    'RECORD ALREADY EXIST AND DO UPDATE THE RECORD
                    Return CHECK_PM_IN(MEMBERID)

                Else
                    'RECORD NOT EXIST DO INSERT A RECORD
                    Return PM_IN()

                    ' sendmessage(MEMBERID)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'con.Close()
    End Function
    Public Sub testlang()

        Dim RESULTTABLE As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(RESULTTABLE)
            If RESULTTABLE.Rows.Count > 0 Then
                MsgBox("ara")

                 Dim gettime As Date = RESULTTABLE.Rows(0).Item(2)
                  Dim res As Integer
                Dim d1 As Date = TimeOfDay
                MsgBox(gettime)
                   res = DateDiff(DateInterval.Minute, gettime, d1)
                MsgBox(res)
            Else
                MsgBox("Wla")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function CHECK_PM_IN(ByVal MEMBERID As String) As Boolean
        Dim RES As New DataTable
        jokenfindthis("SELECT `DTRID`, `MEMBERID`, TIME_FORMAT(  `AMLOGIN` ,  '%H:%i:%s' ) AS TIME,`AMLOGOUT`, TIME_FORMAT(`PMLOGIN`, '%H:%i:%s' ) as PMIN, `PMLOGOUT`, `CURRENTDATE`  FROM tbldtr WHERE MEMBERID = '" & ALLID & "' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "' AND PMLOGIN !='00:00:00' ")
        Try
            da.SelectCommand = cmd
            da.Fill(RES)

            If RES.Rows.Count > 0 Then
                'dri na 
                Dim resMin As Integer
                Dim d1 As Date = TimeOfDay

                Dim gettime As Date = RES.Rows(0).Item(4)
                resMin = DateDiff(DateInterval.Minute, gettime, d1)

                If resMin > 15 Then
                    Return PM_OUT()

                End If

            Else
                Return UPDATE_EXIST_PM()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Public Function PM_IN() As Boolean
        Dim result As Integer
        Try
            con.Open()
            sql = "INSERT INTO `atmsdb`.`tbldtr` (`MEMBERID`, `PMLOGIN`,`CURRENTDATE`) VALUES(@MEMBERID, @PMLOGIN, @CURRENTDATE)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@MEMBERID", ALLID)
            cmd.Parameters.AddWithValue("@PMLOGIN", ATMS.StatLbltime.Text)
            cmd.Parameters.AddWithValue("@CURRENTDATE", Date.Today)
            result = cmd.ExecuteNonQuery()

            If result = 0 Then
                Return False
            Else
                message = " Time in: "
                Return True

            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function
    Public Function AM_IN() As Boolean
        Dim result As Integer
        Try
            con.Open()
            sql = "INSERT INTO `atmsdb`.`tbldtr` (`MEMBERID`, `AMLOGIN`,`CURRENTDATE`) VALUES(@MEMBERID, @AMLOGIN, @CURRENTDATE)"
            cmd = New MySqlCommand(sql, con)
            With ATMS
                cmd.Parameters.AddWithValue("@MEMBERID", ALLID)
                cmd.Parameters.AddWithValue("@AMLOGIN", .StatLbltime.Text)
                cmd.Parameters.AddWithValue("@CURRENTDATE", Date.Today)
                result = cmd.ExecuteNonQuery()

                If result = 0 Then
                    Return False
                Else
                    message = " Time in: "
                    Return True
                End If

            End With

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function UPDATE_AM_OUT() As Boolean
        Dim result As Integer
        Try
            con.Open()

            sql = "UPDATE `tbldtr` SET AMLOGOUT=@AMLOGOUT WHERE MEMBERID='" & ALLID & "' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "' AND AMLOGOUT='00:00:00'"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@AMLOGOUT", ATMS.StatLbltime.Text)
            result = cmd.ExecuteNonQuery()

            If result = 0 Then
                Return False
            Else
                message = " Time out: "
                Return True

            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function PM_OUT() As Boolean
        Dim result As Integer
        Try
            con.Open()
            sql = "UPDATE `tbldtr` SET PMLOGOUT=@PMLOGOUT WHERE MEMBERID='" & ALLID & "' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "' AND PMLOGOUT='00:00:00'"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@PMLOGOUT", ATMS.StatLbltime.Text)
            result = cmd.ExecuteNonQuery()

            If result = 0 Then
                Return False
            Else
                message = " Time out: "
                Return True

            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Function UPDATE_EXIST_PM() As Boolean
        Dim result As Integer
        Try
            con.Open()
            sql = "UPDATE `tbldtr` SET PMLOGIN=@PMLOGIN WHERE MEMBERID='" & ALLID & "' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@PMLOGIN", ATMS.StatLbltime.Text)
            result = cmd.ExecuteNonQuery()

            If result = 0 Then
                Return False
            Else
                message = " Time in: "
                Return True

            End If


            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
   

    Public Sub filldata(ByVal picimage As Object, ByVal Calledffrom As String)
        Dim arrImage() As Byte
        Dim publictable As New DataTable
        Dim logResult As Boolean

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)

            Select Case Calledffrom


                Case "Main"
                    With ATMS
                        If publictable.Rows.Count > 0 Then


                            'logResult = CHECCKLOGS(.txtsearchid.Text)
                            ALLID = publictable.Rows(0).Item(0)

                            .btnIDNO.Text = "ID Number: " & publictable.Rows(0).Item(0)
                            .btnname.Text = "Name: " & publictable.Rows(0).Item(1)

                            .btnemail.Text = "Position: " & publictable.Rows(0).Item(3)
                            Dim gradeposition As String = publictable.Rows(0).Item(10)

                            'If gradeposition = "Teacher" Then
                            '    .btnemail.Text = "Position : Faculty"
                            If gradeposition = "Student" Then
                                .btnemail.Text = "Grade Level :" & publictable.Rows(0).Item(8)
                            End If

                            .btncontactperson.Text = "Contact Person: " & publictable.Rows(0).Item(4)
                            .btnNoofContactperson.Text = "No. of Contact person: " & publictable.Rows(0).Item(5)
                            membername = publictable.Rows(0).Item(1)
                            reciever = publictable.Rows(0).Item(5)

                            arrImage = publictable.Rows(0).Item(9)
                            Dim mstream As New System.IO.MemoryStream(arrImage)
                            picimage.Image = Image.FromStream(mstream)

                            .lblmsg.Text = "Your attendance is successfully recorded!"
                            .Panel4.BackColor = Color.PaleTurquoise
                            .lblmsg.BackColor = Color.PaleTurquoise
                            .lblmsg.ForeColor = Color.Blue
                            .picsuccess.BringToFront()
                            .picfailed.SendToBack()
                            .Panel4.Show()
                            ' MsgBox(ALLID)
                            logResult = CHECCKLOGS(ALLID)

                            If logResult = True Then

                                 If reciever = "" Then
                                    reciever = "+6391234567"
                                    ATMS.MsgStats.Text = "Message Status: Invvalid Mobile number!"
                                Else

                                    Dim result As Integer
                                    Try

                                        sql = "INSERT INTO  messageout (MessageTo, MessageText,UserId) VALUES(@MessageTo, @MessageText,@UserId)"
                                        cmd = New MySqlCommand(sql, con)
                                        With ATMS
                                            cmd.Parameters.AddWithValue("@MessageTo", reciever)
                                            cmd.Parameters.AddWithValue("@MessageText", membername & message & ATMS.StatLbltime.Text)
                                            cmd.Parameters.AddWithValue("@UserId", ALLID)
                                            result = cmd.ExecuteNonQuery()
                                            If result = 0 Then
                                                ATMS.MsgStats.Text = "Message Status: Not Sent!"
                                            Else

                                                ATMS.MsgStats.Text = "Message Status: Sent!"
                                            End If
                                        End With


                                    Catch ex As Exception
                                        MsgBox(ex.Message)
                                    End Try
                                End If

                            End If
                           

                        Else

                            .btnIDNO.Text = "ID Number: "
                            .btnname.Text = "Name: "
                            .btnemail.Text = "Email: "
                            .btncontactperson.Text = "Contact Person: "
                            .btnNoofContactperson.Text = "No. of Contact person: "
                            .lblmsg.Text = "Error in Logging in!"
                            .Panel4.BackColor = Color.LemonChiffon
                            .lblmsg.BackColor = Color.LemonChiffon
                            .lblmsg.ForeColor = Color.Red
                            .picsuccess.SendToBack()
                            .picfailed.BringToFront()
                            .Panel4.Show()


                        End If
                    End With


                Case "Member"
                   
                    With MemberProfile
                        .tbxlastname.Text = publictable.Rows(0).Item(1)
                        .tbxfirstname.Text = publictable.Rows(0).Item(2)
                        .tbxmiddlename.Text = publictable.Rows(0).Item(3)
                        .txtmmberadress.Text = publictable.Rows(0).Item(4)
                        .txtemail.Text = publictable.Rows(0).Item(5)
                        .txtstudmobile.Text = publictable.Rows(0).Item(6)
                        .txtparents.Text = publictable.Rows(0).Item(7)
                        .txtparentsContact.Text = publictable.Rows(0).Item(8)
                        .txtparentsSecContact.Text = publictable.Rows(0).Item(9)
                        .txtparentAdress.Text = publictable.Rows(0).Item(10)
                        arrImage = publictable.Rows(0).Item(13)
                        Dim mstream As New System.IO.MemoryStream(arrImage)
                        picimage.Image = Image.FromStream(mstream)

                        Dim STATS As String = publictable.Rows(0).Item(11)

                        If STATS = "Active" Then
                            .radactive.Checked = True
                            .radnotactive.Checked = False
                        ElseIf STATS = "Not Active" Then
                            .radactive.Checked = False
                            .radnotactive.Checked = True
                        End If
                        Dim GRADELEVEL As Integer = publictable.Rows(0).Item(12)
                        '   member = publictable.Rows(0).Item(14)
                        jokenfindthis("select COURSE_ID, CONCAT(  `COURSE_NAME` ,  ' - ',  `COURSE_MAJOR` ) AS GRADELVL from course")
                        'fillcombo(.cbgradelvl, "GRADELVL", "COURSE_ID")
                        fillcombowithSelectedvalue(.cbgradelvl, "GRADELVL", "COURSE_ID", GRADELEVEL)
                        .txtrfid.Text = publictable.Rows(0).Item(16)

                    End With

            End Select

            da.Dispose()
            con.Close()
            
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        

            ATMS.txtsearchid.Text = Nothing
    End Sub
    Public Sub broadcastmessage()
        Dim res As New DataTable


        Try
            da.SelectCommand = cmd
            da.Fill(res)

            If res.Rows.Count > 0 Then
                ' broadcast.txtreccipient.Text = res.Rows(0).Item(0)

            Else
                broadcast.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub broadcastmessageloop()
        Dim res As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(res)

            If res.Rows.Count > 0 Then
                'broadcast.txtreccipient.Text = res.Rows(0).Item(0)
                'For Each res .Rows (0).Item (0) as string
                For Each row As DataRow In res.Rows
                    ' MsgBox(row.Item(0))
                    Dim Broadcstreciever As String = row.Item(1)
                    If Broadcstreciever = "" Then
                        Broadcstreciever = "+6391234567"
                    Else
                         Try
                            con.Open()
                            Dim result As Integer
                            sql = "INSERT INTO  messageout (MessageTo, MessageText,UserId,MessageType) VALUES(@MessageTo, @MessageText,@UserId,@MessageType)"
                            cmd = New MySqlCommand(sql, con)
                            With ATMS
                                cmd.Parameters.AddWithValue("@MessageTo", Broadcstreciever)
                                cmd.Parameters.AddWithValue("@MessageText", broadcast.txtmsg.Text)
                                cmd.Parameters.AddWithValue("@UserId", row.Item(0))
                                cmd.Parameters.AddWithValue("@MessageType", "Broadcast")
                                result = cmd.ExecuteNonQuery()
                            End With
                            con.Close()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try


                    End If

                  Next row
                MsgBox("All message is on the process of sending!")
                broadcast.Close()
             Else
                broadcast.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub fillcombo(ByVal combo As Object, ByVal member As String, ByVal idparam As String)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            With combo
                .DataSource = publictable
                .displaymember = member
                .valuemember = idparam
            End With

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub fillcombowithSelectedvalue(ByVal combo As Object, ByVal member As String, ByVal idparam As String, ByVal i As Integer)
        Dim publictable As New DataTable
        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            With combo
                .DataSource = publictable
                .displaymember = member
                .valuemember = idparam
                .selectedvalue = i
            End With

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub fillTable(ByVal dtgrd As Object, ByVal design As String)
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable

            Select Case design

                Case "listofmembers"
                    dtgrd.Columns(0).visible = False
                    dtgrd.Columns(0).width = 30
                    dtgrd.Columns(1).width = 130
                    dtgrd.Columns(2).width = 200
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 150
                    dtgrd.Columns(5).width = 130
                    'dtgrd.Columns(6).width = 120
                    'dtgrd.Columns(7).width = 100
                    dtgrd.Columns(8).width = 150
                    dtgrd.columns(6).visible = False
                    dtgrd.columns(7).visible = False
                    dtgrd.columns(9).visible = False
                Case "listofEmployee"
                    dtgrd.Columns(0).visible = False
                    dtgrd.Columns(0).width = 30
                    dtgrd.Columns(1).width = 130
                    dtgrd.Columns(2).width = 200
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 150
                    dtgrd.Columns(5).width = 130
                    dtgrd.Columns(6).width = 120
                    'dtgrd.Columns(7).width = 100
                    ' dtgrd.Columns(8).width = 150
                    'dtgrd.columns(6).visible = False
                    'dtgrd.columns(7).visible = False
                    'dtgrd.columns(9).visible = False
                Case "listofm"
                    dtgrd.Columns(0).width = 30
                    dtgrd.Columns(1).width = 100
                    dtgrd.Columns(2).width = 200
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 150
                    dtgrd.Columns(5).width = 130
                Case "LoadCourses"
                    dtgrd.Columns(0).width = 30
                    dtgrd.Columns(1).visible = False
                    dtgrd.Columns(2).width = 200
                    dtgrd.Columns(3).width = 200

                Case "studentdtr"
                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).width = 180
                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 120
                    dtgrd.Columns(5).width = 70
                    dtgrd.Columns(6).width = 130
                Case "DTREmployee"

                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).width = 180
                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 150
                    dtgrd.Columns(4).width = 120
                    'dtgrd.Columns(5).width = 70
                    'dtgrd.Columns(6).width = 130

                Case "defaults"
                    dtgrd.Columns(0).Visible = False
                    dtgrd.Columns(1).Visible = False
                    dtgrd.Columns(2).Visible = False
               
                Case "smslogs"
                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).width = 300
                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 100


                Case "StudentDTRLogs"
                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).visible = 100
                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 130
                    dtgrd.Columns(5).width = 100
                Case "TeachertDTRLogs"
                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).visible = 100
                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 130
                    dtgrd.Columns(5).width = 100
                    dtgrd.Columns(6).width = 100
                Case "dtr"
                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).width = 100
                    dtgrd.Columns(2).width = 100
                    dtgrd.Columns(3).width = 100
                    dtgrd.Columns(4).width = 100
                    dtgrd.Columns(5).width = 100
                Case "broadcastlogs"
                    dtgrd.Columns(0).width = 100
                    dtgrd.Columns(1).width = 200
                    dtgrd.Columns(2).width = 400
                    dtgrd.Columns(3).width = 150

                Case "LoadUser"
                    dtgrd.Columns(0).Visible = False
                    dtgrd.Columns(4).Visible = False

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function isemptyresult() As Integer
        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Return table.Rows(0).Item(0)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function
    Public Sub CheckResult(ByVal CaseResult As String)

        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)

            If table.Rows.Count > 0 Then

                Select Case CaseResult
                    Case "login"

                        usersname = table.Rows(0).Item(1)
                        usertype = table.Rows(0).Item(4)

                        If usertype = "Administrator" Then
                            Main.TSUser.Text = "Welcome, " & usersname
                            enabledmenu("Admin")


                        ElseIf usertype = "Encoder" Then
                            Main.TSUser.Text = "Welcoome, " & usersname
                            enabledmenu("encoder")
                        End If


                    Case "isdefaultay"
                        MemberProfile.lblAY.Text = table.Rows(0).Item(0)
                    Case "maindefault"
                        ATMS.lblAY.Text = table.Rows(0).Item(0)
                    Case "memberid"
                        Dim apptext As String = "SRIA-442580-"
                        varDate = table.Rows(0).Item(0)
                        MemberProfile.txtmemberid.Text = apptext & varDate
                        
                End Select

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub enabledmenu(ByVal who As String)

        Select who

            Case "Admin"
                With Main
                    .TLlogin.Image = SMSMYSQL.My.Resources.log_out
                    .TLlogin.Text = "Logout"
                   
                    'Home
                    .tlsATMS.Enabled = True
                    .tlsteacher.Enabled = True
                    .tlsStudent.Enabled = True
                    .tlsBroadcast.Enabled = True
                    .tlsDTR.Enabled = True
                    .tlsSMSlogs.Enabled = True
                    .tlsGradelvel.Enabled = True
                    .ActionToolStripMenuItem.Enabled = True
                    .SettingsToolStripMenuItem.Enabled = True
                    .tlsreports.Enabled = True
                    'Entry
                
                   
                End With
            Case "encoder"
                With Main
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
                End With
        End Select

    End Sub

    Public Sub disabledmenu()
        With Main
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

            'Entry


        End With


    End Sub

    Public Sub addrow(ByVal dtgrd As Object, ByVal headtxt As String, ByVal design As String)
        Try
            Select Case design

                Case "checkboxCourse"
                    checkboxcolumnDeleteCreditSubjects.HeaderText = headtxt
                    Main.DataGridView1.Columns.Add(checkboxcolumnDeleteCreditSubjects)

                Case "checkboxMember"
                    checkboxcolumnDeleteMembers.HeaderText = headtxt
                    Main.dtglistofmember.Columns.Add(checkboxcolumnDeleteMembers)

            End Select
        Catch ex As Exception

        End Try

    End Sub
    Public Sub loadgradelvl()

        With Main
            .txtSearch.Visible = False
            .tslSearch.Visible = False
            .DataGridView1.BringToFront()
            .tlsMessage.Text = "List of Grade levels"
            addrow(.DataGridView1, "", "checkboxCourse")
            jokenfindthis("select `COURSE_ID`, `COURSE_NAME` as 'Grade level', `COURSE_MAJOR` as Section FROM  `course` ")
            fillTable(.DataGridView1, "LoadCourses")
            .DataGridView1.Columns(2).DefaultCellStyle.ForeColor = Color.Green
            '  .Close()

        End With


    End Sub
    Public Sub ClearAll(ByVal group As Object, ByVal what As String)

        Select Case what

            Case "UserAccounts"
                For Each ctrl As Control In group.Controls
                    If ctrl.GetType Is GetType(TextBox) Then
                        ctrl.Text = Nothing
                    End If
                Next



            Case "Rooms"
                For Each ctrl As Control In group.Controls
                    If ctrl.GetType Is GetType(TextBox) Then
                        ctrl.Text = Nothing
                    End If
                Next



        End Select



    End Sub
End Module
