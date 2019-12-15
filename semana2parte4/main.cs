using System;
//Exercício 2: Fazer um programa em C# para ler notas de 10 alunos. Ler 2 notas para cada um deles e calcular a média aritmética das notas. Contar quantos alunos estão com a média acima de 5.0.

//Obs1.: Se nenhum aluno tirou nota acima de 5.0, imprimir mensagem: Não há nenhum aluno com nota acima de 5.
//Obs2.: Não utilizar vetores.
class MainClass {
  public static void Main (string[] args) {
    int n1,n2,media = 0;
    int cont = 0;
    int aluno =10;

    for(int i=0; i<aluno; i++){
      Console.WriteLine("Nota 1 : ");
      n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Nota 2  : ");
      n2 = int.Parse(Console.ReadLine());
      media = ((n1+n2)/2);

      if(media>=5){
        cont= cont+1;
  }
    }
    Console.WriteLine("A quantidade de alunos acima da media é {0}",cont);
  }
}
