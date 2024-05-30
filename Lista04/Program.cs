//principal
using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            int escolha;

            Console.WriteLine("Informe:");
            Console.WriteLine("1) Para executar o exercício 01.");
            Console.WriteLine("2) Para executar o exercício 02.");
            Console.WriteLine("3) Para executar o exercício 03.");
            Console.WriteLine("4) Para executar o exercício 04.");
            Console.WriteLine("5) Para executar o exercício 05.");
            Console.WriteLine("6) Para executar o exercício 06.");
            Console.WriteLine("7) Para executar o exercício 07.");
            Console.WriteLine("8) Para executar o exercício 08.");
            Console.WriteLine("9) Para executar o exercício 09.");
            Console.WriteLine("10) Para executar o exercício 10.");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio01 exercicio01 = new Exercicio01();
                    exercicio01.Pedir();
                    break;
                case 2:
                    Exercicio02 exercicio02 = new Exercicio02();
                    exercicio02.Pedir();
                    break;
                case 3:
                    Exercicio03 exercicio03 = new Exercicio03();
                    exercicio03.Pedir();
                    break;
                case 4:
                    Exercicio04 exercicio04 = new Exercicio04();
                    exercicio04.Pedir();
                    break;
                case 5:
                    Exercicio05 exercicio05 = new Exercicio05();
                    exercicio05.Pedir();
                    break;
                case 6:
                    Exercicio06 exercicio06 = new Exercicio06();
                    exercicio06.Pedir();
                    break;
                case 7:
                    Exercicio07 exercicio07 = new Exercicio07();
                    exercicio07.Pedir();
                    break;
                case 8:
                    Exercicio08 exercicio08 = new Exercicio08();
                    exercicio08.Pedir();
                    break;
                case 9:
                    Exercicio09 exercicio09 = new Exercicio09();
                    exercicio09.Pedir();
                    break;
                case 10:
                    Exercicio10 exercicio10 = new Exercicio10();
                    exercicio10.Pedir();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
