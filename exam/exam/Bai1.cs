// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

// Bank Account Interface
interface IBankAccount
{
    decimal CheckBalance();
    void Transfer(decimal amount);
}

// Base Account class
abstract class Account : IBankAccount
{
    protected decimal balance;

    public Account(decimal initialBalance)
    {
        this.balance = initialBalance;
    }

    public abstract decimal CheckBalance();
    public abstract void Transfer(decimal amount);
}

// Normal Account Implementation
class NormalAccount : Account
{
    protected decimal balance;

    public NormalAccount(decimal initialBalance) : base(initialBalance)
    {
        this.balance = initialBalance;
    }

    public override decimal CheckBalance()
    {
        return balance;
    }

    public override void Transfer(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"You've transferred: {amount:C}. Your new balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }
}

// Derived class for Exchange Account
class ExchangeAccount : Account
{
    private decimal exchangeRate;
    private decimal amount;

    public ExchangeAccount(decimal initialAmount, decimal exchangeRate) : base(initialAmount * exchangeRate)
    {
        this.amount = initialAmount;
        this.exchangeRate = exchangeRate;
    }

    public override decimal CheckBalance()
    {
        return amount * exchangeRate;
    }

    public override void Transfer(decimal transferAmount)
    {
        if (transferAmount > amount)
        {
            Console.WriteLine("Insufficient balance for transfer.");
        }
        else
        {
            amount -= transferAmount;
            Console.WriteLine($"You've transferred {transferAmount * exchangeRate:C}. Your new balance: {CheckBalance():C}");
        }
    }
}

class Bai1
{
    static void bai1Main()
    {
        Console.WriteLine("Select account type: 1. Normal Account  2. Exchange Account");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter initial amount (For normal account: use VND. While exchange account use USD): ");
        decimal initialAmount = Convert.ToDecimal(Console.ReadLine());
        decimal exchangeRate = 25000;
        Account account;

        if (choice == 1)
        {
            account = new NormalAccount(initialAmount);
        }
        else if (choice == 2)
        {
            account = new ExchangeAccount(initialAmount, exchangeRate);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
            return;
        }

        Console.WriteLine("Your balance:" + account.CheckBalance() + "VND ");

        // Performing bank transfer
        Console.WriteLine("Enter amount to transfer:");
        decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
        account.Transfer(transferAmount);
        Console.WriteLine("Your balance:" + account.CheckBalance() + " VND");
    }
}

