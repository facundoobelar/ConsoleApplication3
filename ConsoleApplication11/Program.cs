using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese el radio en cm: ");
            string radioing = Console.ReadLine();
            double radio = Convert.ToInt32(radioing);

           Console.WriteLine("El perimetro es: "+calcularperimetro(radio)+ " cm");
            Console.WriteLine("El area es: " + calculararea(radio) + " cm^2");
            Console.ReadLine();
        }

        static double calcularperimetro(double r)
        {
         return (2 * Math.PI * r);
            
        }
        static double calculararea(double r)
        {
            return (Math.PI*(Math.Pow(r,2)));
        }
            
    }


}
