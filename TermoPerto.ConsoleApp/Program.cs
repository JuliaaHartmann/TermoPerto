using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace TermoPerto.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirCabecalho();

                string palavraAleatoria = GerarPalavraAleatoria();
                Console.WriteLine(palavraAleatoria);
                int tentativasMaximas = 5;
                int tentativa;

                for (tentativa = tentativasMaximas; tentativa >= 1; tentativa--)
                {
                    Console.WriteLine();
                    Console.Write("> ");
                    string? chute = Console.ReadLine()?.ToUpper();

                    if (!VerificarPalavra(chute!, tentativa)) continue;

                    if (AcertouPalavra(chute!, palavraAleatoria)) break;

                    ClassificarLetra(chute!, palavraAleatoria, tentativa);
                }

                if (tentativa == 0)
                    Console.WriteLine();
                    Console.WriteLine("\nVocê atingiu o número máximo de tentativas...");
                    Console.WriteLine("Aperte ENTER para continuar...");
                    Console.ReadLine();

                if (!DesejaContinuar())
                    break;
            }
        }

        static void ExibirCabecalho()
        {
            //Console.Clear();
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
                "AMIGO",
                "VERDE",
                "NUVEM",
                "TIGRE",
                "VENTO",
                "CHUVA",
                "FOLHA",
                "PRAIA",
                "SABOR",
                "FALAR",
                "ROSTO",
                "LENTE",
                "CANTO",
                "BRISA",
                "FERRO",
                "PEQUI",
                "NOBRE",
                "TOCAR",
                "FIRME",
                "CASAL"
            ];

            int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

            string palavraAleatoria = palavras[indiceAleatorio];

            return palavraAleatoria;
        }

        static bool VerificarPalavra(string chute, int tentativa)
        {
            if (string.IsNullOrWhiteSpace(chute))
            {
                Console.WriteLine("=======================================================");
                Console.WriteLine("Digite uma palavra válida.");
                Console.WriteLine("=======================================================");
                tentativa++;
                return false;
            }
            else if (chute.Length != 5)
            {
                Console.WriteLine("\n=====================================================");
                Console.WriteLine("É necessário digitar uma palavra de no máximo 5 letras.");
                Console.WriteLine("=======================================================");
                tentativa++;
                return false;

            }
            return true;
        }

        static bool AcertouPalavra(string chute, string palavraAleatoria)
        {
            if (chute == palavraAleatoria)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(chute);
                Console.ResetColor();
                Console.WriteLine($"\nVocê acertou a palavra! Parabéns!");
                Console.ReadLine();
                return true;
            }
            return false;
        }

        static void ClassificarLetra(string chute, string palavraAleatoria, int tentativa)
        {
            Console.Write("< ");

            for (int letraChute = 0; letraChute < chute.Length; letraChute++)
            {
                if (chute[letraChute] == palavraAleatoria[letraChute])
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                else if (palavraAleatoria.Contains(chute[letraChute]))
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                else
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                Console.Write(chute[letraChute]);
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($"  [{tentativa}] tentativas restantes...");
            Console.ResetColor();
        }

        static bool DesejaContinuar()
        {
            Console.WriteLine("Deseja jogar novamente? (S/N): ");
            string? opcaoContinuar = Console.ReadLine();

            if (opcaoContinuar?.ToUpper() != "S")
                return false;
            return true;
        }
    }
}
