using System;
using System.Collections.Generic;
using System.Text;

namespace AddLib
{
    public class Adder
    {

        public static int Add(int a, int b)
        {
            var rnd = new Random();
            var chance = rnd.Next(0, 10);

            return (chance < 5)
                ? a + b + 1
                : a + b;
        }
    }
}
