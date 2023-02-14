﻿Imports Newtonsoft.Json

Public Class Form1
    Private hargaPerHari As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fileName As String = "data.txt"
        Dim fileContents As String = File.ReadAllText(fileName)
        Dim lines As String() = fileContents.Split(Environment.NewLine)

        'Dim hargaPerHari As Integer = 0
        For Each line As String In lines
            If line.StartsWith("hargaPerHari=") Then
                hargaPerHari = Integer.Parse(line.Split("=")(1))
                Exit For
            End If
        Next

        'Label1.Text = hargaPerHari.ToString()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim multiplier As Integer = Integer.Parse(TextBox1.Text)
        Dim result As Integer = hargaPerHari * multiplier
        Label1.Text = result.ToString()
    End Sub
End Class
