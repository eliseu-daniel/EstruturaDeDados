using System;

namespace ListaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista Estatica");
            Console.WriteLine();
            Console.WriteLine();

            int Tamanho;
            Console.WriteLine("Qual Tamanho da Lista?");
            Tamanho = Convert.ToInt32(Console.ReadLine());

            Lista Agenda = new Lista(Tamanho);

            Agenda.Inserir("A");
            Agenda.Inserir("C");

            System.Console.WriteLine("Impressao do A e C");
            Agenda.Imprimir();

            System.Console.WriteLine("Inserindo a Letra B na 2a. posição");
            Agenda.Inserir("B", 2);

            System.Console.WriteLine("Impressao do A, B e C");
            Agenda.Imprimir();

            System.Console.WriteLine("Excluindo o C");
            Agenda.Excluir();

            System.Console.WriteLine("Impressão do A e B");
            Agenda.Imprimir();

            System.Console.WriteLine("Excluindo o A");
            Agenda.Excluir(1);

            System.Console.WriteLine("Impressao do B");
            Agenda.Imprimir();
            
            Console.ReadKey();
        }
    }
}