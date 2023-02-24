// See https://aka.ms/new-console-template for more information
using System;
namespace project1
{
    class test
    {
        public static void Main()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
