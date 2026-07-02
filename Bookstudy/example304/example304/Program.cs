Random rnd = new Random();
int max = 0;
int min = 100;

for (int i = 0; i < 10; i++)
{
    int num = rnd.Next(1, 101);
    Console.Write(num + " ");

    if (num > max)
    {
        max = num;
    }
    else if (num < min)
    {
        min = num;
    }
}

Console.WriteLine();
Console.WriteLine($"最大値:{max}");
Console.WriteLine($"最小値:{min}");
