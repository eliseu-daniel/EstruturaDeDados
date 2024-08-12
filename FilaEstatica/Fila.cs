using System;

namespace FilaEstatica
{
    class Fila
    {
        string[] fila;
        int primeiro, ultimo;

        public Fila(int Tamanho)
        {
            fila = new string[Tamanho];
            primeiro = 0;
            ultimo = 0;
        }

        public void Enfileirar(string Valor)
        {
            if (ultimo < fila.Length)
            {
                fila[ultimo] = Valor;
                ultimo++;
            }
            else
            {
                System.Console.WriteLine("Fila Cheia!");
            }
        }

        public void Desenfileirar()
        {
            if (primeiro < ultimo)
            {
                primeiro++;
            }
            else
            {
                System.Console.WriteLine("Fila Vazia");
            }
        }

        public void Imprimir()
        {
            if (primeiro < ultimo)
            {
                for (int i = primeiro; i < ultimo; i++)
                {
                    System.Console.WriteLine(fila[i]);
                }
            }
            else
            {
                System.Console.WriteLine("Fila Vazia");
            }
        }
    }
}