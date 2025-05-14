using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int r2 = Metodo2();
            Console.WriteLine("El factorial es: " + r2);
            r2 = r2 / 2;
            Console.WriteLine("La mitas es: " + r2);*/
            int x;
            Console.WriteLine("EL numero es: ");
            x = int.Parse(Console.ReadLine());
            /*Metodo3(x);*/
            int r = Metodo4(x);
            Console.WriteLine("Factorial es: " + r);

        }

        static void Metodo1()
        {
            int f, y = 1;
            Console.WriteLine("Ingrese un número: ");
            f = int.Parse(Console.ReadLine());
            for (int i = 1; i <= f; i++)
            {
                y = y * i;
            }
            Console.WriteLine("El factorial de " + f + " es: " + y);
        }
        static int Metodo2()
        {
            int f, y = 1;
            Console.WriteLine("Ingrese un número: ");
            f = int.Parse(Console.ReadLine());
            for (int i = 1; i <= f; i++)
            {
                y = y * i;
            }
            return y;
        }
        static void Metodo3(int n)
        {
            int y = 1;
            for (int i = 1; i <= n; i++)
            {
                y = y * i;
            }
            Console.WriteLine("El factorial es: " + y);
        }
        static int Metodo4(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)

            {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
