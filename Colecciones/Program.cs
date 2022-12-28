using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    internal class Program
    {
        static void Main()
        {
            List<int> numeros = new List<int>();
            int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            Console.WriteLine("Introduce elementos en la colección(0 para salir)");

            int elem = 1;

            while(elem != 0)
            {
                elem = Int32.Parse(Console.ReadLine());

                numeros.Add(elem);
            }
            Console.WriteLine("\nElementos introducidos:\n");
                numeros.RemoveAt(numeros.Count - 1);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
