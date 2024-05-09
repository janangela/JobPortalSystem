<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Panel1 = New Panel()
        Label1 = New Label()
        LinkLabel2 = New LinkLabel()
        Button3 = New Button()
        Panel2 = New Panel()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(349, 132)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(638, 477)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(216, 424)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 20)
        Label1.TabIndex = 13
        Label1.Text = "Already have an account?"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.ActiveLinkColor = Color.IndianRed
        LinkLabel2.AutoSize = True
        LinkLabel2.BackColor = Color.Transparent
        LinkLabel2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel2.ForeColor = Color.DimGray
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(400, 422)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(60, 23)
        LinkLabel2.TabIndex = 12
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Log In"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SteelBlue
        Button3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.ImageAlign = ContentAlignment.TopCenter
        Button3.Location = New Point(216, 354)
        Button3.Margin = New Padding(0)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 54)
        Button3.TabIndex = 10
        Button3.Text = "SIGN UP"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaption
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(103, 110)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(443, 219)
        Panel2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.DarkGray
        TextBox3.Location = New Point(13, 152)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(417, 48)
        TextBox3.TabIndex = 9
        TextBox3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = Color.DarkGray
        TextBox1.Location = New Point(13, 81)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(417, 48)
        TextBox1.TabIndex = 8
        TextBox1.Text = "Email"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = Color.DarkGray
        TextBox2.Location = New Point(13, 12)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(417, 48)
        TextBox2.TabIndex = 7
        TextBox2.Text = "Name"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Button2.ImageAlign = ContentAlignment.TopCenter
        Button2.Location = New Point(169, 33)
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
        Button1.BackColor = Color.SteelBlue
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(309, 33)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 42)
        Button1.TabIndex = 4
        Button1.Text = "Sign Up"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Signup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1334, 736)
        Controls.Add(Panel1)
        Name = "Signup"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
