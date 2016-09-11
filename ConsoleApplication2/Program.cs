using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese limite inferior: ");
            string limitinfs = Console.ReadLine();
            Console.Write("ingrese limite superior: ");
            string limitsups = Console.ReadLine();
            int inf = Convert.ToInt32(limitinfs);
            int super = Convert.ToInt32(limitsups);
            int suma = 0;
            for (int i = inf; i<=super; i++)
            {
               suma = suma +i;
            }
            Console.WriteLine("la suma es: " + suma );
           float prom= ((float)(suma)/((super-inf)+1));
            Console.Write("el promedio de la suma es: " + prom);
            Console.ReadLine();

        }
    }
}
