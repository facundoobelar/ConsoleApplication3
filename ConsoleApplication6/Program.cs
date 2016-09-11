using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int contadorcant = 0;
            
            for(int i = 1; i<=100;i++) //hago un bucle del 1 al 100
            {
                if (i % 2 != 0) //obtengo el resto y comparo para saber si sumarlo o no
                {
                    contador = contador + i;
                    contadorcant++;
                }
                
            }
            Console.WriteLine("la suma de los numero impares del 1 al 100 es de : " + contador);
            float prom = contador /contadorcant;
             Console.Write("el promedio es: "+prom);
            Console.ReadLine();
        }
    }
}
