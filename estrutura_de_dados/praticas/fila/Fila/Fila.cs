using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila
{
    internal class Fila
    {
        private int[] vetor_fila;
        private int inicio, fim;

        public Fila(int item)
        {
            vetor_fila = new int[item];
            inicio = fim = 0;
        }
    }
}
