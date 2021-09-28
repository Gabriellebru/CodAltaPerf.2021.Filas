using System;
using System.Collections.Generic;
using System.Text;

namespace CodAltaPerf._2021.Filas.Interfaces
{
    public interface IFila<T>
    {
        public void Enfilera(T obj);

        public T Desenfilera();

        public IEnumerable<T> Imprime();

        public int Tamanho();

        public bool EstaVazia();



    }
}
