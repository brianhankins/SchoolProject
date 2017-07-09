<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.applianceList = New System.Windows.Forms.ComboBox()
        Me.selectApplianceLabel = New System.Windows.Forms.Label()
        Me.kilowattLabel = New System.Windows.Forms.Label()
        Me.kilowattNumber = New System.Windows.Forms.NumericUpDown()
        Me.hourLabel = New System.Windows.Forms.Label()
        Me.hoursUsedNumber = New System.Windows.Forms.NumericUpDown()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.PowerNeededLabel = New System.Windows.Forms.Label()
        Me.powerNeededNumber = New System.Windows.Forms.NumericUpDown()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.LabelWater = New System.Windows.Forms.Label()
        Me.numberOfGallons = New System.Windows.Forms.NumericUpDown()
        Me.LabelWaterCost = New System.Windows.Forms.Label()
        Me.costofWater = New System.Windows.Forms.NumericUpDown()
        Me.TotalWaterLabel = New System.Windows.Forms.Label()
        Me.ExportFileBtn = New System.Windows.Forms.Button()
        Me.totalCostsBtn = New System.Windows.Forms.Button()
        Me.showTotalCostsLbl = New System.Windows.Forms.Label()
        Me.ExitAppBtn = New System.Windows.Forms.Button()
        CType(Me.kilowattNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hoursUsedNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerNeededNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfGallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.costofWater, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(638, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home Utility Auditing Program"
        '
        'applianceList
        '
        Me.applianceList.FormattingEnabled = True
        Me.applianceList.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Washer", "Oven"})
        Me.applianceList.Location = New System.Drawing.Point(272, 211)
        Me.applianceList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.applianceList.Name = "applianceList"
        Me.applianceList.Size = New System.Drawing.Size(300, 28)
        Me.applianceList.TabIndex = 1
        '
        'selectApplianceLabel
        '
        Me.selectApplianceLabel.AutoSize = True
        Me.selectApplianceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectApplianceLabel.Location = New System.Drawing.Point(266, 175)
        Me.selectApplianceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.selectApplianceLabel.Name = "selectApplianceLabel"
        Me.selectApplianceLabel.Size = New System.Drawing.Size(200, 29)
        Me.selectApplianceLabel.TabIndex = 2
        Me.selectApplianceLabel.Text = "Select Appliance:"
        '
        'kilowattLabel
        '
        Me.kilowattLabel.AutoSize = True
        Me.kilowattLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kilowattLabel.Location = New System.Drawing.Point(266, 357)
        Me.kilowattLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.kilowattLabel.Name = "kilowattLabel"
        Me.kilowattLabel.Size = New System.Drawing.Size(259, 29)
        Me.kilowattLabel.TabIndex = 3
        Me.kilowattLabel.Text = "Cost per kilowatt-hour: "
        '
        'kilowattNumber
        '
        Me.kilowattNumber.Location = New System.Drawing.Point(272, 392)
        Me.kilowattNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kilowattNumber.Name = "kilowattNumber"
        Me.kilowattNumber.Size = New System.Drawing.Size(180, 26)
        Me.kilowattNumber.TabIndex = 4
        '
        'hourLabel
        '
        Me.hourLabel.AutoSize = True
        Me.hourLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourLabel.Location = New System.Drawing.Point(266, 451)
        Me.hourLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.hourLabel.Name = "hourLabel"
        Me.hourLabel.Size = New System.Drawing.Size(359, 29)
        Me.hourLabel.TabIndex = 5
        Me.hourLabel.Text = "Number of hours used (per day):"
        '
        'hoursUsedNumber
        '
        Me.hoursUsedNumber.Location = New System.Drawing.Point(272, 486)
        Me.hoursUsedNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.hoursUsedNumber.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.hoursUsedNumber.Name = "hoursUsedNumber"
        Me.hoursUsedNumber.Size = New System.Drawing.Size(180, 26)
        Me.hoursUsedNumber.TabIndex = 6
        '
        'CalculateButton
        '
        Me.CalculateButton.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.CalculateButton.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.CalculateButton.Location = New System.Drawing.Point(272, 746)
        Me.CalculateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(302, 42)
        Me.CalculateButton.TabIndex = 7
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = False
        '
        'PowerNeededLabel
        '
        Me.PowerNeededLabel.AutoSize = True
        Me.PowerNeededLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerNeededLabel.Location = New System.Drawing.Point(270, 263)
        Me.PowerNeededLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PowerNeededLabel.Name = "PowerNeededLabel"
        Me.PowerNeededLabel.Size = New System.Drawing.Size(293, 29)
        Me.PowerNeededLabel.TabIndex = 9
        Me.PowerNeededLabel.Text = "Power needed (kilowatts):"
        '
        'powerNeededNumber
        '
        Me.powerNeededNumber.Location = New System.Drawing.Point(276, 298)
        Me.powerNeededNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.powerNeededNumber.Name = "powerNeededNumber"
        Me.powerNeededNumber.Size = New System.Drawing.Size(180, 26)
        Me.powerNeededNumber.TabIndex = 10
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(270, 821)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(0, 33)
        Me.TotalLabel.TabIndex = 11
        Me.TotalLabel.Visible = False
        '
        'LabelWater
        '
        Me.LabelWater.AutoSize = True
        Me.LabelWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWater.Location = New System.Drawing.Point(266, 546)
        Me.LabelWater.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWater.Name = "LabelWater"
        Me.LabelWater.Size = New System.Drawing.Size(350, 29)
        Me.LabelWater.TabIndex = 12
        Me.LabelWater.Text = "Amount of water used (gallons):"
        Me.LabelWater.Visible = False
        '
        'numberOfGallons
        '
        Me.numberOfGallons.Location = New System.Drawing.Point(272, 582)
        Me.numberOfGallons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numberOfGallons.Name = "numberOfGallons"
        Me.numberOfGallons.Size = New System.Drawing.Size(180, 26)
        Me.numberOfGallons.TabIndex = 13
        Me.numberOfGallons.Visible = False
        '
        'LabelWaterCost
        '
        Me.LabelWaterCost.AutoSize = True
        Me.LabelWaterCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWaterCost.Location = New System.Drawing.Point(266, 643)
        Me.LabelWaterCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWaterCost.Name = "LabelWaterCost"
        Me.LabelWaterCost.Size = New System.Drawing.Size(271, 29)
        Me.LabelWaterCost.TabIndex = 14
        Me.LabelWaterCost.Text = "Cost of water (per hour):"
        Me.LabelWaterCost.Visible = False
        '
        'costofWater
        '
        Me.costofWater.Location = New System.Drawing.Point(272, 678)
        Me.costofWater.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.costofWater.Name = "costofWater"
        Me.costofWater.Size = New System.Drawing.Size(180, 26)
        Me.costofWater.TabIndex = 15
        Me.costofWater.Visible = False
        '
        'TotalWaterLabel
        '
        Me.TotalWaterLabel.AutoSize = True
        Me.TotalWaterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalWaterLabel.Location = New System.Drawing.Point(268, 881)
        Me.TotalWaterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalWaterLabel.Name = "TotalWaterLabel"
        Me.TotalWaterLabel.Size = New System.Drawing.Size(0, 33)
        Me.TotalWaterLabel.TabIndex = 16
        Me.TotalWaterLabel.Visible = False
        '
        'ExportFileBtn
        '
        Me.ExportFileBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExportFileBtn.Location = New System.Drawing.Point(931, 14)
        Me.ExportFileBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ExportFileBtn.Name = "ExportFileBtn"
        Me.ExportFileBtn.Size = New System.Drawing.Size(164, 42)
        Me.ExportFileBtn.TabIndex = 17
        Me.ExportFileBtn.Text = "Export As File"
        Me.ExportFileBtn.UseVisualStyleBackColor = False
        '
        'totalCostsBtn
        '
        Me.totalCostsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.totalCostsBtn.Location = New System.Drawing.Point(618, 746)
        Me.totalCostsBtn.Name = "totalCostsBtn"
        Me.totalCostsBtn.Size = New System.Drawing.Size(166, 42)
        Me.totalCostsBtn.TabIndex = 18
        Me.totalCostsBtn.Text = "Show Total Costs"
        Me.totalCostsBtn.UseVisualStyleBackColor = False
        Me.totalCostsBtn.Visible = False
        '
        'showTotalCostsLbl
        '
        Me.showTotalCostsLbl.AutoSize = True
        Me.showTotalCostsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showTotalCostsLbl.Location = New System.Drawing.Point(277, 848)
        Me.showTotalCostsLbl.Name = "showTotalCostsLbl"
        Me.showTotalCostsLbl.Size = New System.Drawing.Size(0, 32)
        Me.showTotalCostsLbl.TabIndex = 19
        Me.showTotalCostsLbl.Visible = False
        '
        'ExitAppBtn
        '
        Me.ExitAppBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.ExitAppBtn.Location = New System.Drawing.Point(13, 14)
        Me.ExitAppBtn.Name = "ExitAppBtn"
        Me.ExitAppBtn.Size = New System.Drawing.Size(93, 42)
        Me.ExitAppBtn.TabIndex = 20
        Me.ExitAppBtn.Text = "Exit"
        Me.ExitAppBtn.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1142, 957)
        Me.Controls.Add(Me.ExitAppBtn)
        Me.Controls.Add(Me.showTotalCostsLbl)
        Me.Controls.Add(Me.totalCostsBtn)
        Me.Controls.Add(Me.ExportFileBtn)
        Me.Controls.Add(Me.TotalWaterLabel)
        Me.Controls.Add(Me.costofWater)
        Me.Controls.Add(Me.LabelWaterCost)
        Me.Controls.Add(Me.numberOfGallons)
        Me.Controls.Add(Me.LabelWater)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.powerNeededNumber)
        Me.Controls.Add(Me.PowerNeededLabel)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.hoursUsedNumber)
        Me.Controls.Add(Me.hourLabel)
        Me.Controls.Add(Me.kilowattNumber)
        Me.Controls.Add(Me.kilowattLabel)
        Me.Controls.Add(Me.selectApplianceLabel)
        Me.Controls.Add(Me.applianceList)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        CType(Me.kilowattNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hoursUsedNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerNeededNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfGallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.costofWater, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents applianceList As ComboBox
    Friend WithEvents selectApplianceLabel As Label
    Friend WithEvents kilowattLabel As Label
    Friend WithEvents kilowattNumber As NumericUpDown
    Friend WithEvents hourLabel As Label
    Friend WithEvents hoursUsedNumber As NumericUpDown
    Friend WithEvents CalculateButton As Button
    Friend WithEvents PowerNeededLabel As Label
    Friend WithEvents powerNeededNumber As NumericUpDown
    Friend WithEvents TotalLabel As Label
    Friend WithEvents LabelWater As Label
    Friend WithEvents numberOfGallons As NumericUpDown
    Friend WithEvents LabelWaterCost As Label
    Friend WithEvents costofWater As NumericUpDown
    Friend WithEvents TotalWaterLabel As Label
    Friend WithEvents ExportFileBtn As Button
    Friend WithEvents totalCostsBtn As Button
    Friend WithEvents showTotalCostsLbl As Label
    Friend WithEvents ExitAppBtn As Button
End Class
