//Declare uma variável com um valor inteiro representando o total de minutos.
    int totalDeMinutos;
    Console.Write(@"Digite a quantidade total de minutos que você passou estudando: ");
    totalDeMinutos = int.Parse(Console.ReadLine()!);
    //Calcule quantas horas completas existem nesse valor e quantos minutos restam.
    TimeSpan tempo = TimeSpan.FromMinutes(totalDeMinutos);
    //Exiba o resultado no formato X horas e Y minutos.
    Console.WriteLine($"Tempo: {tempo.ToString(@"hh")} horas e {tempo.ToString(@"mm")} minutos");