using System;

public class Exercicio01
{

    public void Media(ref int a, int b, int c, char d)
    {
        //Aqui eu coloco o calculo e o parametro a ser utilizado passando valor 
        switch (d)
        {
            case 'A':
                a = (a + b + c) / 3;
                break;
            case 'P':
                a = (a * 5 + b * 3 + c * 2) / 10;
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;

        }
    }
    public void Pedir()
    {
        //Aqui eu vou colocar a entrada e chamar o método
        int n, n1, n2, n3;
        char letra;
        Console.WriteLine("Digite o número de aluno: ");
        n = int.Parse(Console.ReadLine().ToUpper());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite a sua nota: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a letra correspondente: ");
            letra = char.Parse(Console.ReadLine());
            //Aqui eu chamo o método após receber
            Media(ref n1, n2, n3, letra);
            Console.WriteLine("A média é: {0:00}", n1);
        }
    }
}