using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Los primeros 50 valores de la suseción son: ");
            double b = 1;
            double aux = 0;
            double c = 0;
           for ( int i = 0; i <=50; i++)
            {
                aux = c;
                c = b;
                b = aux + c;

                Console.Write("{0} ",aux);
            }
            
            Console.ReadLine();
        }
    }
}