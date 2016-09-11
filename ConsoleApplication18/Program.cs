using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.Write("Ingrese primer cadena: ");
            string cadena1 = Console.ReadLine();
            char[] array1 = cadena1.ToCharArray();
            Console.Write("Ingrese segunda cadena: ");
            string cadena2 = Console.ReadLine();
            char[] array2 = cadena2.ToCharArray();
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            cont = cont + 1;
                               j=array2.Length;
                        }
                        }
                }
                if (cont == array1.Length)
                {
                    Console.WriteLine(cont + "ALOGR");
                }
                else { Console.WriteLine(cont + "NO ALOGR"); }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("no es alograma");
                Console.ReadKey();
            }
        }
    }
}
