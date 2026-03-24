for (int i = 0; i < 21; i++)
{
    string numeroStr = i.ToString();
    int resultado;
    foreach (var numero in numeroStr)
    {
        resultado += numero;
    }

    if(resultado % 3 == 0)
    {
        continue;
    }
    

    Console.WriteLine(i);
}