using HelloWorld.Servicos;
using System;

namespace HelloWorld
{
   public class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        //MENU para chamar os Exercicios
       public static void Menu()
        {
            Console.WriteLine("Bem vindo! :) Selecione uma das opções abaixo!");
            Console.WriteLine("(0) - FINALIZAR");
            Console.WriteLine("(01) - Chamar nome de usuário");
            Console.WriteLine("(02) - Chamar nome e sobrenome");
            Console.WriteLine("(03) - Soma");
            Console.WriteLine("(04) - Subtração");
            Console.WriteLine("(05) - Multiplicação");
            Console.WriteLine("(06) - Divisão");
            Console.WriteLine("(07) - Média");
            Console.WriteLine("(08) - Contador de caracteres");
            Console.WriteLine("(09) - Validador de placas de trânsito");
            Console.WriteLine("(10) - Exibidor de data atual em diferentes formatos");


            
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Funcoes.NomeDoUsuario(); break;
                case 2: Funcoes.ConcatenarNome(); break;
                case 3: OperacoesMatematicas.Soma(); break;
                case 4: OperacoesMatematicas.Subtracao(); break;
                case 5: OperacoesMatematicas.Multiplicacao(); break;
                case 6: OperacoesMatematicas.Divisao(); break;  
                case 7: OperacoesMatematicas.Media(); break;
                case 8: Contador.Caracteres(); break;
                case 9: ValidacaoPlacaVeiculo.ValidarPlaca(); break;
                case 10: ExibirDataFormatos.ExibirData(); break;
            }
                
                
                
                
                
                
                
            
        }


    }
}