using System;

class Calcular {
  public static void Main (string[] args) {

    Calculadora Calc = new Calculadora(num1 + num2, num1 - num2, num1 * num2, num1 / num2);

    double n1, n2;

    int opcao;

    Console.WriteLine ("Digite sua opçao: 1 - ADIÇÃO 2 - SUBTRAÇÃO 3 - MULTIPLICAÇÃO 4 - DIVISÃO ");

    switch(opcao){
      case 1:
        while(opcao == 1){

          Console.WriteLine("Digite o 1º número: ");
          n1 = Console.ReadLine();
          Console.WriteLine("Digite o 2º número: ");
          n2 = Console.ReadLine;

          Calc.Soma = n1 + n2; 
          Console.WriteLine("A soma é igual a {0}", Soma);

          Console.WriteLine("Gostaria de realizar outro cálculo? ");
          Console.WriteLine("Digite sua opçao: 1 - ADIÇÃO 2 - SUBTRAÇÃO 3 - MULTIPLICAÇÃO 4 - DIVISÃO ");

          opcao = Console.ReadLine;

        }

          

      break;

      case 2:

        while(opcao == 2){

          Console.WriteLine("Digite o 1º número: ");
          n1 = Console.ReadLine();
          Console.WriteLine("Digite o 2º número: ");
          n2 = Console.ReadLine;

          Calc.Subtracao = n1 - n2; 
          Console.WriteLine("A substracao é igual a {0}", Subtracao);

          Console.WriteLine("Gostaria de realizar outro cálculo? ");
          Console.WriteLine("Digite sua opçao: 1 - ADIÇÃO 2 - SUBTRAÇÃO 3 - MULTIPLICAÇÃO 4 - DIVISÃO ");

          opcao = Console.ReadLine;
        }

          
        
      break;

      case 3: 

        while(opcao == 3){

          Console.WriteLine("Digite o 1º número: ");
          n1 = Console.ReadLine();
          Console.WriteLine("Digite o 2º número: ");
          n2 = Console.ReadLine;

          Calc.Subtracao = n1 * n2; 
          Console.WriteLine("A substracao é igual a {0}", Multiplicacao);

          Console.WriteLine("Gostaria de realizar outro cálculo? ");
          Console.WriteLine("Digite sua opçao: 1 - ADIÇÃO 2 - SUBTRAÇÃO 3 - MULTIPLICAÇÃO 4 - DIVISÃO ");

          opcao = Console.ReadLine;
        }

      break;

      case 4:
        while(opcao == 4){
          Console.WriteLine("Digite o 1º número: ");
          n1 = Console.ReadLine();
          Console.WriteLine("Digite o 2º número: ");
          n2 = Console.ReadLine;

          Calc.Subtracao = n1 / n2; 
          Console.WriteLine("A substracao é igual a {0}", Divisao);

          Console.WriteLine("Gostaria de realizar outro cálculo? ");
          Console.WriteLine("Digite sua opçao: 1 - ADIÇÃO 2 - SUBTRAÇÃO 3 - MULTIPLICAÇÃO 4 - DIVISÃO ");

          opcao = Console.ReadLine;
        } 

      break;

      default:
        Console.WriteLine("Digite uma opcao válida: ");

        Console.WriteLine("Gostaria de realizar outro cálculo? ");
        Console.WriteLine("Digite sua opçao: 1 - ADIÇÃO 2 - SUBTRAÇÃO 3 - MULTIPLICAÇÃO 4 - DIVISÃO ");

        opcao = Console.ReadLine;   

        break;
    }


  }
}