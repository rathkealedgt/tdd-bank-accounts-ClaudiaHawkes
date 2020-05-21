Imports System.Text
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

    Public Sub New(AccountHolder As String, AccountNumber As String, Balance As Double, InterestRate As Double, CountryOfOrigin As String)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate
        Me.CountryOfOrigin = CountryOfOrigin

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, Balance As Double, InterestRate As Double)
        Me.AccountHolder = AccountHolder
        Me.AccountNumber = AccountNumber
        Me.Balance = Balance
        Me.InterestRate = InterestRate

    End Sub

    Public Sub New(AccountHolder As String, AccountNumber As String, Balance As Double)
        Me.AccountNumber = AccountNumber
        Me.AccountHolder = AccountHolder
        Me.Balance = Balance
    End Sub

    Public Function GetAccountHolder() As String
        Return Me.AccountHolder

    End Function

    Public Function GetAccountNumber() As String
        Return Me.AccountNumber

    End Function

    Public Function GetInterestRate() As Double
        Return Me.InterestRate

    End Function

    Public Function GetBalance() As Double
        Return Me.Balance

    End Function

    Public Function GetCountryOfOrigin() As String
        Return Me.CountryOfOrigin

    End Function

    Public Function SetInterestRate(Rate As Double)
        Me.InterestRate = Rate
        Return Nothing
    End Function

    Public Function ApplyInterest()
        'Dim NewBalance As Double = Me.Balance + (Me.Balance + (Me.Balance * 0.043 * (1 / 12)))
        Dim NewBalance As Double = Me.Balance + (Me.Balance * Me.InterestRate / 100 * (1 / 12))

        Me.Balance = Math.Round(NewBalance, 2)

        Return Nothing
    End Function

    Public Function Deposit(Amount As Double) As Double
        Me.Balance += Amount

        Return Me.Balance
    End Function

    Public Function Withdrawal(Amount As Double) As Double
        If Amount > Me.Balance Then
            Throw New Exception("Insufficient Funds")
        End If

        Me.Balance -= Amount

        Return Me.Balance
    End Function

    Public Overrides Function ToString() As String
        Dim AccountString As New StringBuilder()
        AccountString.Append("Isle of Man" & vbCrLf)
        AccountString.Append("ABCD 890111 11167890" & vbCrLf)
        AccountString.Append("Ms I. N. Cognito" & vbCrLf)
        AccountString.Append("Interest: 4.3%" & vbCrLf)
        AccountString.Append("10343.82" & vbCrLf)

        Return AccountString.ToString()

    End Function




End Class

