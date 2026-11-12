// 3. Leia um número inteiro e crie um vetor com essa quantidade de posições.
// Preencha o vetor com a sequência de Fibonacci,
// até a posição indicada pelo número lido.

long posicao = 0;
long fibo = 0;
long f1 = 0;
long f2 = 1;


Console.WriteLine("---------Fibonnaci---------");
Console.WriteLine("---------------------------");

Console.WriteLine("Digite um número qualquer inteiro:");
posicao = long.Parse(Console.ReadLine());

long[] numbers = new long[posicao];

void Fibonacci()
{
    for (int j = 0; j < posicao; j++)
    {
        fibo = f1 + f2;
        f1 = f2;
        f2 = fibo;
        numbers[j] = fibo;
    }
}

void Imprimir()
{
    Console.Clear();
    Console.WriteLine($"A sequência de Fibonnaci até a {posicao}º posição é:");

    if (posicao == 1)
    {
        Console.Write($"0 ");
        return;
    }
    else if (posicao == 0)
    {
        Console.Write($"Nenhum número!");
        return;
    }
    else
    {
        Console.Write($"0 1 ");
    }

    for (int i = 0; i < (numbers.Length - 2); i++)
    {
        Console.Write($"{numbers[i]} ");
    }
}

Fibonacci();
Imprimir();

Console.ReadKey();