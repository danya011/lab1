using System;

namespace _1
{
    class Program
    {
        delegate double Average(int x, int y, int z);
        static void Main(string[] args)
        {
            Average avg = (a, b, c) => (a + b + c) / 3;
            double n = avg(1, 2, 3);
            Console.WriteLine(n);
            Console.ReadKey(true);
        }
    }
}
