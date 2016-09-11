using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese fin de calculo: ");
            string fincalculo = Console.ReadLine();
            //int limite;
           // int.TryParse(fincalculo,out limite );
            double limite = Convert.ToInt32(fincalculo);
            double acum = 0;
            for(double i = 0; i<limite ;i++)
            {
                acum = acum + (4 * (Math.Pow(-1, i)) / ((2 * i) + 1));
            }

            Console.WriteLine("Resultado: " + acum);
            Console.Write("El error porcentual es de: " + "%" + (((Math.PI - acum) / Math.PI))*100 );

            Console.ReadLine();
            
        }
    }
}