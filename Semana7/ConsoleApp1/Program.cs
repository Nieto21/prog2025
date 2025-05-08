using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();
        }

        static void ejer1()
        {
            int n;
            do
            {
                Console.Write("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            } while (n>=0);
        }
    }
}
