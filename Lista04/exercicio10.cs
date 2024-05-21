using System;

class Exercicio10
{
    public char Categoria(int a)
    {
        //Aqui eu verifico e retorno qual o conceito dele
        if ()
        {
            return 'F';
        }
        else if ()
        {
            return 'E';
        }
        else if ()
        {
            return 'D';
        }
        else if ()
        {
            return 'C';
        }
        else if ()
        {
            return 'B';
        }
        else if ()
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
