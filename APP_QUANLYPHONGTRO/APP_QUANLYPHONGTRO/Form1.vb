Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim phongViewForm As New Phong_view
        phongViewForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim phongViewForm As New HopDongView
        phongViewForm.Show()
    End Sub
End Class
