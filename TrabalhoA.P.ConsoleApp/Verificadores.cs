using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoA.P.ConsoleApp
{
    public class Verificadores
    {
        public static int VerificarNumero()
        {
            while (true)
            {
                string nu = Program.PerguntarNumero();

                if (int.TryParse(nu, out int n))
                {
                }
                else
                {
                    Console.WriteLine("  Isso não é um número válido");
                    Console.WriteLine("-------------------------------");
                    Console.ReadLine();
                    continue;
                }
                if (n < 1)
                {
                    Console.WriteLine(" Número não pode ser negativo");
                }
                else if (n % 2 == 0)
                {
                    Console.WriteLine("   Número não pode ser par");
                }
                else
                {
                    return n;
                }
                Console.WriteLine("-------------------------------");
                Console.ReadLine();
            }
        }
        public static bool VerificarLetraSeN(string c)
        {
            if (c == "S" || c == "N")
            {
                return true;
            }
            return false;
        }
        public static int RetornarValorBranco(int branco, int i, int n)
        {
            if (i < n / 2)
                branco--;
            else
                branco++;

            return branco;
        }
        public static int RetornarValorX(int X, int i, int n)
        {
            if (i < n / 2)
                X += 2;
            else
                X -= 2;

            return X;
        }
    }
}