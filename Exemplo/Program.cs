int[] numbers = new int[4];
int contador;


void populaVetor()
{
    contador = 0;
    do
    {
        //Console.WriteLine("informe o numero desejado na posição "+contador);
        Console.WriteLine($"informe o numero desejado da posição {contador}");
        numbers[contador] = int.Parse(Console.ReadLine());
        contador++;


    } while (contador < numbers.Length);
}
