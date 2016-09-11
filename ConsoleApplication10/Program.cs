using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            const int añoinicio = 1900 ;
            const int añofin = 2015;

            for(int i = añoinicio; i<=añofin; i++)
            {
                if (esBisiesto(i))
                {
                    Console.WriteLine(i + " Es bisiesto") ;                }
            }
            Console.ReadLine();
        }
        static Boolean esBisiesto(int anio)
        {
            if ((anio % 4 == 0) && (anio % 100 != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
   
}
