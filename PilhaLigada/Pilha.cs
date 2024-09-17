using System;

namespace PilhaLigada
{

    internal class Pilha
    {
        Noh topo = null;
        int quantidade = 0;

        public int Quantidade()
        {
            get {return quantidade;}
        }

        public void Empilhar(string Valor)
        {
            Noh nn = new Noh();

            nn.Valor = Valor; //set
            nn.Anterior = topo;

            topo = nn;
            quantidade++;
        }
        public Desempilhar()
        {
            if(Quantidade() > 0)
            {
                topo = topo.Anterior;
                quantidade--;
            }
            else
            {
                System.Console.WriteLine("Pilha Vazia.");
            }
        }

        public void Imprimir()
        {
            Noh auxTopo = topo;
            
            for (int i = Quantidade; i > 0; i--)
            {
                System.Console.WriteLine(auxTopo.Valor);
                auxTopo = auxTopo.Anterior;
            }
        }

    }
}