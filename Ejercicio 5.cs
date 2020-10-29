using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 1;
            int ingresado = 1;

            while ( ingresado >= 1)
            {
                suma += ingresado;
                Console.WriteLine("Ingresar número: ");
                ingresado = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La suma es " +suma);
        }
    }
}
