//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = new int[17];

int t = 1;

int task1 = 0;
int task2 = 1;

Random rand = new Random();

for (int i = 0; i < 17; ++i)
{
    arr[i] = rand.Next(-7, 7);
    task1 += arr[i];
    Console.Write(arr[i]);
    if (i % 2 != 0)
    {
        Console.Write(", ");
        t *= arr[i];
    }
    else
    {
        Console.Write(", ");
    }
}
Console.WriteLine($"произведение нечетных элементов массива : {t}");
Console.WriteLine($"Сумма всех элементов массива: {task1}");
Console.WriteLine("Произведение положительных элементов массива");

for (int i = 0; i < 17; ++i)
{
    if (arr[i] > 0)
    {
        task2 *= arr[i];
        Console.Write(arr[i] + " | ");
    }
}
Console.WriteLine($" равно {task2}");