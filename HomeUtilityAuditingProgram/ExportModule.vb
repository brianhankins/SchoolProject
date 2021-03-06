﻿Imports System.IO

Module ExportModule
    Dim subPath As String
    Dim exportSubPath As String
    Dim configFile = "\HUAP_Config.txt"
    Dim exportFileName = "\HUAP_Export.txt"
    Public fullPath As String
    Public exportFullPath As String


    'Set up initial file export
    Public Sub Export()
        Try
            Dim dialog As New FolderBrowserDialog() With {
                .RootFolder = Environment.SpecialFolder.Desktop,
                .SelectedPath = "C:\",
                .Description = "Please select a location to save the configuration file."
            }

            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                subPath = dialog.SelectedPath

            Else
                MessageBox.Show("Error: Configuration file not saved. Exiting Program.")
                MainForm.Close()
            End If

            fullPath = subPath + configFile

            SWriter(fullPath)

            MessageBox.Show("Success! Configuration file saved at: " + fullPath)

        Catch ex As Exception
            MessageBox.Show("An error ocurred: " + ex.Message)
        End Try
    End Sub

    Public Sub ExportFile(
        ByRef fieldArray As Integer(),
        appliance As String,
        ByRef arrayCost As Integer())

        Try
            Dim dialog As New FolderBrowserDialog() With {
                .RootFolder = Environment.SpecialFolder.Desktop,
                .SelectedPath = "C:\",
                .Description = "Please select a location to save the file."
            }

            If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                exportSubPath = dialog.SelectedPath

            Else
                MessageBox.Show("Error: Export file not saved. Please try again.")
                Return
            End If

            fullPath = exportSubPath + exportFileName

            SWriterExport(fullPath, fieldArray, appliance, arrayCost)

            MessageBox.Show("Success! Export file saved at: " + fullPath)

        Catch ex As Exception
            MessageBox.Show("An error ocurred: " + ex.Message + " at " + ex.TargetSite.ToString())
        End Try
    End Sub

    Private Sub SWriter(path As String)
        Using sw As StreamWriter = New StreamWriter(path)
            sw.Write("Refrigerator" & "," &
                GetDefaultValues.RefrigeratorDefaults(0).ToString() & "," &
                GetDefaultValues.RefrigeratorDefaults(1).ToString() & "," &
                GetDefaultValues.RefrigeratorDefaults(2).ToString() &
                vbNewLine &
                "TV" & "," &
                GetDefaultValues.TvDefaults(0).ToString() & "," &
                GetDefaultValues.TvDefaults(1).ToString() & "," &
                GetDefaultValues.TvDefaults(2).ToString() &
                 vbNewLine &
                "Space Heater" & "," &
                GetDefaultValues.SpaceHeaterDefaults(0).ToString() & "," &
                GetDefaultValues.SpaceHeaterDefaults(1).ToString() & "," &
                GetDefaultValues.SpaceHeaterDefaults(2).ToString() &
                vbNewLine &
                "Fan" & "," &
                GetDefaultValues.FanDefaults(0).ToString() & "," &
                GetDefaultValues.FanDefaults(1).ToString() & "," &
                GetDefaultValues.FanDefaults(2).ToString() &
                vbNewLine &
                "Dryer" & "," &
                GetDefaultValues.DryerDefaults(0).ToString() & "," &
                GetDefaultValues.DryerDefaults(1).ToString() & "," &
                GetDefaultValues.DryerDefaults(2).ToString() &
                vbNewLine &
                "Oven" & "," &
                GetDefaultValues.OvenDefaults(0).ToString() & "," &
                GetDefaultValues.OvenDefaults(1).ToString() & "," &
                GetDefaultValues.OvenDefaults(2).ToString() &
                vbNewLine &
                "Washer" & "," &
                GetDefaultValues.WasherDefaults(0).ToString() & "," &
                GetDefaultValues.WasherDefaults(1).ToString() & "," &
                GetDefaultValues.WasherDefaults(2).ToString() & "," &
                GetDefaultValues.WasherDefaults(3).ToString() & "," &
                GetDefaultValues.WasherDefaults(4).ToString()
            )
        End Using
    End Sub

    Private Sub SWriterExport(
            path As String,
            ByVal fieldValueArray As Integer(),
            applianceItem As String,
            ByVal costArray As Integer())
        Try
            If (fieldValueArray.Length = 3) Then
                Using sw As StreamWriter = New StreamWriter(path)
                    sw.WriteLine("Appliance:" + applianceItem)
                    sw.WriteLine("Power Needed: " + fieldValueArray(0).ToString())
                    sw.WriteLine("Cost Per Hour: " + fieldValueArray(1).ToString())
                    sw.WriteLine("Hours Used Per Day: " + fieldValueArray(2).ToString())
                    sw.WriteLine("----- Totals --------")
                    sw.WriteLine("Total Amount: " + costArray(0).ToString())
                    sw.WriteLine("Monthly Costs: " + costArray(1).ToString())
                    sw.WriteLine("Yearly Costs: " + costArray(2).ToString())

                End Using
            Else
                Using sw As StreamWriter = New StreamWriter(path)
                    sw.WriteLine("Appliance:" + applianceItem)
                    sw.WriteLine("Power Needed: " + fieldValueArray(0).ToString())
                    sw.WriteLine("Cost Per Hour: " + fieldValueArray(1).ToString())
                    sw.WriteLine("Hours Used Per Day: " + fieldValueArray(2).ToString())
                    sw.WriteLine("Gallons of Water: " + fieldValueArray(3).ToString())
                    sw.WriteLine("Cost of Water: " + fieldValueArray(4).ToString())
                    sw.WriteLine("----- Totals --------")
                    sw.WriteLine("Total Amount: " + costArray(0).ToString())
                    sw.WriteLine("Monthly Costs: " + costArray(1).ToString())
                    sw.WriteLine("Yearly Costs: " + costArray(2).ToString())

                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message + " at " + ex.TargetSite.ToString())
        End Try
    End Sub
End Module