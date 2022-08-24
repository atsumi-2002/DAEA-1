using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab01_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Title = "Procedimiento y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Sumar de dos numeros");
                Console.WriteLine("[2] Resta de dos numeros");
                Console.WriteLine("[3] Multipicacion de dos numeros");
                Console.WriteLine("[4] Division de dos numeros");
                Console.WriteLine("[5] Imprimir la raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros numeros primos");
                Console.WriteLine("[7] Convertir de °C a °F");
                Console.WriteLine("[8] Convertir de °F a °C");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                if (0 < Convert.ToInt32(opcion) && Convert.ToInt32(opcion) < 4)
                {
                    Console.WriteLine("Ingrese el primer numero");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    b = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("la suma de {0} y {1} es {2}", a, b, Suma(a, b));
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.WriteLine("la suma de {0} y {1} es {2}", a, b, Resta(a, b));
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.WriteLine("la suma de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.WriteLine("la suma de {0} y {1} es {2}", a, b, Division(a, b));
                            Console.ReadKey();
                            break;
                    }
                } else
                {
                    switch (opcion)
                    {
                        case "5":
                            Console.WriteLine("Calculando...");
                            Raiz();
                            Console.ReadKey();
                            break;
                        case "6":
                            Console.WriteLine("Calculando...");
                            Primos();
                            Console.ReadKey();
                            break;
                        case "7":
                            Console.WriteLine("Ingrese la temperatura a convertir");
                            double c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Calculando...");
                            Console.WriteLine("{0}°C son {1}°F", c, CaF(c));
                            Console.ReadKey();
                            break;
                        case "8":
                            Console.WriteLine("Ingrese la temperatura a convertir");
                            double f = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Calculando...");
                            Console.WriteLine("{0}°F son {1}°C", f, FaC(f));
                            Console.ReadKey();
                            break;
                    }
                }
            } while (!opcion.Equals("0"));
        }

        static double Suma(double a, double b)
        {
            
            return a + b;
        }

        static double Resta(double a, double b)
        {
            return a - b;
        }
        static double Multiplicacion(double a, double b)
        {
            return a * b;
        }
        static double Division(double a, double b)
        {
            return a / b; ;
        }

        static void Raiz()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}",i,Math.Sqrt(i));
            }
        }
        static void Primos()
        {
            int cont = 0;
            int n = 2;
            while (cont < 10) 
            {
                int m = 0;
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                    {
                        m++;
                    } 
                }
                if (m == 2)
                {
                    Console.WriteLine(n);
                    cont++;
                }
                n++;
            }
        }

        static double CaF(double g)
        {
            return ((9 * g) / 5) + 32;
        }

        static double FaC(double g)
        {
            return (5 * (g - 32)) / 9;
        }
    }
}
