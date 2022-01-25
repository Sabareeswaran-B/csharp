/* using System;

namespace Looping
{
    class ExcerciseOne
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class ExcerciseTwo
    {
        public static void Main(string[] args)
        {   
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }

    class ExcerciseThree
    {
        public static void Main(string[] args)
        {   
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"sum of these numbers is {sum}");
        }
    }

    class ExcerciseFour
    {
        public static void Main(string[] args)
        {   
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}:");
                int value = Convert.ToInt32(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine($"sum of these numbers is {sum}");
        }
    }

    class ExcerciseFive
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter number of terms:");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {                
                Console.WriteLine($"Number is: {i} and its cube is: {i*i*i}");                
            }
        }
    }

    class ExcerciseSix
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter the number:");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {                
                Console.WriteLine($"{value} x {i} = {value*i}");                
            }
        }
    }

    class ExcerciseSeven
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter the number:");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                // Console.WriteLine($"{value} x {i} = {value*i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($" {j} x {i} = {j*i} ");
                }
                Console.Write("\n");
            }
        }
    }

    class ExcerciseEight
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter the number:");
            int value = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= value*2; i = i + 2)
            {                
                Console.WriteLine($"{i}");
                sum += i;
            }
            Console.WriteLine($"sum of these odd numbers is: {sum}");
        }
    }

    class ExcerciseNine
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter the number:");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }

    class ExcerciseTen
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter the number:");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }
    }
} */