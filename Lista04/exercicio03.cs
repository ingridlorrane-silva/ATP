using System;
using System.Security.Cryptography.X509Certificates;

public class Exercicio03
{

    public void Ordem(ref int a, ref int b, ref int c)
    {
        //Aqui eu coloco o calculo e o parametro a ser utilizado passando os valores modificados 
        //vejo se a é maior que b
        if (a < b)
        {
            a = b;
        }
        //Vejo se c é maior que b
        if (c > b)
        {
            b = c;
        }
        //vejo se a é realmente o maior número
        if (a < c)
        {
            a = c;
        }
    }
        public void Pedir()
        {
            //Aqui eu vou colocar a entrada e chamar o metodo
            int n, n1, n2, n3;
            Console.WriteLine("Digite o número de conjuntos:");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Digite os números:");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                //Aqui eu chamo o metodo
                Ordem(ref n1, ref n2, ref n3);
                //Saio em ordem crescente
                Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n3, n2, n1);
            }
        }
}