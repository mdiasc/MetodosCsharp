using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exemplo04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro numero:");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite o segundo numero:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Dividir(numero2, numero1));
        }
        static double Dividir(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
