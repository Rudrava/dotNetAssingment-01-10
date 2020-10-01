<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OddEvenChecker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OddEvenChecker))
        Me.value = New System.Windows.Forms.TextBox()
        Me.Header = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'value
        '
        Me.value.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.value.Location = New System.Drawing.Point(430, 107)
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(207, 44)
        Me.value.TabIndex = 0
        '
        'Header
        '
        Me.Header.AutoSize = True
        Me.Header.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Location = New System.Drawing.Point(163, 21)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(416, 38)
        Me.Header.TabIndex = 1
        Me.Header.Text = "Rudrava's Even Odd Checker"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(70, 113)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(286, 38)
        Me.Label.TabIndex = 2
        Me.Label.Text = "Input Number here"
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(279, 194)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(194, 44)
        Me.Submit.TabIndex = 4
        Me.Submit.Text = "Check"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result.Location = New System.Drawing.Point(315, 289)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(108, 38)
        Me.result.TabIndex = 3
        Me.result.Text = "Label3"
        Me.result.Visible = False
        '
        'OddEvenChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.value)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OddEvenChecker"
        Me.Text = "Odd Even Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents value As TextBox
    Friend WithEvents Header As Label
    Friend WithEvents Label As Label
    Friend WithEvents Submit As Button
    Friend WithEvents result As Label
End Class
