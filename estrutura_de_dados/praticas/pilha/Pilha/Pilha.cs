using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    internal class Pilha
    {
        //Declarando o vetor e a variável topo
        private int[] vetor_pilha;
        private int topo;

        // Criando o construtor
        public Pilha(int tamanho)
        {
            vetor_pilha = new int[tamanho];
            topo = 0;
        }

        // Método para empilhar
        public void Empilhar(int item)
        {
            vetor_pilha[topo] = item;
            topo++;
        }

        //Método para desempilhar
        public int Desempilhar()
        {
            topo--;
            return (vetor_pilha[topo]);
        }

        //Método para avisar preenchimento total da pilha
        public bool Cheia()
        {
            return (topo == vetor_pilha.Length);
        }

        //Método para avisar que a pilha está vazia
        public bool Vazia()
        {
            return (topo == 0);
        }
    }
}
