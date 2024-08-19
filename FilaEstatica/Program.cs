using System;

namespace FilaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Trabalhando com Fila Estatica");
            System.Console.WriteLine();

            Fila Impressao = new Fila(5);

            Impressao.Enfileirar("A");
            Impressao.Enfileirar("B");
            Impressao.Enfileirar("C");
            Impressao.Enfileirar("D");
            Impressao.Enfileirar("E");

            Impressao.Imprimir();

            Impressao.Desenfileirar();

            Console.ReadKey();
        }
    }
}