using System;
class Exercicio07
{
    public static void Verificar(int a)
    {
        //Aqui eu verifico e retorno qual o conceito dele
        if (a <= 39)
        {
            Console.WriteLine("O conceito é: F");
        }
        else if (a<=59)
        {
            Console.WriteLine("O conceito é: E");
        }
        else if(a<=69)
        {
            Console.WriteLine("O conceito é: D");   
        }
        else if (a <= 79)
        {
            Console.WriteLine("O conceito é: C");
        }
        else if (a <= 89)
        {
            Console.WriteLine("O conceito é: B");
        }
        else if (a >= 90)
        {
            Console.WriteLine("O conceiro é: A");
        }
        else
        {
            Console.WriteLine("A nota é inválida");
        }
    }
    public static void Pedir()
    {
        int n, med;
        //Aqui eu peço a quantidade de alunos e a média
        Console.WriteLine("Digite o número de alunos alunos que irá verificar a média: ");
        n = int.Parse(Console.ReadLine());
        for (int i =0; i<n; i++)
        {
            Console.WriteLine("Digite a média: ");
            med = int.Parse(Console.ReadLine());
            //Chamo o metodo
            Verificar(med);
        }

    }
}
