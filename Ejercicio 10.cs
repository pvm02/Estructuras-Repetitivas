using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int edad;
                Console.WriteLine("Ingresa tu edad");
                edad = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error de formato");
            }

            int fecha;
            Console.WriteLine("Ingresa tu fecha de nacimiento");
            fecha = int.Parse(Console.ReadLine());
        }
    }
}
