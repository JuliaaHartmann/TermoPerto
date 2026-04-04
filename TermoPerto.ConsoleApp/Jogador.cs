class Jogador
{
    public static bool VerificarPalavra(string chute, int tentativa)
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

    public static bool AcertouPalavra(string chute, string palavraAleatoria)
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

    public static void ClassificarLetra(string chute, string palavraAleatoria, int tentativa)
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
}