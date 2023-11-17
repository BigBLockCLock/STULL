<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dtr
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnprint = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbgradelvl = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btngo = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Date1 = New System.Windows.Forms.DateTimePicker
        Me.Date2 = New System.Windows.Forms.DateTimePicker
        Me.Rad4 = New System.Windows.Forms.RadioButton
        Me.Rad3 = New System.Windows.Forms.RadioButton
        Me.Rad2 = New System.Windows.Forms.RadioButton
        Me.Rad1 = New System.Windows.Forms.RadioButton
        Me.Button4 = New System.Windows.Forms.Button
        Me.dtgmaster = New System.Windows.Forms.DataGridView
        Me.dtgslave = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GrpList = New System.Windows.Forms.GroupBox
        Me.GrpRecords = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtgmaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgslave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GrpList.SuspendLayout()
        Me.GrpRecords.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 547)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.btnprint)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Rad4)
        Me.GroupBox1.Controls.Add(Me.Rad3)
        Me.GroupBox1.Controls.Add(Me.Rad2)
        Me.GroupBox1.Controls.Add(Me.Rad1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 545)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Filter"
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.White
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.ForeColor = System.Drawing.Color.Black
        Me.btnprint.Location = New System.Drawing.Point(15, 215)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(195, 26)
        Me.btnprint.TabIndex = 44
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbgradelvl)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(207, 62)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Filter by Advisory"
        '
        'cbgradelvl
        '
        Me.cbgradelvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbgradelvl.FormattingEnabled = True
        Me.cbgradelvl.Location = New System.Drawing.Point(6, 30)
        Me.cbgradelvl.Name = "cbgradelvl"
        Me.cbgradelvl.Size = New System.Drawing.Size(143, 23)
        Me.cbgradelvl.TabIndex = 30
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(158, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(43, 23)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Go"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btngo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Date1)
        Me.GroupBox2.Controls.Add(Me.Date2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 137)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter By Date"
        Me.GroupBox2.Visible = False
        '
        'btngo
        '
        Me.btngo.BackColor = System.Drawing.Color.White
        Me.btngo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btngo.ForeColor = System.Drawing.Color.Black
        Me.btngo.Location = New System.Drawing.Point(62, 100)
        Me.btngo.Name = "btngo"
        Me.btngo.Size = New System.Drawing.Size(94, 23)
        Me.btngo.TabIndex = 8
        Me.btngo.Text = "Go"
        Me.btngo.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Date To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Date From:"
        '
        'Date1
        '
        Me.Date1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date1.Location = New System.Drawing.Point(10, 35)
        Me.Date1.Name = "Date1"
        Me.Date1.Size = New System.Drawing.Size(194, 20)
        Me.Date1.TabIndex = 4
        '
        'Date2
        '
        Me.Date2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date2.Location = New System.Drawing.Point(10, 74)
        Me.Date2.Name = "Date2"
        Me.Date2.Size = New System.Drawing.Size(194, 20)
        Me.Date2.TabIndex = 5
        '
        'Rad4
        '
        Me.Rad4.AutoSize = True
        Me.Rad4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad4.Location = New System.Drawing.Point(23, 89)
        Me.Rad4.Name = "Rad4"
        Me.Rad4.Size = New System.Drawing.Size(155, 20)
        Me.Rad4.TabIndex = 41
        Me.Rad4.TabStop = True
        Me.Rad4.Text = "Broadcast Messages"
        Me.Rad4.UseVisualStyleBackColor = True
        '
        'Rad3
        '
        Me.Rad3.AutoSize = True
        Me.Rad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad3.Location = New System.Drawing.Point(23, 66)
        Me.Rad3.Name = "Rad3"
        Me.Rad3.Size = New System.Drawing.Size(161, 20)
        Me.Rad3.TabIndex = 40
        Me.Rad3.TabStop = True
        Me.Rad3.Text = "SMS Logs by Students"
        Me.Rad3.UseVisualStyleBackColor = True
        '
        'Rad2
        '
        Me.Rad2.AutoSize = True
        Me.Rad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad2.Location = New System.Drawing.Point(23, 43)
        Me.Rad2.Name = "Rad2"
        Me.Rad2.Size = New System.Drawing.Size(171, 20)
        Me.Rad2.TabIndex = 39
        Me.Rad2.TabStop = True
        Me.Rad2.Text = "DTR Logs by Employee"
        Me.Rad2.UseVisualStyleBackColor = True
        '
        'Rad1
        '
        Me.Rad1.AutoSize = True
        Me.Rad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rad1.Location = New System.Drawing.Point(23, 17)
        Me.Rad1.Name = "Rad1"
        Me.Rad1.Size = New System.Drawing.Size(161, 20)
        Me.Rad1.TabIndex = 38
        Me.Rad1.TabStop = True
        Me.Rad1.Text = "DTR Logs by Students"
        Me.Rad1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(68, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 26)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "Go"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'dtgmaster
        '
        Me.dtgmaster.AllowUserToAddRows = False
        Me.dtgmaster.AllowUserToDeleteRows = False
        Me.dtgmaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgmaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgmaster.Location = New System.Drawing.Point(6, 19)
        Me.dtgmaster.Name = "dtgmaster"
        Me.dtgmaster.ReadOnly = True
        Me.dtgmaster.RowHeadersVisible = False
        Me.dtgmaster.Size = New System.Drawing.Size(811, 208)
        Me.dtgmaster.TabIndex = 0
        '
        'dtgslave
        '
        Me.dtgslave.AllowUserToAddRows = False
        Me.dtgslave.AllowUserToDeleteRows = False
        Me.dtgslave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgslave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgslave.Location = New System.Drawing.Point(6, 19)
        Me.dtgslave.Name = "dtgslave"
        Me.dtgslave.ReadOnly = True
        Me.dtgslave.RowHeadersVisible = False
        Me.dtgslave.Size = New System.Drawing.Size(811, 272)
        Me.dtgslave.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GrpList)
        Me.Panel2.Controls.Add(Me.GrpRecords)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1060, 547)
        Me.Panel2.TabIndex = 1
        '
        'GrpList
        '
        Me.GrpList.Controls.Add(Me.dtgmaster)
        Me.GrpList.Location = New System.Drawing.Point(230, 4)
        Me.GrpList.Name = "GrpList"
        Me.GrpList.Size = New System.Drawing.Size(825, 233)
        Me.GrpList.TabIndex = 3
        Me.GrpList.TabStop = False
        Me.GrpList.Text = "GroupBox4"
        '
        'GrpRecords
        '
        Me.GrpRecords.Controls.Add(Me.dtgslave)
        Me.GrpRecords.Location = New System.Drawing.Point(230, 243)
        Me.GrpRecords.Name = "GrpRecords"
        Me.GrpRecords.Size = New System.Drawing.Size(825, 299)
        Me.GrpRecords.TabIndex = 2
        Me.GrpRecords.TabStop = False
        Me.GrpRecords.Text = "GroupBox4"
        '
        'dtr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 547)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dtr"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtgmaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgslave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GrpList.ResumeLayout(False)
        Me.GrpRecords.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtgmaster As System.Windows.Forms.DataGridView
    Friend WithEvents dtgslave As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbgradelvl As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Rad4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btngo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents GrpList As System.Windows.Forms.GroupBox
    Friend WithEvents GrpRecords As System.Windows.Forms.GroupBox
End Class
