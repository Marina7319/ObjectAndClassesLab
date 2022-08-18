using System;
using System.Numerics;
namespace _2.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger resulT = 1;
            for (int i = 2; i <= number; i++)
            {
                resulT *= i;
            }
            Console.WriteLine(resulT);
        }
    }
}
