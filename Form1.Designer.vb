<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        StepLabel = New Label()
        OKButton = New Button()
        ExitButton = New Button()
        StepTextBox = New TextBox()
        OutPutLabel = New Label()
        SuspendLayout()
        ' 
        ' StepLabel
        ' 
        StepLabel.AutoSize = True
        StepLabel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        StepLabel.Location = New Point(46, 44)
        StepLabel.Name = "StepLabel"
        StepLabel.Size = New Size(56, 21)
        StepLabel.TabIndex = 0
        StepLabel.Text = "Step  :"
        ' 
        ' OKButton
        ' 
        OKButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        OKButton.Location = New Point(253, 36)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(66, 41)
        OKButton.TabIndex = 1
        OKButton.Text = "OK"
        OKButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(376, 254)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(88, 46)
        ExitButton.TabIndex = 2
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' StepTextBox
        ' 
        StepTextBox.Location = New Point(106, 36)
        StepTextBox.Multiline = True
        StepTextBox.Name = "StepTextBox"
        StepTextBox.Size = New Size(124, 41)
        StepTextBox.TabIndex = 3
        ' 
        ' OutPutLabel
        ' 
        OutPutLabel.AutoSize = True
        OutPutLabel.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        OutPutLabel.Location = New Point(106, 144)
        OutPutLabel.Name = "OutPutLabel"
        OutPutLabel.Size = New Size(0, 17)
        OutPutLabel.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSalmon
        ClientSize = New Size(487, 380)
        Controls.Add(OutPutLabel)
        Controls.Add(StepTextBox)
        Controls.Add(ExitButton)
        Controls.Add(OKButton)
        Controls.Add(StepLabel)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StepLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StepTextBox As TextBox
    Friend WithEvents OutPutLabel As Label
End Class
