namespace example305;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("九九の表示");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write($"{i}×{j} = {i * j, 2:d}" + " ");
            }
            Console.WriteLine();
        }
    }
}