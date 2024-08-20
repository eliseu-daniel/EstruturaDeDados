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

        //Inserir na posição escolhida
        public void Inserir(string Valor, int Posicao)
        {
            if(ultimo < lista.Length)
            {
                for (int i = 0; i < (ultimo - (Posicao-1)); i++)
                {
                    lista[ultimo - i] = lista[(ultimo -1) - i];
                }
                lista[Posicao - 1] = Valor;
                ultimo++;
            }
            else
            {
                Console.WriteLine("Lista Cheia");
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(i + " - " + lista[i]);
            }
        }
    }
}