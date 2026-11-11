bool Eprimo(int numero)
{
    if(numero <= 1)
    {
        return false;
    }

    int contador = 0;
    for(int i = 2; i <= numero/2; i++)
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

void retorno(int numeroInfo)
{
    for (int i = 1; i <= numeroInfo; i++)
    {
        if (Eprimo(i))
        {
            Console.WriteLine(i);
        }
    }
}

Console.WriteLine("informe um numero: ");
retorno (int.Parse(Console.ReadLine()));
