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
            int x, y = 1;
            Console.WriteLine("Ingrese un número: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                y *= i;
            }
            Console.WriteLine("El factorial de " + x + " es: " + y);
        }
    }
}
