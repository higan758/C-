using System.ComponentModel.Design;

namespace balance;

public class BankAccount
{
    private String accountNumber;
    private double balance;

    public String AccountNumber
    {
        get { return accountNumber; }
    }
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
        }
    }
    //conmstructor
    public BankAccount(String accNum , double initialBalance)
    {
        accountNumber = accNum;
        balance = initialBalance;

    }
    public void Deposit(double amount)
    {
        if (amount > 0)
                balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
            balance -= amount;
    }



}