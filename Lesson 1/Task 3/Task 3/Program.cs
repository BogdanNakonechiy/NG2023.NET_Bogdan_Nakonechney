using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            string[] symbolArr = new string[10];
            int[] numbArr = new int[10];

            Console.Write("Enter > ");
            numbers = Console.ReadLine();

            symbolArr = numbers.Split(' ');

            for(int numbCount = 0; numbCount < symbolArr.Length; numbCount++)
                numbArr[numbCount] = Convert.ToInt32(symbolArr[numbCount]);

            Console.WriteLine("Numbers");
            foreach(var numb in numbArr)
                Console.WriteLine(numb);
            Console.WriteLine();
        }
    }
}