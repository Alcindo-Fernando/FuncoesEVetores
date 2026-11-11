bool Eprimo(int numero)
{
    if(numero <= 1)
    {
        return false;
    }

    int contador = 0;
    for(int i = 2; i <= numero; i++)
    {
        if(numero % i == 0)
        {
            contador++;
        }
    }
    if(contador > 1)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.WriteLine("informe um numero");
int numeroInfo = int.Parse(Console.ReadLine());

for(int i = 1; i <= numeroInfo; i++)
{
    if (Eprimo(i))
    {
        Console.WriteLine(i);
    }
}