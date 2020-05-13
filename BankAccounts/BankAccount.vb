''' <summary>
'''     Represents a single bank account.
''' </summary>
''' <author>Claudia Hawkes</author>
''' <date>12/05/20</date>
Public Class BankAccount

    Private AccountHolder As String
    Private AccountNumber As String
    Private InterestRate As Double
    Private Balance As Double
    Private CountryOfOrigin As String

    Public Sub New(Name As String, Account As String, Balance As Double, Interest As Double, Country As String)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate
        Me.CountryOfOrigin = CountryOfOrigin

    End Sub

    Public Sub New(Name As String, Account As String, Balance As Double, Interest As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate

    End Sub

    Public Sub New(Name As String, Account As String, Balance As Double)
        Me.AccountNumber = AccountNumber
        Me.AccountHolder = AccountHolder
        Me.Balance = Balance
    End Sub


End Class
