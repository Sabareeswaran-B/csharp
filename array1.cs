/* using System;

namespace ArrayOperations
{
    class ExcerciseOne
    {
        public static void Main(string[] args)
        {
            int[] values = new int[10];
            Console.WriteLine($"Input 10 elemnts of an array:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write($"Elements in array are:");
            foreach (int value in values)
            {                
                Console.Write($"\t{value}");
            }
        }
    }

    class ExcerciseTwo
    {
        public static void Main(string[] args)
        {   
            int[] values = new int[3];
            Console.WriteLine($"Input 3 elemnts of an array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(values);
            Console.Write($"Elements in array reverse:");
            foreach (int value in values)
            {                
                Console.Write($"\t{value}");
            }
        }
    }

    class ExcerciseThree
    {
        public static void Main(string[] args)
        {   
            int[] value = new int[3];
            Console.WriteLine($"Input 3 elemnts of an array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                value[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = value.Sum();
            Console.Write($"Sum of all elements in the array is: {sum}");
        }
    }

    class ExcerciseFour
    {
        public static void Main(string[] args)
        {   
            int[] values = new int[3];
            int[] valuesCopy = new int[3];
            Console.WriteLine($"Input 3 elemnts of an array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Copy(values, 0, valuesCopy, 0, values.Length);
            Console.Write($"Elements stored in the original array are:");
            foreach (int value in values)
            {                
                Console.Write($"\t{value}");
            }
            Console.Write($"\nElements copied in the duplicate array are:");
            foreach (int value in valuesCopy)
            {                
                Console.Write($"\t{value}");
            }
        }
    }

    class ExcerciseFive
    {
        public static void Main(string[] args)
        {   
            int[] values = new int[3];
            int[] valuesWithoutDuplicate = new int[3];
            int count = 0;
            Console.WriteLine($"Input 10 elemnts of an array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                if(!valuesWithoutDuplicate.Contains(values[i]))
                {
                    valuesWithoutDuplicate[i] = values[i];
                }
                else
                {
                    count++;
                }
            }            
            Console.Write($"The number of duplicate elements is: {count} \n");

        }
    }

    class ExcerciseSix
    {
        public static void Main(string[] args)
        {   
            int[] values = new int[3];
            int[] valuesWithoutDuplicate = new int[3];
            Console.WriteLine($"Input 3 elemnts of an array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The unique elements found in the array are:");
            for (int i = 0; i < 3; i++)
            {
                if(!valuesWithoutDuplicate.Contains(values[i]))
                {
                    valuesWithoutDuplicate[i] = values[i];
                    Console.Write($"{values[i]}\t");
                }
            }
        }
    }

    class ExcerciseSeven
    {
        public static void Main(string[] args)
        {   
            int[] valuesSet1 = new int[3];
            int[] valuesSet2 = new int[3];
            int[] mergedArray = new int[valuesSet1.Length + valuesSet2.Length];
            Console.WriteLine($"Input 3 elemnts of the first array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                valuesSet1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Input 3 elemnts of the second array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                valuesSet2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < mergedArray.Length; i++)
            {
                if(i < valuesSet1.Length)
                {
                    mergedArray[i] = valuesSet1[i];
                }
                else
                {
                    int j = i - valuesSet1.Length;
                    mergedArray[i] = valuesSet2[j];
                }
            }

            Array.Sort(mergedArray);

            Console.Write($"\nThe merged array in ascending order is :");
            foreach (int value in mergedArray)
            {                
                Console.Write($"\t{value}");
            }
            
        }
    }

    class ExcerciseEight
    {
        public static void Main(string[] args)
        {   
            int[] values = new int[5];
            int[] fr1 = new int[5];
            int[] valuesWithoutDuplicate = new int[5];
            Console.WriteLine($"Input 5 elemnts of an array:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Frequency of all elements of the array:");
            for (int i = 0; i < 5; i++)
            {
                int frequency = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (values[i] == values[j])
                    {
                        frequency++;                        
                    }
                }
                fr1[i] = frequency;
                if (!valuesWithoutDuplicate.Contains(values[i]))
                {
                    Console.WriteLine($"{values[i]} occurs {fr1[i]} times");
                    valuesWithoutDuplicate[i] = values[i];
                }
            }
        }
    }

    class ExcerciseNine
    {
        public static void Main(string[] args)
        {   
            int[] values = new int[3];
            int maximum = 0, minimum = 0;
            Console.WriteLine($"Input 3 elemnts of an array:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Element {i}:");
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                {
                    maximum = values[0];
                    minimum = values[0];
                }
                else
                {
                    if (maximum <= values[i])
                    {
                        maximum = values[i];
                    }
                    if (minimum >= values[i])
                    {
                        minimum = values[i];
                    }
                }
            }

            // maximum = values.Max();
            Console.WriteLine($"The maximum element is: {maximum}");
            // minimum = values.Min();
            Console.WriteLine($"The minimum element is: {minimum}");
        }
    }

    class ExcerciseTen
    {
        public static void Main(string[] args)
        {   
            int[] arr1 = new int[6];
            int[] arr2 = new int[6];
            int[] arr3 = new int[6];
            int i = 0, j = 0, k = 0;
            Console.WriteLine($"Input 6 elemnts of an array:");
            for (i = 0; i < 6; i++)
            {
                Console.Write($"Element {i}:");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = 1;
            }

            for (i=0; i < arr1.Length; i++)
            {
                if(arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.WriteLine($"\nthe original array:");
            foreach (int value in arr1)
            {                
                Console.Write($"\t{value}");
            }
            Console.WriteLine($"\nthe array with only even elements:");
            foreach (int value in arr2)
            {
                if (value != 1)
                {
                    Console.Write($"\t{value}");
                }
            }
            Console.WriteLine($"\nthe array with only odd elements:");
            foreach (int value in arr3)
            {                
                if (value != 0)
                {
                    Console.Write($"\t{value}");
                }
            }
        }
    }
} */