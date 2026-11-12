
Console.WriteLine("Digite o tamanho do Vetor: ");
int[] numeros = new int[int.Parse(Console.ReadLine())];

void sequencia(int[] numeros)
{

    int atual = 1;
    int anterior = 0;
    int proximo;

    numeros[1] = atual;
    numeros[2] = anterior;

    for (int i = 2; i < numeros.Length; i++)
    {

        proximo = atual + anterior;
        numeros[i] = proximo;

        anterior = atual;
        atual = proximo;

    }

    for(int i = 0; i < numeros.Length; i++)
    {
        int aux = numeros[i];
        Console.WriteLine(aux);
    }

}


sequencia(numeros);