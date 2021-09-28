using System;
using System.Collections.Generic;
using System.Text;

namespace CodAltaPerf._2021.Filas.Util
{
    public static class Uteis
    {
        public static void MenuUsuario()
        {
            Console.Clear();
            Console.WriteLine("Escolha seu usuário\n");
            Console.WriteLine("1- Usuario caixa");
            Console.WriteLine("2- Usuário cliente");
            Console.WriteLine("0- Sair\n");
            Console.Write("Digite sua escolha: ");
        }
        public static void MenuCaixa()
        {
            Console.Clear();
            Console.WriteLine("Escolha seu caixa\n");
            Console.WriteLine("1- Caixa comum");
            Console.WriteLine("2- Caixa prioritário");
            Console.WriteLine("0- Voltar ao menu anterior\n");
            Console.Write("Digite sua escolha: ");
        }

        public static void MenuSenhas()
        {
            Console.Clear();
            Console.WriteLine("Retire sua senha\n");
            Console.WriteLine("1- Senha comum");
            Console.WriteLine("2- Senha prioritária");
            Console.WriteLine("0- Voltar ao menu anterior\n");
            Console.Write("Digite sua escolha: ");
        }

        public static void InvalidOptionError()
        {
            Console.WriteLine("Opção inválida, tente novamente.\n");
            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static int PegaOpçãoDigitada()
        {
            int option;
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                option = -1;
            }
            return option;
        } 

        public static void Chamada(int tipo, int posicao)
        {
            switch (tipo)
            {
                case 1: // normal
                    Console.WriteLine($"CXN-{posicao.ToString("000")}");
                    break;
                case 2: // preferencial
                    Console.WriteLine($"CXP-{posicao.ToString("000")}");
                    break;
            }
            Console.ReadLine();
        }

        public static void ErroChamada(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    Console.WriteLine("Fila Normal está vazia.");
                    break;
                case 2:
                    Console.WriteLine("Fila Preferencial está vazia.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
