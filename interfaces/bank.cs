namespace interfaces
{
    interface IAccounts
    {
        void calculateInterest(int p, int n, int r);

        public void deposit(float amount, string accNumber);
    }

    class DepositAccount : IAccounts
    {
        private string? _acctype;

        public string AccountType
        {
            get => _acctype!;
            set => _acctype = value;
        }

        public DepositAccount(string accType)
        {
            AccountType = accType;
        }

        public void calculateInterest(int p, int n, int r)
        {
            float interest;
            if (AccountType == "Business")
            {
                interest = p * (n - 2) / 12 * r / 100;
            }
            else
            {
                interest = p * (n - 2) / 12 * r / 100;
            }
            Console.WriteLine($"The interest for the amount {p} is {interest}\n");

        }

        public void deposit(float amount, string accNumber)
        {
            Console.WriteLine($"Your account {accNumber} is credited Rs.{amount}");
        }

        public void withdraw(float amount, string accNumber)
        {
            Console.WriteLine($"Your account {accNumber} is debited Rs.{amount}");
        }
    }

    class LoanAccount : IAccounts
    {
        private string? _acctype;

        public string AccountType
        {
            get => _acctype!;
            set => _acctype = value;
        }

        public LoanAccount(string accType)
        {
            AccountType = accType;
        }

        public void calculateInterest(int p, int n, int r)
        {
            float interest;
            if (AccountType == "Business")
            {
                interest = p * (n - 2) / 12 * r / 100;
            }
            else
            {
                interest = p * (n - 2) / 12 * r / 100;
            }
            Console.WriteLine($"The interest for the amount {p} is {interest}\n");
        }

        public void deposit(float amount, string accNumber)
        {
            Console.WriteLine($"Your account {accNumber} is credited Rs.{amount}");
        }
    }

    class ExcerciseTwo
    {
        public void run()
        {
            DepositAccount individualDepositAcc = new DepositAccount("Individual");
            individualDepositAcc.deposit(1000, "12546324779");
            individualDepositAcc.withdraw(250, "12546324779");
            individualDepositAcc.calculateInterest(50000, 24, 8);

            DepositAccount businessDepositAcc = new DepositAccount("Business");
            businessDepositAcc.deposit(21544254, "52658785112");
            businessDepositAcc.withdraw(545621, "52658785112");
            businessDepositAcc.calculateInterest(500000, 20, 16);

            LoanAccount individualLoanAcc = new LoanAccount("Individual");
            individualLoanAcc.deposit(5000, "54684512524");
            individualLoanAcc.calculateInterest(50000, 12, 8);

            LoanAccount businessLoanAcc = new LoanAccount("Business");
            businessLoanAcc.deposit(47621, "1654561655");
            businessLoanAcc.calculateInterest(500000, 10, 16);
        }
    }
}
