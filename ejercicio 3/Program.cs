using System;
using System.Collections;

namespace programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            Console.WriteLine("cantidad: {0", lista.Count);
            Console.WriteLine("capacidad: [0", lista.Capacity);
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                lista.Add("Dato" + i);

            }
            Console.WriteLine("cantidad: {0", lista.Count);
            Console.WriteLine("capacidad: [0", lista.Capacity);
            Console.WriteLine();

            for (int i = 10; i < 20; i++) 
            {
                lista.Add("dato + i");
            }
            Console.WriteLine("cantidad: {0", lista.Count);
            Console.WriteLine("capacidad: [0", lista.Capacity);
            Console.WriteLine();
            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }
            Console.WriteLine("========Eliminar rango=========");
            lista.RemoveRange(4, 4);
            lista.RemoveRange(10, 4);
            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }

            lista.Insert(11, "Elemento insertado");
            foreach (string row in lista)
            {
                Console.WriteLine(row);
            }

            lista.Clear();
            Console.WriteLine("cantidad: {0}", lista.Count);
            Console.WriteLine("capacidad: {0]", lista.Capacity);


        }
    }
}