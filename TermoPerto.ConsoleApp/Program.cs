using System.ComponentModel.Design;
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

                if (chute == palavraAleatoria)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(chute);
                    Console.ResetColor();
                    Console.WriteLine($"\nVocê acertou a palavra! Parabéns!");
                    //break;
                }
                
                for (int letraChute = 0; letraChute < chute.Length; letraChute++)
                {
                    Console.Write("< ");
                    if (chute[letraChute] == palavraAleatoria[letraChute])
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                    else if (palavraAleatoria.Contains(chute))
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.BackgroundColor = ConsoleColor.DarkRed;

                    Console.Write(letraChute);
                    Console.ResetColor();
                }        

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

        static bool DesejaContinuar()
        {
            Console.Write("Deseja continuar? (S/N): ");
            string? opcaoContinuar = Console.ReadLine();

            if (opcaoContinuar?.ToUpper() != "S")
                return false;
            return true;
        }
    }
}
