<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Model2
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
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnBukaModel1 = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.gb2 = New System.Windows.Forms.GroupBox()
        Me.lVarA = New System.Windows.Forms.Label()
        Me.lVarB = New System.Windows.Forms.Label()
        Me.lVarC = New System.Windows.Forms.Label()
        Me.lTd3 = New System.Windows.Forms.Label()
        Me.lTd2 = New System.Windows.Forms.Label()
        Me.lTd1 = New System.Windows.Forms.Label()
        Me.tbVarA = New System.Windows.Forms.TextBox()
        Me.tbVarB = New System.Windows.Forms.TextBox()
        Me.tbVarC = New System.Windows.Forms.TextBox()
        Me.lbHasil = New System.Windows.Forms.ListBox()
        Me.lbOperand = New System.Windows.Forms.Label()
        Me.cbOperand = New System.Windows.Forms.ComboBox()
        Me.gb1.SuspendLayout()
        Me.gb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.tbVarC)
        Me.gb1.Controls.Add(Me.tbVarB)
        Me.gb1.Controls.Add(Me.tbVarA)
        Me.gb1.Controls.Add(Me.lTd3)
        Me.gb1.Controls.Add(Me.lTd2)
        Me.gb1.Controls.Add(Me.lTd1)
        Me.gb1.Controls.Add(Me.lVarC)
        Me.gb1.Controls.Add(Me.lVarB)
        Me.gb1.Controls.Add(Me.lVarA)
        Me.gb1.Location = New System.Drawing.Point(12, 65)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(235, 100)
        Me.gb1.TabIndex = 0
        Me.gb1.TabStop = False
        Me.gb1.Text = "GroupBox1"
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(13, 172)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(114, 38)
        Me.btnHitung.TabIndex = 1
        Me.btnHitung.Text = "Button1"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnBukaModel1
        '
        Me.btnBukaModel1.Location = New System.Drawing.Point(133, 172)
        Me.btnBukaModel1.Name = "btnBukaModel1"
        Me.btnBukaModel1.Size = New System.Drawing.Size(114, 38)
        Me.btnBukaModel1.TabIndex = 2
        Me.btnBukaModel1.Text = "Button2"
        Me.btnBukaModel1.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(13, 322)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(114, 38)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Button3"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'gb2
        '
        Me.gb2.Controls.Add(Me.lbHasil)
        Me.gb2.Location = New System.Drawing.Point(13, 216)
        Me.gb2.Name = "gb2"
        Me.gb2.Size = New System.Drawing.Size(234, 100)
        Me.gb2.TabIndex = 4
        Me.gb2.TabStop = False
        Me.gb2.Text = "GroupBox2"
        '
        'lVarA
        '
        Me.lVarA.AutoSize = True
        Me.lVarA.Location = New System.Drawing.Point(7, 24)
        Me.lVarA.Name = "lVarA"
        Me.lVarA.Size = New System.Drawing.Size(39, 13)
        Me.lVarA.TabIndex = 0
        Me.lVarA.Text = "Label1"
        '
        'lVarB
        '
        Me.lVarB.AutoSize = True
        Me.lVarB.Location = New System.Drawing.Point(7, 48)
        Me.lVarB.Name = "lVarB"
        Me.lVarB.Size = New System.Drawing.Size(39, 13)
        Me.lVarB.TabIndex = 1
        Me.lVarB.Text = "Label2"
        '
        'lVarC
        '
        Me.lVarC.AutoSize = True
        Me.lVarC.Location = New System.Drawing.Point(7, 72)
        Me.lVarC.Name = "lVarC"
        Me.lVarC.Size = New System.Drawing.Size(39, 13)
        Me.lVarC.TabIndex = 2
        Me.lVarC.Text = "Label3"
        '
        'lTd3
        '
        Me.lTd3.AutoSize = True
        Me.lTd3.Location = New System.Drawing.Point(92, 72)
        Me.lTd3.Name = "lTd3"
        Me.lTd3.Size = New System.Drawing.Size(39, 13)
        Me.lTd3.TabIndex = 5
        Me.lTd3.Text = "Label4"
        '
        'lTd2
        '
        Me.lTd2.AutoSize = True
        Me.lTd2.Location = New System.Drawing.Point(92, 48)
        Me.lTd2.Name = "lTd2"
        Me.lTd2.Size = New System.Drawing.Size(39, 13)
        Me.lTd2.TabIndex = 4
        Me.lTd2.Text = "Label5"
        '
        'lTd1
        '
        Me.lTd1.AutoSize = True
        Me.lTd1.Location = New System.Drawing.Point(92, 24)
        Me.lTd1.Name = "lTd1"
        Me.lTd1.Size = New System.Drawing.Size(39, 13)
        Me.lTd1.TabIndex = 3
        Me.lTd1.Text = "Label6"
        '
        'tbVarA
        '
        Me.tbVarA.Location = New System.Drawing.Point(121, 20)
        Me.tbVarA.Name = "tbVarA"
        Me.tbVarA.Size = New System.Drawing.Size(100, 20)
        Me.tbVarA.TabIndex = 6
        '
        'tbVarB
        '
        Me.tbVarB.Location = New System.Drawing.Point(121, 44)
        Me.tbVarB.Name = "tbVarB"
        Me.tbVarB.Size = New System.Drawing.Size(100, 20)
        Me.tbVarB.TabIndex = 7
        '
        'tbVarC
        '
        Me.tbVarC.Location = New System.Drawing.Point(121, 68)
        Me.tbVarC.Name = "tbVarC"
        Me.tbVarC.Size = New System.Drawing.Size(100, 20)
        Me.tbVarC.TabIndex = 8
        '
        'lbHasil
        '
        Me.lbHasil.FormattingEnabled = True
        Me.lbHasil.Location = New System.Drawing.Point(9, 20)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(211, 69)
        Me.lbHasil.TabIndex = 0
        '
        'lbOperand
        '
        Me.lbOperand.AutoSize = True
        Me.lbOperand.Location = New System.Drawing.Point(13, 13)
        Me.lbOperand.Name = "lbOperand"
        Me.lbOperand.Size = New System.Drawing.Size(39, 13)
        Me.lbOperand.TabIndex = 6
        Me.lbOperand.Text = "Label1"
        '
        'cbOperand
        '
        Me.cbOperand.FormattingEnabled = True
        Me.cbOperand.Location = New System.Drawing.Point(16, 30)
        Me.cbOperand.Name = "cbOperand"
        Me.cbOperand.Size = New System.Drawing.Size(73, 21)
        Me.cbOperand.TabIndex = 7
        '
        'Model2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 373)
        Me.Controls.Add(Me.cbOperand)
        Me.Controls.Add(Me.lbOperand)
        Me.Controls.Add(Me.gb2)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBukaModel1)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Model2"
        Me.Text = "Model2"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.gb2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBukaModel1 As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents gb2 As GroupBox
    Friend WithEvents lVarC As Label
    Friend WithEvents lVarB As Label
    Friend WithEvents lVarA As Label
    Friend WithEvents tbVarC As TextBox
    Friend WithEvents tbVarB As TextBox
    Friend WithEvents tbVarA As TextBox
    Friend WithEvents lTd3 As Label
    Friend WithEvents lTd2 As Label
    Friend WithEvents lTd1 As Label
    Friend WithEvents lbHasil As ListBox
    Friend WithEvents lbOperand As Label
    Friend WithEvents cbOperand As ComboBox
End Class
