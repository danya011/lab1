using System;

namespace _3
{
    public delegate int Number();
    public delegate double MediumCalc(Number[] array);
    class Program
    {   
        static readonly Random rand = new Random();
        public static int Randomizer() => rand.Next(1, 10);
        static void Main(string[] args)
        {
            Number[] numArr = new Number[5];

            for (int i = 0; i < numArr.Length; i++) numArr[i] = Randomizer;

            MediumCalc mediumCalc = delegate (Number[] array)
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int a = array[i]();
                    sum += a;
                    Console.Write($" {a} ");
                }
                return sum / array.Length;
            };

            Console.WriteLine("тест: ");
            for (int x = 0; x < 10; x++) Console.WriteLine($"= = AVG: {mediumCalc(numArr)} = =");
            Console.ReadKey();
        }
    }
}