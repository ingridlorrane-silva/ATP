using System;

public class Exercicio03
{

    public static void Ordem(ref int a, ref int b, ref int c)
    {
        //Aqui eu coloco o calculo e o parametro a ser utilizado passando os valores modificados 
        //vejo se a é maior que b
        int aux = 0;
        if (a < b)
        {
            aux = a;
            a = b;
            b = aux;
        }
        //Vejo se c é maior que b
        if (c > b)
        {
            aux = b;
            b = c;
            c = aux;
        }
        //vejo se a é realmente o maior número
        if (a < b)
        {
            aux = a;
            a = b;
            b = aux;
        }
    }
        public static void Pedir()
        {
            //Aqui eu vou colocar a entrada e chamar o metodo
            int n1, n2, n3;
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
