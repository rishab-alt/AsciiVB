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
        lblASCII = New Label()
        txtInput = New TextBox()
        btnConvert = New Button()
        SuspendLayout()
        ' 
        ' lblASCII
        ' 
        lblASCII.AutoSize = True
        lblASCII.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lblASCII.Location = New Point(29, 25)
        lblASCII.Name = "lblASCII"
        lblASCII.Size = New Size(183, 45)
        lblASCII.TabIndex = 0
        lblASCII.Text = "Ascii result"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(234, 317)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(148, 23)
        txtInput.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(271, 355)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Submit"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(618, 450)
        Controls.Add(btnConvert)
        Controls.Add(txtInput)
        Controls.Add(lblASCII)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblASCII As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnConvert As Button
End Class
