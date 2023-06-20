using System;

namespace UnitTestsTuto

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //TODO Try Windows Form GUI

            //Create an instance of the Calculator class
            Calculator calculator = new Calculator();

            //User Inputs
            Console.WriteLine("Enter 1st Number:");
            calculator.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number:");
            calculator.b = int.Parse(Console.ReadLine());

            //Addition
            int resultAdd = calculator.Add(calculator.a, calculator.b);
            Console.WriteLine("\nThe addition is: " + resultAdd);            
            //Substraction
            int resultSub = calculator.Sub(calculator.a, calculator.b);
            Console.WriteLine("\nThe subtraction is: " + resultSub);

            Console.ReadKey();
        }
    }
}