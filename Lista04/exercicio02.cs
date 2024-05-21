using System;

public class Exercicio02
{
    public void Valores(double a, int b, ref double c, ref double d, ref double e)
    {
        d = d + a;
        e = e + b;
        Media(d, e, ref c);
    }

    public void Media(double d, double e, ref double c)
    {
        c = d / e;
    }
    public void Pedir()
    {
        double sal= 0, med= 0, s= 0, f= 0;
        int fil;
        string opcao;
        //garantir que entre pelo menos uma vez
        do
        {
            Console.WriteLine("Digite o valor do salário:");
            sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de filhos:");
            fil = int.Parse(Console.ReadLine());
            //Chamar aqui para calcular a média
            Valores( sal, fil, ref  med, ref  s, ref f);
            //verificar se ele deseja continuar
            Console.WriteLine("Deseja continuar?");
            opcao = Console.ReadLine();
        } while (opcao.ToLower() == "s");
        Console.WriteLine("A média da população é: " + med);
    }
}