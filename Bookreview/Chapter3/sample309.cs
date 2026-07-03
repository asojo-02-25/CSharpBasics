namespace Bookreview;

class Sample309
{
    public static void Run()
    {
        int[,] a = new int[3, 4];

        for (int m = 0; m < a.GetLength(0); m++)
        {
            for (int n = 0; n < a.GetLength(1); n++)
            {
                a[m, n] = m + n;
            }
        }

        for (int m = 0; m < a.GetLength(0); m++)
        {
            for (int n = 0; n < a.GetLength(1); n++)
            {
                Console.Write($"a[{m}, {n}] = {a[m, n],2:d} ");
            }
            Console.WriteLine();
        }
    }
}