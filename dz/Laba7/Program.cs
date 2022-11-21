using System;
using System.Collections.Generic;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Створити ліст інтових змінних, який може вміщати тільки 1 і 0, заповнити його з клавіатури. 
             * Порахувати кількість 1 і 0. 
             * Скопіювати отриманий ліст в масив.
             */
            int a,one = 0,zero = 0;
            string str;
            List<int> list = new List<int>();
            Console.WriteLine("Введіть змінні: ");
            Console.WriteLine("Щоб закінчити введіть end");
            while (true)
            {
                str = Console.ReadLine();
                if (str.Equals("end"))
                {
                    break;
                }
                a = int.Parse(str); 
                if(a == 1 || a == 0)
                {
                    list.Add(a);
                }
                else
                {
                    Console.WriteLine("Тільки 1 або 0");
                    Console.WriteLine("Введіть змінні: ");
                }
            }

            int[] arr = new int[list.Count];
            list.CopyTo(arr);
            
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 1)
                {
                    one++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine("one = " + one + "\n" + "zero = " + zero);
        }
    }
}
