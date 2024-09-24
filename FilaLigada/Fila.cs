using System;

namespace FilaLigada
{
    internal class Fila
    {
        Noh ultimo, primeiro = null;

        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public void Enfileirar( string Valor)
        {
            Noh nn = new Noh();

            nn.Valor = Valor;
            nn.Proximo = ultimo;

            if(ultimo == null)
            {
                primeiro = ultimo = nn;
            }
            else
            {
                ultimo.Proximo = nn;
                ultimo = nn;
            }
            
            quantidade++;
        }

        public void Imprimir()
        {
            Noh auxfim = primeiro;

            for (int i = primeiro; i < ultimo; i++)
            {
                System.Console.WriteLine(auxfim.Valor);
                auxfim = auxfim.Proximo;
            }
        }
    }
}