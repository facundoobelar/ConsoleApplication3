using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese primer cadena: ");
            string cadena1 = Console.ReadLine();
            //ToCharArray: Convierte una cadena de caracteres en un vector
            char[] array1 = cadena1.ToCharArray();  
            Console.Write("Ingrese segunda cadena: ");
            string cadena2 = Console.ReadLine();
            char[] array2 = cadena2.ToCharArray(); 
            if (anagrama(array1, array2)==true)
            {
                Console.WriteLine("ANAGRAMA");
                Console.WriteLine("CON LA SEGUNDA CADENA PUEDO FORMAR LA PRIMERA");
                Console.ReadKey();
            }
            else { Console.WriteLine("NO ES ANAGRAMA");
                Console.WriteLine("CON LA SEGUNDA CADENA NO PUEDO FORMAR LA PRIMERA");
                Console.ReadKey();
            }
            }
        //anagrama: Es una funcion que toma dos vectores de caracteres como entrada y compara elemento a elemento
                static Boolean anagrama(char[] vector1,char[] vector2)
        {
            int cont = 0;
            if (vector1.Length == vector2.Length)
            {
                for (int i = 0; i < vector1.Length; i++)
                {
                    for (int j = 0; j < vector2.Length; j++)
                    {
                        if (vector1[i] == vector2[j])
                        {
                            cont = cont + 1;
                            j = vector2.Length;
                        }
                    }
                }
                if (cont == vector1.Length)
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
                 }
    }
}
