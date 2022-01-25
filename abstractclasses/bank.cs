using System;

namespace AbstractClasses
{
    abstract class Bank
    {
        public abstract int getBalance();
    }

    class BankA : Bank
    {
        private int balance;

        public void deposit(int money)
        {
            balance += money;
        }

        public override int getBalance()
        {
            return balance;
        }
    }

    class BankB : Bank
    {
        private int balance;

        public void deposit(int money)
        {
            balance += money;
        }

        public override int getBalance()
        {
            return balance;
        }
    }

    class BankC : Bank
    {
        private int balance;

        public void deposit(int money)
        {
            balance += money;
        }

        public override int getBalance()
        {
            return balance;
        }
    }

    class ExcerciseThree
    {
        public void run()
        {
            BankA a = new BankA();
            BankB b = new BankB();
            BankC c = new BankC();
            a.deposit(100);
            b.deposit(150);
            c.deposit(200);
            Console.WriteLine($"The balance in BankA is {a.getBalance()}");
            Console.WriteLine($"The balance in BankB is {b.getBalance()}");
            Console.WriteLine($"The balance in BankC is {c.getBalance()}");
        }
    }
}
