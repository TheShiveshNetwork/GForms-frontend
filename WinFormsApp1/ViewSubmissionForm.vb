Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports Newtonsoft.Json

Public Class ViewSubmissionForm
    Private currIndex As Integer = 0
    Private myApiResponse As List(Of ApiResponse) = Nothing

    Public Class Body
        Public Property FormId As String
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property Github_Link As String
        Public Property Timer As String
    End Class

    Public Class ApiResponse
        Public Property Id As String
        Public Property Body As Body
    End Class

    Private Sub ViewSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchAllSubmissions()
    End Sub

    Private Sub FetchAllSubmissions()
        Dim apiUrl As String = String.Format("http://localhost:3000/api/getAllResponses")
        Dim request As WebRequest = WebRequest.Create(apiUrl)
        request.Method = "GET"

        Try
            Dim response As WebResponse = request.GetResponse()
            Using dataStream As Stream = response.GetResponseStream()
                Using reader As New StreamReader(dataStream)
                    Dim responseFromServer As String = reader.ReadToEnd()

                    myApiResponse = JsonConvert.DeserializeObject(Of List(Of ApiResponse))(responseFromServer)

                    DisplayCurrentItem()

                End Using
            End Using
            response.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplayCurrentItem()
        If myApiResponse IsNot Nothing AndAlso myApiResponse.Count > 0 AndAlso currIndex >= 0 AndAlso currIndex < myApiResponse.Count Then
            Dim currentItem As ApiResponse = myApiResponse(currIndex)
            TextBox1.Text = currentItem.Body.Name
            TextBox2.Text = currentItem.Body.Email
            TextBox3.Text = currentItem.Body.Phone
            TextBox4.Text = currentItem.Body.Github_Link
            TextBox5.Text = currentItem.Body.Timer
        Else
            MessageBox.Show("No data available.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GoNext()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GoPrevious()
    End Sub

    Private Sub GoNext()
        If myApiResponse IsNot Nothing AndAlso currIndex < myApiResponse.Count - 1 Then
            currIndex += 1
            DisplayCurrentItem()
        End If
    End Sub

    Private Sub GoPrevious()
        If myApiResponse IsNot Nothing AndAlso currIndex > 0 Then
            currIndex -= 1
            DisplayCurrentItem()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            GoPrevious()
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            GoNext()
        End If
    End Sub
End Class