using System;

namespace AbstractClasses
{
    // abstract class Bank
    // {
    //     public abstract int getBalance();
    // }

    // class BankA : Bank
    // {
    //     private int balance;

    //     public void deposit(int money)
    //     {
    //         balance += money;
    //     }

    //     public override int getBalance()
    //     {
    //         return balance;
    //     }
    // }

    // class BankB : Bank
    // {
    //     private int balance;

    //     public void deposit(int money)
    //     {
    //         balance += money;
    //     }

    //     public override int getBalance()
    //     {
    //         return balance;
    //     }
    // }

    // class BankC : Bank
    // {
    //     private int balance;

    //     public void deposit(int money)
    //     {
    //         balance += money;
    //     }

    //     public override int getBalance()
    //     {
    //         return balance;
    //     }
    // }

    // class ExcerciseThree
    // {
    //     public void run()
    //     {
    //         BankA a = new BankA();
    //         BankB b = new BankB();
    //         BankC c = new BankC();
    //         a.deposit(100);
    //         b.deposit(150);
    //         c.deposit(200);
    //         Console.WriteLine($"The balance in BankA is {a.getBalance()}");
    //         Console.WriteLine($"The balance in BankB is {b.getBalance()}");
    //         Console.WriteLine($"The balance in BankC is {c.getBalance()}");
    //     }
    // }


    public abstract class Bank
    {
        //geter setter
        public float Balance { get; set; }

        //An abstract method for Deposit declaration
        public abstract void Deposit(float money);

        //An abstract method for Get Balance declaration
        public abstract void GetBalance();
    }

    public class BankA : Bank
    {
        public override void Deposit(float money)
        {
            Balance += money;
        }

        public override void GetBalance()
        {
            Console.WriteLine($"Your Account Balnce is {Balance}");
        }
    }

    public class ExcerciseThree
    {
        public void run()
        {
            Bank bankA = new BankA();
            Console.WriteLine("1: Check Balance,");
            Console.WriteLine("2: Deposit Money.");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            if (userChoice == 1)
            {
                bankA.GetBalance();
            }
            else if (userChoice == 2)
            {
                Console.Write("Drop your money in the CDM now.");
                int money = Convert.ToInt32(Console.ReadLine());
                bankA.Deposit(money);
                bankA.GetBalance();
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
    }
}
