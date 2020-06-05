<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txtAccountHolder
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
        Me.txtAccountHolderName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtCountryOfOrigin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddAccounts = New System.Windows.Forms.Button()
        Me.btnAddInterest = New System.Windows.Forms.Button()
        Me.btnPrintAccounts = New System.Windows.Forms.Button()
        Me.txtAccountList = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAccountHolderName
        '
        Me.txtAccountHolderName.Location = New System.Drawing.Point(35, 53)
        Me.txtAccountHolderName.Name = "txtAccountHolderName"
        Me.txtAccountHolderName.Size = New System.Drawing.Size(509, 31)
        Me.txtAccountHolderName.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(941, 598)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(157, 88)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Account Holder Name:"
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(35, 170)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(509, 31)
        Me.txtAccountNumber.TabIndex = 4
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(35, 298)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(509, 31)
        Me.txtInterestRate.TabIndex = 5
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(35, 416)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(509, 31)
        Me.txtBalance.TabIndex = 6
        '
        'txtCountryOfOrigin
        '
        Me.txtCountryOfOrigin.Location = New System.Drawing.Point(35, 526)
        Me.txtCountryOfOrigin.Name = "txtCountryOfOrigin"
        Me.txtCountryOfOrigin.Size = New System.Drawing.Size(509, 31)
        Me.txtCountryOfOrigin.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Account Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Interest Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 388)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Balance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 498)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Country Of Origin:"
        '
        'btnAddAccounts
        '
        Me.btnAddAccounts.Location = New System.Drawing.Point(637, 598)
        Me.btnAddAccounts.Name = "btnAddAccounts"
        Me.btnAddAccounts.Size = New System.Drawing.Size(162, 91)
        Me.btnAddAccounts.TabIndex = 12
        Me.btnAddAccounts.Text = "Add Account"
        Me.btnAddAccounts.UseVisualStyleBackColor = True
        '
        'btnAddInterest
        '
        Me.btnAddInterest.Location = New System.Drawing.Point(335, 598)
        Me.btnAddInterest.Name = "btnAddInterest"
        Me.btnAddInterest.Size = New System.Drawing.Size(150, 91)
        Me.btnAddInterest.TabIndex = 13
        Me.btnAddInterest.Text = "Add Interest"
        Me.btnAddInterest.UseVisualStyleBackColor = True
        '
        'btnPrintAccounts
        '
        Me.btnPrintAccounts.Location = New System.Drawing.Point(35, 598)
        Me.btnPrintAccounts.Name = "btnPrintAccounts"
        Me.btnPrintAccounts.Size = New System.Drawing.Size(150, 91)
        Me.btnPrintAccounts.TabIndex = 14
        Me.btnPrintAccounts.Text = "Print Accounts"
        Me.btnPrintAccounts.UseVisualStyleBackColor = True
        '
        'txtAccountList
        '
        Me.txtAccountList.Location = New System.Drawing.Point(619, 53)
        Me.txtAccountList.Multiline = True
        Me.txtAccountList.Name = "txtAccountList"
        Me.txtAccountList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAccountList.Size = New System.Drawing.Size(509, 504)
        Me.txtAccountList.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(614, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Account List:"
        '
        'txtAccountHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1151, 701)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAccountList)
        Me.Controls.Add(Me.btnPrintAccounts)
        Me.Controls.Add(Me.btnAddInterest)
        Me.Controls.Add(Me.btnAddAccounts)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCountryOfOrigin)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtAccountHolderName)
        Me.Name = "txtAccountHolder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAccountHolderName As Windows.Forms.TextBox
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtAccountNumber As Windows.Forms.TextBox
    Friend WithEvents txtInterestRate As Windows.Forms.TextBox
    Friend WithEvents txtBalance As Windows.Forms.TextBox
    Friend WithEvents txtCountryOfOrigin As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents btnAddAccounts As Windows.Forms.Button
    Friend WithEvents btnAddInterest As Windows.Forms.Button
    Friend WithEvents btnPrintAccounts As Windows.Forms.Button
    Friend WithEvents txtAccountList As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
End Class
