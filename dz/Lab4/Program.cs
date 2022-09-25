using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            max = 0;
            min = 0;
            int[] arr = new int[5];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = i;
                if(i == 0)
                {
                    max = i;
                    min = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            arr[0] = max;
            arr[4] = min; 
            var str = string.Join(" ",arr);
            Console.WriteLine(str);

        }
    }
}
