using System.Linq.Expressions;

public int Somar(int a, int b)
{
    int resultado = a + b;
    return resultado;
}

// Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação.
// lambda: é uma função anônima (sem nome próprio) escrita de forma compacta, geralmente em uma única linha de código

// int - parametro 1 , int - parametro 2, int - retorno
Func<int, int, int> somar = (a,b) => a + b;