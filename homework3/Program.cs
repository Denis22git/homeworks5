//Найдите разницу между максимальным и минимальным элементов массива.

class Program
{
    static void Main(string[] args)
    {
        int a, i, n, sum = 0, sumo = 0;
        int[] m = new int[100];

        Random rand = new Random();
        n = 11;
        Console.WriteLine("Массив");
        for (i = 0; i < n; i++)
        {
            m[i] = rand.Next(0, 50);
            Console.Write(m[i] + " ");
        }

        var min = m[0];
        var max = m[0];

        for (i = 0; i < n; i++)
        {
            if (m[i] < min)
            {
                min = m[i];
            }
            else if (m[i] > max)
            {
                max = m[i];
            }
        }
        Console.WriteLine("\nМинимальный элемент: " + min);
        Console.WriteLine("Максимальный элемент: " + max);
        for (i = 0; i < n; i++)
        {
            Console.Write(m[i] + " ");
        }
        Console.ReadKey();
    }
}