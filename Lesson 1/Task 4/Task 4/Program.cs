using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first str > ");
            string firstStr = Console.ReadLine();
            Console.Write("Enter second str > ");
            string secondStr = Console.ReadLine();

            if (firstStr.Length > secondStr.Length)
            {
                Console.WriteLine("Result > " + firstStr + secondStr);
            }
            else if (firstStr.Length < secondStr.Length)
            {
                Console.Write("Result > ");
                for (int numbCount = 0; numbCount < secondStr.Length; numbCount++)
                {
                    if (secondStr.Length / 2 == numbCount)
                        Console.Write(firstStr[numbCount]);
                    Console.Write(secondStr[numbCount]);
                }
            }
            else
                Console.Clear();
            Console.ReadLine();
        }
    }
}
