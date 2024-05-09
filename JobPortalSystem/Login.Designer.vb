<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        btnLOGIN = New Button()
        Label1 = New Label()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        txtPassword = New TextBox()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        txtUsername = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(btnLOGIN)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(341, 154)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(638, 447)
        Panel1.TabIndex = 0
        ' 
        ' btnLOGIN
        ' 
        btnLOGIN.BackColor = Color.SteelBlue
        btnLOGIN.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLOGIN.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnLOGIN.ImageAlign = ContentAlignment.TopCenter
        btnLOGIN.Location = New Point(211, 313)
        btnLOGIN.Margin = New Padding(0)
        btnLOGIN.Name = "btnLOGIN"
        btnLOGIN.Size = New Size(200, 54)
        btnLOGIN.TabIndex = 14
        btnLOGIN.Text = "LOGIN"
        btnLOGIN.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(211, 393)
        Label1.Name = "Label1"
        Label1.Size = New Size(163, 20)
        Label1.TabIndex = 13
        Label1.Text = "Don't have an account?"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.IndianRed
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.ForeColor = Color.DimGray
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(371, 391)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(74, 23)
        LinkLabel2.TabIndex = 12
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Sign Up"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.IndianRed
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.LinkColor = Color.DimGray
        LinkLabel1.Location = New Point(457, 281)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(125, 20)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(txtPassword)
        Panel3.Location = New Point(66, 188)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(516, 78)
        Panel3.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(9, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.Location = New Point(86, 14)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(417, 48)
        txtPassword.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txtUsername)
        Panel2.Location = New Point(66, 104)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(516, 78)
        Panel2.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(11, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(63, 60)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.ForeColor = Color.DarkGray
        txtUsername.Location = New Point(86, 15)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(417, 48)
        txtUsername.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.ImageAlign = ContentAlignment.TopCenter
        Button2.Location = New Point(170, 35)
        Button2.Margin = New Padding(0)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 42)
        Button2.TabIndex = 5
        Button2.Text = "Log In"
        Button2.TextAlign = ContentAlignment.TopCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(310, 35)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 42)
        Button1.TabIndex = 4
        Button1.Text = "Sign Up"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AccessibleName = ""
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1334, 736)
        Controls.Add(Panel1)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLOGIN As Button
End Class
