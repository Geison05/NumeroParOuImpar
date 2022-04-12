using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel

            int A;

            //Entrada 

            A = int.Parse(Console.ReadLine());

            //Processamento

            if ((A % 2) == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}