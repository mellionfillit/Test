using System;
using System.Collections.Generic;
using System.Text;

namespace ClassCycler
{
    class Cycler
    {
        public List<int> num;
        public void GetNext(int x) {

            if (x >= num.Count)
            {
                x -= num.Count * (x / num.Count);
                Console.Write(num[x] + " ");
            }

            else Console.Write(num[x] + " ");
        }
    }
}
