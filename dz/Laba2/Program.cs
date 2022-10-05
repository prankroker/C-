using System;

namespace Laba1_140922
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double U, R, I;
            string str;
            bool isUok = false;
            do {
                Console.WriteLine("Напруга ");
                str = Console.ReadLine();
                isUok = double.TryParse(str, out U);
                if (!isUok)
                {
                    Console.WriteLine("Error");

                }
            } while (!isUok);
            Console.WriteLine("Опір ");
            str = Console.ReadLine();
            R = double.Parse(str);

            if(R <= 0)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                return;
            }

            I = U / R;
            Console.WriteLine($"Сила струму: I = {I},R = {R}");
            */
            //Laba 2(7)
            int nn, nk, k;
            double res, b;
            string str;
            Console.WriteLine("Введіть nn: ");
            str = Console.ReadLine();
            nn = int.Parse(str);
            Console.WriteLine("Введіть nk: ");
            str = Console.ReadLine();
            nk = int.Parse(str);
            res = 0;
            b = 0;
            if (0 <= nn && nn <= nk)
            {
                for (int i = nn; i <= nk; i++)
                {
                    k = i;
                    b = (Math.Pow(k, 2) - Math.Pow((-1), k + 1) * 2 * k - 1) / (Math.Pow(k, 2) + 8);
                    res += b;
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("помилка");
            }
        }
    }
}
