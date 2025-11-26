namespace balance;

public class Program
{
    static void Main(string[] args)
    {
        BankAccount acc1 = new BankAccount("12345F", 10000);
        
        acc1.Deposit(5000); 
        acc1.Withdraw(1500);

        Console.WriteLine(acc1.Balance);    

    }

}