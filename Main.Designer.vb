<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LunchATMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGradeLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAnnouncementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefaultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tlsATMS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsteacher = New System.Windows.Forms.ToolStripButton()
        Me.tlsStudent = New System.Windows.Forms.ToolStripButton()
        Me.tlsGradelvel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsBroadcast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsSMSlogs = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsDTR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tlsreports = New System.Windows.Forms.ToolStripButton()
        Me.TLlogin = New System.Windows.Forms.ToolStripButton()
        Me.TSUser = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dbStatsNotConnected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tlsStatusCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.dtglistofbroadcst = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtglistofmember = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tlsMessage = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.tslSearch = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtglistofbroadcst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtglistofmember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1201, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LunchATMSToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LunchATMSToolStripMenuItem
        '
        Me.LunchATMSToolStripMenuItem.Name = "LunchATMSToolStripMenuItem"
        Me.LunchATMSToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.LunchATMSToolStripMenuItem.Text = "Launch ATMS"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.AddStudentToolStripMenuItem, Me.AddGradeLevelToolStripMenuItem, Me.AddAnnouncementToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Image = CType(resources.GetObject("AddEmployeeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Image = CType(resources.GetObject("AddStudentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'AddGradeLevelToolStripMenuItem
        '
        Me.AddGradeLevelToolStripMenuItem.Image = CType(resources.GetObject("AddGradeLevelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddGradeLevelToolStripMenuItem.Name = "AddGradeLevelToolStripMenuItem"
        Me.AddGradeLevelToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddGradeLevelToolStripMenuItem.Text = "Add Advisory"
        '
        'AddAnnouncementToolStripMenuItem
        '
        Me.AddAnnouncementToolStripMenuItem.Image = CType(resources.GetObject("AddAnnouncementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddAnnouncementToolStripMenuItem.Name = "AddAnnouncementToolStripMenuItem"
        Me.AddAnnouncementToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddAnnouncementToolStripMenuItem.Text = "Add Announcement"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultsToolStripMenuItem, Me.ManageUserToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'DefaultsToolStripMenuItem
        '
        Me.DefaultsToolStripMenuItem.Image = CType(resources.GetObject("DefaultsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DefaultsToolStripMenuItem.Name = "DefaultsToolStripMenuItem"
        Me.DefaultsToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.DefaultsToolStripMenuItem.Text = "Defaults"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.Image = CType(resources.GetObject("ManageUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.DatabaseToolStripMenuItem.Text = "Database Utilities"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(133, 26)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ToolStrip2.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsATMS, Me.ToolStripSeparator2, Me.tlsteacher, Me.tlsStudent, Me.tlsGradelvel, Me.ToolStripSeparator3, Me.tlsBroadcast, Me.ToolStripSeparator1, Me.tlsSMSlogs, Me.ToolStripSeparator4, Me.tlsDTR, Me.ToolStripSeparator5, Me.tlsreports, Me.TLlogin, Me.TSUser})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1201, 57)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "Reports"
        '
        'tlsATMS
        '
        Me.tlsATMS.ForeColor = System.Drawing.Color.White
        Me.tlsATMS.Image = CType(resources.GetObject("tlsATMS.Image"), System.Drawing.Image)
        Me.tlsATMS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsATMS.Name = "tlsATMS"
        Me.tlsATMS.Size = New System.Drawing.Size(90, 54)
        Me.tlsATMS.Text = "Start ATMS "
        Me.tlsATMS.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsATMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 57)
        '
        'tlsteacher
        '
        Me.tlsteacher.ForeColor = System.Drawing.Color.White
        Me.tlsteacher.Image = CType(resources.GetObject("tlsteacher.Image"), System.Drawing.Image)
        Me.tlsteacher.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsteacher.Name = "tlsteacher"
        Me.tlsteacher.Size = New System.Drawing.Size(79, 54)
        Me.tlsteacher.Text = "Employee"
        Me.tlsteacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsteacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlsStudent
        '
        Me.tlsStudent.ForeColor = System.Drawing.Color.White
        Me.tlsStudent.Image = CType(resources.GetObject("tlsStudent.Image"), System.Drawing.Image)
        Me.tlsStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsStudent.Name = "tlsStudent"
        Me.tlsStudent.Size = New System.Drawing.Size(64, 54)
        Me.tlsStudent.Text = "Student"
        Me.tlsStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tlsGradelvel
        '
        Me.tlsGradelvel.ForeColor = System.Drawing.Color.White
        Me.tlsGradelvel.Image = CType(resources.GetObject("tlsGradelvel.Image"), System.Drawing.Image)
        Me.tlsGradelvel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsGradelvel.Name = "tlsGradelvel"
        Me.tlsGradelvel.Size = New System.Drawing.Size(70, 54)
        Me.tlsGradelvel.Text = "Advisory"
        Me.tlsGradelvel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsGradelvel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 57)
        '
        'tlsBroadcast
        '
        Me.tlsBroadcast.ForeColor = System.Drawing.Color.White
        Me.tlsBroadcast.Image = CType(resources.GetObject("tlsBroadcast.Image"), System.Drawing.Image)
        Me.tlsBroadcast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsBroadcast.Name = "tlsBroadcast"
        Me.tlsBroadcast.Size = New System.Drawing.Size(79, 54)
        Me.tlsBroadcast.Text = "Broadcast"
        Me.tlsBroadcast.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsBroadcast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'tlsSMSlogs
        '
        Me.tlsSMSlogs.ForeColor = System.Drawing.Color.White
        Me.tlsSMSlogs.Image = CType(resources.GetObject("tlsSMSlogs.Image"), System.Drawing.Image)
        Me.tlsSMSlogs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsSMSlogs.Name = "tlsSMSlogs"
        Me.tlsSMSlogs.Size = New System.Drawing.Size(77, 54)
        Me.tlsSMSlogs.Text = "SMS Logs"
        Me.tlsSMSlogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsSMSlogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 57)
        '
        'tlsDTR
        '
        Me.tlsDTR.ForeColor = System.Drawing.Color.White
        Me.tlsDTR.Image = CType(resources.GetObject("tlsDTR.Image"), System.Drawing.Image)
        Me.tlsDTR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsDTR.Name = "tlsDTR"
        Me.tlsDTR.Size = New System.Drawing.Size(75, 54)
        Me.tlsDTR.Text = "DTR Logs"
        Me.tlsDTR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsDTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 57)
        '
        'tlsreports
        '
        Me.tlsreports.ForeColor = System.Drawing.Color.White
        Me.tlsreports.Image = Global.SMSMYSQL.My.Resources.Resources.HP_Documents_Folder
        Me.tlsreports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlsreports.Name = "tlsreports"
        Me.tlsreports.Size = New System.Drawing.Size(64, 54)
        Me.tlsreports.Text = "Reports"
        Me.tlsreports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tlsreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TLlogin
        '
        Me.TLlogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TLlogin.ForeColor = System.Drawing.Color.White
        Me.TLlogin.Image = Global.SMSMYSQL.My.Resources.Resources.remove_from_database_icon
        Me.TLlogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TLlogin.Name = "TLlogin"
        Me.TLlogin.Size = New System.Drawing.Size(50, 54)
        Me.TLlogin.Text = "Login"
        Me.TLlogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TLlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TSUser
        '
        Me.TSUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TSUser.ForeColor = System.Drawing.Color.White
        Me.TSUser.Name = "TSUser"
        Me.TSUser.Size = New System.Drawing.Size(72, 54)
        Me.TSUser.Text = "Hi, Guest!"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dbStatsNotConnected, Me.tlsStatusCode})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 624)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1201, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dbStatsNotConnected
        '
        Me.dbStatsNotConnected.Image = CType(resources.GetObject("dbStatsNotConnected.Image"), System.Drawing.Image)
        Me.dbStatsNotConnected.Name = "dbStatsNotConnected"
        Me.dbStatsNotConnected.Size = New System.Drawing.Size(203, 20)
        Me.dbStatsNotConnected.Text = "Database: Not Connected "
        '
        'tlsStatusCode
        '
        Me.tlsStatusCode.Name = "tlsStatusCode"
        Me.tlsStatusCode.Size = New System.Drawing.Size(0, 20)
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.dtglistofbroadcst)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.dtglistofmember)
        Me.Panel1.Location = New System.Drawing.Point(0, 140)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 478)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView2.Size = New System.Drawing.Size(1196, 474)
        Me.DataGridView2.TabIndex = 53
        '
        'dtglistofbroadcst
        '
        Me.dtglistofbroadcst.AllowUserToAddRows = False
        Me.dtglistofbroadcst.AllowUserToDeleteRows = False
        Me.dtglistofbroadcst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistofbroadcst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglistofbroadcst.Location = New System.Drawing.Point(0, 0)
        Me.dtglistofbroadcst.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtglistofbroadcst.Name = "dtglistofbroadcst"
        Me.dtglistofbroadcst.ReadOnly = True
        Me.dtglistofbroadcst.RowHeadersVisible = False
        Me.dtglistofbroadcst.RowHeadersWidth = 51
        Me.dtglistofbroadcst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtglistofbroadcst.Size = New System.Drawing.Size(1196, 474)
        Me.dtglistofbroadcst.TabIndex = 52
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1196, 474)
        Me.DataGridView1.TabIndex = 2
        '
        'dtglistofmember
        '
        Me.dtglistofmember.AllowUserToAddRows = False
        Me.dtglistofmember.AllowUserToDeleteRows = False
        Me.dtglistofmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistofmember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtglistofmember.Location = New System.Drawing.Point(0, 0)
        Me.dtglistofmember.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtglistofmember.Name = "dtglistofmember"
        Me.dtglistofmember.ReadOnly = True
        Me.dtglistofmember.RowHeadersVisible = False
        Me.dtglistofmember.RowHeadersWidth = 51
        Me.dtglistofmember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtglistofmember.Size = New System.Drawing.Size(1196, 474)
        Me.dtglistofmember.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(1)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsMessage, Me.ToolStripButton1, Me.txtSearch, Me.tslSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 85)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1201, 44)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "Reports"
        '
        'tlsMessage
        '
        Me.tlsMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlsMessage.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlsMessage.Image = Global.SMSMYSQL.My.Resources.Resources.HP_Documents_Folder
        Me.tlsMessage.Name = "tlsMessage"
        Me.tlsMessage.Size = New System.Drawing.Size(26, 41)
        Me.tlsMessage.Text = "l"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 41)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(265, 44)
        Me.txtSearch.Visible = False
        '
        'tslSearch
        '
        Me.tslSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslSearch.Image = CType(resources.GetObject("tslSearch.Image"), System.Drawing.Image)
        Me.tslSearch.Name = "tslSearch"
        Me.tslSearch.Size = New System.Drawing.Size(217, 41)
        Me.tslSearch.Text = "Search by Last name"
        Me.tslSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.tslSearch.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 650)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Attendance Monitoring System With RFID"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtglistofbroadcst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtglistofmember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LunchATMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsATMS As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddGradeLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsteacher As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsStudent As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsGradelvel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tlsSMSlogs As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtglistofmember As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlsMessage As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AddAnnouncementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlsBroadcast As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dtglistofbroadcst As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dbStatsNotConnected As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tslSearch As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tlsStatusCode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsDTR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlsreports As System.Windows.Forms.ToolStripButton
    Friend WithEvents TLlogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSUser As System.Windows.Forms.ToolStripLabel
End Class
