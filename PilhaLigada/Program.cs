using PilhaLigada;

System.Console.WriteLine("Pilha Ligada");

Pilha agenda = new Pilha();

System.Console.WriteLine(agenda.Quantidade());

System.Console.WriteLine("Inserindo os valores em A ate o E");

agenda.Empilhar("A");
agenda.Empilhar("B");
agenda.Empilhar("C");
agenda.Empilhar("D");
agenda.Empilhar("E");

System.Console.WriteLine("Imprimindo todos os valores da Pilha");
agenda.Imprimir();