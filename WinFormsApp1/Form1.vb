Imports System.Windows
Imports System.Windows.Forms.DataFormats

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ViewSubmissionForm As New ViewSubmissionForm()
        ViewSubmissionForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CreateSubmissionForm As New CreateSubmissionForm()
        CreateSubmissionForm.Show()
    End Sub

    ' Open the windows on key press
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Open View Submission Form when "Ctrl+V" is pressed
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Dim ViewSubmissionForm As New ViewSubmissionForm()
            ViewSubmissionForm.Show()
        End If
        ' Open Create Submission Form when "Ctrl+C" is pressed
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Dim CreateSubmissionForm As New CreateSubmissionForm()
            CreateSubmissionForm.Show()
        End If
    End Sub
End Class
