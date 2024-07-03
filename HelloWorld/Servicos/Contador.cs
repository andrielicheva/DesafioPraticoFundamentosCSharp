using System;

namespace HelloWorld.Servicos;
public class Contador
{
    public static void Caracteres()
    {
        Console.WriteLine("Digite as palavras cujos caracteres você deseja contar:");
        string resposta = Console.ReadLine();

        // Divide a string em palavras string[] palavras = resposta.Split(new char[] { ' ' },
        // e remove os espaços (StringSplitOptions.RemoveEmptyEntries)

        string[] palavras = resposta.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int totalCaracteres = 0;
        foreach (string palavra in palavras)
        {
            totalCaracteres += palavra.Length;
        }

            Console.WriteLine($"O total dos caracteres é {totalCaracteres}");

            Program.Menu();
    }
   
}

