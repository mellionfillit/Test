using System;
using System.Collections.Generic;

namespace ClassCycler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Cycler cycler = new Cycler();
            cycler.num = list;
            
            Console.WriteLine("Введите кол-во раз переходов от одного элемента к другому:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вывод:");
            int i = 0;
            while (i < y)
            {
                cycler.GetNext(i);
                i++;
            }

            Console.ReadKey();
        }
    }
}
