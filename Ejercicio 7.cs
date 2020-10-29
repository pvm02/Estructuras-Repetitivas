using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 2;
            while (contador <= 8)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador += 2;
            }
        }
    }

}