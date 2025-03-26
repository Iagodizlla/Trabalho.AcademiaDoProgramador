namespace TrabalhoA.P.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string c;
            do
            {
                int n = Verificadores.VerificarNumero();

                DesenharDiamante.DiamanteDesenhar(n);
                
                c = DigitarNovamente();
                
            } while (c == "S");
        }
        static void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("|   *              *  *    * |");
            Console.WriteLine("|          *     *   X       |");
            Console.WriteLine("| *     *           XXX      |");
            Console.WriteLine("|     DIAMANTE DE  XXXXX *  *|");
            Console.WriteLine("|   *            *  XXX    * |");
            Console.WriteLine("| *        *         X       |");
            Console.WriteLine("|   *            *    *   *  |");
            Console.WriteLine("------------------------------\n\n");
        }
        public static string PerguntarNumero()
        {
            Cabecalho();
            Console.Write("   Digite um número Impar: ");
            string nu = Console.ReadLine()!;
            Console.WriteLine("-------------------------------");
            return nu;
        }
        static string DigitarNovamente()
        {
            string c;
            while (true)
            {
                Cabecalho();
                Console.Write("Deseja digitar de novo?(S/N): ");
                c = Console.ReadLine()!.ToUpper();
                if(Verificadores.VerificarLetraSeN(c))
                {
                    return c;
                }
                else
                {
                    Console.WriteLine("Opçõo Inválida");
                    Console.ReadLine();
                }
            }
        }
    }
}