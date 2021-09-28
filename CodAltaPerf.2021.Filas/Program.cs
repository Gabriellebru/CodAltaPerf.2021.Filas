using CodAltaPerf._2021.Filas.Entidades;
using CodAltaPerf._2021.Filas.Util;
using System;

namespace CodAltaPerf._2021.Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            //campo de variaveis
            bool ManterAppAberto = true;
            int MenuUsuarioOption;

            FilaEstaticaInteiros FilaNormal = new FilaEstaticaInteiros();
            FilaEstaticaInteiros FilaPreferencial = new FilaEstaticaInteiros();


            //codigo da aplicação
            while (ManterAppAberto)
            {
                Uteis.MenuUsuario();
                MenuUsuarioOption = Uteis.PegaOpçãoDigitada();

                switch (MenuUsuarioOption)
                {
                    case 1:
                        //usuario caixa
                        bool ManterMenuCaixaAberto = true;
                        int MenuCaixaOption;
                        int chamada;

                        while (ManterMenuCaixaAberto)
                        {
                            Uteis.MenuCaixa();
                            MenuCaixaOption = Uteis.PegaOpçãoDigitada();

                            switch (MenuCaixaOption)
                            {
                                case 1:
                                    // caixa comum
                                    if(FilaNormal.Tamanho() > 0)
                                    {
                                        Uteis.Chamada(1, FilaNormal.Tamanho());
                                        FilaNormal.Desenfilera();
                                    }
                                    else
                                    {
                                        Uteis.ErroChamada(1);
                                    }
                                    break;
                                case 2:
                                    // caixa prioritario
                                    if (FilaPreferencial.Tamanho() > 0)
                                    {
                                        Uteis.Chamada(2, FilaPreferencial.Tamanho());
                                        FilaPreferencial.Desenfilera();
                                    }
                                    else
                                    {
                                        Uteis.ErroChamada(2);
                                    }
                                    break;
                                case 0:
                                    ManterMenuCaixaAberto = false;
                                    break;
                                default:
                                    Uteis.InvalidOptionError();
                                    break;
                            }
                        }

                        break;


                    // READY
                    case 2:
                        bool ManterMenuSenhasAberto = true;
                        int MenuSenhasOption;
                        while (ManterMenuSenhasAberto)
                        {
                            Uteis.MenuSenhas();
                            MenuSenhasOption = Uteis.PegaOpçãoDigitada();

                            switch (MenuSenhasOption)
                            {
                                case 1:
                                    FilaNormal.Enfilera(FilaNormal.Tamanho() + 1);
                                    Uteis.Chamada(1, FilaNormal.Tamanho());
                                    break;
                                case 2:
                                    FilaPreferencial.Enfilera(FilaPreferencial.Tamanho() + 1);
                                    Uteis.Chamada(2, FilaPreferencial.Tamanho());
                                    break;
                                case 0:
                                    ManterMenuSenhasAberto = false;
                                    break;
                                default:
                                    Uteis.InvalidOptionError();
                                    break;
                            }
                        }
                        break;
                    case 0:
                        ManterAppAberto = false;
                        break;
                    default:
                        Uteis.InvalidOptionError();
                        // opção invalida
                        break;
                }
            }
        }
    }
}
