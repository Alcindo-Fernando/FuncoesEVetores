int[] numeros = new int[5];
int contador;

void receberValores()
{
    contador = 0;
    do
    {

        Console.WriteLine($"Informe um numero inteiro para a posição {contador+1}: ");
        numeros[contador] = int.Parse(Console.ReadLine());

        contador++;

    } while (contador < numeros.Length);
}

void copiandoInv(int[] nuemros)
{
    int[] numInverso = new int[numeros.Length];
    contador = 0;
    int aux = 0;

    for (int i = numeros.Length - 1; i >= 0; i--)
    {
        contador = numeros[i];

        numInverso[aux] = contador;

        aux++;
    }

    for(int i = 0; i < numInverso.Length; i++)
    {
        Console.Write(numInverso[i]);
    }
    
}

void copiandoImpares(int[] numeros) { 

    int?[] numImpares = new int?[numeros.Length];
    contador = 0;
    int aux = 0;

    for (int i = numeros.Length - 1; i >= 0; i--)
    {
        if (numeros[i] % 2 != 0)
        {
            contador = numeros[i];

            numImpares[aux] = contador;

            aux++;
        }
    }

    for (int i = 0; i < numImpares.Length; i++)
    {
        Console.Write(numImpares[i]);
    }


}


void copiandoPares(int[] numeros)
{

    int?[] numPares = new int?[numeros.Length];
    contador = 0;
    int aux = 0;

    for (int i = numeros.Length - 1; i >= 0; i--)
    {
        if (numeros[i] % 2 == 0)
        {
            contador = numeros[i];

            numPares[aux] = contador;

            aux++;
            contador++;
        }
    }

    for(int i = 0; i < numeros.Length; i++)
    {
        
        Console.Write(numPares[i]);
    }

}

receberValores();

copiandoInv(numeros);

Console.WriteLine("\n-----------");

copiandoImpares(numeros);

Console.WriteLine("\n-------------");

copiandoPares(numeros);
