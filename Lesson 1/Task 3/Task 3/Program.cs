using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            char[] numbersArr = new char[11];

            Console.Write("Enter string > ");
            numbers = Console.ReadLine();

            for (int numbCount = 0; numbCount < numbersArr.Length - 1; numbCount++)
                numbersArr[numbCount] = numbers[numbCount];

            Console.Write("Array numb > ");
            for(int numbCount = 0; numbCount < numbersArr.Length - 1; numbCount++)
                Console.Write(numbersArr[numbCount] + " ");

            Console.WriteLine("\n");
        }
    }
}