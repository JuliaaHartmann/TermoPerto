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
                Jogo.ExibirCabecalho();

                string palavraAleatoria = Jogo.GerarPalavraAleatoria();

                int tentativasMaximas = 5;
                int tentativa;

                for (tentativa = tentativasMaximas; tentativa >= 1; tentativa--)
                {
                    Console.WriteLine();
                    Console.Write("> ");
                    string? chute = Console.ReadLine()?.ToUpper();

                    if (!Jogador.VerificarPalavra(chute!, tentativa)) continue;

                    if (Jogador.AcertouPalavra(chute!, palavraAleatoria)) break;

                    Jogador.ClassificarLetra(chute!, palavraAleatoria, tentativa);
                }

                if (tentativa == 0)
                    Console.WriteLine();
                    Console.WriteLine("\nVocê atingiu o número máximo de tentativas...");
                    Console.WriteLine("Aperte ENTER para continuar...");
                    Console.ReadLine();

                if (!Jogo.DesejaContinuar())
                    break;
            }
        }        
    }
}
