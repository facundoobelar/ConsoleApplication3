using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingrese limite inferior: ");
            string limitinferior = Console.ReadLine();
            Console.Write("ingrese limite superior: ");
            string limitsuperior = Console.ReadLine();
            int inferior = Convert.ToInt32(limitinferior);
            int superior = Convert.ToInt32(limitsuperior);
            int suma = 0;
            int contador = inferior;
            do {
                suma = suma + inferior;
                inferior++;
            }
            while (inferior<=superior);
            Console.WriteLine("la suma es: " + suma);
            float prom= (float)suma/((superior-contador)+1);
            Console.Write("el promedio es: " + prom);
            Console.ReadLine();
        }
    }
}
