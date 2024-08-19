using System;

namespace ListaEstatica
{
    class Lista
    {
        string[] lista;
        int ultimo;

        //construtor
        public Lista(int Tamanho) //Tamanho do vetor lista
        {
            lista = new string[Tamanho];
            ultimo = 0;
        }

        //Inserir na ultima posição
        public void Inserir(string Valor)
        {
            if (ultimo < lista.Length)
            {
                lista[ultimo] = Valor;
                ultimo++;
            }
            else
            {
                Console.WriteLine("Lista Cheia!!");
            }
        }

        public void Inserir(string Valor, int Posicao)
        {
            
        }
    }
}