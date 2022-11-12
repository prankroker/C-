using System;

namespace Laba6
{
    class Program
    {   
        static int Reverse(int a)
        {
            int e = 0;
            while (a > 0)
            {
                int f = a % 10;
                e = (e * 10) + f;
                a = a / 10;
                
            }
            Console.WriteLine(e);
            return a;
        }
        static string Reverse(string b)
        {
            string reverse = ""
;           int Length = 0;
            Length = b.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + b[Length];
                Length--;
            }
            Console.WriteLine(reverse);
            return b;
        }
        static double Reverse(double d)
        {
            string inpt = d.ToString();
            char[] arr = inpt.ToCharArray();
            for(int i = 0; i < arr.Length / 2; i++)
            {
                char tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            string output = new string(arr);
            Console.WriteLine(output);
            return d;
        }
        static string Reverse(string c,int x)
        {
            char[] arr = c.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char tmp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = tmp;
            }
            string output = new string(arr);
            Console.WriteLine(output);
            return c;
        }
        static void Massiv(int[] arr)
        {
            string k;
            for (int i = arr.Length-1; i >-1; i--)
            {
                k = Convert.ToString(arr[i]);
                Console.Write(k+" ");
            }
        }
        static void Main(string[] args)
        {
            int a;
            string str, b, c;
            double d;
            Console.WriteLine("Введіть ціле число: ");
            str = Console.ReadLine();
            a = int.Parse(str);
            Reverse(a);

            Console.WriteLine("Введіть слово: ");
            b = Console.ReadLine();
            Reverse(b);

            Console.WriteLine("Введіть дробове число: ");
            str = Console.ReadLine();
            d = double.Parse(str);
            Reverse(d);

            Console.WriteLine("Введіть строку з магічним знаком: ");
            c = Console.ReadLine();
            Reverse(c);

            int[] arr = new int[4] { 1, 2, 3, 4 };
            Massiv(arr);


        }
    }
}
