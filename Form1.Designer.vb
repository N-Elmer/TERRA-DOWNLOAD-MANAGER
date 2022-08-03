Imports System.Net

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LINK = New System.Windows.Forms.ListBox()
        Me.SAVE = New System.Windows.Forms.ListBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BROWSEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHOWHELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HIDEHELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(394, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DOWNLOAD LINKS"
        '
        'LINK
        '
        Me.LINK.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LINK.FormattingEnabled = True
        Me.LINK.ItemHeight = 15
        Me.LINK.Location = New System.Drawing.Point(397, 45)
        Me.LINK.Name = "LINK"
        Me.LINK.Size = New System.Drawing.Size(200, 64)
        Me.LINK.TabIndex = 2
        '
        'SAVE
        '
        Me.SAVE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVE.FormattingEnabled = True
        Me.SAVE.ItemHeight = 15
        Me.SAVE.Location = New System.Drawing.Point(397, 145)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(199, 64)
        Me.SAVE.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.HELPToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(604, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BROWSEToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'BROWSEToolStripMenuItem
        '
        Me.BROWSEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BROWSEToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BROWSEToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BROWSEToolStripMenuItem.Name = "BROWSEToolStripMenuItem"
        Me.BROWSEToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.BROWSEToolStripMenuItem.Text = "BROWSE"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EXITToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HELPToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SHOWHELPToolStripMenuItem, Me.HIDEHELPToolStripMenuItem})
        Me.HELPToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.HELPToolStripMenuItem.Text = "HELP"
        '
        'SHOWHELPToolStripMenuItem
        '
        Me.SHOWHELPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SHOWHELPToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SHOWHELPToolStripMenuItem.Name = "SHOWHELPToolStripMenuItem"
        Me.SHOWHELPToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SHOWHELPToolStripMenuItem.Text = "SHOW HELP"
        '
        'HIDEHELPToolStripMenuItem
        '
        Me.HIDEHELPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HIDEHELPToolStripMenuItem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HIDEHELPToolStripMenuItem.Name = "HIDEHELPToolStripMenuItem"
        Me.HIDEHELPToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.HIDEHELPToolStripMenuItem.Text = "ABOUT"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 224)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(223, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(49, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(260, 20)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(338, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(6, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 21)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "ADD LINK"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(315, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 21)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "SAVE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LINK"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(169, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "MB"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(119, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 21)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "CANCEL"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(560, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "speed"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(3, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "SIZE"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Blue
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Blue
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 170)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(381, 24)
        Me.ProgressBar1.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(6, 200)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 21)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "DOWNLOAD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DOWNLOAD STATUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(394, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "SAVE LOCATION"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(3, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ACTIVATION KEY"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Gray
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(0, 114)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(606, 10)
        Me.TextBox4.TabIndex = 26
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(348, 223)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 21)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "OK"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TERRA_DOWNLOADER.My.Resources.Resources._2f9ba805f8191e6e5906eb9d9b1ee50ea4ef7ce1cfaeb8382b147f6b3223823d
        Me.ClientSize = New System.Drawing.Size(604, 249)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.LINK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "form1"
        Me.Opacity = 0.85R
        Me.Text = "TERRA- X DOWNLOADER"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents LINK As ListBox
    Friend WithEvents SAVE As ListBox
    Private txtsaveto As Object
    Private txtURL As Object
    Private WithEvents httpclient As Net.WebClient
    Dim wc As New WebClient

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Console.Beep(8000, 100)
        Try
            If TextBox1.Text = "" Then
                MsgBox("ERROR PLEASE INPUT URL BEFORE CLICKING DOWNLOAD BUTTON", vbOKOnly, "ERROR")
                Console.Beep(8000, 100)
            End If
        Catch ex As Exception
            MsgBox("ERROR: " + ex.ToString)
            Console.Beep(8000, 100)
        End Try
        LINK.Items.Add(TextBox1.Text)
        SAVE.Items.Add(TextBox2.Text)
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs)
        TextBox2.Text = SaveFileDialog1.FileName
        SaveFileDialog1.Filter = ".exe|*.exe|.jpg|*.jpg|.zip|*.zip|.rar|*.rar|.png|*.png|.gif|*.gif|.mp4|*.mp4|.iso|*.iso|.mp3|*.mp3"
        SaveFileDialog1.ShowDialog()
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Private lblcurrentstat As Object
    Private lbldownstat As Object

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            httpclient = New Net.WebClient
            Dim total As Integer = LINK.Items.Count
            Dim current As Integer = -1
            While current < total
                LINK.SelectedIndex = current + 1
                Me.SAVE.SelectedIndex = current + 1
                Dim download As String = LINK.SelectedItem
                Dim save As String = Me.SAVE.SelectedItem
                httpclient.DownloadFileAsync(New Uri(download), save)
                Label4.Text = "CURRENT STATUS: DOWNLOADING..."
                Do While httpclient.IsBusy
                    Application.DoEvents()
                Loop
                current = current + 1
            End While
        Catch ex As Exception
            LINK.Items.Clear()
            SAVE.Items.Clear()
        End Try
    End Sub

    Private Sub httpclient_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles httpclient.DownloadProgressChanged
        ProgressBar1.Maximum = e.TotalBytesToReceive
        ProgressBar1.Value = e.BytesReceived
        If e.ProgressPercentage = 0 Or e.ProgressPercentage = 100 Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If
        Label4.Text = "DOWNLOAD STATUS: " & e.ProgressPercentage & "%"
        Label7.Text = "DOWNLOADED: " & Format(e.BytesReceived / 1024 / 1024, "#0.00") & "MB"
        Label10.Text = "OF: " & Format(e.TotalBytesToReceive / 1024 / 1024, "#0.00") & "MB"
    End Sub

    Private Sub wc_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        speed = (e.BytesReceived / (DirectCast(e.UserState, Stopwatch).ElapsedMilliseconds / 1000.0#)).ToString("#")
        Label8.Text = "SPEED: " & Format(speed / 1024, "#0.00") & "KB/s"
        If e.ProgressPercentage = 100 Then
            Console.Beep(8000, 500)
            Label4.Text = "CURRENT STATUS: COMPLETED SUCCESSFULLY"
            ProgressBar1.Maximum = ProgressBar1.Minimum
        Else
            Console.Beep(900, 500)
            Console.Beep(900, 500)
            Label4.Text = "CURRENT STATUS: DOWNLOAD FAILED" & e.ProgressPercentage & "%"
            Label7.Text = "DOWNLOADED: --/--"
            Label8.Text = "SPEED: --/--"
        End If
    End Sub
    Private speed As String
    Friend WithEvents MenuStrip1 As MenuStrip

    Private Sub POWERToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private alwaysasktoolstripmenuitem As Object
    Public Property OpenFileDialogtoolstripmenuitem As Boolean

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Console.Beep(8000, 100)
        Button3.Enabled = True
        Try
            httpclient.CancelAsync()
            Label4.Text = "CURRENT STATUS: CANCELLED"
            Label7.Text = "DOWNLOADED: --/--"
            Label8.Text = "SPEED: --/--"
            ProgressBar1.Value = 0
            MsgBox("DOWNLOAD CANCELLED", vbOKOnly, "CANCELLED")
            Console.Beep(8000, 100)
        Catch ex As Exception
            MsgBox("ERROR: " + ex.ToString)
            Console.Beep(8000, 100)
            MsgBox(ex.Message)
            Console.Beep(8000, 100)
        End Try
    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BROWSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem

    Private Sub BROWSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BROWSEToolStripMenuItem.Click
        Console.Beep(8000, 100)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Console.Beep(8000, 100)
        End
    End Sub
    Friend WithEvents SHOWHELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HIDEHELPToolStripMenuItem As ToolStripMenuItem

    Private Sub SHOWHELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SHOWHELPToolStripMenuItem.Click
        Console.Beep(8000, 100)
        MsgBox("HOW TO USE TERRA DOWNLOADER

1- COPY DOWNLOAD LINK OR URL OR ADDRESS AND PASTE IN
   LINK BAR

2- CHOOSE DOWNLOAD LOCATION IN PC BY CLICKING 
   ON THE --BROWSE-- BUTTON BESIDE THE --SAVE-- 
   LOCATION BAR

3- TYPE IN DOWNLOAD FILE NAME AND CHOOSE EXTENSION FROM 
   EXTENSION FILTER OR WRITE FILE EXTENSION IF EXTENSION
   IS NOT IN EXTENSION FILTER AND SAVE

4- CLICK --ADD LINK-- BUTTON TO PREPARE DOWNLOAD BY
   ADDING IT TO QUEUE

5- REPEAT STEP 1 TO 4 UNTIL YOU HAVE ALL YOUR DOWNLOADS 
   QUEUED THEN CLICK DOWNLOAD WHEN ALL LINKS ARE QUEUED
   TO LAUNCH DOWNLOAD

6- CLICK ON CANCEL TO STOP DOWNLOAD
NB:TO USE CANCEL BUTTON ACTIVATE YOUR SOFTWARE USING LICENSE KEY")
        Console.Beep(8000, 100)
    End Sub

    Private Sub ABOUTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HIDEHELPToolStripMenuItem.Click
        Console.Beep(8000, 100)
        MsgBox("-TERRA-X DOWNLOAD MANAGER 1.0   
-RELEASE YEAR 2019   
-NUMFOR ELMER CEO AND FOUNDER OF TERRA-EXPLORATION ")
        Console.Beep(8000, 100)
    End Sub
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label

    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button5 As Button

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Console.Beep(8000, 100)
        If TextBox3.Text = "Admin123456789" Then
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Console.Beep(8000, 100)
        TextBox2.Text = SaveFileDialog1.FileName
        SaveFileDialog1.Filter = ".exe|*.exe|.jpg|*.jpg|.zip|*.zip|.rar|*.rar|.png|*.png|.gif|*.gif|.mp4|*.mp4|.iso|*.iso|.mp3|*.mp3"
        SaveFileDialog1.ShowDialog()
        TextBox2.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Console.Beep(8000, 100)
        Try
            If TextBox1.Text = "" Then
                MsgBox("ERROR PLEASE INPUT URL BEFORE CLICKING --ADD LINK--", vbOKOnly, "ERROR")
                Console.Beep(8000, 100)
            End If
        Catch ex As Exception
            MsgBox("ERROR: " + ex.ToString)
            Console.Beep(8000, 100)
        End Try
        LINK.Items.Add(TextBox1.Text)
        SAVE.Items.Add(TextBox2.Text)
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Console.Beep(8000, 100)
        Try
            httpclient = New Net.WebClient
            Dim total As Integer = LINK.Items.Count
            Dim current As Integer = -1
            While current < total
                LINK.SelectedIndex = current + 1
                Me.SAVE.SelectedIndex = current + 1
                Dim download As String = LINK.SelectedItem
                Dim save As String = Me.SAVE.SelectedItem
                httpclient.DownloadFileAsync(New Uri(download), save)
                Label4.Text = "CURRENT STATUS: DOWNLOADING..."
                Do While httpclient.IsBusy
                    Application.DoEvents()
                Loop
                current = current + 1
            End While
        Catch ex As Exception
            LINK.Items.Clear()
            SAVE.Items.Clear()
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Console.Beep(8000, 100)
        Button3.Enabled = True
        Try
            httpclient.CancelAsync()
            Label4.Text = "CURRENT STATUS: CANCELLED"
            Label7.Text = "DOWNLOADED: --/--"
            Label8.Text = "SPEED: --/--"
            ProgressBar1.Value = 0
            Console.Beep(900, 500)
            Console.Beep(900, 500)
            MsgBox("DOWNLOAD CANCELLED", vbOKOnly, "CANCELLED")
            Console.Beep(8000, 100)
        Catch ex As Exception
            MsgBox("ERROR: " + ex.ToString)
            Console.Beep(8000, 100)
            MsgBox(ex.Message)
            Console.Beep(8000, 100)
        End Try
    End Sub

    Private Sub MENUToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUToolStripMenuItem.Click
        Console.Beep(8000, 100)
    End Sub

    Private Sub HELPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HELPToolStripMenuItem.Click
        Console.Beep(8000, 100)
    End Sub
End Class
