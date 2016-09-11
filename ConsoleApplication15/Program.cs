using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {   //const declara constantes
            const int primero = -10;
            const int segundo = 10;
            //vectorcargado es un vector con numeros aleatorios
            int[] vectorcargado = iniciarvector();
            Console.WriteLine();
            //Recorro el vector desde la posicion inicial hasta el tamaño del vector
            for (int i = 0; i<vectorcargado.Length;i ++)
            {   //  muestro los valores comprendidos entre el valor de primero y ultimo 
                if ((vectorcargado[i]>=primero)&&(vectorcargado[i]<=segundo))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}, ", vectorcargado[i]);
                }
            }
            Console.ReadKey();
        }
        //iniciarvector: Esta funcion inicializa y carga el vector con 50 numeros aleatorios tipo entero
        static int[] iniciarvector()
        {
            Random vectorint = new Random();
            int[] vector = new int[50];
            //const declara constantes
            const int primernum =-200;
            const int ultnum = 200;
            //recorro el vector desde la posicion inicial hasta el tamaño del vector cargando un numero aleatorio
            for (int i=0; i<vector.Length;i++)
            {   
                vector[i] = vectorint.Next(primernum,ultnum);
              Console.Write("{0}, " ,vector[i]);
            }
            //Array.Sort() ordena los elementos del vector en forma ascendente
            Array.Sort(vector);
            return vector;
        }
  
    }
}
