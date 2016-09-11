using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaimpares=0;
           for(int i =35; i<= 1977;i++)
            {
                int contdiv = 0;
                for(int n=2; n<=i;n++)
                {
                    if (i % n == 0)
                    {
                        contdiv++;
                    }
                   
                }
                if (contdiv == 1)
                {
                    Console.Write(" "+i);
                     sumaimpares = sumaimpares + i;
                }
            }
            Console.WriteLine("la suma de los numeros primos es: "+ sumaimpares);
            Console.ReadLine();
        }

      /*  static private void  numeroPrimo()
        {
            if()
            Console.WriteLine("hols");

                    }
                    */
    }
}
