using System;

public class Exercicio05
{

    public int MDC(int a, int b)
    {
        //Aqui eu coloco o calculo e o parametro a ser utilizado passando valor
        int r = 0;
        // Repetição até que b seja igual a 0 
        while (b != 0)
        {
            r = a % b;
            a = b;
            b = r;
          }
        //Retorno o MDC pela variávl a
        return a;
    }


    public void Pedir()
    {
        //Aqui eu vou colocar a entrada e chamar o método
        int n1, n2;
        //Recebo os dois valores
        Console.WriteLine("Digite os valores: ");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        //Aqui eu chamo o método após receber
        Console.WriteLine("O MDC é: " + MDC(n1, n2));
    }
}
