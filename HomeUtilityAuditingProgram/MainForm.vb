Imports System.IO

Public Class MainForm
    Private path As String
    Public totalAmount As Integer
    Public calculateMonthCosts As Integer
    Public calculateYearCosts As Integer


    Public import As New ImportModule(Me)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Maximize window as it may hide buttons
        WindowState = FormWindowState.Maximized

        'This text is added only once to create the file.
        Export()
        path = fullPath

    End Sub

    Private Sub ApplianceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles applianceList.SelectedIndexChanged
        'Get values from text file
        Dim list As New List(Of String)

        'Read values from text file and call appropriate function
        Using reader As StreamReader = New StreamReader(path)
            Dim line As String
            line = reader.ReadLine

            Do While (Not line Is Nothing)
                list.Add(line)

                Dim getValues = line.Split(New Char() {","c})
                Dim getAppliance = getValues(0)
                Dim selectedAppliance = applianceList.SelectedItem

                If (getAppliance = selectedAppliance And getAppliance = "Washer") Then
                    import.ImportDefaultWasherVaules(line)
                    Exit Do
                ElseIf (getAppliance = selectedAppliance) Then
                    import.ImportDefaultVaules(line)
                    Exit Do
                End If

                line = reader.ReadLine
            Loop
        End Using

        'Set labels to not show on selection change
        TotalLabel.Visible = False
        TotalWaterLabel.Visible = False

        'Check for Washer selection and display the Water, Cost labels, and input both fields
        If (applianceList.SelectedItem.ToString = "Washer") Then

            LabelWater.Visible = True
            numberOfGallons.Visible = True

            LabelWaterCost.Visible = True
            costofWater.Visible = True

        Else

            LabelWater.Visible = False
            numberOfGallons.Visible = False

            LabelWaterCost.Visible = False
            costofWater.Visible = False

        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim waterAmount As Double

        'Check to see if item in dropdown was selected - show error if nothing was selected
        If (applianceList.SelectedIndex = -1) Then

            MessageBox.Show("Please select an appliance from the list.")

            'Calculate water fields and show both total amount labels if Washer is selected
        ElseIf (applianceList.SelectedItem.ToString = "Washer") Then
            TotalLabel.Visible = True
            TotalWaterLabel.Visible = True

            totalAmount = kilowattNumber.Value * hoursUsedNumber.Value * powerNeededNumber.Value

            TotalLabel.Text = "The total operating cost of the " + applianceList.SelectedItem + " is: " + totalAmount.ToString()

            waterAmount = numberOfGallons.Value * costofWater.Value

            TotalWaterLabel.Text = "The total cost of water for the " + applianceList.SelectedItem + " is: " + waterAmount.ToString()

            'Calculate all other non-washer selections and show total amount label
        Else
            showTotalCostsLbl.Visible = False
            TotalLabel.Visible = True
            totalCostsBtn.Visible = True

            totalAmount = kilowattNumber.Value * hoursUsedNumber.Value * powerNeededNumber.Value

            TotalLabel.Text = "The total operating cost of the " + applianceList.SelectedItem + " is: " + totalAmount.ToString()

        End If

    End Sub

    'Saves the current form in a text file.
    Private Sub ExportFileBtn_Click(sender As Object, e As EventArgs) Handles ExportFileBtn.Click
        'Checks to see if appliance list was selected
        If (applianceList.SelectedIndex = -1) Then
            MessageBox.Show("Please select an appliance from the list.")
            Return
        Else
            CalculateButton.PerformClick()
        End If

        Dim arrayCostValues(3) As Integer
        arrayCostValues(0) = totalAmount
        arrayCostValues(1) = calculateMonthCosts
        arrayCostValues(1) = calculateYearCosts

        If (applianceList.SelectedItem.ToString = "Washer") Then
            Dim applianceWasherValues(5) As Integer
            applianceWasherValues(0) = kilowattNumber.Value
            applianceWasherValues(1) = hoursUsedNumber.Value
            applianceWasherValues(2) = powerNeededNumber.Value
            applianceWasherValues(3) = numberOfGallons.Value
            applianceWasherValues(4) = costofWater.Value

            Dim applianceWasher = applianceList.SelectedItem.ToString()

            ExportFile(applianceWasherValues, applianceWasher, arrayCostValues)
        Else
            Dim applianceValues(3) As Integer
            applianceValues(0) = kilowattNumber.Value
            applianceValues(1) = hoursUsedNumber.Value
            applianceValues(2) = powerNeededNumber.Value

            Dim applianceItem = applianceList.SelectedItem.ToString()

            ExportFile(applianceValues, applianceItem, arrayCostValues)
        End If
    End Sub

    'Calculates Monthly and Yearly costs
    Private Sub TotalCostBtn_Click(sender As Object, e As EventArgs) Handles totalCostsBtn.Click
        Dim calculateDailyCost As Integer
        Dim daysInMonth = 30
        Dim daysInYear = 365

        TotalLabel.Visible = False
        TotalWaterLabel.Visible = False
        showTotalCostsLbl.Visible = True

        calculateDailyCost = 24 \ hoursUsedNumber.Value

        calculateMonthCosts = totalAmount * calculateDailyCost * daysInMonth
        calculateYearCosts = totalAmount * calculateDailyCost * daysInYear

        showTotalCostsLbl.Text = "The total operating costs are: Monthly: " + calculateMonthCosts.ToString() + " Yearly: " + calculateYearCosts.ToString()

    End Sub

    'Close the Form
    Private Sub ExitAppBtn_Click(sender As Object, e As EventArgs) Handles ExitAppBtn.Click
        Close()
    End Sub
End Class
