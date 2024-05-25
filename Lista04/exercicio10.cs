using System;

class Exercicio10
{
    public static char Categoria(int a)
    {
        // Aqui eu verifico e retorno qual o conceito dele
        if (a >= 5 && a <= 7)
        {
            return 'F';
        }
        else if (a >= 8 && a <= 10)
        {
            return 'E';
        }
        else if (a >= 11 && a <= 13)
        {
            return 'D';
        }
        else if (a >= 14 && a <= 15) // Corrigido para >= 14
        {
            return 'C';
        }
        else if (a >= 16 && a <= 17)
        {
            return 'B';
        }
        else
        {
            return 'A';
        }
    }

    public static void Pedir()
    {
        int n = 0;
        // Aqui eu peço a idade do nadador
        Console.WriteLine("Digite a idade do nadador: ");
        n = int.Parse(Console.ReadLine());
        if (n >= 5)
        {
            Console.WriteLine("A categoria do nadador é: " + Categoria(n));
        }
        else
        {
            Console.WriteLine("Idade inválida!");
        }
    }
}
