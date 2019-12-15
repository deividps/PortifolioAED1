/* Crie uma classe que modele uma pessoa:

Atributos: nome, idade, peso e altura
Métodos: Envelhercer, engordar, emagrecer, crescer. Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.*/

class Pessoa 
{
  public string nome;
  public int idade;
  public double peso;
  public double altura;

  public void setEnvelhecer ()
  {
    if (idade <= 21)
    {
      altura = altura*0.5;
    }

    idade +=1;
  }

  public double getEnvelhecer ()
  {
    return idade;
  }

  public void setEngordar(double e )
  {
    peso = peso + e;
  }

  public double getEngordar ()
  {
    return peso;
  }

  public void setEmagrecer(double em)
  {
    peso = peso - em;
  }

  public double getEmagrecer()
  {
    return peso;
  }

  public Pessoa (string n, int age, double w, double h)
  {
    nome = n;
    idade = age;
    peso = w;
    altura = h;
  }
}