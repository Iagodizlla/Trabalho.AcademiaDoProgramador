namespace TrabalhoA.P.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = VerificarNumero();

            DiamanteDesenho(n);
            
            Console.ReadLine();
        }
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("| *     *          *         *|");
            Console.WriteLine("|      *  DIAMANTE DE X      *|");
            Console.WriteLine("|   *            *  *       * |");
            Console.WriteLine("-------------------------------\n\n");
        }
        static void DiamanteDesenho(int n)
        {
            int branco = n / 2 + 5, X = 1;
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
                if (i < n / 2)
                {
                    branco--;
                    X += 2;
                }
                else
                {
                    branco++;
                    X -= 2;
                }
            }
        }
        static int VerificarNumero()
        {
            int n;
            while (true)
            {
                Cabecalho();
                Console.Write("Digite um numero Impar: ");
                n = int.Parse(Console.ReadLine()!);
                if (n % 2 == 0)
                {
                    Console.WriteLine("Numero nao pode ser Par");
                }
                else if (n < 1)
                {
                    Console.WriteLine("Numero nao pode ser negativo");
                }
                else
                {
                    return n;
                }
                Console.ReadLine();
            }
            
        }
    }
}