using System;

namespace PilhaEstatica
{
    class Pilha
    {
        string[] pilha;
        int topo = 0;

        //construtor tem o mesmo nome da classe
        //construtor é executado apenas quando é instanciado a classe
        public Pilha(int Tamanho)
        {
            pilha = new string[Tamanho];
            //Console.WriteLine("Tamanho da pilha: " + Tamanho);
        }
        public void Empilhar(string Valor)
        {
            if (topo < pilha.Length)
            {
                pilha[topo] = Valor; //armazena o valor no vetor
                topo++; //atualiza o vetor para a proxima posição do vetor
            }
            else
            {
                Console.WriteLine("Pilha Cheia");
            }
        }
    }
}