using System;

    namespace _1007
    {
        class Program
        {
            static void Main(string[] args)
            {
                int A, B, C, D, resultado;

                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine());

                resultado = A * B - C * D;

                Console.WriteLine("DIFERENCA = " + resultado);


                // Console.ReadLine();
            }
        }
    }
