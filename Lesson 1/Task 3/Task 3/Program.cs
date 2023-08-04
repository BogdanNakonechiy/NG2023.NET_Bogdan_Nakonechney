using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers;
            string[] charArr = new string[10];
            int[] numbArr = new int[10];

            Console.Write("Enter > ");
            numbers = Console.ReadLine();

            charArr = numbers.Split(' ');

            for(int numbCount = 0; numbCount < charArr.Length; numbCount++)
                numbArr[numbCount] = Convert.ToInt32(charArr[numbCount]);

            Console.WriteLine("Numbers");
            foreach(var numb in numbArr)
                Console.WriteLine(numb);
            Console.WriteLine();
        }
    }
}