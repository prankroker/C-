using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string str;
            int maxs = 0;
            int mins = int.MaxValue;
            int buff = 0;
            int buff2 = 0;
            int x = 0;

            Console.WriteLine("Enter rows:");
            str = Console.ReadLine();
            a = int.Parse(str);

            Console.WriteLine("Enter cols:");
            str = Console.ReadLine();
            b = int.Parse(str);

            int[,] arr = new int[a, b];
            Console.Write("\n");
            for (int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    Random value = new Random();
                    arr[i, j] = value.Next(1,25);
                    Console.Write(arr[i,j] + " ");
                }
                    Console.Write("\n");
            }
            Console.Write("\n");
            for (int i = 0; i < a; i++)
            {
                for(int j = 0; j < b; j++)
                {
                    buff += arr[i,j];
                    buff2 = i;
                }
                
                if (maxs < buff)
                {
                    maxs = buff;
                    x = buff2 + 1;
                }
                
                buff = 0;
            }
            Console.WriteLine("max = " + maxs + " at " + x + " row");
            buff2 = 0;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    buff += arr[i, j];
                    buff2 = i;
                }

                if (mins > buff)
                {
                    mins = buff;
                    x = buff2 + 1;
                }

                buff = 0;
            }
            Console.WriteLine("min = " + mins + " at " + x + " row");
        }
    }
}
