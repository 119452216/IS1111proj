Public Class frmClassic
    Dim dblClassicShoe As Double = 54.49
    Dim dblLaces As Double = 4.0
    Dim dblQuarter As Double
    Dim dblVamp As Double
    Dim dblEyestay As Double
    Dim dblHeeltab As Double
    Dim dblHeelCounter As Double
    Dim dblText As Double
    Dim dblVat As Double

    Dim dblBasePrice As Double = dblClassicShoe + dblLaces
    Dim dblCustomisation As Double = dblHeelCounter + dblVamp + dblQuarter + dblEyestay + dblHeeltab
    Dim dblLogo As Double = dblCustomisation * 0.18
    Dim dblToatal As Double = dblBasePrice + dblCustomisation + dblLogo
    Dim dblsubtotal As Double = dblBasePrice + dblCustomisation + dblLogo + dblVat
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declaring local varibles
        Dim dblCustomisation As Double = dblHeelCounter + dblVamp + dblQuarter + dblEyestay + dblHeeltab + dblText
        dblVat = (dblToatal * 0.23)

        If chkYes.Checked Then
            dblLogo = (dblCustomisation * 0.18)
        Else dblLogo = 0D
        End If

        'setting the prices for the certain options
        If cboQuarter.SelectedIndex = -1 Then
            MessageBox.Show("please enter an option for quarter")
        ElseIf cboQuarter.Text = "White" Then
            dblQuarter = 0D
        Else dblQuarter = 8.99D
        End If

        If cboVamp.SelectedIndex = -1 Then
            MessageBox.Show("Please Enter an option for Vamp")
        ElseIf cboVamp.Text = "White" Then
            dblVamp = 0D
        Else dblVamp = 14.99D
        End If

        If cboEyestay.SelectedIndex = -1 Then
            MessageBox.Show("Please enter an option for Eyestay")
        ElseIf cboEyestay.Text = "White" Then
            dblEyestay = 0D
        Else dblEyestay = 5D
        End If

        If cboHeelTab.SelectedIndex = -1 Then
            MessageBox.Show("Please enter an option for the Heel tab")
        ElseIf cboHeelTab.Text = "White" Then
            dblHeeltab = 0D
        Else dblHeeltab = 4.99D
        End If

        If cboHeelCounter.SelectedIndex = -1 Then
            MessageBox.Show("Please enter an option for the Heel counter")
        ElseIf cboHeelCounter.Text = "White" Then
            dblHeelCounter = 0D
        Else dblHeelCounter = 6.49D
        End If

        If txtText.Text = "" Then
            dblText = 0
        Else dblText = 0.45
        End If
        'placing the final price in the textbox
        txtFinalPriceClassic.Text = ("subtotal:" & (FormatCurrency(dblBasePrice + dblQuarter + dblVamp + dblEyestay + dblHeeltab + dblLogo + dblVat + dblHeelCounter + dblText)))



    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'allowing me to upload a logo image
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image( *.jpg;*.png;*.gif)|*.jpg;*.png*.gif"

        If opf.ShowDialog = DialogResult.OK Then
        End If
    End Sub
End Class