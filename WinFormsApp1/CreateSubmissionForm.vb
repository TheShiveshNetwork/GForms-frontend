Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private elapsedTime As TimeSpan
    Private startTime As DateTime
    Private isTimerRunning As Boolean = False

    Public Class CreateSubmission
        <JsonProperty("formId")>
        Public Property FormId As String
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("email")>
        Public Property Email As String
        <JsonProperty("phone")>
        Public Property Phone As String
        <JsonProperty("github_link")>
        Public Property Github_Link As String
        <JsonProperty("timer")>
        Public Property Timer As String
    End Class

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        elapsedTime = TimeSpan.Zero
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        SubmitForm()
    End Sub

    Private Sub SubmitForm()
        Dim formId As String = "66754adde9d3bacff5434589"   ' Hard coded existing objectId for a form
        Dim name As String = TextBox1.Text
        Dim email As String = TextBox2.Text
        Dim phone As String = TextBox3.Text
        Dim github_link As String = TextBox4.Text
        Dim timer As String = lblTimer.Text

        If String.IsNullOrWhiteSpace(name) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(phone) OrElse String.IsNullOrWhiteSpace(github_link) Then
            MessageBox.Show("Please fill all fields.", "Validation Error")
            Exit Sub
        End If

        Dim postData As New CreateSubmission With {
            .FormId = formId,
            .Name = name,
            .Email = email,
            .Phone = phone,
            .Github_Link = github_link,
            .Timer = timer
        }

        Dim jsonData As String = JsonConvert.SerializeObject(postData)

        ' MessageBox.Show("JSON Data: " & jsonData)

        Dim apiUrl As String = "http://localhost:3000/api/submitForm"

        Dim request As WebRequest = WebRequest.Create(apiUrl)
        request.Method = "POST"
        request.ContentType = "application/json"

        ' Convert the JSON string to a byte array
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(jsonData)
        request.ContentLength = byteArray.Length

        ' Write the byte array to the request stream
        Using dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
        End Using

        ' Get the response from the API
        Try
            Using response As WebResponse = request.GetResponse()
                Using dataStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(dataStream)
                        Dim responseFromServer As String = reader.ReadToEnd()
                        MessageBox.Show("Hurray! Sccessfully submitted response.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Timer functions
    Private Sub StartTimer()
        startTime = DateTime.Now - elapsedTime
        timer.Start()
        isTimerRunning = True
    End Sub
    Private Sub StopTimer()
        timer.Stop()
        elapsedTime = DateTime.Now - startTime
        isTimerRunning = False
    End Sub
    Private Sub btnStartTimer_Click(sender As Object, e As EventArgs) Handles btnStartTimer.Click
        If isTimerRunning Then
            StopTimer()
        Else
            StartTimer()
        End If
    End Sub
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' Calculate the elapsed time
        elapsedTime = DateTime.Now - startTime
        ' Update the label to display the elapsed time
        lblTimer.Text = String.Format("{0:hh\:mm\:ss}", elapsedTime)
    End Sub

    ' Shortcut key functions
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            If isTimerRunning Then
                StopTimer()
            Else
                StartTimer()
            End If
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            SubmitForm()
        End If
    End Sub
End Class