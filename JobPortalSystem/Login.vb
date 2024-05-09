Imports System.Drawing.Drawing2D


Public Class Login



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        Dim signup As New Signup()
        signup.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim startColor As Color = Color.MidnightBlue
        Dim endColor As Color = Color.PowderBlue

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Dim brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(brush, rect)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim signup As New Signup()
        signup.Show()
        Me.Hide()

    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnLOGIN_Click(sender As Object, e As EventArgs) Handles btnLOGIN.MouseClick

        Dim username As String = "user"
        Dim password As String = "password"

        Dim enteredUsername As String = txtUsername.Text.Trim()
        Dim enteredPassword As String = txtPassword.Text.Trim()

        If enteredUsername = username AndAlso enteredPassword = password Then
            PrefferedJobs.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
        End If

    End Sub

End Class

