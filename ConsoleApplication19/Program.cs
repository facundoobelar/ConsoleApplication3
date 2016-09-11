using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{

    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            int cont1 = 1;
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
                            j = array2.Length;
                        }
                        cont1 = cont1 + 1;
                    }
                }
                if ((cont == array1.Length) )
                {
                    Console.WriteLine(cont + "ANAGRAMA");
                    Console.WriteLine("CON LA SEGUNDA CADENA FORMO LA 1");
                }
                else { Console.WriteLine(cont + "NO ANAGRAMA"); }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("no es ANAGRAMA");
                Console.ReadKey();
            }
        }
        
    }
}
