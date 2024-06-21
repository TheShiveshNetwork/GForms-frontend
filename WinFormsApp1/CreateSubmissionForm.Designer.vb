<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        btnStartTimer = New Button()
        SubmitButton = New Button()
        lblTimer = New Label()
        timer = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(383, 28)
        Label1.TabIndex = 0
        Label1.Text = "JohnDoe, Slidely Task 2, Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(178, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(246, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(178, 103)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(246, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 3
        Label3.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(178, 136)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(246, 27)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Phone Num"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(178, 169)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(246, 27)
        TextBox4.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 172)
        Label5.Margin = New Padding(0)
        Label5.Name = "Label5"
        Label5.Size = New Size(149, 20)
        Label5.TabIndex = 7
        Label5.Text = "Github Link for Task 2"
        ' 
        ' btnStartTimer
        ' 
        btnStartTimer.Location = New Point(12, 231)
        btnStartTimer.Name = "btnStartTimer"
        btnStartTimer.Size = New Size(223, 49)
        btnStartTimer.TabIndex = 9
        btnStartTimer.Text = "Toggle Stopwatch (Ctrl + T)"
        btnStartTimer.UseVisualStyleBackColor = True
        ' 
        ' SubmitButton
        ' 
        SubmitButton.Location = New Point(12, 301)
        SubmitButton.Name = "SubmitButton"
        SubmitButton.Size = New Size(412, 49)
        SubmitButton.TabIndex = 10
        SubmitButton.Text = "Submit (Ctrl + S)"
        SubmitButton.UseVisualStyleBackColor = True
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.BackColor = SystemColors.ActiveBorder
        lblTimer.Location = New Point(241, 233)
        lblTimer.Name = "lblTimer"
        lblTimer.Padding = New Padding(10, 13, 10, 13)
        lblTimer.Size = New Size(83, 46)
        lblTimer.TabIndex = 11
        lblTimer.Text = "00:00:00"
        ' 
        ' timer
        ' 
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(447, 388)
        Controls.Add(lblTimer)
        Controls.Add(SubmitButton)
        Controls.Add(btnStartTimer)
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
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnStartTimer As Button
    Friend WithEvents SubmitButton As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents timer As Timer
End Class
