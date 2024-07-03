using System;

namespace HelloWorld.Servicos;
public class OperacoesMatematicas
{
    public static void Soma()
    {
        try
        {
            Console.WriteLine("Olá, escolha dois números para começar!");

            Console.WriteLine("Informe o primeiro número");
            string entrada1 = Console.ReadLine();
            double primeiroNumero = Convert.ToDouble(entrada1);

            Console.WriteLine("Informe o segundo número");
            string entrada2 = Console.ReadLine();
            double segundoNumero = Convert.ToDouble(entrada2);

            double resultado = primeiroNumero + segundoNumero;

            Console.WriteLine($"O resultado da soma é: {resultado} !");

            Program.Menu();

        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");

            Program.Menu();
        }
    }

    public static void Subtracao()
    {
        try
        {
            Console.WriteLine("Olá, escolha dois números para começar!");

            Console.WriteLine("Informe o primeiro número");
            string entrada1 = Console.ReadLine();
            double primeiroNumero = Convert.ToDouble(entrada1);

            Console.WriteLine("Informe o segundo número");
            string entrada2 = Console.ReadLine();
            double segundoNumero = Convert.ToDouble(entrada2);

            double resultado = primeiroNumero - segundoNumero;

            Console.WriteLine($"O resultado da subtração é: {resultado}!");

            Program.Menu();

        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");

            Program.Menu();
        }
    }
    public static void Multiplicacao()
    {
        try
        {
            Console.WriteLine("Olá, escolha dois números para começar!");

            Console.WriteLine("Informe o primeiro número");
            string entrada1 = Console.ReadLine();
            double primeiroNumero = Convert.ToDouble(entrada1);

            Console.WriteLine("Informe o segundo número");
            string entrada2 = Console.ReadLine();
            double segundoNumero = Convert.ToDouble(entrada2);

            double resultado = primeiroNumero * segundoNumero;

            Console.WriteLine($"O resultado da multiplicação é: {resultado}!");

            Program.Menu();

        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");

            Program.Menu();
        }
    }
    public static void Divisao()
    {
        try
        {
            Console.WriteLine("Olá, escolha dois números para começar!");

            Console.WriteLine("Informe o primeiro número");
            string entrada1 = Console.ReadLine();
            double primeiroNumero = Convert.ToDouble(entrada1);

            Console.WriteLine("Informe o segundo número");
            string entrada2 = Console.ReadLine();
            double segundoNumero = Convert.ToDouble(entrada2);

            if (segundoNumero == 0)
                Console.WriteLine("Número inválido, digite novamente!");
            else
            {
                double resultado = primeiroNumero / segundoNumero;
                Console.WriteLine($"O resultado da divisão é: {resultado}!");
            }

            Program.Menu();

        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");

            Program.Menu();
        }
    }
    public static void  Media()
    {
        try
        {
            Console.WriteLine("Olá, escolha dois números para começar!");

            Console.WriteLine("Informe o primeiro número");
            string entrada1 = Console.ReadLine();
            double primeiroNumero = Convert.ToDouble(entrada1);

            Console.WriteLine("Informe o segundo número");
            string entrada2 = Console.ReadLine();
            double segundoNumero = Convert.ToDouble(entrada2);

            double resultado = (primeiroNumero + segundoNumero) / 2;

            Console.WriteLine($"O resultado da média dos dois números é: {resultado}!");

            Program.Menu();

        }
        
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Certifique-se de inserir números válidos.");

            Program.Menu();
        }
    }
}

