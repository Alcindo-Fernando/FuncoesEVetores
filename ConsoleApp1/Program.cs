char[] caracteres = new char[6];
int contador;
void receberValores()
{
    contador = 0;
    do
    {
        Console.WriteLine($"Informe o numero da posição {contador}");
        caracteres[contador] = char.Parse(Console.ReadLine());
        contador++;
    } while (contador < caracteres.Length);

}
void imprimirValoresCrescente()
{
    for (int i = 0; i < caracteres.Length; i++)
    {
        Console.WriteLine(caracteres[i]);
    }
}

void imprimirValoresDecrescente()
{

    for(int i = caracteres.Length - 1; i >= 0; i--)
    {
        Console.WriteLine(caracteres[i]);
    }

}


receberValores();

Console.WriteLine("--------------");

imprimirValoresCrescente();

Console.WriteLine("--------------");

imprimirValoresDecrescente();

