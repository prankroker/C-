using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,res;
            string str;
            Console.WriteLine("Введіть тризначне число:");
            str = Console.ReadLine();
            a = Double.Parse(str);
            res = a % 2;
            if (res == 0 &&  a < 1000 && a > 99)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
