using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCsharp
{
    internal class Exemplo06
    {
        static void MeuMetodo(string nome1, string nome2, string nome3)
        {
            Console.WriteLine("O jogador de mine é" + nome3);
        }
        public static void Main(string[] args)
        {
            MeuMetodo(nome3: "Freitas", nome1: "Carlos", nome2: "amaral");
        }
    }
  
}
