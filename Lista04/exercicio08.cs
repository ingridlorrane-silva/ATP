using System;

class Exercicio08
{
    public static double Calcular(int a)
    {
        //Calculo o valor de s
        double s = 0;
        for (int i = 1; i <= a; i++)
        {
            double numerador = (Math.Pow(i, 2) + 1);
            double denominador = i + 3;
            s += numerador / denominador;
        }
        return s;
    }
    public static  void Pedir()
    {
        //Peço n e chamo o metodo
        int n = 0;
        Console.WriteLine("Digite um número: ");
        n = int.Parse(Console.ReadLine());
        //Já dou a saída com o retorno que for indicado
        Console.WriteLine("O valor de S é: " + Calcular(n));
    }
}
