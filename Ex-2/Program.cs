// 2. Leia cinco números inteiros e grave-os em um vetor.
// Copie para um novo vetor na sequência inversa; copie também os pares
// e os ímpares, cada um para outro vetor. Mostre os quatro vetores.

Console.WriteLine("---------Pares e Impares---------");
Console.WriteLine("---------------------------------");

int[] numbers = new int[5];
int[] invertido = new int[5];
int[] pares = new int[5];
int[] impares = new int[5];

int contador = 0;

void InserirInt()
{
    Console.WriteLine($"Informe os cinco números desejados!");
    for (contador = 0; contador < numbers.Length; contador++)
    {
        Console.WriteLine($"\nInforme o {contador + 1}º número:");
        numbers[contador] = int.Parse(Console.ReadLine());
    }
    Console.Clear();
}

void Normal()
{
    Console.WriteLine($"Ordem normal:");
    for (int i = 0; i < numbers.Length; i++)
    {
        
        Console.Write($"{numbers[i]} ");
    }
}

void Inverter()
{
    Console.WriteLine($"\nOrdem invertida:");
    for (int i = 0; i < numbers.Length; i++)
    {
        invertido[i] = numbers[numbers.Length - 1 - i];
        Console.Write($"{invertido[i]} ");
    }
}

void Par()
{
    contador = 0;
    Console.WriteLine($"\nPares:");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            pares[contador] = numbers[i];
            Console.Write($"{pares[contador]} ");
            contador++; 
        }
    }
  
}

void Impar()
{
    contador = 0;
    Console.WriteLine($"\nImpares:");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 != 0)
        {
            impares[contador] = numbers[i];
            Console.Write($"{impares[contador]} ");
            contador++;
           
        }
    }
}

InserirInt();
Normal();
Inverter();
Par();
Impar();

Console.ReadKey();



