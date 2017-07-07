Public Class ImportModule

    Dim _mainForm As MainForm

    Public Sub New(ByVal main As MainForm)
        _mainForm = main
    End Sub


    Public Sub ImportDefaultVaules(line As String)
        Try

            Dim values = line.Split(New Char() {","c})

            Dim powerValue = Convert.ToDouble(values(1))
            Dim kilowattValue = Convert.ToDouble(values(2))
            Dim hourValue = Convert.ToDouble(values(3))

            _mainForm.powerNeededNumber.Value = powerValue
            _mainForm.kilowattNumber.Value = kilowattValue
            _mainForm.hoursUsedNumber.Value = hourValue

        Catch
            MessageBox.Show("Error: An error occured getting the appliance. Please try again.")
        End Try
    End Sub

    Public Sub ImportDefaultWasherVaules(line As String)
        Try

            Dim values = line.Split(New Char() {","c})

            Dim powerValue = Convert.ToDouble(values(1))
            Dim kilowattValue = Convert.ToDouble(values(2))
            Dim hourValue = Convert.ToDouble(values(3))
            Dim gallonsValue = Convert.ToDouble(values(4))
            Dim waterValue = Convert.ToDouble(values(5))

            _mainForm.powerNeededNumber.Value = powerValue
            _mainForm.kilowattNumber.Value = kilowattValue
            _mainForm.hoursUsedNumber.Value = hourValue
            _mainForm.numberOfGallons.Value = gallonsValue
            _mainForm.costofWater.Value = waterValue

        Catch
            MessageBox.Show("Error: An error occured getting the Washer. Please try again.")
        End Try
    End Sub
End Class
