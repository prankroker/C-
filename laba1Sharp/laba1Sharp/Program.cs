using System;

namespace laba1Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 пошук найбільшого
            /*
            int a, b, c;
            string str;
            Console.WriteLine("Введіть перше число");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Введіть друге число");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            Console.WriteLine("Введіть третє число");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);
            if(a > b && a > c)
            {
                Console.WriteLine("Перше число найбільше");
            }
            else if(b > c)
            {
                Console.WriteLine("Друге число найбільше");
            }
            else
            {
                Console.WriteLine("Третє число найбільше");
            }
            */
            //2 пошук середнього
            /*
            double a, b, c, avg;
            string str;
            Console.WriteLine("Введіть перше число");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);
            Console.WriteLine("Введіть друге число");
            str = Console.ReadLine();
            b = Convert.ToDouble(str);
            Console.WriteLine("Введіть третє число");
            str = Console.ReadLine();
            c = Convert.ToDouble(str);
            avg = (a + b + c) / 3;
            Console.WriteLine(avg);
            */
            //3 сума податку
            /*
            double a, b, c;
            string str;
            Console.WriteLine("Введіть суму товару ");
            str = Console.ReadLine();
            a = Convert.ToDouble(str);
            if(a<999)
            {
                b = 0.02;
            }
            else if(a>1000 && a < 9999)
            {
                b = 0.03;
            }
            else
            {
                b = 0.05;
            }
            c = a * b;
            Console.WriteLine(c + " Податок");
            */
            //4 Вираз
            /*
            int x, y;
            string str;
            Console.WriteLine("Введіть х ");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);
            if (x > 0)
            {
                y = 6 * x - 9;
            }
            else if(x == 0)
            {
                y = 0;
            }
            else
            {
                y = 2 * Math.Abs(x) - 1;
            }
            Console.WriteLine("Відповідь " + y);
            */
            //5 трикутник
            /*
            int a, b, c;
            string str;
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            str = Console.ReadLine();
            c = Convert.ToInt32(str);
            if ((a + b) > c)
            {
                Console.WriteLine("трикутник існує");
            }
            else
            {
                Console.WriteLine("трикутник не існує");
            }
            */
        }
    }
}
