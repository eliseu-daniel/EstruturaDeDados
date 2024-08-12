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

        public void Desempilhar()
        {
            if (topo > 0)
            {
                topo--;
            }
            else
            {
                System.Console.WriteLine("Pilha vazia!");
            }
        }

        public void Imprimir()
        {
            if (topo > 0)
            {
                for (int i = (topo - 1); i >= 0; i--)
                {
                    System.Console.WriteLine(pilha[i]);
                }
            }
            else
            {
                System.Console.WriteLine("Pilha vazia!");
            }
        }
    }
}