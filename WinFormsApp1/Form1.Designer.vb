<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.BurlyWood
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(36, 98)
        Button1.Name = "Button1"
        Button1.Size = New Size(403, 52)
        Button1.TabIndex = 1
        Button1.Text = "View Submissions (Ctrl + V)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cornsilk
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(36, 156)
        Button2.Name = "Button2"
        Button2.Size = New Size(403, 52)
        Button2.TabIndex = 2
        Button2.Text = "Create new Submission (Ctrl + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(36, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 28)
        Label1.TabIndex = 3
        Label1.Text = "JohnDoe, Slidely Task 2, Slidely Forms App"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(497, 315)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        KeyPreview = True
        Name = "Form1"
        Text = "Google Forms"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
