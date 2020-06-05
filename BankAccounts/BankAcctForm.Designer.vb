<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAcctForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAccountHolder = New System.Windows.Forms.TextBox()
        Me.AccountHolder = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.AccountNumber = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(680, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 97)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAccountHolder
        '
        Me.txtAccountHolder.Location = New System.Drawing.Point(12, 41)
        Me.txtAccountHolder.Name = "txtAccountHolder"
        Me.txtAccountHolder.Size = New System.Drawing.Size(271, 31)
        Me.txtAccountHolder.TabIndex = 1
        '
        'AccountHolder
        '
        Me.AccountHolder.AutoSize = True
        Me.AccountHolder.Location = New System.Drawing.Point(12, 9)
        Me.AccountHolder.Name = "AccountHolder"
        Me.AccountHolder.Size = New System.Drawing.Size(227, 25)
        Me.AccountHolder.TabIndex = 2
        Me.AccountHolder.Text = "Account Holder Name:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(12, 135)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(271, 31)
        Me.txtAccountNumber.TabIndex = 3
        '
        'AccountNumber
        '
        Me.AccountNumber.AutoSize = True
        Me.AccountNumber.Location = New System.Drawing.Point(12, 107)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(177, 25)
        Me.AccountNumber.TabIndex = 4
        Me.AccountNumber.Text = "Account Number:"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(12, 233)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(271, 31)
        Me.txtInterestRate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'BankAcctForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 534)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.AccountNumber)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.AccountHolder)
        Me.Controls.Add(Me.txtAccountHolder)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "BankAcctForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents txtAccountHolder As Windows.Forms.TextBox
    Friend WithEvents AccountHolder As Windows.Forms.Label
    Friend WithEvents txtAccountNumber As Windows.Forms.TextBox
    Friend WithEvents AccountNumber As Windows.Forms.Label
    Friend WithEvents txtInterestRate As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
