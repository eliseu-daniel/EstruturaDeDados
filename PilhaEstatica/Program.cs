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
            //agenda.Empilhar("Falha"); // vai mostrar o else do metodo Empilhar

            Console.ReadKey(); // faz uma parada no processamento
        }
    }
}