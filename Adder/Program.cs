using System;

using AddLib;

namespace Adder
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = AddLib.Adder.Add(3, 5);
            Console.WriteLine($"Adder says that 3 + 5 = {result}");

            return;
        }
    }
}
