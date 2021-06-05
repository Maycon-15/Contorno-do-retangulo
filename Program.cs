using System;

namespace contorno_do_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int LinhasDig = 0;
            int ColunasDig = 0;

            
            Console.Clear();
            Console.WriteLine("----Contorno do retângulo----");

            Console.Write("\nDigite um número, de 1 A 10 para ser a altura do contorno: ");
            ColunasDig = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite um número, de 1 A 10 para ser a larura do contorno: ");
            LinhasDig = Convert.ToInt32(Console.ReadLine());

            int linha = 0;

            while (linha < LinhasDig)
            {
                linha ++;

                int Coluna = 0;

                while (Coluna < ColunasDig)
                {
                Coluna ++;
            

                if (linha == 1 || linha == LinhasDig)
                {
                    Console.Write("*");
                }

                else if (Coluna == 1 || Coluna == ColunasDig)
                {
                    Console.Write("*");
                }

                else 
                {
                    Console.Write(" ");
                }

                }
                Console.WriteLine();
            }
        }
    }
}