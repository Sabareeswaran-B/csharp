/* using System;

namespace Methods
{
    class ExcerciseOne
    {

        public static void helloFunction() {
            Console.WriteLine("Hello Friends!");
            Console.WriteLine("Have a nice day!");
        }

        public static void Main(string[] args)
        {
            helloFunction();
        }
    }

    class ExcerciseTwo
    {
        public static void helloFunction(string name) {
            Console.WriteLine($"Hello Friend {name}!");
            Console.WriteLine("Have a nice day!");
        }

        public static void Main(string[] args)
        {   
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!;
            helloFunction(name);
        }
    }

    class ExcerciseThree
    {

        public static void sum(int num1, int num2)
        {
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
        }

        public static void Main(string[] args)
        {   
            Console.Write("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number:");
            int b = Convert.ToInt32(Console.ReadLine());
            sum(a,b);
        }
    }

    class ExcerciseFour
    {
        public static void countSpace(string value)
        {
            int spaces = 0;
            foreach (char letter in value)
            {
                if(letter == ' ')
                {
                    spaces++;
                }
            }
            Console.WriteLine($"\"{value}\" contains {spaces} spaces");
        }

        public static void Main(string[] args)
        {   
            Console.Write("Enter a string:");
            string sentance = Console.ReadLine()!;
            countSpace(sentance);
        }
    }

    class ExcerciseFive
    {
        public static void sum(int[] arr)
        {
            int sum = 0;
            foreach (int element in arr)
            {
                sum += element;
            }
            Console.WriteLine($"the sum of the elements of the array is {sum}");
        }

        public static void Main(string[] args)
        {   
            int[] values = new int[5];
            Console.WriteLine($"Input 5 elemnts of an array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            sum(values);
        }
    }

    class ExcerciseSix
    {
        public static void swap(int num1, int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write($"Now the 1st number is {num1} and the 2nd number is {num2}");
        }

        public static void Main(string[] args)
        {   
            Console.Write("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine()!);
            swap(a,b);
        }
    }

    class ExcerciseSeven
    {
        public static void powerOf(int num1, int num2)
        {
            int result = 1;
            for (int i = 1; i <= num2; i++)
            {
                result *= num1;
            }

            Console.Write($"So, the number {num1} ^ (to the power) {num2} = {result}");
        }

        public static void Main(string[] args)
        {   
            Console.Write("Enter the Base number:");
            int a = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Enter the exponent:");
            int b = Convert.ToInt32(Console.ReadLine()!);
            powerOf(a,b);
        }
    }

    class ExcerciseEight
    {
        public static int fibo(int num)
        {
            if(num <= 1)
            {
                return num;
            }
            else
            {
                return (fibo(num-1) + fibo(num-2));
            }
        }

        public static void Main(string[] args)
        {   
            Console.Write("Enter number of fibonacci series:");
            int a = Convert.ToInt32(Console.ReadLine()!);
            for(int i = 0; i < a; i++)
            {
                int result = fibo(i);
                Console.Write($"{result}\t");
            }
        }
    }

    class ExcerciseNine
    {
        public static bool isPrime(int num)
        {
            for (int i=2; i < num; i++)
            if (num %i == 0)
                return false;
            return true;
        }
        public static void Main()
        {
        Console.Write("Input a number : ");
        int n= Convert.ToInt32(Console.ReadLine());	
        
            if (isPrime(n))
            Console.WriteLine($"{n} is a prime number");
            else
            Console.WriteLine($"{n} is not a prime number");
        }
    }

    class ExcerciseTen
    {
        public static int sum(int num)
        {
            string values = num.ToString();
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += Convert.ToInt32(values.Substring(i, 1));
            }
            return sum;
        }

        public static void Main()
        {
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The sum of the digits of the number {n} is : {sum(n)} \n");
        }
    }
}
 */