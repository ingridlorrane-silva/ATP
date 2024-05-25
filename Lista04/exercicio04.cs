using System;

public class Exercicio04
{

    public static void Triangulo(int a, int b, int c)
    {
        //Aqui eu coloco o calculo e o parametro a ser utilizado passando valor
        //Vejo se é um triangulo
        if (a < b + c && b < a + c && c < a + b)
        {
            //Verifico se todos os lados são iguais
            if (a == b && b == c)
            {
                Console.WriteLine("Triângulo Equilátero");
            }
            //Verifico se pelo menos dois lados são iguais
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("Triângulo Isósceles");
            }
            //Se não atende os demais os lados são diferentes
            else
            {
                Console.WriteLine("Triângulo Escaleno");
            }
        }
        //Aqui escrevo que não é um triangulo
        else
        {
            Console.WriteLine("Não é um triângulo");
        }
        }


    public static void Pedir()
        {
            //Aqui eu vou colocar a entrada e chamar o método
            int n, n1, n2, n3;
            Console.WriteLine("Digite os lados do triângulo: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            //Aqui eu chamo o método após receber
            Triangulo(n1, n2, n3);
        }
    }
