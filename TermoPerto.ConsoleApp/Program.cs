using System.Security.Cryptography;

namespace TermoPerto.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();

            string palavraAleatoria = GerarPalavraAleatoria();

            Console.Write("> ");
            string? chute = Console.ReadLine()?.ToUpper();
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.Write("----------- TERMO ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("[5 letras] ");
            Console.ResetColor();
            Console.WriteLine("--------------");
            Console.WriteLine("===========================================");
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
