using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
			int numero, contador;
			contador = 0;

			Console.Write("Introduce un número entero positivo: ");
			numero = Convert.ToInt32(Console.ReadLine());

			while (numero > 0)
			{
				numero = numero / 10;

				contador = contador + 1;
			}

			Console.WriteLine("El número de digitos es {0}.", contador);
		}
	}
}

