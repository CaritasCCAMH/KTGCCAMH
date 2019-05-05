<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENT_REGISTRATION_FORM
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PROVINCE = New System.Windows.Forms.ComboBox
        Me.cbodistrict = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PROVINCE
        '
        Me.PROVINCE.FormattingEnabled = True
        Me.PROVINCE.Location = New System.Drawing.Point(240, 56)
        Me.PROVINCE.Name = "PROVINCE"
        Me.PROVINCE.Size = New System.Drawing.Size(160, 21)
        Me.PROVINCE.TabIndex = 2
        '
        'cbodistrict
        '
        Me.cbodistrict.FormattingEnabled = True
        Me.cbodistrict.Location = New System.Drawing.Point(422, 56)
        Me.cbodistrict.Name = "cbodistrict"
        Me.cbodistrict.Size = New System.Drawing.Size(160, 21)
        Me.cbodistrict.TabIndex = 3
        '
        'CLIENT_REGISTRATION_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 261)
        Me.Controls.Add(Me.cbodistrict)
        Me.Controls.Add(Me.PROVINCE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "CLIENT_REGISTRATION_FORM"
        Me.Text = "CLIENT_REGISTRATION_FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PROVINCE As System.Windows.Forms.ComboBox
    Friend WithEvents cbodistrict As System.Windows.Forms.ComboBox
End Class
