char[] vetor = new char[10];
int[] asc = new int[10];
int contador = 0;


do
{
    Console.WriteLine($"informe caracter posição {contador}: ");
    vetor[contador] = char.Parse(Console.ReadLine());

    asc[contador] = (int)vetor[contador]; //converte caracter para asc


    contador ++;
    

} while (contador < vetor.Length);

void copiarASC()
{
string[] vetString = new string[vetor.Length + asc.Length];
    int contadorChar = 0;
    int contadorAsc = 0;
    for(int i = 0; i < vetString.Length; i++)
    {
       if(i % 2 == 0)
        {
            vetString[i] = $"{vetor[contadorChar]}";
            contadorChar++;
        }
        else
        {
            vetString[i] = $"{asc[contadorAsc]}";
            contadorAsc++;
        }
    }

    for (int i = 0; i < vetString.Length; i++)
    {

        Console.WriteLine(vetString[i]);

    }
       

}

copiarASC();

