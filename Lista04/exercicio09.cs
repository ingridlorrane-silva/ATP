using System;

class Exercicio09
{
    public double Media()
    {
        int q = 0, s = 0, n = 0;
        string a;
        do
        {
            Console.WriteLine("Digite a Nota do aluno:");
            n = int.Parse(Console.ReadLine());
            //Verifico se a nota é maior ou igual a 6
            if (n >= 6)
            {
                //Caso sim conto a quantidade de alunos  e somo a nota
                q++;
                s += n;
            }
            //Vejo se existem mais notas de alunos
            Console.WriteLine("Deseja continuar? (S)im (N)ão");
            a = Console.ReadLine();


        } while (a.ToLower() == "s");
        //Aqui eu calculo a média dos aprovados e retorno ela

        return s / q;
    }
    public void Pedir()
    {
        //Aqui eu chamo o metodo e dou a saida
        double med = 0;
        med = Media();
        Console.WriteLine("A média dos alunos é: " + med);
    }
}
