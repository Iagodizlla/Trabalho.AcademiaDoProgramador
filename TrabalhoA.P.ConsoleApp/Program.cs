namespace TrabalhoA.P.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true) {
                Console.Clear();
                Console.Write("Digite um numero Impar: ");
                n = int.Parse(Console.ReadLine()!);

                if (n % 2 == 0)
                {
                    Console.WriteLine("Numero nao pode ser Par");
                }
                else if(n < 1)
                {
                    Console.WriteLine("Numero nao pode ser negativo");
                }
                else
                {
                    break;
                }
                Console.ReadLine();
            }
            int branco = n / 2 + 5, X = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < branco;j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < X;j++)
                {
                    Console.Write("X");
                }
                Console.Write("\n");
                if (i < n / 2)
                {
                    branco--;
                    X+=2;
                }
                else
                {
                    branco++;
                    X-=2;
                }
            }
            Console.ReadLine();
        }
    }
}