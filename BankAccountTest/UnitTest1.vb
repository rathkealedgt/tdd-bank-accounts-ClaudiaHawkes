Imports System.Text
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

        'Assert
        Assert.AreEqual(Name, "Ms I. N. Cognito")
    End Sub

End Class