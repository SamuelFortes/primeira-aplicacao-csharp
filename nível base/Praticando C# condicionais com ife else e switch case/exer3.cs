//Receba a nota final do aluno
        float notaFinal;
        Console.Write("Informe a nota final do aluno: ");
        notaFinal = float.Parse(Console.ReadLine()!);
        //Classifique o desempenho conforme a tabela:
        bool notaA = notaFinal >= 9;
        bool notaB = (notaFinal >= 7 && notaFinal < 9);
        bool notaC = (notaFinal >= 5 && notaFinal < 7);
        bool notaD = notaFinal < 5;

        if(notaA)
        {
            Console.WriteLine("O aluno recebeu a nota A.");
        }
        else if(notaB)
        {
            Console.WriteLine("O aluno recebeu a nota B.");
        }
        else if(notaC)
        {
            Console.WriteLine("O aluno recebeu a nota C.");
        }
        else
        {
            Console.WriteLine("O aluno recebeu a nota D.");
        }