Imports System.IO
Imports Newtonsoft.Json

Public Class Form1
    Private hargaPerHari As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileName As String = "data.json"
        Dim fileContents As String = File.ReadAllText(fileName)
        Dim data As Dictionary(Of String, Integer) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Integer))(fileContents)

        hargaPerHari = data("hargaPerHari")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim multiplier As Integer = Integer.Parse(TextBox1.Text)
        Dim result As Integer = hargaPerHari * multiplier
        Label1.Text = result.ToString()
    End Sub
End Class
