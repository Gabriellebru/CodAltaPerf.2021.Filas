using CodAltaPerf._2021.Filas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodAltaPerf._2021.Filas.Entidades
{
    public class FilaEstaticaInteiros : IFila<int>
    {
        public int Inicio { get; private set; }
        public int Final { get; private set; }

        public int TamanhoMaximo { get; private set; }

        private int[] VetorElementos { get; set; }


        public FilaEstaticaInteiros()
        {
            TamanhoMaximo = 100;
            VetorElementos = new int[TamanhoMaximo];
            Inicio = Final = 0;
        }


        public FilaEstaticaInteiros(int tamanhoMaximo)
        {
            TamanhoMaximo = tamanhoMaximo;
            VetorElementos = new int[tamanhoMaximo];
            Inicio = Final = 0;
        }

        public int Desenfilera()
        {
            if (EstaVazia())
            {
                throw new ArgumentException("Fila Vazia , elemento não removido");
            }
            int retorno = VetorElementos[Inicio];

            for (int i = 0; i < Final - 1; i++)
            {
                VetorElementos[i] = VetorElementos[i + 1];
            }
            VetorElementos[Final] = 0;

            Final--;

            return retorno;
        }

        public void Enfilera(int obj)
        {
            if (EstaCheia())
            {
                throw new ArgumentException("Fila cheia , elemento não inserido");
            }
            VetorElementos[Final] = obj;
            Final++;
        }

        public bool EstaVazia()
        {
            return Inicio == Final;
        }

        public IEnumerable<int> Imprime()
        {
            for (int i = 0; i < Final ; i++)
            {
                yield return VetorElementos[i];
            }
        }

        public int Tamanho()
        {
            return Final;
        }

        public bool EstaCheia()
        {
            return Final == TamanhoMaximo;
        }

        public int[] RetorVetorElementos()
        {
            return VetorElementos;
        }
    }
}
