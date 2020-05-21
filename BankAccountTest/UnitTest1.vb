Imports System.Text
Imports BankAccounts
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestContructors()

        ' Arrange
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        ' Act
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
        Dim Account2 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate)
        Dim Account3 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance)

        ' Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)
    End Sub


    <TestMethod()> Public Sub TestGetAccountHolder()
        ' Arrange
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"

        'Act
        Dim Account1 As New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)
        Dim Name As String = Account1.GetAccountHolder()
        Dim Number As String = Account1.GetAccountNumber()
        Dim Interest As Double = Account1.GetInterestRate()
        Dim AccountBalance As Double = Account1.GetBalance()
        Dim Country As String = Account1.GetCountryOfOrigin()

        'Assert
        Assert.AreEqual(Name, "Ms I. N. Cognito")
        Assert.AreEqual(Number, "ABCD 890111 11167890")
        Assert.AreEqual(Interest, 4.3)
        Assert.AreEqual(AccountBalance, 10343.82)
        Assert.AreEqual(Country, "Isle of Man")

    End Sub

    <TestMethod()> Public Sub TestSetInterestRate()
        ' Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act
        Account1.SetInterestRate(5.1)

        ' Assert
        Assert.AreEqual(5.1, Account1.GetInterestRate())

    End Sub

    <TestMethod()> Public Sub TestInterestRate()
        'p x r x t = i => 37.07 + 10343.82 = 10380.89

        ' Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()

        ' Act
        Account1.ApplyInterest()

        ' Assert
        Assert.AreEqual(Account1.GetBalance(), 10380.89)
    End Sub

    <TestMethod()> Public Sub TestToStringMethod()

        'Arrange
        Dim ExpectedValueString As New StringBuilder()
        ExpectedValueString.Append("Isle of Man" & vbCrLf)
        ExpectedValueString.Append("ABCD 890111 11167890" & vbCrLf)
        ExpectedValueString.Append("Ms I. N. Cognito" & vbCrLf)
        ExpectedValueString.Append("Interest: 4.3%" & vbCrLf)
        ExpectedValueString.Append("10343.82" & vbCrLf)

        Dim Account1 As BankAccount = NewAccount()

        'Act
        Dim ActualString = Account1.ToString()

        'Assert
        Assert.AreEqual(ExpectedValueString.ToString(), ActualString)
    End Sub

    <TestMethod()> Public Sub TestDeposit()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedValue As Double = 10343.82 + 700

        'Act
        Dim ActualValue As Double = Account1.Deposit(700)

        'Assert
        Assert.AreEqual(ExpectedValue, ActualValue)

    End Sub

    <TestMethod()> Public Sub TestWithdrawalSmall()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedVal As Double = 10343.82 - 700.0

        'Act
        Dim NewBalance = Account1.Withdrawal(700.0)

        'Assert
        Assert.AreEqual(ExpectedVal, NewBalance)
    End Sub


    <TestMethod()> Public Sub TestWithdrawalLarge()

        'Arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount()
        Dim ExpectedVal As Double = 10343.82 - 700.0

        'Act
        Try
            Dim NewBalance = Account1.Withdrawal(700.0)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        'Assert
        Assert.AreEqual(ExpectedVal, Account1.GetBalance)
    End Sub

    Private Function NewAccount() As BankAccounts.BankAccount
        Dim AccountHolder As String = "Ms I. N. Cognito"
        Dim AccountNumber As String = "ABCD 890111 11167890"
        Dim InterestRate As Double = 4.3
        Dim Balance As Double = 10343.82
        Dim CountryOfOrigin As String = "Isle of Man"
        Return New BankAccounts.BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, CountryOfOrigin)



    End Function

End Class