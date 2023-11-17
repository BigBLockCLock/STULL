Imports MySql.Data.MySqlClient
Public Class Form3
    'Dim cmd As New MySqlCommand
    'Dim da As New MySqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        jokenfindthis("SELECT `DTRID`, `MEMBERID`, TIME_FORMAT(  `AMLOGIN` ,  '%H:%i:%s' ) AS TIME,`AMLOGOUT`, `PMLOGIN`, `PMLOGOUT`, `CURRENTDATE` FROM  `tbldtr`  WHERE MEMBERID = '222' AND CURRENTDATE ='" & Format(Now, "yyyy-MM-dd") & "'")
        testlang()
      

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            ' ProgressBar1.Value = 0
            Timer1.Stop()
            Label1.Text = "All components has been loaded successfully..."

        Else
            If ProgressBar1.Value = 0 Then
                Label1.Text = "Initializing ..."
            ElseIf ProgressBar1.Value = 20 Then
                Label1.Text = "Please wait while preparing Components..."
            ElseIf ProgressBar1.Value = 50 Then
                Label1.Text = "Loading Components..."
            ElseIf ProgressBar1.Value = 90 Then
                Label1.Text = "Almost done loading components..."
            End If
            ProgressBar1.Value += 1
            Label2.Text = ProgressBar1.Value
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Start()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ' MsgBox(System.DateTime.Now.ToString("h:m:s"))
        ' MsgBox(My.Computer.Clock.LocalTime.ToLongTimeString)
        ' MsgBox(DateTime.Now.ToString("H:mm:ss tt"))
        jokeninsert("INSERT INTO messageout (MessageTo, MessageText,UserId) VALUES ('reciever','message time','123123');")

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Button6.Text = Date.Now.ToString("H:mm:ss")

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim FILE_NAME As String = "C:\Users\joken\Documents\config.txt"
        
        Dim i As Integer
        Dim aryText(4) As String

        aryText(0) = TextBox1.Text
        aryText(1) = TextBox2.Text
        aryText(2) = TextBox3.Text
        aryText(3) = TextBox4.Text


        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

        For i = 0 To 4

            objWriter.WriteLine(aryText(i))

        Next

        objWriter.Close()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
    
        Dim FILE_NAME As String = "C:\Users\joken\Documents\config.txt"


        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            ' Do While objReader.Peek() <> -1

            'objReader.ReadLine()

            'Loop

            TextBox1.Text = objReader.ReadLine()
            TextBox2.Text = objReader.ReadLine() & vbNewLine
            TextBox3.Text = objReader.ReadLine() & vbNewLine & vbNewLine
            TextBox4.Text = objReader.ReadLine() & vbNewLine & vbNewLine & vbNewLine



        Else

            MsgBox("File Does Not Exist")

        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        OpenFileDialog1.ShowDialog()

        'FolderBrowserDialog1.ShowDialog()

        clickme.Text = "Logout button is clicked!"
        PictureBox1.Image = SMSMYSQL.My.Resources.log_out
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        clickme.Text = "Login button is clicked!"
        PictureBox1.Image = SMSMYSQL.My.Resources.Login
    End Sub
End Class