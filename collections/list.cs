namespace CollectionsEx
{
    class ListExercise
    {
        private void showList(List<int> listVals)
        {
            foreach (int number in listVals)
                Console.Write($"{number}, ");
            // foreach (int number in oddNumbers)
            //     Console.Write($"{number}, ");
        }

        public void run()
        {
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            Console.Write("Enter the limit:");
            int limit = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < limit; i++)
            {
                Console.Write("Enter a number:");
                int val = Convert.ToInt32(Console.ReadLine());
                if (val % 2 == 0)
                    evenNumbers.Add(val);
                else
                    oddNumbers.Add(val);
            }
            Console.WriteLine("The Even numbers are:");
            showList(evenNumbers);

            Console.WriteLine("\nThe Odd numbers are:");
            showList(oddNumbers);

            Console.Write("\nEnter a number to remove:");
            int removeVal = Convert.ToInt32(Console.ReadLine());
            if (removeVal % 2 == 0)
            {
                if (evenNumbers.Contains(removeVal))
                {
                    evenNumbers.Remove(removeVal);
                    Console.WriteLine($"{removeVal} is removed successfully");
                }
                else
                {
                    Console.WriteLine("The given number is not on the list");
                }
            }
            else
            {
                if (oddNumbers.Contains(removeVal))
                {
                    oddNumbers.Remove(removeVal);
                    Console.WriteLine($"{removeVal} is removed successfully");
                }
                else
                {
                    Console.WriteLine("The given number is not on the list");
                }
            }

            Console.WriteLine("The Even numbers are:");
            showList(evenNumbers);

            Console.WriteLine("\nThe Odd numbers are:");
            showList(oddNumbers);

        }
    }
}
