namespace Bookspace;

class Example310
{
    public static void Run()
    {
        const int SIZE = 5;
        Random rnd = new Random();
        int[,] data = new int[SIZE, SIZE];
        int num = 1;

        while (num <=  SIZE * SIZE)
        {
            int m = rnd.Next(SIZE);
            int n = rnd.Next(SIZE);

            if (data[m, n] == 0)
            {
                data[m, n] = num;
                num++;
            }
            
        }
        for (int i = 0;  i < SIZE; i++)
        {
            for (int j = 0; j < SIZE; j++)
            {
                Console.Write($"{data[i, j],2:d}|");
            }
            
            Console.WriteLine();

            for (int j = 0; j < SIZE; j++)
            {
                Console.Write("----");
            }

            Console.WriteLine();
        }
    }
}


