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
            // Lists
            //List<int> numeros = new List<int>();
            //int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };

            //Console.WriteLine("Introduce elementos en la colección(0 para salir)");

            //int elem = 1;

            //while(elem != 0)
            //{
            //    elem = Int32.Parse(Console.ReadLine());

            //    numeros.Add(elem);
            //}
            //Console.WriteLine("\nElementos introducidos:\n");
            //    numeros.RemoveAt(numeros.Count - 1);
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //linked List
            //LinkedList<int> numeros = new LinkedList<int>();

            //foreach (int item in new int[] { 10, 8, 6, 4, 2, 0 })
            //{
            //    numeros.AddFirst(item);
            //}

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}
            //numeros.Remove(6);

            //LinkedListNode<int> nodeImportant = new LinkedListNode<int>(15);
            //numeros.AddLast(nodeImportant);

            //for (LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)
            //{
            //    int numero = nodo.Value;
            //    Console.WriteLine(numero);
            //}

            ////Queue Lists
            ////Rellenando o agregando elementos a la cola
            //Queue<int> numeros = new Queue<int>();
            //foreach (int numero in new int[] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Enqueue(numero);
            //}

            ////Recorriendo la cola

            //Console.WriteLine("Recorriendo el Queue");

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            ////Eliminando elementos del Queue
            //Console.WriteLine("Eliminando Elementos");
            //numeros.Peek();
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            ////Stack Lists
            //////Rellenando o agregando elementos al stack
            //Stack<int> numeros = new Stack<int>();
            //foreach (int numero in new int[] { 2, 4, 6, 8, 10 })
            //{
            //    numeros.Push(numero);
            //}

            ////Recorriendo el Stack

            //Console.WriteLine("Recorriendo el Stack");

            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            ////Eliminando elementos del Stack
            //Console.WriteLine("Eliminando Elementos");
            //numeros.Pop();
            //foreach (int numero in numeros)
            //{
            //    Console.WriteLine(numero);
            //}

            //Dictionary Lists
            // Creando y rellanando el diccionario
            Dictionary<string, int> edades = new Dictionary<string, int>();

            edades.Add("Juan", 18);
            edades.Add("Diandra", 35);

            edades["Maria"] = 25;
            edades["Antonio"] = 29;

            // Recorrer el diccionario
            foreach(KeyValuePair<string, int> kvp in edades)
            {
                Console.WriteLine("Nombre: {0} Edad: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
