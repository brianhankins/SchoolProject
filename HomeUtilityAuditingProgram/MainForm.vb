Imports System.IO

Public Class MainForm
    Private path As String = ""


    Public import As New ImportModule(Me)

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This text is added only once to create the file.
        InitialExport()
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
        Dim totalAmount As Double
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
            TotalLabel.Visible = True

            totalAmount = kilowattNumber.Value * hoursUsedNumber.Value * powerNeededNumber.Value

            TotalLabel.Text = "The total operating cost of the " + applianceList.SelectedItem + " is: " + totalAmount.ToString()

        End If

    End Sub

    'Saves the current form in a text file.
    Private Sub ExportFileBtn_Click(sender As Object, e As EventArgs) Handles ExportFileBtn.Click
        ExportDefaultVaules(path)
    End Sub
End Class
