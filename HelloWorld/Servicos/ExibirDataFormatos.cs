using System;

namespace HelloWorld.Servicos;
    public class ExibirDataFormatos
    {
        public static void ExibirData()
        {
            // Obtém a data e hora atual
            DateTime dataAtual = DateTime.Now;

            // Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
            Console.WriteLine("Formato completo:");
            Console.WriteLine(dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss"));

            // Apenas a data no formato "01/03/2024"
            Console.WriteLine("\nApenas a data:");
            Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

            // Apenas a hora no formato de 24 horas
            Console.WriteLine("\nApenas a hora (formato 24 horas):");
            Console.WriteLine(dataAtual.ToString("HH:mm:ss"));

            // A data com o mês por extenso
            Console.WriteLine("\nData com o mês por extenso:");
            Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));

            // Aguarda o usuário pressionar Enter para sair
            Console.ReadLine();
        }
    }
    