// 1. Leia até seis caracteres e grave-os em um vetor, na ordem inserida.
// Imprima o vetor da primeira até a última posição
// e, depois, da última até a primeira.

Console.WriteLine("---------Frente e Trás---------");
Console.WriteLine("-------------------------------");

Console.WriteLine($"Quantos caracteres você gostaria de inserir?");
int carac = int.Parse(Console.ReadLine());

char[] numbers = new char[carac];
int contador = 0;

Console.Clear();

void InserirChar()
{
    for (contador = 0; contador < numbers.Length; contador++)
    {
        Console.WriteLine($"Informe o  {contador + 1}º caracter:");
        numbers[contador] = char.Parse(Console.ReadLine());
    }
    Console.Clear();
}

void FrenteTras()
{
    Console.WriteLine($"Caracteres da esquerda pra direita:");

    for (contador = 0; contador < numbers.Length; contador++)
    {
        Console.Write($"{numbers[contador]} ");
    }
}

void TrasFrente()
{
    Console.WriteLine($"\nCaracteres da direita pra esquerda:");

    for (contador = numbers.Length; contador > 0; contador--)
    {
        Console.Write($"{numbers[contador - 1]} ");
    }
}

InserirChar();
FrenteTras();
TrasFrente();

Console.ReadKey();