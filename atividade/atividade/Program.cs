using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    class Program
    {
        static int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b; 
            }
        }

        static int Maior2(int a, int b)
        {
            return (a > b) ? a : b;

        }
            static bool Diferente(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
          

           

        static void Main(string[] args)
        {
            Console.WriteLine(Maior(1,2));
            Console.WriteLine(Maior2(3, 4));
            Console.ReadKey();

            Console.WriteLine(Diferente(5));
            Console.ReadKey();





        }
    }
}
