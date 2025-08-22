﻿﻿using TRILHA_NET_POO_DESAFIO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone celular = null;

        while (celular == null)
        {
            Console.WriteLine("### Escolha seu celular ###");
            Console.WriteLine("1 - Nokia G50 (64GB)");
            Console.WriteLine("2 - iPhone 15 (256GB)");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    celular = new Nokia("119999999", "Nokia G50", "111111111111111", 64);
                    Console.WriteLine("\nVocê escolheu: Nokia G50\n");
                    break;
                case "2":
                    celular = new Iphone("118888888", "iPhone 15", "222222222222222", 256);
                    Console.WriteLine("\nVocê escolheu: iPhone 15\n");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.\n");
                    break;
            }
        }

        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n### MENU DE OPERAÇÕES ###");
            Console.WriteLine("1 - Exibir informações do celular");
            Console.WriteLine("2 - Ligar");
            Console.WriteLine("3 - Receber ligação");
            Console.WriteLine("4 - Instalar aplicativo");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    celular.ExibirInfo();
                    break;
                case "2":
                    celular.Ligar();
                    break;
                case "3":
                    celular.ReceberLigacao();
                    break;
                case "4":
                    Console.Write("Digite o nome do aplicativo: ");
                    string app = Console.ReadLine();
                    celular.InstalarAplicativo(app);
                    break;
                case "0":
                    executando = false;
                    Console.WriteLine("Saindo... Até mais!");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
