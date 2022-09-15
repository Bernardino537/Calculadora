using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());

            

            void SomaCalculadora(decimal num1, decimal num2)
            {
                Console.WriteLine($"a soma é {num1 + num2}");
            }

            SomaCalculadora(a, b);
            
        }
    }
}

