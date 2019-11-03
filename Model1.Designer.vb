<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Model1
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
        Me.lbHasil = New System.Windows.Forms.ListBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnBukaModel2 = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbHasil
        '
        Me.lbHasil.FormattingEnabled = True
        Me.lbHasil.Location = New System.Drawing.Point(13, 12)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(336, 95)
        Me.lbHasil.TabIndex = 0
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(13, 115)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(108, 23)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Button1"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnBukaModel2
        '
        Me.btnBukaModel2.Location = New System.Drawing.Point(127, 115)
        Me.btnBukaModel2.Name = "btnBukaModel2"
        Me.btnBukaModel2.Size = New System.Drawing.Size(108, 23)
        Me.btnBukaModel2.TabIndex = 2
        Me.btnBukaModel2.Text = "Button2"
        Me.btnBukaModel2.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(241, 115)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(108, 23)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Button3"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Model1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 150)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBukaModel2)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.lbHasil)
        Me.Name = "Model1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbHasil As ListBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBukaModel2 As Button
    Friend WithEvents btnKeluar As Button
End Class
