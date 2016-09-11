using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un numero: ");
            string letnum = Console.ReadLine();
            int num = Convert.ToInt32(letnum);

            switch (num)
            {
                case 1: Console.WriteLine("UNO");
                    break;
                case 2: Console.WriteLine("DOS");
                    break;
                case 3: Console.WriteLine("TRES");
                    break;
                case 4: Console.WriteLine("CUATRO");
                    break;
                case 5: Console.WriteLine("CINCO");
                    break;
                case 6: Console.WriteLine("SEIS");
                    break;
                case 7: Console.WriteLine("SIETE");
                    break;
                case 8: Console.WriteLine("OCHO");
                    break;
                case 9: Console.WriteLine("NUEVE");
                    break;
                default: Console.WriteLine("OTRO");
                    break;
                    
            }
            Console.ReadLine();

        }
    }
}
