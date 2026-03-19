//Defina uma variável para o salário atual (decimal).
decimal salarioAtual;
Console.Write("Digite o valor do seu salário atual: ");
salarioAtual = decimal.Parse(Console.ReadLine()!);
//Defina uma variável para o percentual de aumento (decimal).
decimal aumentoPercentual = (decimal)1.1;
//Calcule o novo salário e o salve em uma nova variável (decimal).
decimal novoSalario = salarioAtual * aumentoPercentual;
//Por fim, exiba o novo salário.
Console.WriteLine($"O novo salário é de R${novoSalario:F2}");