Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient

Public Class Signup

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Signup_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim startColor As Color = Color.MidnightBlue
        Dim endColor As Color = Color.PowderBlue

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Dim brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(brush, rect)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim login As New Login()
        login.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim login As New Login()
        login.Show()
        Me.Hide()

    End Sub


End Class