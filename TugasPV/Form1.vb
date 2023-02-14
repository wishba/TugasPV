Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Private hargaPerHari As Integer
    Private supirPerHari As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileName As String = "data.json"
        Dim fileContents As String = File.ReadAllText(fileName)
        Dim data As Dictionary(Of String, Integer) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Integer))(fileContents)

        hargaPerHari = data("hargaPerHari")
        supirPerHari = data("supirPerHari")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalHari As Integer = Integer.Parse(TextBox1.Text)
        Dim result As Integer

        For i As Integer = 1 To totalHari
            result += hargaPerHari
        Next

        If CheckBox1.Checked Then
            result += supirPerHari * totalHari
        End If

        Label1.Text = result.ToString()
    End Sub
End Class
