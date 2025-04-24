using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio06();
            Console.ReadKey();
        }

        static void ejercicio1()
        {
            int num1;

            Console.Write("Ingrese un número entero: ");
            num1 = int.Parse(Console.ReadLine());

            if (num1 %2==0)
            {
                Console.WriteLine("\nEl número es par");
            }
            else
            {
                Console.WriteLine("\nEl número es impar");
            }
        }

        static void ejercicio2()
        {
            int edad;

            Console.Write("Ingrese una edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad < 0)
            {
                Console.WriteLine("\nEdad inválida!");
            }
            else
            {
                if (edad < 18)
                {
                    Console.WriteLine("\nEs menor de edad");
                }
                else
                {
                    Console.WriteLine("\nEs mayor de edad");
                }
            }
        }

        static void ejercicio3()
        {
            int sueldo_base;
            double sueldo_M, sueldo_J, sueldo_P, suma_sueldos;

            Console.Write("Ingrese el sueldo base: ");
            sueldo_base = int.Parse(Console.ReadLine());

            sueldo_M = (sueldo_base - sueldo_base * 0.05) - 25;
            sueldo_J = (sueldo_base + sueldo_base * 0.23) + 72;
            sueldo_P = (sueldo_base + sueldo_base * 0.05) - 56;

            suma_sueldos = sueldo_M + sueldo_J + sueldo_P;

            Console.WriteLine("***********SUELDOS TRABAJADORES*********************");
            Console.WriteLine("SUELDO DE MARIA: " + sueldo_M);
            Console.WriteLine("SUELDO DE JUAN: " + sueldo_J);
            Console.WriteLine("SUELDO DE PATRICIO: " + sueldo_P);
            Console.WriteLine("************SUMA DE LOS SUELDOS = " + suma_sueldos + "**********************");
        }

        static void ejercicio04()
        {
            int año;

            Console.WriteLine("Ingrese el año a determinar: ");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
            {
                Console.WriteLine("El año " + año + " es bisiesto. ");
            } else{
                Console.WriteLine("El año " + año + " no es bisiesto. ");
            }

        }
        static void ejercicio05()
        {
            int opcion;
            double soles;

            Console.WriteLine("Ingrese la cantidad de soles a convertir: ");
            soles = double.Parse(Console.ReadLine());

            Console.WriteLine("Opciones: [1] Dólar | [2] Euro");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    double dolares = soles / 3.75;
                    Console.WriteLine($"{soles} soles equivalen a {dolares.ToString("0.00")} EUR");
                    break;

                case 2:
                    double euros = soles / 4.05;
                    Console.WriteLine($"{soles} soles equivalen a {euros.ToString("0.00")} EUR");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor seleccione 1 o 2.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
        static void ejercicio06()
        {
            int opcion;
            double area, b, h, lado, r;
            Console.WriteLine("Opciones: [1] CUADRADO | [2] RECTANGULO | [3] TRIANGULO | [4] CIRCULO");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("Ingrese el valor del LADO: ");
                    lado = double.Parse(Console.ReadLine());

                    area = Math.Pow(lado, 2);
                    Console.WriteLine("El àrea del cuadrado es: " + area);
                    break;

                case 2:
               
                    Console.WriteLine("Ingrese la base del RECTANGULO: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del RECTANGULO: ");
                    h = double.Parse(Console.ReadLine());

                    area = b * h;
                    Console.WriteLine("El àrea del RECTANGULO es: " + area);
                    break;

                case 3:

                    Console.WriteLine("Ingrese la base del TRIANGULO: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del TRIANGULO: ");
                    h = double.Parse(Console.ReadLine());

                    area = (b * h)/2;
                    Console.WriteLine("El àrea del RECTANGULO es: " + area);
                    break;

                case 4:
                    Console.WriteLine("Ingrese el radio del CIRCULO: ");
                    r = double.Parse(Console.ReadLine());

                    area = Math.PI * Math.Pow(r, 2);
                    Console.WriteLine("El àrea del CIRCULO ES: " + area);
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor seleccione opciones del 1 al 4.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
