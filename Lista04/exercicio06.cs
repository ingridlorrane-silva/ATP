using System;

class Exercicio06 { 

    public bool Verificar(int a)
    {
        //aqui coloco a conferência para ver se é positivo ou não
        if (a >= 0)
        {
            return true;
        }
        //se não ele é negativo
        else
        {
            return false;
        }

    }
    public void Pedir()
    {
        //Recebo o valor e chamo o metodo 
        int n = 0;
        Console.WriteLine("Digite um número: ");
        n = int.Parse(Console.ReadLine());
        //Chamo o metodo
        if (Verificar(n))
        {
            Console.WriteLine("O número {0} é posittivo.", n);
        }
        else
        {
            Console.WriteLine("O número {0} não é positivo.", n);
        }

    }
}
