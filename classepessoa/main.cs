using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa Fulano = new Pessoa ("Deivid", 31,69.5,181.5);
    Console.WriteLine("Em seu cadastro consta os dados: ");
    Console.WriteLine("Seu nome é:{0} ", Fulano.nome);
    Console.WriteLine("Sua idade é:{0} ", Fulano.idade);
    Console.WriteLine("Seu peso é: {0}", Fulano.peso);
    Console.WriteLine("Sua altura é:{0} ", Fulano.altura);

    Console.WriteLine("-------------------------------------");

    Console.WriteLine("Confirme seu nome: ");
    Fulano.nome = Console.ReadLine();
    Console.WriteLine("Confirme sua idade: ");
    Fulano.idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Confirme seu peso: ");
    Fulano.peso = double.Parse(Console.ReadLine());
    Console.WriteLine("Confirme sua altura: ");
    Fulano.altura = double.Parse(Console.ReadLine());

    Console.WriteLine("--------------------------------------");
    
  }
}