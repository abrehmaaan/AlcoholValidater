<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label = New System.Windows.Forms.Label()
        Me.age = New System.Windows.Forms.TextBox()
        Me.check = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label.Location = New System.Drawing.Point(246, 47)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(325, 37)
        Me.label.TabIndex = 0
        Me.label.Text = "Drink Verification"
        Me.label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'age
        '
        Me.age.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.age.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.age.ForeColor = System.Drawing.SystemColors.Info
        Me.age.Location = New System.Drawing.Point(246, 180)
        Me.age.Name = "age"
        Me.age.PlaceholderText = "Enter Your Age"
        Me.age.Size = New System.Drawing.Size(325, 34)
        Me.age.TabIndex = 1
        Me.age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'check
        '
        Me.check.BackColor = System.Drawing.SystemColors.ControlText
        Me.check.Font = New System.Drawing.Font("Poor Richard", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.check.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.check.Location = New System.Drawing.Point(346, 273)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(148, 64)
        Me.check.TabIndex = 2
        Me.check.Text = "Verify"
        Me.check.UseVisualStyleBackColor = False
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.result.Location = New System.Drawing.Point(397, 373)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(0, 20)
        Me.result.TabIndex = 3
        Me.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.label)
        Me.Name = "Form1"
        Me.Text = "Drink Verification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label As Label
    Friend WithEvents age As TextBox
    Friend WithEvents check As Button
    Friend WithEvents result As Label
End Class
