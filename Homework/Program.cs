using Homework.Assistant;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4;
            num1.PowerNumbers(3);
            var power = num1.PowerNumbers(2);
            Console.WriteLine(power);
            

        }
    }
}
