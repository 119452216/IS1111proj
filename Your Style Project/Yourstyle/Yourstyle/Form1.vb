Public Class Form1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If radClassic.Checked Then
            Me.Hide()
            frmClassic.Show()
        End If
        If radRetro.Checked Then
            Me.Hide()
            frmRetro.Show()
        End If
        If radVintage.Checked Then
            Me.Hide()
            frmVintage.Show()
        End If
    End Sub
End Class
