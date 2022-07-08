//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве

Console.WriteLine("Введите размерность массива");
Console.Write("n=");
int n = int.Parse(Console.ReadLine());
Console.Write("m=");
int m = int.Parse(Console.ReadLine());
int[,] arr = new int[n, m];
Random rnd = new Random();

for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        arr[i, j] = rnd.Next(100, 1000);

Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
    for (int j = 0; j < arr.GetLength(1); j++)
        Console.Write("{0,5}", arr[i, j]);
int even, odd;
even = odd = 0;
for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        if (arr[i, j] % 2 == 0)
            even++;
odd = arr.Length - even;
Console.WriteLine($"Количество четных: {even}, количество нечетных: {odd}");
Console.ReadKey();