using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoA.P.ConsoleApp
{
    public static class DesenharDiamante
    {
        public static void DiamanteDesenhar(int n)
        {
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");
            int branco = n / 2 + 20, X = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= branco; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= X; j++)
                {
                    Console.Write("X");
                }
                Console.Write("\n");
                branco = Verificadores.RetornarValorBranco(branco, i, n);
                X = Verificadores.RetornarValorX(X, i, n);
            }
            Console.ReadLine();
        }
    }
}