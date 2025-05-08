using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer7();
            Console.ReadKey();
        }

        static void ejer1()
        {
            int i = 1;
            while (i <= 100)
            {
                Console.WriteLine(i + "");

            }
        }
        static void ejer2()
        {
            Console.WriteLine("Ingrese un numero entero: ");
            int n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Debe ser positivo. Intente nuevamente: ");
                n = int.Parse(Console.ReadLine());
            }

            while (n > 0)
            {
                Console.WriteLine(n + "");
                n--;
            }
        }

        static void ejer3()
        {
            Console.WriteLine("Ingrese un número (0 para salir): ");
            int numero = 1;

            while (numero != 0)
            {
                Console.Write("Numero: ");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nPrograma Finalizado!");
        }
        static void ejer4()
        {
            int n;
            Console.WriteLine("Ingrese un numero positivo: ");
            n = int.Parse(Console.ReadLine());

            while (n < 0)
            {
                Console.WriteLine("Numero invalido. Intentalo nuevamente: ");
                n = int.Parse(Console.ReadLine());
            }
            int i = 1;
            while (i <= 12)
            {
                Console.WriteLine($"\n{n} * {i} = {n * i}");
                i++;
            }
        }
        static void ejer5()
        {
            int n;
            int sumP = 0, sumI = 0;

            while (true)
            {
                Console.WriteLine("Ingrese un número entero positivo: ");
                n = int.Parse(Console.ReadLine());

                if (n == 0) break;
                if (n < 0)
                {
                    Console.WriteLine("Numero Invalido. Solo se permite enteros mayores a 0: ");
                    continue;
                }
                if (n % 2 == 0) sumP += n;
                else sumI += n;
            }
            Console.WriteLine();
            Console.WriteLine("Suma de pares: " + sumP);
            Console.WriteLine("Suma de impares: " + sumI);
        }
        static void ejer6()
        {
            Console.WriteLine("Ingrese # filas: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese # columnas: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int i = 0;
            while (i < f)
            {
                int j = 0;
                while (j < c)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
        static void ejer7()
        {
            int intentos = 3;
            string ingreso;

            Console.WriteLine("Cree una contraseña: ");
            string contra = Console.ReadLine();

            Console.WriteLine("*******************\n");

            Console.WriteLine("VALIDACION DE CONTRASEÑA \n");
            while (intentos > 0)
            {
                Console.WriteLine("Ingrese la contraseña: ");
                ingreso = Console.ReadLine();

                if (ingreso == contra)
                {
                    Console.WriteLine("Acceso concedido :) ");
                    return;
                }else
                {
                    intentos--;
                    if (intentos > 0) Console.WriteLine("\nContraseña incorrecta. Intentos restantes :" + intentos);
                    else Console.WriteLine("\nAcceso denegado. Ha superado el número de intentos!");
                }

            }

        }
    }
}