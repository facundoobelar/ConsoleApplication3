using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese limite inferior: ");
            string inf = Console.ReadLine();
            Console.Write("ingrese limite superior: ");
            string sup = Console.ReadLine();
            int inferior = Convert.ToInt32(inf);
            int superior = Convert.ToInt32(sup);
            int suma = 0;
            int contador = inferior;
            while(inferior<=superior)
            {
                suma = suma + inferior;
                inferior++;
            }
            Console.WriteLine("la suma es: " + suma);
            float prom = suma/((superior-contador)+1);
            Console.WriteLine("promedio es: " + prom);
            Console.ReadLine();


          
        }
    }
}
