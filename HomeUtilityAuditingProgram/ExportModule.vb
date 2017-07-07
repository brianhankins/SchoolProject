Imports System.IO

Module ExportModule
    Private subPath = "c:\"

    'Saves text file to local machine
    Public Sub ExportDefaultVaules(path As String)
        Try
            'Check if file exists at path location & rename file if exists
            If (File.Exists(path)) = True Then
                Dim userInput As String

                userInput = InputBox("What would you like to name this text file?", "Cancel", Nothing)
                If (userInput Is Nothing OrElse userInput = "") Then
                    MessageBox.Show("Error: Cancelled Export")
                Else
                    path = subPath + userInput + ".txt"
                    MessageBox.Show("The file has been saved to: " + path)
                End If
            End If

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

        Catch
            MessageBox.Show("Error: An error occured. Please try again.")
        End Try
    End Sub
End Module
