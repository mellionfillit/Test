using System;
using System.Collections.Generic;

namespace NumberRepetition
{
    class Program
    {
        //Написать программу, которая подсчитывает количество повторений каждого числа, встреченного в заданной строке.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();

            List<int> num = new List<int>(10);
            char[] ms = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int count = 0;

            for (int i = 0; i < ms.Length ; i++) {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str1[j]==ms[i])
                    {
                        count++;
                    }
                }
                num.Add(count);
                count = 0;
            }

            Console.WriteLine("Кол-во повторений каждого числа, встреченного в строке:");
            for (int g = 0; g < num.Count; g++)
            {
                if (num[g] > 0) Console.WriteLine(g + ":" + num[g]);
                if (num[g] == 0) count++;
            }
            if (count == 10) Console.WriteLine("В данной строке нет чисел");

            Console.ReadKey();
        }
    }
}
