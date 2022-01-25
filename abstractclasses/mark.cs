namespace AbstractClasses
{
    abstract class Marks
    {
        public abstract int getPercentage();
    }

    class StudentA : Marks
    {
        public override int getPercentage()
        {
            int total = mark1 + mark2 + mark3;
            float percentage = ((float)total / 300) * 100;
            return ((int)percentage);
        }

        int mark1;
        int mark2;
        int mark3;

        public StudentA(int m1, int m2, int m3)
        {
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
        }
    }

    class StudentB : Marks
    {
        public override int getPercentage()
        {
            int total = mark1 + mark2 + mark3 + mark4;
            float percentage = ((float)total / 400) * 100;
            return ((int)percentage);
        }

        int mark1;
        int mark2;
        int mark3;
        int mark4;

        public StudentB(int m1, int m2, int m3, int m4)
        {
            mark1 = m1;
            mark2 = m2;
            mark3 = m3;
            mark4 = m4;
        }
    }

    class ExcerciseFour
    {
        public void run()
        {
            Console.Write("Enter the mark1 of StudentA:");
            int m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the mark2 of StudentA:");
            int m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the mark3 of StudentA:");
            int m3 = Convert.ToInt32(Console.ReadLine());


            StudentA a = new StudentA(m1, m2, m3);
            Console.WriteLine($"The Percentage of StudentA is {a.getPercentage()}%");


            Console.Write("Enter the mark1 of StudentB:");
            m1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the mark2 of StudentB:");
            m2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the mark3 of StudentB:");
            m3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the mark4 of StudentB:");
            int m4 = Convert.ToInt32(Console.ReadLine());


            StudentB b = new StudentB(m1, m2, m3, m4);
            Console.WriteLine($"The Percentage of StudentB is {b.getPercentage()}%");

        }
    }
}
