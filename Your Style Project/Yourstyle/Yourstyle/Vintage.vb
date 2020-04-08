Public Class frmVintage
    'declaring varibles
    Const dblVintageShoe As Double = 44.99D
    Const dblLaces As Double = 4D
    Dim dblQuarter As Double
    Dim dblVamp As Double
    Dim dblEyestay As Double
    Dim dblHeeltab As Double
    Dim dblHeelCounter As Double
    Dim dbltext As Double

    Dim dblVat As Double
    Dim dblBasePrice As Double = dblVintageShoe + dblLaces
    Dim dblCustomisation As Double = dblHeelCounter + dblVamp + dblQuarter + dblEyestay
    Dim dblLogo As Double = dblCustomisation * 0.18
    Dim dblToatal As Double = dblBasePrice + dblCustomisation + dblLogo

    Dim dblsubtotal As Double = dblBasePrice + dblCustomisation + dblLogo + dblVat
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'declaring local varibles
        dblVat = (dblToatal * 0.23)
        Dim dblCustomisation As Double = dblHeelCounter + dblVamp + dblQuarter + dblEyestay + dbltext

        If chkYes.Checked Then
            dblLogo = (dblCustomisation * 0.18)
        Else dblLogo = 0D
        End If

        'setting price options 

        If cboQuarter.SelectedIndex = -1 Then
            MessageBox.Show("please enter an option for Quarter")
        ElseIf cboQuarter.Text = "White" Then
            dblQuarter = 0D
        Else dblQuarter = 8.99D
        End If

        If cboVamp.SelectedIndex = -1 Then
            MessageBox.Show("Please enter an option for the Vamp")
        ElseIf cboVamp.Text = "White" Then
            dblVamp = 0
        Else dblVamp = 14.99D
        End If

        If cboEyestay.SelectedIndex = -1 Then
            MessageBox.Show("Please enter an option for the Eyestay")
        ElseIf cboEyestay.Text = "White" Then
            dblEyestay = 0
        Else dblEyestay = 5D
        End If


        If cboHeelCounter.SelectedIndex = -1 Then
            MessageBox.Show("please enter an option for the heel counter")
        ElseIf cboHeelCounter.Text = "White" Then
            dblHeelCounter = 0D
        Else dblHeelCounter = 6.49D
        End If

        If txtText.Text = "" Then
            dbltext = 0
        Else dbltext = 0.45
        End If
        'placing final price in the textbox

        txtVintagePrice.Text = ("Subtotal:" & (FormatCurrency(dblBasePrice + dblVamp + dblQuarter + dblEyestay + dblVat + dblHeelCounter + dblLogo + dbltext)))
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        'allowing user to upload images for logo
        Dim opf As New OpenFileDialog
        opf.Filter = "choose image( *.jpg;*.png;*.gif)|*.jpg;*.png*.gif"

        If opf.ShowDialog = DialogResult.OK Then

        End If

    End Sub

End Class