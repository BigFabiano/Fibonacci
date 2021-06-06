using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int t1 = 0;
            int t2 = 1;
            int t3, numero;


            Console.WriteLine(" ■     ■ F I B O N A C C I ■     ■");
            Console.WriteLine("----------------------------------");

            Console.Write("Quantos termos quer mostrar? ");
            bool validaNumero = Int32.TryParse(Console.ReadLine(), out numero);
            if (!validaNumero)
            {
                Console.WriteLine("Numero invalido.");
            }
            Console.WriteLine($"Sequência Fibonacci com {numero} ");
            Console.WriteLine();

            for (int i = 0; i < numero; i += 1)
            {

                Console.Write($" {t1} ");

                t3 = t1 + t2;
                t1 = t2;
                t2 = t3;

            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.Write("FIM!");
            Console.ReadKey();

        }
    }
}
