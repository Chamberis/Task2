using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string firstNum = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string secondNum = Console.ReadLine();

            int sum = int.Parse(firstNum) + int.Parse(secondNum);
            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }
    }
}
