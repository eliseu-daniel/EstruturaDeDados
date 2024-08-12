using System;

namespace PilhaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tamanho;
            Console.WriteLine("Informe o tamanho da pilha");
            Tamanho = Convert.ToInt32(Console.ReadLine());

            Pilha agenda = new Pilha(Tamanho);

            Console.WriteLine("Trabalhando com Pilha Estatica");

            agenda.Empilhar("A");
            agenda.Empilhar("B");
            agenda.Empilhar("C");
            agenda.Empilhar("D");
            agenda.Empilhar("E");
            agenda.Empilhar("Falha"); // vai mostrar o else do metodo Empilhar

            System.Console.WriteLine();
            System.Console.WriteLine("IMPRIMINDO A PILHA");
            agenda.Imprimir();

            System.Console.WriteLine();
            System.Console.WriteLine("DESEMPILHAR");
            agenda.Desempilhar();
            agenda.Desempilhar();
            agenda.Desempilhar();
            agenda.Desempilhar();
            agenda.Desempilhar();

            agenda.Desempilhar(); // erro

            agenda.Empilhar("A");
            System.Console.WriteLine("Deu tudo certo");

            Console.ReadKey(); // faz uma parada no processamento
        }
    }
}