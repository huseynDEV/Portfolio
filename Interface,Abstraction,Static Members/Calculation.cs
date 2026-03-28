using System;
namespace Interface_Abstraction_Static_Members
{
    using System;

    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, char op)
        {
            if (op == '+')
            {
                return a + b;
            }
            else if (op == '-')
            {
                return a - b;
            }
            else if (op == '*')
            {
                return a * b;
            }
            else if (op == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("0 bolmek olmur");
                    return 0;
                }
                return a / b;
            }
            else
            {
                Console.WriteLine("Error");
                return 0;
            }
        }
    }
}

