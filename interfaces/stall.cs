namespace interfaces
{
    interface Istall
    {
        void display();
    }

    class GoldStall : Istall
    {
        private string? _stallName;
        private int _cost;
        private string? _ownerName;
        private int _tvSet;

        public string StallName
        {
            get => _stallName!;
            set => _stallName = value;
        }

        public string OwnerName
        {
            get => _ownerName!;
            set => _ownerName = value;
        }
        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
        public int TvSet
        {
            get => _tvSet;
            set => _tvSet = value;
        }

        public GoldStall(string sName, int cost, string oName, int tv_set)
        {
            StallName = sName;
            Cost = cost;
            OwnerName = oName;
            TvSet = tv_set;
        }

        public void display()
        {
            Console.WriteLine($"Stall Name: {StallName}");
            Console.WriteLine($"Cost: {Cost}.Rs");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"No. of Tv Set: {TvSet}");
        }
    }

    class PremiumStall : Istall
    {
        private string? _stallName;
        private int _cost;
        private string? _ownerName;
        private int _tvSet;

        public string StallName
        {
            get => _stallName!;
            set => _stallName = value;
        }

        public string OwnerName
        {
            get => _ownerName!;
            set => _ownerName = value;
        }
        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
        public int TvSet
        {
            get => _tvSet;
            set => _tvSet = value;
        }

        public PremiumStall(string sName, int cost, string oName, int tv_set)
        {
            StallName = sName;
            Cost = cost;
            OwnerName = oName;
            TvSet = tv_set;
        }

        public void display()
        {
            Console.WriteLine($"Stall Name: {StallName}");
            Console.WriteLine($"Cost: {Cost}.Rs");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"No. of Projectors: {TvSet}");
        }
    }

    class ExecutiveStall : Istall
    {
        private string? _stallName;
        private int _cost;
        private string? _ownerName;
        private int _tvSet;

        public string StallName
        {
            get => _stallName!;
            set => _stallName = value;
        }

        public string OwnerName
        {
            get => _ownerName!;
            set => _ownerName = value;
        }
        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }
        public int TvSet
        {
            get => _tvSet;
            set => _tvSet = value;
        }

        public ExecutiveStall(string sName, int cost, string oName, int tv_set)
        {
            StallName = sName;
            Cost = cost;
            OwnerName = oName;
            TvSet = tv_set;
        }

        public void display()
        {
            Console.WriteLine($"Stall Name: {StallName}");
            Console.WriteLine($"Cost: {Cost}.Rs");
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"No. of Screens: {TvSet}");
        }
    }

    class ExcerciseOne
    {
        public void run()
        {
            Console.Write(
                "List of shapes\n1.Gold Stall\n2.Premium Stall\n3.Executive Stall\nEnter your choice:"
            );
            int choice = Convert.ToInt32(Console.ReadLine());
            string input;
            string[] data = new string[4];

            switch (choice)
            {
                case 1:
                    Console.WriteLine(
                        "Enter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Number of TV sets)"
                    );
                    input = Console.ReadLine()!;
                    data = input.Split(",");
                    GoldStall goldStall = new GoldStall(
                        data[0],
                        Convert.ToInt32(data[1]),
                        data[2],
                        Convert.ToInt32(data[3])
                    );
                    goldStall.display();
                    break;
                case 2:
                    Console.WriteLine(
                        "Enter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Number of projectors)"
                    );
                    input = Console.ReadLine()!;
                    data = input.Split(",");
                    PremiumStall premiumStall = new PremiumStall(
                        data[0],
                        Convert.ToInt32(data[1]),
                        data[2],
                        Convert.ToInt32(data[3])
                    );
                    premiumStall.display();
                    break;
                case 3:
                    Console.WriteLine(
                        "Enter Stall details in comma separated(Stall Name,Stall Cost,Owner Name,Number of screens)"
                    );
                    input = Console.ReadLine()!;
                    data = input.Split(",");
                    ExecutiveStall executiveStall = new ExecutiveStall(
                        data[0],
                        Convert.ToInt32(data[1]),
                        data[2],
                        Convert.ToInt32(data[3])
                    );
                    executiveStall.display();
                    break;
                default:
                    Console.WriteLine("Invalid Input, Enter a correct choice");
                    break;
            }
        }
    }
}
