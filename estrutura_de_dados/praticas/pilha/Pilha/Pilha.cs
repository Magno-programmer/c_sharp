using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    internal class Pilha
    {
        private int[] vetor_pilha;
        private int topo;

        public Pilha(int tamanho)
        {
            vetor_pilha = new int[tamanho];
            topo = 0;
        }

        public void Empilhar(int item)
        {
            vetor_pilha[topo] = item;
            topo++;
        }

        public int Desempilhar()
        {
            topo--;
            return topo;
        }

        public bool Cheia()
        {
            return (topo == vetor_pilha.Length);
        }

        public bool Vazia()
        {
            return (topo == 0);
        }
    }
}
