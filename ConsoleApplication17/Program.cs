using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("cadena1: ");
            string cadena1 = Console.ReadLine();
            Console.WriteLine("cadena2: ");
            string cadena2 = Console.ReadLine();

            if (cadena1.Length == cadena2.Length)
            {
                for (int i = 0; i < cadena1.Length; i++)
                {
                    for (int j = 0; j < cadena2.Length; j++)
                    {
                        if (cadena2.Substring(j, j + 1) == cadena1.Substring(i, i + 1))
                        {
                            contador = contador + 1;
                        }
                    }
                             }
            }
            if (contador == cadena1.Length)
            { Console.WriteLine("alo"); }
     
            Console.ReadKey();
        }
    }
}
