using System.Security.Cryptography;

public static class Jogo
    {
        public static void ExibirCabecalho()
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

    public static string GerarPalavraAleatoria()
    {
        string[] palavras = [
           "AMIGO","VERDE","NUVEM","TIGRE","VENTO","CHUVA","FOLHA","PRAIA","SABOR", "FALAR",
           "ROSTO","LENTE","CANTO","BRISA","FERRO","PEQUI","NOBRE","TOCAR","FIRME","CASAL"
        ];

        int indiceAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[indiceAleatorio];

        return palavraAleatoria;
    }

    public static bool DesejaContinuar()
    {
        Console.WriteLine("Deseja jogar novamente? (S/N): ");
        string? opcaoContinuar = Console.ReadLine();

        if (opcaoContinuar?.ToUpper() != "S")
            return false;
        return true;
    }
}