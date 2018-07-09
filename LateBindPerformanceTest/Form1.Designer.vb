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
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.txtLate = New System.Windows.Forms.TextBox()
        Me.txtEarly = New System.Windows.Forms.TextBox()
        Me.lblEarly = New System.Windows.Forms.Label()
        Me.lblLate = New System.Windows.Forms.Label()
        Me.lblTwoLate = New System.Windows.Forms.Label()
        Me.txtDoubleLate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(118, 31)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(100, 23)
        Me.btnRun.TabIndex = 0
        Me.btnRun.Text = "Run Test"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(12, 33)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCount.TabIndex = 1
        '
        'txtLate
        '
        Me.txtLate.Location = New System.Drawing.Point(118, 136)
        Me.txtLate.Name = "txtLate"
        Me.txtLate.ReadOnly = True
        Me.txtLate.Size = New System.Drawing.Size(100, 20)
        Me.txtLate.TabIndex = 2
        '
        'txtEarly
        '
        Me.txtEarly.Location = New System.Drawing.Point(118, 91)
        Me.txtEarly.Name = "txtEarly"
        Me.txtEarly.ReadOnly = True
        Me.txtEarly.Size = New System.Drawing.Size(100, 20)
        Me.txtEarly.TabIndex = 2
        '
        'lblEarly
        '
        Me.lblEarly.AutoSize = True
        Me.lblEarly.Location = New System.Drawing.Point(12, 94)
        Me.lblEarly.Name = "lblEarly"
        Me.lblEarly.Size = New System.Drawing.Size(68, 13)
        Me.lblEarly.TabIndex = 3
        Me.lblEarly.Text = "Early Binding"
        '
        'lblLate
        '
        Me.lblLate.AutoSize = True
        Me.lblLate.Location = New System.Drawing.Point(12, 139)
        Me.lblLate.Name = "lblLate"
        Me.lblLate.Size = New System.Drawing.Size(66, 13)
        Me.lblLate.TabIndex = 3
        Me.lblLate.Text = "Late Binding"
        '
        'lblTwoLate
        '
        Me.lblTwoLate.AutoSize = True
        Me.lblTwoLate.Location = New System.Drawing.Point(12, 182)
        Me.lblTwoLate.Name = "lblTwoLate"
        Me.lblTwoLate.Size = New System.Drawing.Size(75, 13)
        Me.lblTwoLate.TabIndex = 4
        Me.lblTwoLate.Text = "2-Late Binding"
        '
        'txtDoubleLate
        '
        Me.txtDoubleLate.Location = New System.Drawing.Point(118, 179)
        Me.txtDoubleLate.Name = "txtDoubleLate"
        Me.txtDoubleLate.ReadOnly = True
        Me.txtDoubleLate.Size = New System.Drawing.Size(100, 20)
        Me.txtDoubleLate.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 222)
        Me.Controls.Add(Me.lblTwoLate)
        Me.Controls.Add(Me.lblLate)
        Me.Controls.Add(Me.lblEarly)
        Me.Controls.Add(Me.txtEarly)
        Me.Controls.Add(Me.txtDoubleLate)
        Me.Controls.Add(Me.txtLate)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.btnRun)
        Me.MaximumSize = New System.Drawing.Size(260, 260)
        Me.MinimumSize = New System.Drawing.Size(260, 260)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRun As Button
    Friend WithEvents txtCount As TextBox
    Friend WithEvents txtLate As TextBox
    Friend WithEvents txtEarly As TextBox
    Friend WithEvents lblEarly As Label
    Friend WithEvents lblLate As Label
    Friend WithEvents lblTwoLate As Label
    Friend WithEvents txtDoubleLate As TextBox
End Class
