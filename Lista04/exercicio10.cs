using System;

class Exercicio10
{
    public char Categoria(int a)
    {
        //Aqui eu verifico e retorno qual o conceito dele
        if (a=5 || a<=7)
        {
            return 'F';
        }
      else if (a=8 || a<=10)
        {
            return 'E';
        }
      else if (a=11 || a<=13)
        {
            return 'D';
        }
      else if (a=13 || a<=15)
        {
            return 'C';
        }
      else if (a=16 || a<=17)
        {
            return 'B';
        }
      else if (a>=18)
        {
            return 'A';
        }
    }
    public void Pedir()
    {
        int n, med;
        //Aqui eu peço a quantidade de alunos e a média
        Console.WriteLine("Digite a idade do nadador: ");
        n = int.Parse(Console.ReadLine());
        if (n > 5)
        {
            Console.WriteLine("A categoria do nadador é: " + Categoria(n));
        }
        else
        {
            Console.WriteLine("Idade inválida!");
        }


    }
}
