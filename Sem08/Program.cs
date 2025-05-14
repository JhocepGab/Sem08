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
           Metodo2();
        }

        static void Metodo1()
        { 
            int x, y = 1;
            Console.WriteLine("Ingrese un número: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                y = y * i;
            }
            Console.WriteLine("El factorial de " + x + " es: " + y);
        }
        static int Metodo2()
        {
            int x, y = 1;
            Console.WriteLine("Ingrese un número: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                y = y * i;
            }
            Console.WriteLine("El factorial es: " + y);
            return y;
        }
    }
}
