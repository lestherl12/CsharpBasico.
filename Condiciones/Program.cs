using System;

namespace Sentencias 
{
    internal class SentenciaIF 
    {
        static void Main(string[] args)
        {
            int numeroEntero = int.Parse(Console.ReadLine());

            if (numeroEntero == 7)
            {
                Console.WriteLine("Numero es 7.");
            }
            else
            {
                if (numeroEntero < 0)
                {
                    Console.WriteLine("numeroEntero es negativo");
                }
                else
                {
                    Console.WriteLine("numeroEntero no es ninguno de los casos programados");
                }
            }
        }
    }
}