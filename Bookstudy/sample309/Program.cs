namespace sample309;

class Program
{
    static void Main(string[] args)
    {
        int[,] a = new int[3, 4];
        
        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 4; n++)
            {
                a[m, n] = m + n;
            }
        }

        for (int m = 0; m < 3; m++)
        {
            for (int n = 0; n < 4; n++)
            {
                Console.WriteLine($"a[{m},{n}] = {m + n}");
            }
            Console.WriteLine();
        }
    }
}