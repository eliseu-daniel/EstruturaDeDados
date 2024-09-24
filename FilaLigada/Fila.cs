using System;

namespace FilaLigada
{
    internal class Fila
    {
        Noh primeiro = null;
        Noh ultimo = null;
        int quantidade = 0;

        public int Quantidade
        {
            get { return quantidade; }
        }

        public void Enfileirar( string Valor)
        {
            // nn -> NovoNoh
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

        public void Desenfileirar()
        {
            if (Quantidade > 0)
            {
                primeiro = primeiro.Proximo;
                quantidade--;
            }else
            {
                System.Console.WriteLine("Fila Vazia");
            }
        }
        public void Imprimir()
        {
            Noh auxfim = primeiro;

            for (int i = 0; i < Quantidade; i++)
            {
                System.Console.WriteLine(auxfim.Valor);
                auxfim = auxfim.Proximo;
            }
        }
    }
}