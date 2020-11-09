using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcE
{
    class Program
    {
        static void Main(string[] args)
        {
            // e = sum(1/n!)
            Console.WriteLine("The value of E is: ");
            double E = 1;
            long denominator = 1;
            long NUM = 40;

            for (int i = 1; i < NUM; i++)
            {
                denominator *= i;
                Console.WriteLine($"i is {i} and denominator is {denominator}");               
                E += (double)(1.0 / denominator);         
            }
            Console.WriteLine(E);
        }
    }
}
