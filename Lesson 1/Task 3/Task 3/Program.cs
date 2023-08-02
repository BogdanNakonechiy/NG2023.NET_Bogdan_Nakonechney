using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArr = new int[10];

            for(int numbCount = 0; numbCount <= numbersArr.Length - 1; numbCount++)
            {
                Console.Write($"Enter numb {numbCount + 1} > ");
                int.TryParse(Console.ReadLine(), out numbersArr[numbCount]);
            }

            Console.Write("Array > ");
            for(int numbCount = 0; numbCount <= numbersArr.Length - 1; numbCount++)
            {
                Console.Write(numbersArr[numbCount] + " ");
            }
            Console.WriteLine();
        }
    }
}