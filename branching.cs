/* using System;

namespace Branching
{
    class ExcerciseOne
    {
        static void Main(string[] args)
        {
            int value1, value2;
            Console.WriteLine("Enter first number.");
            int.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Enter second number.");
            int.TryParse(Console.ReadLine(), out value2);
            if(value1 == value2)
            {
                Console.WriteLine("Both number are same");
            }
            else
            {
                Console.WriteLine("The given numbers are not same.");
            }
        }
    }
    class ExcerciseTwo
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter a number.");
            if(int.TryParse(Console.ReadLine(), out value))
            {
                if(value <= 0)
                {
                    Console.WriteLine("Enter a valid number.");
                }
                else if (value % 2 == 0)
                {
                    Console.WriteLine("The given number is even.");
                }
                else
                {
                    Console.WriteLine("The given number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

        }
    }
    class ExcerciseThree
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter a number.");
            if(int.TryParse(Console.ReadLine(), out value))
            {
                if(value < 0)
                {
                    Console.WriteLine("The given number is negative.");
                }
                else
                {
                    Console.WriteLine("The given number is positive.");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

        }
    }
    class ExcerciseFour
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter a number.");
            if(int.TryParse(Console.ReadLine(), out value))
            {
                if (((value % 4 == 0) && (value % 100 != 0)) || (value % 400 == 0))
                Console.WriteLine($"{value} is a Leap Year.");  
                else Console.WriteLine($"{value} is not a Leap Year.");
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

        }
    }
    class ExcerciseFive
    {
        static void Main(string[] args)
        {
            int value;
            Console.WriteLine("Enter a your age.");
            if(int.TryParse(Console.ReadLine(), out value))
            {
                if (value >= 18)
                Console.WriteLine("Eligible.");  
                else Console.WriteLine("Not Eligible");
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

        }
    }
    class ExcerciseSix
    {
        static void Main(string[] args)
        {
            int m, n = 0;
            Console.WriteLine("Enter a number.");
            if(int.TryParse(Console.ReadLine(), out m))
            {
                if(m > 0) n = 1;
                else if (m == 0) n = 0;
                else if (m < 0) n = -1;
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

        }
    }
    class ExcerciseSeven
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Enter your height.");
            if(int.TryParse(Console.ReadLine(), out height))
            {
                if(height >= 180)
                {
                    Console.WriteLine("You are 6+ feet!");
                }
                else if(height >= 150)
                {
                    Console.WriteLine("You are 5+ feet!");
                }
                else if(height >= 120)
                {
                    Console.WriteLine("You are 4+ feet!");
                }
                else
                {
                   Console.WriteLine("You are a child!");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

        }
    }
    class ExcerciseEight
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Enter first number.");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number.");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number.");
            c = Convert.ToInt32(Console.ReadLine());
            
            if(a > b)
            {
                if(a > c) d = a;
                else d = c;
            }
            else
            {
                if(b > c) d = b;
                else d = c;
            }

            Console.WriteLine(d);
        }
    }
    class ExcerciseNine
    {
        static void Main(string[] args)
        {
        int x,y;

            Console.Write("Input the value for X coordinate :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value for Y coordinate :");
            y = Convert.ToInt32(Console.ReadLine());


            if( x > 0 && y > 0)
            Console.Write("First quandrant.");
            else if( x < 0 && y > 0)
            Console.Write("Second quandrant.");
            else if( x < 0 && y < 0)
            Console.Write("Third quandrant.");
            else if( x > 0 && y < 0)
            Console.Write("Fourth quandrant.");
            else if( x == 0 && y == 0)
            Console.Write("the origin.");

        }
    }
    class ExcerciseTen
    {
        static void Main(string[] args)
        {
            int maths, physics, chemistry;

            Console.Write("Enter Maths mark:");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Physics mark:");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Chemistry mark:");
            chemistry = Convert.ToInt32(Console.ReadLine());

            if( maths >= 65 && physics >= 55 && chemistry >= 50)
            {
                if( maths + physics + chemistry >= 180 || maths + physics >= 140 || maths + chemistry >= 140)
                {
                    Console.WriteLine("Eligible");
                }
                else
                {
                    Console.WriteLine("Not Eligible");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }


} */