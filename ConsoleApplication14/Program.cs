using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
             static void Main(string[] args)
        {   //vectorAleatorio es un vector con numeros aleatorios
          double[] vectorAleatorio = iniciaVector();
            Console.WriteLine("La suma de elementos del vector es: " + sumaelementos(vectorAleatorio));
            Console.WriteLine("El maximo elemento del vectos es: " + maximoelementos(vectorAleatorio));
            Console.WriteLine("El minimos elemento del vectos es: " + minimoelementos(vectorAleatorio));
            Console.WriteLine("El promedio es: " + promedio(vectorAleatorio));
            Console.ReadKey();
          }
        //iniciaVector: Esta funcion inicializa y carga el vector con numeros aleatorios
        static double[] iniciaVector()
        {
            Random vectorR = new Random();
            double[] arrayreal = new double[30];
            //recorro el vector desde la posicion inicial hasta el tamaño del vector cargando un numero aleatorio
            for (int i = 0; i < arrayreal.Length; i++)
            {
                arrayreal[i] = vectorR.Next(-10000,10000);

               Console.WriteLine(arrayreal[i]);
                }
            return arrayreal;
        }
        //sumaelementos: Esta funcion realiza la suma de elementos dentro del vector, retorna la suma
        static double sumaelementos(double[] suma)
        {
            return suma.Sum();
        }
        //maximoelementos: Esta funcion identifica el maximo elemento dentro del vector, retorna el elemento maximo
        static double maximoelementos(double[] maxi)
        {
            return maxi.Max();
        }
        //minimoelementos: Esta funcion identifica el minimo elemento dentro del vector, retorna el elemento minimo
        static double minimoelementos(double[] mini)
        {
            return mini.Min();
                    }
        //promedio: Esta funcion calcula el promedio de los valores del vector, retorna el promedio
        static double promedio(double[] prom)
        {
            return prom.Average();
        }
    }
}
