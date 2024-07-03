
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld.Servicos;
public class Funcoes
{
    public static void NomeDoUsuario()
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem vindo(a)!");

        Program.Menu();
    }
    public static void ConcatenarNome()
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();

        Console.WriteLine("Qual é o seu sobrenome?");
        string sobrenome = Console.ReadLine();

        // Concatena e exibe a saudação com o nome e sobrenome.
        Console.WriteLine("Olá, " + nome + " " + sobrenome + "!");

        Program.Menu();
    }
}

