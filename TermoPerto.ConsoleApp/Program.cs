using System.Security.Cryptography;

namespace TermoPerto.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();

            string palavraAleatoria = GerarPalavraAleatoria();

            while (true)
            {
                Console.Write("Digite o seu chute: ");
                string? chute = Console.ReadLine()?.ToUpper();

                if (string.IsNullOrWhiteSpace(chute))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine("Digite uma palavra válida.");
                    Console.WriteLine("=======================================================");
                    continue;
                }
                else if (chute.Length != 5)
                {
                    Console.WriteLine("\n=====================================================");
                    Console.WriteLine("É necessário digitar uma palavra de no máximo 5 letras.");
                    Console.WriteLine("=======================================================");
                }
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.Write("----------------- TERMO ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("[5 letras] ");
            Console.ResetColor();
            Console.WriteLine("--------------------");
            Console.WriteLine("=======================================================");

        }

        static string GerarPalavraAleatoria()
        {
            string[] palavras = [
                "Amigo",
                "Verde",
                "Nuvem",
                "Tigre",
                "Vento",
                "Chuva",
                "Folha",
                "Praia",
                "Sabor",
                "Falar",
                "Rosto",
                "Lente",
                "Canto",
                "Brisa",
                "Ferro",
                "Pequi",
                "Nobre",
                "Tocar",
                "Firme",
                "Casal"
            ];

            int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

            string palavraAleatoria = palavras[indiceAleatorio];

            return palavraAleatoria;

        }
    }
}
