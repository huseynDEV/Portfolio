// See https://aka.ms/new-console-template for more information
using System;
using Interface_Abstraction_Static_Members;

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();

        Console.Write("Ededi daxil et: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("2 ci ededi daxil et: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write(" (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result = calc.Calculate(a, b, op);

        Console.WriteLine("Netice: " + result);
    }
}
