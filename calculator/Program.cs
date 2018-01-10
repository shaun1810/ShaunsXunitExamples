using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5,2));
        }

    }
}
