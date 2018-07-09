Public Class Form1
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim watch As Stopwatch = New Stopwatch()
        If (txtCount.Text Is "") Then
            txtCount.Text = 100000
        End If

        Dim count As Integer = Me.txtCount.Text

        watch.Start()
        For index = 1 To count
            Dim dumbText As String = sender.Text
        Next
        watch.Stop()
        txtLate.Text = watch.ElapsedMilliseconds


        watch.Restart()
        Dim btn As Button = CType(sender, Button)
        For index = 1 To count
            Dim dumbText As String = btn.Text
        Next
        watch.Stop()
        txtEarly.Text = watch.ElapsedMilliseconds


        watch.Restart()
        For index = 1 To count
            Dim dumbText As Integer = sender.Text '.Length.CompareTo(1)
        Next
        watch.Stop()
        txtDoubleLate.Text = watch.ElapsedMilliseconds

    End Sub
End Class
