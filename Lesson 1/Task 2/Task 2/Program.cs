using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;

            Console.Write("Enter numb > ");
            numb = Convert.ToInt32(Console.ReadLine()) + 10;

            Console.WriteLine("Result > " + numb);
        }
    }
}