using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exemplo01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro numero:");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo numero:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Multiplicar(numero2, numero1));
        }
        static double Multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }
    }
}
