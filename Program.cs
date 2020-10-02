using System;

namespace BubbleSortSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 1, 4, 2, 8 };
            int tempValue;

            Console.WriteLine("Original array :");
            
            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }

            for (int p = 0; p <= arr.Length - 2; p++)
            {
                for (int i = 0; i < arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        tempValue = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = tempValue;
                    }
                }
            }

            Console.WriteLine("\n" + "Sorted array :");
            
            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }

            Console.Write("\n");
        
        }
    }
}
