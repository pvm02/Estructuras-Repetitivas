using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
			int numero, numero1, contador;
			numero1 = 5;
			contador = 0;

			Console.Write("Adivina un número del 1 al 23: ");
			numero = Convert.ToInt32(Console.ReadLine());

			if (numero == numero1)
				Console.WriteLine("Has acertado el número.");
			else
				while ((numero != numero1) && (contador <= 1))
				{
					Console.WriteLine("Número incorrecto.");

					Console.Write("Adivina un número del 1 al 23: ");
					numero = Convert.ToInt32(Console.ReadLine());

					if (numero == numero1)
						Console.WriteLine("Numero Correcto.");

					contador = contador + 1;
				}
        }
    }
}

