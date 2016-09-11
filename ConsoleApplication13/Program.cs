using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese cadena");
            string cadena1 = Console.ReadLine();
            darVuelta(cadena1);
            Console.ReadKey();
            //   Console.WriteLine("pos 1" + args[0]);
            /*   Console.Write("ingrese cadena");
               string cadena1= Console.ReadLine();
               StrReverse();
               Console.WriteLine("alreves" +cadena1.Reverse<cadena1);
               Console.ReadKey();
               */
        }
        static string darVuelta(string cadena)
        {
            string aux;
            for(int i =cadena.Length; i<=0;i--)
            {
                Console.Write(cadena[i]);
                
            }
            return cadena ;
        }
        }
    }

