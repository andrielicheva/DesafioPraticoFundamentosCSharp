using System;

namespace HelloWorld.Servicos;
public class ValidacaoPlacaVeiculo
{
    public static bool ValidarPlaca(string placa)
    {
        if (placa.Length != 7)
            return false;

        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
                return false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(placa[i]))
                return false;
        }

        return true;
    }

    public static void ValidarPlaca()
    {
        Console.Write("Digite a placa do veículo: ");
        string placaDigitada = Console.ReadLine();

        if (ValidacaoPlacaVeiculo.ValidarPlaca(placaDigitada))
            Console.WriteLine("Verdadeiro");
        else
            Console.WriteLine("Falso");
    }
}