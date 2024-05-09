Imports System.Drawing.Drawing2D

Public Class PrefferedJobs
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PrefferedJobs_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim startColor As Color = Color.MidnightBlue
        Dim endColor As Color = Color.PowderBlue

        Dim rect As New Rectangle(0, 0, Me.Width, Me.Height)

        Dim brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Vertical)

        e.Graphics.FillRectangle(brush, rect)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class