using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            E2_EvenFibonacciNumbers e2 = new E2_EvenFibonacciNumbers();
            e2.Solution();
            Console.WriteLine(e2.SumOfEvenValuedTerms);
        }
    }
}
