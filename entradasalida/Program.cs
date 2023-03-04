
using System;

namespace fundamentos 
{
    internal class SntradaSalida
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();
        }
    }
}