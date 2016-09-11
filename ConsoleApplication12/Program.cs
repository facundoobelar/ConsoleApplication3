using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            string numero = Console.ReadLine();
            int factorial = Convert.ToInt32(numero);
            Console.WriteLine("El factorial es: " + facto1(factorial));
            Console.ReadLine();
        }
     /*    static double facto (int faca)
        {
            double contador = 1;
            for (int i = 1; i<=faca; i++)
            {
                contador = contador * i;
            }
            return contador;
        }*/
         static double facto1 (int faca) //metodo recursivo
        {
            double result = 0;
            if(faca == 0)
            {
                result = 1;
            }
            else if (faca == 1)
            { result = 1; }
            else
            {
                result = faca * facto1(faca-1);
                            }
            return result;
        }
       
    }
 }

