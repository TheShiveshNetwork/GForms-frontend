<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionForm
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
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(376, 28)
        Label1.TabIndex = 0
        Label1.Text = "JohnDoe, Slidely Task 2, View Submissions"
        ' 
        ' TextBox4
        ' 
        TextBox4.Enabled = False
        TextBox4.Location = New Point(182, 167)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(246, 27)
        TextBox4.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 170)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 20)
        Label5.TabIndex = 15
        Label5.Text = "Github Link for Task 2"
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(182, 134)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 27)
        TextBox3.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 137)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 13
        Label4.Text = "Phone Num"
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(182, 101)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 27)
        TextBox2.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 11
        Label3.Text = "Email"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(182, 68)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(246, 27)
        TextBox1.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 9
        Label2.Text = "Name"
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(182, 200)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(246, 27)
        TextBox5.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 203)
        Label6.Margin = New Padding(0)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 20)
        Label6.TabIndex = 17
        Label6.Text = "Stopwatch Time"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(19, 295)
        Button1.Name = "Button1"
        Button1.Size = New Size(210, 47)
        Button1.TabIndex = 19
        Button1.Text = "Previous (Ctrl + P)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(235, 295)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 47)
        Button2.TabIndex = 20
        Button2.Text = "Next (Ctrl + N)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ViewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 391)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionForm"
        Text = "ViewSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
