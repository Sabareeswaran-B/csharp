// public abstract class Bank
// {
//     public int accountNo { get; set; }

//     public Bank(int accountNo)
//     {
//         this.accountNo = accountNo;
//     }

//     public abstract string deposit(int amount);
// }

// public class IOB : Bank
// {
//     public IOB(int accountNo) : base(accountNo) { }

//     public override string deposit(int amount)
//     {
//         // Console.WriteLine($"{amount} is credited to the account {accountNo}");
//         return $"{amount} is credited to the account {accountNo}";
//     }
// }

// public class Program {
//     public static void Main(string[] args)
//     {
//         Bank sabareesIOB = new IOB(20004523);
//         var res = sabareesIOB.deposit(100);
//         Console.WriteLine(res);
//     }
//  }