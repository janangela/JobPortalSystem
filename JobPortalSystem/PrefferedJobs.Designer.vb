<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrefferedJobs
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
        Label1 = New Label()
        Button1 = New Button()
        Panel5 = New Panel()
        Label2 = New Label()
        CheckedListBox1 = New CheckedListBox()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(116, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(378, 45)
        Label1.TabIndex = 0
        Label1.Text = "PREFFERED JOBS"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SteelBlue
        Button1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(219, 341)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 46)
        Button1.TabIndex = 11
        Button1.Text = "NEXT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(CheckedListBox1)
        Panel5.Controls.Add(Label1)
        Panel5.Controls.Add(Button1)
        Panel5.Location = New Point(339, 153)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(605, 414)
        Panel5.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Location = New Point(116, 250)
        Label2.Name = "Label2"
        Label2.Size = New Size(387, 42)
        Label2.TabIndex = 14
        Label2.Text = "                                                                                              " & vbCrLf & vbCrLf
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Accountant", "Actor", "Aerospace Engineers", "Agriculture as a career", "Agricultural Engineers", "Architects and Landscape Architects", "Architecture and Engineering", "Art Director", "Announcer", "Biochemists and Biophysicists", "Biological and Biomedical Sciences", "Bioinformatics Scientists", "Biomedical Engineering", "Biostatisticians", "Botanists", "Broadcast and Sound Engineering Technician", "Business and Finance", "Civil Drafters", "Chemical Engineers", "Civil Engineers", "Computer and Information Research Scientists", "Computer Hardware Engineers", "Computer Network Architects", "Computer Programming", "Community and Social Service", "Computer Science, Engineering & Technology", "Consumer Services, Hospitality, and Tourism", "Computer Support Specialists", "Computer Systems Analysts", "Culinary Arts and Personal Services", "Dancers and Choreographers", "Database Administrators ", "Dietitians and Nutritionists", "Edito Publishing & New Media", "Education, Teaching and Training", "Electrical and Electronics Engineering", "Entomology", "Environmental Engineering", "Environmental Scientists", "Graphic Designer", "Genetics", "Health Care", "Health Educator or Community Health Worker", "Health and Safety Engineering", "Industrial Engineering", "Information Security Analysts", "Interpreter and Translator", "Legal and Paralegal services", "Liberal Arts and Humanities", "Management", "Materials Engineering", "Marine Biologists and Oceanographers", "Marine Engineering and Naval Architecture", "Manufacturing and Production", "Mechanical Engineering", "Media, Communications and Entertainment", "Mental Health Counselor and Marriage and Family Therapist", "Microbiology", "Mining and Geological Engineering", "Molecular and Cell Biologists", "Music  Director and Composer", "Network and Computer Systems Administrators", "Nuclear Engineering", "Neuroscience/Neurobiology", "Opertaions Research (OR)", "Parasitology", "Pharmacology and Toxicology", "Pathology", "Petroleum Engineering", "Plant Scientist", "Probation Officers and Correctional Treatment Specialists", "Producer and Director", "Psychology", "Public Relation Specialists", "Photographer", "Rehabilitation Counselor", "Religious Activities and Education", "Reporter for Radio, TV, Internet", "Research Analyst", "Set and Exhibit Designer", "School and Career Counselor", "Social Work", "Sports", "Substance Abuse and Behavioral Disorder Counselors", "Technical Writer", "Transportation and Distribution", "Visual and Performing Arts", "Web Developers", "Writers and Authors", "Zoologists and Wildlife Biologists"})
        CheckedListBox1.Location = New Point(116, 107)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(378, 114)
        CheckedListBox1.TabIndex = 13
        ' 
        ' PrefferedJobs
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1334, 736)
        Controls.Add(Panel5)
        Name = "PrefferedJobs"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PrefferedJobs"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label2 As Label
End Class
