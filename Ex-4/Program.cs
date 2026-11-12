// 4. Crie um vetor de strings com 10 posições.
// Copie cada posição para um novo vetor, adicionando na seguinte o valor da
// tabela ASCII, alternando letra e número (letra, número, letra, número).

Console.WriteLine("---------ASCII---------");
Console.WriteLine("-----------------------");
string[] strings = new string[10];
string[] ascci = new string[strings.Length * 2];

void InserirChar()
{
    for (int i = 0; i < strings.Length; i++)
    {
        do
        {
            Console.WriteLine($"Digite o {i + 1}º caractere:");
            strings[i] = Console.ReadLine();
        } while (strings[i].Length != 1);
    }
}

void Ascii()
{
    for (int i = 0; i < strings.Length; i++)
    {
        ascci[i * 2] = strings[i];
        ascci[i * 2 + 1] = ((int)strings[i][0]).ToString();
    }
}

void Imprimir()
{
    Console.Clear();
    Console.WriteLine("O vetor final foi:");
    for (int i = 0; i < ascci.Length; i++)
    {
        Console.Write($"{ascci[i]} ");
    }
}

InserirChar();
Ascii();
Imprimir();

Console.ReadKey();